using FirstFantasy.Classes.Equipment;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public abstract class Character : IDescribable
    {
        private String name;
        private int level;
        private int experience;
        private Races race;
        private Weapon characterweapon;
        private List<Inventory> inventories;

        public enum Races { Dwarf, Elf, Hobbit, Human, Orc };

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public Races Race { get => race; set => race = value; }
        public Weapon Characterweapon { get => characterweapon; set => characterweapon = value; }
        public List<Inventory> Inventories { get => inventories; set => inventories = value; }


        public abstract String Taunt();

        public abstract string SayTypeCharacter();

        public virtual String ShowCharacter()
        {
            return "Name: " + name + " Type: " + SayTypeCharacter() + " Level: " + level + " XP: " + experience + " Weapon: " + characterweapon.ShowInformation();
        }

        public string ShowInformation()
        {
            return "This is a level " + level + " character";
        }

        public int Attack(Weapon weapon)
        {
            Random n = new Random();
            int damage = weapon.Damage;
            int numberrandom = n.Next(1, 9);
            int hurt = damage + numberrandom;
            return hurt;
        }

        public void AddInventories(List<Inventory> inventories, Inventory stock)
        {
            inventories.Add(stock);
            this.inventories = inventories;
        }

        public string InventoryInformation(List<Inventory> inventories)
        {
            string information = "";
            foreach (Inventory inventory in inventories)
            {
                information += inventory.ShowInformation() + "\n";
            }
            return information;
        }
    }
}
