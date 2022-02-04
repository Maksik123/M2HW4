using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Extensions;
using M2HW4.Interfaces;

namespace M2HW4.Products
{
    public class Sword : MeleeWeapon
    {
        Random randomCrit = new Random();

        public override int Damage => 4;

        public override int CriticalChance => 20;

        public override double CriticalLevel => 2.5;

        public override double CriticalDamage => Damage * CriticalLevel;

        public override void Attack()
        {
            if (CriticalChance < randomCrit.Next(100))
            {
                string message = $"хыдыщ!\nВы нанесли {CriticalDamage} урона";
                message.WriteCriticalDamageLine();
            }
            else
            {
                Console.WriteLine($"{GetType().Name} дзыньк");
            }
        }
    }
}
