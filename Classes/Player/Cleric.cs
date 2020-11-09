using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Cleric : Character
    {
        public Cleric()
        {
          
        }

        public Cleric(string name)
        {
            this.Name = name;
        }

        public override string SayTypeCharacter()
        {
            return "Cleric";
        }

        public override String Taunt()
        {
            return "By the Gods";
        }

    }
}
