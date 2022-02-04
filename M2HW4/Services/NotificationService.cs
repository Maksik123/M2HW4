using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Interfaces;
using M2HW4.Products;

namespace M2HW4.Services
{
    public class NotificationService : IShowInfo
    {
        public void ShowInfo(IWeapon weapon)
        {
            var item = weapon;
            if (item is RangeWeapon)
            {
                Console.WriteLine($"Вы нанесли {item.Damage}");
            }

            if (item is MeleeWeapon)
            {
                Console.WriteLine($"Вы нанесли {item.Damage}");
            }
        }
    }
}
