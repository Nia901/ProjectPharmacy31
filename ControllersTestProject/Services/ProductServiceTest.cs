using Controller;
using ControllersTestProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersTestProject.Services
{
    public class ProductServiceTest
    {
        [Test]
        public async Task Create_Product_If1()
        {
            var context= TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            var list= await controller.GetAll();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);

        }
        [Test]
        public async Task Create_Product_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateProduct(" ", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5));

        }
        [Test]
        public async Task Create_Product_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateProduct("Orange", " ", Data.Enums.Categories.Women, "Food", 20.50m, 5));

        }
        [Test]
        public async Task Create_Product_If4()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, " ", 20.50m, 5));

        }
        [Test]
        public async Task Create_Product_If5()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", -1, 5));

        }
        [Test]
        public async Task Create_Product_If6()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, -1));

        }
        [Test]
        public async Task Create_Product()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 3));

        }
        [Test]
        public async Task Change_Products_Quantity()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            await controller.ChanngeQuantity("Orange", "Plodove1", 10);
            Assert.AreEqual(15, (await controller.GetAll())[0].Quantity);

        }
        [Test]
        public async Task Change_Products_Quantity_If1()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.ChanngeQuantity("Orange", "Plodove1", 1));
        }
        [Test]
        public async Task Change_Products_Quantity_If2()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove2", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.ChanngeQuantity("Orange", "Plodove1", 1));
        }
        [Test]
        public async Task Change_Products_Quantity_If3()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            Assert.ThrowsAsync<ArgumentException>(async () => await controller.ChanngeQuantity("Orange", "Plodove1", -1));
        }
        [Test]
        public async Task GetProductByBrand_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            var list = await controller.GetProductsByBrand("Plodove1");
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
        [Test]
        public async Task GetProductByCategory_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            var list = await controller.GetProductsByCategory(Data.Enums.Categories.Women);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
        [Test]
        public async Task GetProductByType_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            var list = await controller.GetProductsByProductType("Food");
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
        [Test]
        public async Task GetProductForBabies_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Babies, "Food", 20.50m, 5);
            var list = await controller.GetProductsForBaby();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
        [Test]
        public async Task GetProductForChildren_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Children, "Food", 20.50m, 5);
            var list = await controller.GetProductsForChildren();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
        [Test]
        public async Task GetProductForWomen_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Women, "Food", 20.50m, 5);
            var list = await controller.GetProductsForWomen();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
        [Test]
        public async Task GetProductForMen_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Men, "Food", 20.50m, 5);
            var list = await controller.GetProductsForMen();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
        [Test]
        public async Task GetProductForElders_Test_Method()
        {
            var context = TestDbPharmacy.CreateContext();
            ProductController controller = new ProductController(context);
            await controller.CreateProduct("Orange", "Plodove1", Data.Enums.Categories.Elders, "Food", 20.50m, 5);
            var list = await controller.GetProductsForElders();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Orange", list[0].Name);
        }
    }
}
