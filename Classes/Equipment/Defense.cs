using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Defense : Inventory
    {
        private int endurance;

        public int Endurance { get => endurance; set => endurance = value; }

        public Defense(int endurance)
        {
            this.endurance = endurance;
        }
    }
}
