using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Fighter : Character
    {
        public override String Taunt()
        {
            return "By my Lord";
        }

        public override string SayTypeCharacter()
        {
            return "Fighter";
        }
    }
}
