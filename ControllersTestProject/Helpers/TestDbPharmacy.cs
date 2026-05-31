using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersTestProject.Helpers
{
    public class TestDbPharmacy
    {
        public static PharmecyContext CreateContext()
        {
            var options=new DbContextOptionsBuilder<PharmecyContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            PharmecyContext context = new PharmecyContext(options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
