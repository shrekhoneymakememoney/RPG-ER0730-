using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_ER0730_

{
    public enum Monster
    {
        Vampire, Goblin, Orc,
    }
    internal class NPC
    {
        public Monster Type { get; set; }

        public NPC(Monster type)
        {
            Type = type;
        }
    }
}
