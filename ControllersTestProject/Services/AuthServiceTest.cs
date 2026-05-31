using Controller;
using ControllersTestProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersTestProject.Services
{
    public class AuthServiceTest
    {
        [Test]
        public async Task Login_Admin_1()
        {
            var context=TestDbPharmacy.CreateContext();
            context.Admins.Add(new Data.Entities.Admin
            {
                Username = "Ivan1",
                Password = "123",
                FirstName="Ivan",
                LastName="Ivanov",
                Email="ivan@abv.bg"
            });
            await context.SaveChangesAsync();
            AdminController ac=new AdminController(context);
            Assert.IsTrue(await ac.Login("Ivan1", "123"));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async() => await ac.CreateAdmin(" ", "Ivanov", "ivan@abv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.CreateAdmin("Ivan", " ", "ivan@abv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.CreateAdmin("Ivan", "Ivanov", " ", "123", "Ivan1"));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If4()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", " ", "Ivan1"));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If5()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", " "));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If6()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.CreateAdmin("Ivan", "Ivanov", "ivanabv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If7()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abvbg", "123", "Ivan1"));
        }
        [Test]
        public async Task Create_Admin_Test_Method_If8()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Create_Admin_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            var list = await ac.GetAll();
            Assert.AreEqual(1, list.Count);
            Assert.IsNotNull(list[0]);
        }
        [Test]
        public async Task Update_Admin_Test_Method_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin(" ", "Ivanov", "ivan@abv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin("Ivan", " ", "ivan@abv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            var list = await ac.GetAll();
            list[0].Email = " ";
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin("Ivan", "Ivanov", " ", "123", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method_If4()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin("Ivan", "Ivanov", "ivan@abv.bg", " ", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method_If5()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method_If6()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            var list = await ac.GetAll();
            list[0].Password = " ";
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin("Ivan", "Ivanov", "ivan@abv.bg", " ", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method_If7()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin("Ivan", "Ivanov", "ivanbv.bg", "123", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method_If8()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.UpdateAdmin("Ivan", "Ivanov", "ivan@abvbg", "123", "Ivan1"));
        }
        [Test]
        public async Task Update_Admin_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            await ac.UpdateAdmin("Ivan3", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            var list = await ac.GetAll();
            Assert.AreEqual("Ivan3", list[0].FirstName);
        }
        [Test]
        public async Task Delete_Admin_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            Assert.ThrowsAsync<ArgumentException>(async () =>  await ac.DeleteAdmin("Ivan1","123"));
        }
        [Test]
        public async Task Delete_Admin_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            Assert.ThrowsAsync<ArgumentException>(async () => await ac.DeleteAdmin("Ivan1", "1"));
        }
        [Test]
        public async Task Delete_Admin()
        {
            var context = TestDbPharmacy.CreateContext();
            AdminController ac = new AdminController(context);
            await ac.CreateAdmin("Ivan", "Ivanov", "ivan@abv.bg", "123", "Ivan1");
            await ac.DeleteAdmin("Ivan1", "123");
            var list= await ac.GetAll();   
            Assert.AreEqual(0, list.Count);
        }
    }
}
