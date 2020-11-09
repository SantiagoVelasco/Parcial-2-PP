using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Rouge : Character
    {
        public override string SayTypeCharacter()
        {
            return "Rouge";
        }

        public override String Taunt()
        {
            return "By MEEE!";
        }
    }
}
