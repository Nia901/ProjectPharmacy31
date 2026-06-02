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
    public class SpecialistsController
    {
        private PharmecyContext context;
        public SpecialistsController()
        {
            context = new PharmecyContext();
        }
        public SpecialistsController(PharmecyContext context)
        {
            this.context = context;
        }
        public async Task<List<Specialists>> GetAll()
        {
            return await context.Spetialists.ToListAsync();
        }
        public async Task CreateSpecialist(string firstName,string lastName, ProfessionalFields proField,string username,string password)
        {
            if ((await context.Customers.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Admins.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if ((await context.Spetialists.AnyAsync(x => x.Username == username)))
                throw new ArgumentException("Такъв потребител вече съществува!");
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Некоректно изписано първо име!");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Некоректно изписано фамилно име!");
            Specialists s=new Specialists { 
            FirstName=firstName,
            LastName=lastName,
            ProField=proField,
            Role=RoleType.Specialist,
            Username=username,
            Password=password
            };
            context.Spetialists.Add(s);
            await context.SaveChangesAsync();
        }
        public async Task<bool> Login(string username, string password)
        {
            return await context.Spetialists.AnyAsync(x => x.Username == username && x.Password == password);
        }
    }
}
