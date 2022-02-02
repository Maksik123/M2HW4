using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4.Products
{
    public abstract class MeleeWeapon : Weapon
    {
        public abstract int CriticalChance { get; }

        public abstract double CriticalLevel { get; }

        public abstract double CriticalDamage { get; }
    }
}
