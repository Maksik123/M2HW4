﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2HW4.Interfaces;

namespace M2HW4.Products
{
    public class Gun : RangeWeapon , IShowInfo
    {
        public override int Damage => 5;

        public override void Attack()
        {
            Console.WriteLine($"{GetType().Name}: бах!");
        }

        public override void Reload()
        {
            Console.WriteLine("Перезаряжаю");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Вы нанесли {Damage} урона");
        }
    }
}
