using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Interfaces;

namespace M2HW4.Products
{
    public class Player
    {
        public void Attack(IWeapon weapon)
        {
            weapon.Attack();
        }

        public void ShowInfo(IWeapon weapon)
        {
            weapon.ShowInfo();
        }

        public void Reload(RangeWeapon rangeWeapon)
        {
            rangeWeapon.Reload();
        }
    }
}
