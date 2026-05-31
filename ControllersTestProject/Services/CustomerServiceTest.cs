using Controller;
using ControllersTestProject.Helpers;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersTestProject.Services
{
    public class CustomerServiceTest
    {
        [Test]
        public async Task Create_Customer()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 20);
           var list=await controller.GetAll();
            Assert.AreEqual(1,list.ToList().Count);
        }
        [Test]
        public async Task Create_Customer_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 20);
            Assert.ThrowsAsync<ArgumentException>(async() => await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 20));
        }
        [Test]
        public async Task Create_Customer_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateCustomer(" ", "123", "ivan@abv.bg", 20));
        }
        [Test]
        public async Task Create_Customer_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateCustomer("Ivan1", " ", "ivan@abv.bg", 20));
        }
        [Test]
        public async Task Create_Customer_If4()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateCustomer("Ivan1", "123", " ", 20));
        }
        [Test]
        public async Task Create_Customer_If5()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 17));
        }
        [Test]
        public async Task Create_Customer_If6()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 300));
        }
        [Test]
        public async Task Create_Customer_If7()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateCustomer("Ivan1", "123", "ivanabv.bg", 20));
        }
        [Test]
        public async Task Create_Customer_If8()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateCustomer("Ivan1", "123", "ivan@abvbg", 30));
        }
        [Test]
        public async Task Update_Customer_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.UpdateCustomer("Ivan1", "123", "ivan@abv.bg", 30));
        }
        [Test]
        public async Task Update_Customer_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.UpdateCustomer(" ", "123", "ivan@abv.bg", 30));
        }
        [Test]
        public async Task Update_Customer_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.UpdateCustomer("Ivan1", " ", "ivan@abv.bg", 30));
        }
        [Test]
        public async Task Update_Customer_If4()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.UpdateCustomer("Ivan1", "123", "ivan@abv.bg", 5));
        }
        [Test]
        public async Task Update_Customer_If5()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.UpdateCustomer("Ivan1", "123", "ivan@abv.bg", 300));
        }
        [Test]
        public async Task Update_Customer()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            await controller.UpdateCustomer("Ivan1", "123", "ivan@abv.bg", 35);
            Data.Entities.Customer c = await controller.GetByEmail("ivan@abv.bg");
            Assert.AreEqual(35, c.Age);
        }
        [Test]
        public async Task Remove_Customer_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.RemoveCustomer("ivan@abv.bg", "123"));
        }
        [Test]
        public async Task Remove_Customer_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.RemoveCustomer("ivan@abv.bg", "1234"));
        }
        [Test]
        public async Task Remove_Customer()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            await controller.RemoveCustomer("ivan@abv.bg","123");
            var list = await controller.GetAll();
            Assert.AreEqual(0, list.ToList().Count);
        }
        [Test]
        public async Task Login_Customer()
        {
            var context = TestDbPharmacy.CreateContext();
            CustomerController controller = new CustomerController(context);
            await controller.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 30);
            Assert.IsTrue(await controller.Login("Ivan1", "123"));
        }
    }
}
