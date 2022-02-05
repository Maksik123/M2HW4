﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Products;
using M2HW4.Interfaces;
using M2HW4.Extensions;

namespace M2HW4
{
    public class Starter
    {
        Weapon[] inventory = { new Gun(), new MachineGun(), new Sword() };
        Player player = new Player();

        private readonly IShowInfo showInfo;

        public Starter(IShowInfo showInfo)
        {
            this.showInfo = showInfo;
        }

        public void Run()
        {
            foreach (var item in inventory)
            {
                if (item is RangeWeapon)
                {
                    player.Attack(item);
                    showInfo.ShowInfo(item);
                    player.Reload(item as RangeWeapon);
                }

                if (item is MeleeWeapon)
                {
                    player.Attack(item as MeleeWeapon);
                    showInfo.ShowInfo(item);
                }
            }
        }
    }
}
