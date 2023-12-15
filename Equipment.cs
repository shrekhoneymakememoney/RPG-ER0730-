using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_ER0730_
{
    internal class Equipment
    {

        public string EquipmentName { get; set; }
        public int Weight { get; set; }
        public int Damage { get; set; }


        // Derived classes for specific equipment types
        class Sword : Equipment
        {
            public Sword(string name, int weight, int damage)
            {
                EquipmentName = name;
                Weight = weight;
                Damage = damage;
            }
        }

        class Shield : Equipment
        {
            public Shield(string name, int weight, int damage)
            {
                EquipmentName = name;
                Weight = weight;
                Damage = damage;
            }
        }

        class Potion : Equipment
        {
            public Potion(string name, int weight)
            {
                EquipmentName = name;
                Weight = weight;
                // Potions typically don't have damage, so it's set to 0 by default
                Damage = 0;
            }
        }
    }
}
