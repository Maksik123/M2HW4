using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4.Services
{
    public class CatalogueService : Interfaces.IShowCatalogue
    {
        Products.Catalogue catalogue = new Products.Catalogue();

        public void ShowCatalogue()
        {
            var result = this.catalogue.CatalogueOfProducts;
            foreach (var product in catalogue.CatalogueOfProducts)
            {
                Console.WriteLine($"Name {product.Name}, {product.Weight}");
            }
        }
    }
}
