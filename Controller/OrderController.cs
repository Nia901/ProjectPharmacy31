using Data.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Controller
{
   public class OrderController
    {
        private PharmecyContext context;
        public OrderController()
        {
            context = new PharmecyContext();
        }
        public OrderController(PharmecyContext context)
        {
            this.context = context;
        }
        public async Task<List<Order>> GetAll()
        {
            return await context.Orders.Include(x=>x.Product).Include(x=>x.Customer).ToListAsync();
        }
        public async Task CreateOrder(string username,string productName,DateTime orderDate,int quantity)
        {
            Customer c = await context.Customers.FirstOrDefaultAsync(x => x.Username == username);
            Product p = await context.Products.FirstOrDefaultAsync(x => x.Name == productName);
            if (c == null)
                throw new ArgumentException("Такова потребителско име не съществува!");
            if (p == null)
                throw new ArgumentException("Такъв продукт не съществува!");
            if(p.Quantity<quantity)
                throw new ArgumentException("Няма достатъчно количество от този продукт!");
            if (orderDate.Year<1900)
                throw new ArgumentException("Некоректно въведена дата!");
            Order order = new Order { 
                CustomerId=c.Id,
                ProductId=p.Id,
                OrderDate=orderDate,
                Quantity=quantity,
                TotalPrice=p.Price*quantity
            };
            p.Quantity -= quantity;
            context.Orders.Add(order);
            await context.SaveChangesAsync();
        }
        public async Task UpdateOrder(int id,string customerEmail,string password, string productName, DateTime orderDate, int quantity)
        {
            Order o= await context.Orders.FirstOrDefaultAsync(x => x.Id==id);
            Customer c = await context.Customers.FirstOrDefaultAsync(x => x.Email == customerEmail);
            Product p = await context.Products.FirstOrDefaultAsync(x => x.Name == productName);
            
            if (o == null)
                throw new ArgumentException("Такъв номер на поръчка не съществува!");
            Product pOld = await context.Products.FirstOrDefaultAsync(x => x.Id == o.ProductId);
            if (c == null)
                throw new ArgumentException("Такъв имейл не съществува!");
            if (c.Password != password)
                throw new ArgumentException("Некоректно изписана парола!");
            if (p == null)
                throw new ArgumentException("Такъв продукт не съществува!");
            if (orderDate.Year < 1900)
                throw new ArgumentException("Некоректно въведена дата!");
            pOld.Quantity += o.Quantity;
            if (quantity>p.Quantity)
                throw new ArgumentException("Недостатъчно количество на продукт!");
            p.Quantity -= quantity;
            o.CustomerId = c.Id;
            o.ProductId = p.Id;
            o.Quantity = quantity;
            o.OrderDate=orderDate;
            o.TotalPrice=quantity*p.Price;
            await context.SaveChangesAsync();
        }
        public async Task<List<Order>> GetByCustomers(string username,string password)
        {
            if(string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Такова потребителско име не съществува!");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Невалидна парола!");
            Customer c = await context.Customers.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
            if (c == null)
                throw new ArgumentException("Неправилно потребителско име/парола!");
            int id =c.Id;
            return await context.Orders.Include(x=>x.Product).Include(x=>x.Customer).Where(x=>x.CustomerId==id).ToListAsync();
        }
    }
}
