using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4.Products
{
    public class Sword : MeleeWeapon
    {
        public override int Damage => 4;

        public override void Attack()
        {
            Console.WriteLine($"{GetType().Name} дзыньк");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Вы нанесли {Damage} урона");
        }
    }
}
