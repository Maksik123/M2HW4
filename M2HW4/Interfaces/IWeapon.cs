using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4.Interfaces
{
    public interface IWeapon
    {
        public int Damage { get; }

        public void Attack();

        public void ShowInfo();
    }
}
