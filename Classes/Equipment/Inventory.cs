using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Inventory : IDescribable
    {
        public abstract string ShowInformation();
    }
}
