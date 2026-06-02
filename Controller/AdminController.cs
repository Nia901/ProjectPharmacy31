using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AdminController
    {
        private PharmecyContext context;
        public AdminController()
        {
            context = new PharmecyContext();
        }
        public AdminController(PharmecyContext context)
        {
            this.context = context;
        }

        public async Task<List<Admin>> GetAll()
        {
            return await context.Admins.ToListAsync();
        }
        public async Task CreateAdmin(string firstName,string lastName,string email,string password,string username)
        {
            if ((await context.Customers.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Admins.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Spetialists.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if (await context.Admins.AnyAsync(x=>x.Email==email))
                throw new ArgumentException("Такъв имейл вече съществува!");
            if (await context.Customers.AnyAsync(x => x.Email == email))
                throw new ArgumentException("Такъв имейл вече съществува!");
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Моля, въведете коректно първо име!");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Моля, въведете коректно фамилно име!");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Моля, въведете коректен имейл!");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Моля, въведете коректна парола!");
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Моля, въведете коректно потребителско име!");
            if (!email.Contains('@')||!email.Contains('.'))
                throw new ArgumentException("Моля, въведете коректен имейл!");
            Admin a = new Admin
            {
                FirstName=firstName,
                LastName=lastName,
                Email=email,
                Username=username,
                Password=password,
                Role=Data.Enums.RoleType.Admin
            };
            context.Admins.Add(a);
            await context.SaveChangesAsync();
        }
        public async Task UpdateAdmin(string firstName, string lastName, string email, string password,string username)
        {
            Admin adm =await context.Admins.FirstOrDefaultAsync(x => x.Username == username);
            if (adm == null)
                throw new ArgumentException("Такова потребителско име не съществува!");
            if (adm.Password!=password)
                throw new ArgumentException("Неправилно изписана парола!");
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Моля, въведете коректно първо име!");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Моля, въведете коректно фамилно име!");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Моля, въведете коректен имейл!");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Моля, въведете коректна парола!");
            if (!email.Contains('@') || !email.Contains('.'))
                throw new ArgumentException("Моля, въведете коректен имейл!");
            adm.FirstName = firstName;
            adm.LastName = lastName;
            await context.SaveChangesAsync();
        }
        public async Task DeleteAdmin(string username, string password)
        {
            Admin adm =await context.Admins.FirstOrDefaultAsync(x => x.Username == username);
            if (adm == null)
                throw new ArgumentException("Такова потребителско име не съществува!");
            if (adm.Password != password)
                throw new ArgumentException("Неправилно изписана парола!");
            context.Remove(adm);
            await context.SaveChangesAsync();
        }
        public async Task<bool> Login(string username, string password)
        {
            return await context.Admins.AnyAsync(x => x.Username == username && x.Password == password);
        }
    }
}
