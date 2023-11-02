using Microsoft.AspNetCore.Mvc;

namespace Homework_6_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private Product[] productsList =
        {
            new Product(1, "���� Logitech M185", 799),
            new Product(2, "����������� LEGO Star Wars", 599),
            new Product(3, "�������� ������� Samsung Galaxy A24", 8999),
            new Product(4, "�������� ������� Apple iPhone 15 Pro" ,58499),
            new Product(5, "���� ������� ��� ��� Sleepingg", 490),
            new Product(6, "���� Logitech G203 Lightsync USB Black", 1238),
            new Product(7, "����� ��� ������� Suzie", 675),
            new Product(8, "����� ������� Batiste Cherry 200 ��", 225),
            new Product(9, "̳����������� �� PANASONIC NN-ST25HBZPE", 3999),

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