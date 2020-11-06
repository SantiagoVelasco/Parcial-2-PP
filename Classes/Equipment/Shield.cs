using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Shield : Defense
    {
        public Shield(int endurance) : base(endurance)
        {
        }

        public override string ShowInformation()
        {
            return "Shield. Property: Defense. Endurance: " + Endurance;
        }
    }
}
