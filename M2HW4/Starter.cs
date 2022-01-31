using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Services;

namespace M2HW4
{
    public class Starter
    {
    CatalogueService catalogueService = new CatalogueService();
    ShoppingCartService shoppingCartService = new ShoppingCartService();
    OrderService orderService = new OrderService();

    public void Run()
        {
            catalogueService.ShowCatalogue();
            string userText = Console.ReadLine();
            shoppingCartService.AddToShoppingCart(userText);
            orderService.Order();

        }
    }
}
