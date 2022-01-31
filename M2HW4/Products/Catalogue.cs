using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4.Products
{
    public class Catalogue
    {
        public Product[] CatalogueOfProducts = new[]
        {
            new Product() { Name = "Meat", Weight = 100, Vegeterian = false, Price = 55 },
            new Product() { Name = "Greek Salad", Weight = 200, Vegeterian = true, Price = 40 },
            new Product() { Name = "Frecnch fries", Weight = 150, Vegeterian = true, Price = 20 },
            new Product() { Name = "Beer" , Weight = 500, Vegeterian = false, Price = 15 },
        };
    }
}
