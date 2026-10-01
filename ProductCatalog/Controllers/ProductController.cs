using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> productList = new List<Product>()
        {
            new Product() { Id = 1,
                            Name = "Mouse",
                            Category = "Electronics", 
                            Description = "Wireless mouse", 
                            Price = 500, 
                            Image = "https://shop.zebronics.com/cdn/shop/files/Zeb-Blanc-100-Black-pic1.jpg?v=1772884342&width=2000", 
                            Quantity = 20 
                        },

            new Product() { Id = 2, 
                            Name = "Chair",
                            Category = "Furniture", 
                            Description = "Office chair",
                            Price = 3000, 
                            Image = "https://www.cruzinternational.in/cdn/shop/files/41Mqhm1Xq0L.jpg?v=1735909011&width=600",
                            Quantity = 8 
                         },

            new Product() { Id = 3, 
                            Name = "Keyboard", 
                            Category = "Electronics", 
                            Description = "Mechanical keyboard", 
                            Price = 1500, 
                            Image = "https://m.media-amazon.com/images/I/61OzEP1KyAL._AC_UF1000,1000_QL80_.jpg", 
                            Quantity = 15 
                        }
        };

        // GET: Product
        public ActionResult Index()
        {
            return View(productList);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            Product p = productList.FirstOrDefault(x => x.Id == id);
            return View(p);
        }
    }
}