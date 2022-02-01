using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Interfaces;

namespace M2HW4.Products
{
    public abstract class Weapon : IWeapon
    {
        public abstract int Damage { get; }

        public abstract void Attack();

        public abstract void ShowInfo();
    }
}
