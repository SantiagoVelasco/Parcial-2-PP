using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Sword : Weapon
    {
        public Sword(int damage) : base(damage)
        {
        }

        public override string ShowInformation()
        {
            return "Sword. Property: Attack. Damage: "+ Damage;
        }
    }
}
