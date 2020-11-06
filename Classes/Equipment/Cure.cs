using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Cure : Inventory
    {
        private int healing;

        public int Healing { get => healing; set => healing = value; }

        public Cure(int healing)
        {
            this.healing = healing;
        }
    }
}
