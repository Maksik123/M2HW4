using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4.Services
{
    public class OrderService : Interfaces.IOrder
    {
        Products.Order order = new Products.Order();
        ShoppingCartService shopping = new ShoppingCartService();

        public Products.Product[] Order()
        {
            var result = order.UsersOrder;
            var product = shopping.AddToShoppingCart();
            result[order.Counter] = product[order.Counter];
            order.Counter++;
            return result;
        }
    }
}