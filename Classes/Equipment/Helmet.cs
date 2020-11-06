using FirstFantasy.Classes.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Helmet : Defense
    {
        public Helmet(int endurance) : base(endurance)
        {
        }

        public override string ShowInformation()
        {
            return "Helmet. Property: Defense. Endurance: " + Endurance;
        }
    }
}
