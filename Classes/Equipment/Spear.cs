using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Spear : Weapon
    {
        public Spear(int damage) : base(damage)
        {
        }

        public override string ShowInformation()
        {
            return "Spear. Property: Attack. Damage: " + Damage;
        }
    }
}
