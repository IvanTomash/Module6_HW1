using Microsoft.AspNetCore.Mvc;

namespace Homework_6_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private Product[] productsList =
        {
            new Product(1, "Миша Logitech M185", 799),
            new Product(2, "Конструктор LEGO Star Wars", 599),
            new Product(3, "Мобільний телефон Samsung Galaxy A24", 8999),
            new Product(4, "Мобільний телефон Apple iPhone 15 Pro" ,58499),
            new Product(5, "Набір подушок для сну Sleepingg", 490),
            new Product(6, "Миша Logitech G203 Lightsync USB Black", 1238),
            new Product(7, "Сукня для дівчинки Suzie", 675),
            new Product(8, "Сухий шампунь Batiste Cherry 200 мл", 225),
            new Product(9, "Мікрохвильова піч PANASONIC NN-ST25HBZPE", 3999),

        };

        [HttpGet("[action]")]
        public ActionResult<List<Product>> GetRandomProducts()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < 5; i++)
            {
                products.Add(productsList[new Random().Next(0, 9)]);
            }

            return products;
        }
    }
}