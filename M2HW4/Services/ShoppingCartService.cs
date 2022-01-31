using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Interfaces;

namespace M2HW4.Services
{
    public class ShoppingCartService : IAddToShoppingCart
    {
        Products.ShoppingCart cart = new Products.ShoppingCart();
        Products.Catalogue catalogue = new Products.Catalogue();

        public Products.Product[] AddToShoppingCart(string userText)
        {
            var result = cart.UserShoppingCart;
            foreach (var item in catalogue.CatalogueOfProducts)
            {
                cart.UserShoppingCart[cart.Counter] = item;
                cart.Counter++;
            }

            return result;
        }
    }
}
