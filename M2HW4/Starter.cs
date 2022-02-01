using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Products;

namespace M2HW4
{
    public class Starter
    {
        Weapon[] inventory = { new Gun(), new MachineGun(), new Sword() };
        Player player = new Player();

        public void Run()
        {
            foreach (var item in inventory)
            {
                player.Attack(item);
                player.ShowInfo(item);
                if (item is RangeWeapon)
                {
                    player.Reload(item);
                }

                if (item is MeleeWeapon)
                {

                }
            }
        }
    }
}
