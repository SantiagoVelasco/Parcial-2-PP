using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Wizard : Character
    {
        private int mp;

        public int Mp { get => mp; set => mp = value; }

        public override String Taunt()
        {
            return "By the the Magic";
        }

        public string CastSpell()
        {
            return "KAAA BUM";
        }

        public override string SayTypeCharacter()
        {
            return "Wizard";
        }
    }
}
