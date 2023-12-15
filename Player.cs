using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_ER0730_
{
    internal class Player
    {

        public string Name { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }
        public List<Equipment> EquipmentList { get; set; }

        // Default constructor
        public Player()
        {
            Name = "DefaultPlayer";
            HP = 100;
            XP = 0;
            EquipmentList = new List<Equipment>();
        }

        // Constructor with parameters
        public Player(string name, int hp, int xp)
        {
            Name = name;
            HP = hp;
            XP = xp;
            EquipmentList = new List<Equipment>();
        }

        // Properties
        public string PlayerName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int HealthPoints
        {
            get { return HP; }
            set { HP = value; }
        }

        public int ExperiencePoints
        {
            get { return XP; }
            set { XP = value; }
        }

        // Player methods
        public void Attack(NPC npc)
        {
            // Implement attack logic here
            Console.WriteLine($"{Name} is attacking {npc.Type}!");
        }

        public void Damage(int amount)
        {
            // Implement damage logic here
            HP -= amount;
            Console.WriteLine($"{Name} takes {amount} damage. Current HP: {HP}");
        }

        public bool IsDead()
        {
            return HP <= 0;
        }
    }

    // Derived classes for specific player types
    class Warrior : Player
    {
        public Warrior() : base() { }

        public Warrior(string name, int hp, int xp) : base(name, hp, xp)
        {
            // Additional initialization specific to the Warrior class
        }
    }

    class Mage : Player
    {
        public Mage() : base() { }

        public Mage(string name, int hp, int xp) : base(name, hp, xp)
        {
            // Additional initialization specific to the Mage class
        }
    }

    class Archer : Player
    {
        public Archer() : base() { }

        public Archer(string name, int hp, int xp) : base(name, hp, xp)
        {
            // Additional initialization specific to the Archer class
        }
    }
}

