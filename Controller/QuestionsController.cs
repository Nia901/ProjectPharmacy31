using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class QuestionsController
    {
        private PharmecyContext context;
        public QuestionsController()
        {
            context = new PharmecyContext();
        }
        public QuestionsController(PharmecyContext context)
        {
            this.context = context;
        }
        public async Task<List<Questions>> GetAll()
        {
            return await context.Questions.Include(x=>x.Specialist).Include(x=>x.Customer).ToListAsync();
        }
        public async Task CreateQuestions(string username,string firstName,string lastName,string description,DateTime consultationDate)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Моля, въведете коректно първо име!");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Моля, въведете коректно фамилно име!");
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Моля, въведете коректно потрбителско име!");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Моля, въведете коректно запитване!");
            Customer c = await context.Customers.FirstOrDefaultAsync(x => x.Username == username);
                if(c==null)
                throw new ArgumentException("Клиент с такъв имейл не съществува!");
            Specialists s = await context.Spetialists.FirstOrDefaultAsync(x => x.FirstName == firstName && x.LastName==lastName);
            if (s == null)
                throw new ArgumentException("Такъв специалист не съществува!");
            Questions q = new Questions
            {
                CustomerId=c.Id,
                SpecialistId=s.Id,
                Description=description,
                ConsultationDate=consultationDate
            };
            context.Questions.Add(q);
            await context.SaveChangesAsync();
        }
        public async Task<List<Questions>> GetAllBySpec(string username,string password)
        {
            return await context.Questions.Include(x => x.Customer).Include(x => x.Specialist).Where(x=>x.Specialist.Username==username&&x.Specialist.Password==password).ToListAsync();
        }
        public async Task<List<Questions>> GetAllByCustomer(string username, string password)
        {
            return await context.Questions.Include(x=>x.Customer).Include(x=>x.Specialist).Where(x => x.Customer.Username == username && x.Customer.Password == password).ToListAsync();
        }
    }
}
