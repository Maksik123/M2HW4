using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Interfaces;

namespace M2HW4.Products
{
    public class MachineGun : RangeWeapon
    {
        public override int Damage => 10;

        public override void Attack()
        {
            Console.WriteLine($"{GetType().Name}: тра-та-та-та");
        }

        public override void Reload()
        {
            Console.WriteLine("Перезаряжаю");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Вы нанесли {Damage } урона");
        }

    }
}
