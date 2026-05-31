using Controller;
using ControllersTestProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersTestProject.Services
{
    public class OrdersServiceTest
    {
        [Test]
        public async Task Create_Order_Test_If1()
        {
            var context =TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.CreateOrder("customer1", "product1", DateTime.Now, 2));
        }
        [Test]
        public async Task Create_Order_Test_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            await customerController.CreateCustomer("Ivan1","123","ivan@abv.bg",25);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.CreateOrder("Ivan1", "product1", DateTime.Now, 2));
        }
        [Test]
        public async Task Create_Order_Test_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await productController.CreateProduct("Orange","Plodove1",Data.Enums.Categories.Babies,"fruit",2.50m,10);
            await customerController.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 25);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.CreateOrder("Ivan1", "Orange", DateTime.Parse("1330-05-05"), 2));
        }
        [Test]
        public async Task Create_Order_Test_If4()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await customerController.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 25);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 15));
        }
        [Test]
        public async Task Create_Order_Test()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await customerController.CreateCustomer("Ivan1", "123", "ivan@abv.bg", 25);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
             var orders = await orderController.GetAll();
            Assert.AreEqual(1,orders.ToList().Count);
            Assert.AreEqual(8, (await productController.GetAll())[0].Quantity);
        }
        [Test]
        public async Task GetByCustomers_Test_Method_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.GetByCustomers(" ", "123"));
        }
        [Test]
        public async Task GetByCustomers_Test_Method_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.GetByCustomers("customer1", " "));
        }
        [Test]
        public async Task GetByCustomers_Test_Method_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.GetByCustomers("customer1", "123"));
        }
        [Test]
        public async Task GetByCustomers_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await customerController.CreateCustomer("Ivan1", "123", "i@abv.bg", 25);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
            var list= await orderController.GetByCustomers("Ivan1", "123");
            Assert.AreEqual(1, list.ToList().Count);
            Assert.AreEqual(list[0].Customer.Username, "Ivan1");
        }
        [Test]
        public async Task UpdateOrder_Test_Method_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.UpdateOrder(1,"ivan@abv.bg","123","orange",DateTime.Now,5));
        }
        [Test]
        public async Task UpdateOrder_Test_Method_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await customerController.CreateCustomer("Ivan1", "123", "i@abv.bg", 25);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.UpdateOrder(1, "ivan@ab.bg", "123", "Orange", DateTime.Now, 5));
        }
        [Test]
        public async Task UpdateOrder_Test_Method_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await customerController.CreateCustomer("Ivan1", "123", "i@abv.bg", 25);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.UpdateOrder(1, "i@abv.bg", "123", "orange1", DateTime.Now, 5));
        }
        [Test]
        public async Task UpdateOrder_Test_Method_If4()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await customerController.CreateCustomer("Ivan1", "123", "i@abv.bg", 25);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.UpdateOrder(1, "i@abv.bg", "1234", "Orange", DateTime.Now, 5));
        }
        [Test]
        public async Task UpdateOrder_Test_Method_If5()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await customerController.CreateCustomer("Ivan1", "123", "i@abv.bg", 25);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.UpdateOrder(1, "i@abv.bg", "123", "Orange", DateTime.Parse("1800-05-05"), 5));
        }
        [Test]
        public async Task UpdateOrder_Test_Method_If6()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await customerController.CreateCustomer("Ivan1", "123", "i@abv.bg", 25);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
            Assert.ThrowsAsync<ArgumentException>(async () => await orderController.UpdateOrder(1, "i@abv.bg", "123", "Orange", DateTime.Now, 15));
        }
        [Test]
        public async Task UpdateOrder_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            OrderController orderController = new OrderController(context);
            CustomerController customerController = new CustomerController(context);
            ProductController productController = new ProductController(context);
            await customerController.CreateCustomer("Ivan1", "123", "i@abv.bg", 25);
            await productController.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "fruit", 2.50m, 10);
            await orderController.CreateOrder("Ivan1", "Orange", DateTime.Now, 2);
            await orderController.UpdateOrder(1,"i@abv.bg","123","Orange",DateTime.Now,5);
            Assert.AreEqual(5,(await orderController.GetAll())[0].Quantity);
        }
    }
}
