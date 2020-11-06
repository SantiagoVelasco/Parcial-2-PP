﻿using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Axe : Weapon
    {
        public Axe(int damage) : base(damage)
        {
        }

        public override string ShowInformation()
        {
            return "Axe. Property: Attack. Damage: " + Damage;
        }
    }
}
