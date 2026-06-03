using Data.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Controller
{
    public class CustomerController
    {
        private PharmecyContext context;
        public CustomerController()
        {
            context = new PharmecyContext();
        }
        public CustomerController(PharmecyContext context)
        {
            this.context = context;
        }
        public async Task<List<Customer>> GetAll()
        {
            return await context.Customers.ToListAsync();
        }
        public async Task<Customer> GetByEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Моля, въведете коректен имейл!");
            Customer customer = await context.Customers.FirstOrDefaultAsync(x => x.Email == email);
            if (customer==null)
                throw new ArgumentException("Моля, въведете коректен имейл!");
            return customer;
        }
        public async Task CreateCustomer(string username,string password,string email,int age)
        {
           
            if ((await context.Customers.AnyAsync(x=>x.Username==username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Admins.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Spetialists.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Customers.AnyAsync(x => x.Email == email)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Admins.AnyAsync(x => x.Email == email)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Моля, въведете коректно име!");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Моля, въведете коректен имейл!");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Моля, въведете коректна парола!");
            if (!email.Contains('@') || !email.Contains('.'))
                throw new ArgumentException("Моля, въведете коректен имейл!");
            if (age<18||age>150)
                throw new ArgumentException("Нвалидни години!");
            Customer cust = new Customer
            {
                Username=username,
                Password=password,
                Email=email,
                Age=age,
                Role=Data.Enums.RoleType.Customer
            };
            context.Customers.Add(cust);
            await context.SaveChangesAsync();
        }
        public async Task UpdateCustomer(string username, string password, string email, int age)
        {
            Customer customer = await context.Customers.FirstOrDefaultAsync(x => x.Email == email);
            if (customer == null)
                throw new ArgumentException("Такъв имейл не съществува!");
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Моля, въведете коректно име!");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Моля, въведете коректна парола!");
            if (age < 18 || age > 150)
                throw new ArgumentException("Нвалидни години!");
            customer.Username= username;
            customer.Password= password;
            customer.Age= age;
            await context.SaveChangesAsync();
        }
        public async Task RemoveCustomer(string email, string password)
        {
            Customer customer = await context.Customers.FirstOrDefaultAsync(x => x.Email == email);
            if (customer == null)
                throw new ArgumentException("Такъв имейл не съществува!");
            if(customer.Password!= password)
                throw new ArgumentException("Неправилно изписана парола!");
            context.Customers.Remove(customer);
            await context.SaveChangesAsync();
        }
        public async Task<bool> Login(string username, string password)
        {
            return await context.Customers.AnyAsync(x => x.Username == username && x.Password == password);
        }
    }
}
