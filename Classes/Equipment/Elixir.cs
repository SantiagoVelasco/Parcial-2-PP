using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Elixir : Cure
    {
        public Elixir(int healing) : base(healing)
        {
        }

        public override string ShowInformation()
        {
            return "Elixir. Property: Cure. Healing: " + Healing;
        }
    }
}
