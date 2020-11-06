using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Potion : Cure
    {
        public Potion(int healing) : base(healing)
        {
        }

        public override string ShowInformation()
        {
            return "Potion. Property: Cure. Healing: " + Healing;
        }
    }
}
