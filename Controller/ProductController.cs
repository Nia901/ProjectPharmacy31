using Data;
using Data.Entities;
using Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProductController
    {
        private PharmecyContext context;
        public ProductController()
        {
            context = new PharmecyContext();
        }
        public ProductController(PharmecyContext context)
        {
            this.context = context;
        }
        public async Task<List<Product>> GetAll()
        {
            return await context.Products.ToListAsync();
        }
        public async Task CreateProduct(string name,string brand,Categories category,string productType,decimal price,int quantity)
        {
            if(await context.Products.AnyAsync(x=>x.Name==name))
            {
                throw new ArgumentException("Продукт с такоа име вече съществува!");
            }
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Некоректно име на продукт!");
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Некоректно въведен бранд на продукт!");
            if (string.IsNullOrWhiteSpace(productType))
                throw new ArgumentException("Некоректно въведен тип на продукт!");
            if (price<0)
                throw new ArgumentException("Цената трябва да бъде неотрицателно число!");
            if (quantity<0)
                throw new ArgumentException("Количеството трябва да бъде неотрицателно число!");
            Product p = new Product
            {
                Name= name,
                Brand=brand,
                Category=category,
                ProductType=productType,
                Price=price,
                Quantity=quantity
            };
            context.Products.Add(p);
            await context.SaveChangesAsync();
        }
        public async Task ChanngeQuantity(string productName,string brand,int quantity)
        {
            Product p = await context.Products.FirstOrDefaultAsync(x => x.Name == productName&&x.Brand==brand);
            if (quantity < 1)
            {
                throw new ArgumentException("Количеството за добавяне ттрябва да бъде по-голямо от 1!");
            }
            if (p == null)
                throw new ArgumentException("Продукт с това име/марка не съществува!");
            p.Quantity += quantity;
            await context.SaveChangesAsync();
        }
        public async Task<List<Product>> GetProductsByBrand(string brand)
        {
            return await context.Products.Where(x=>x.Brand==brand).ToListAsync();   
        }
        public async Task<List<Product>> GetProductsByCategory(Categories category)
        {
            return await context.Products.Where(x => x.Category == category).ToListAsync();
        }
        public async Task<List<Product>> GetProductsByProductType(string productType)
        {
            return await context.Products.Where(x => x.ProductType == productType).ToListAsync();
        }
        public async Task<List<Product>> GetProductsForBaby()
        {
            return await context.Products.Where(x => x.Category==Categories.Babies).ToListAsync();
        }
        public async Task<List<Product>> GetProductsForWomen()
        {
            return await context.Products.Where(x => x.Category == Categories.Women).ToListAsync();
        }
        public async Task<List<Product>> GetProductsForMen()
        {
            return await context.Products.Where(x => x.Category == Categories.Men).ToListAsync();
        }
        public async Task<List<Product>> GetProductsForChildren()
        {
            return await context.Products.Where(x => x.Category == Categories.Children).ToListAsync();
        }
        public async Task<List<Product>> GetProductsForElders()
        {
            return await context.Products.Where(x => x.Category == Categories.Elders).ToListAsync();
        }
    }
}
