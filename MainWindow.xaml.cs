using FirstFantasy.Classes;
using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        Character myCharacter;
        List<Inventory> inventories = new List<Inventory>();
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string informationCharacter = "";
            string option = cboxCharacter.Text;
            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric {Name= txtName.Text, Experience = 0, Level = 1 };
                    informationCharacter += "Character: Cleric\n";
                    break;

                case "Fighter":
                    myCharacter = new Fighter { Name = txtName.Text, Experience = 0, Level = 1 };
                    informationCharacter += "Character: Fighter\n";
                    break;

                case "Rouge":
                    myCharacter = new Rouge { Name = txtName.Text, Experience = 0, Level = 1 };
                    informationCharacter += "Character: Rouge\n";
                    break;

                case "Wizard":
                    myCharacter = new Wizard { Name = txtName.Text, Experience = 0, Level = 1 };
                    informationCharacter += "Character: Wizard\n";
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            Random r = new Random();
            string gun = cboxFstWeapon.Text;
            switch (gun)
            {
                case "Axe":
                    myCharacter.Characterweapon = new Axe(r.Next(1, 9));
                    informationCharacter += "Weapon: Axe\n";
                    break;
                case "Spear":
                    myCharacter.Characterweapon = new Spear(r.Next(1, 9));
                    informationCharacter += "Weapon: Spear\n";
                    break;
                case "Sword":
                    myCharacter.Characterweapon = new Sword(r.Next(1, 9));
                    informationCharacter += "Weapon: Sword\n";
                    break;
                default:
                    myCharacter.Characterweapon = null;
                    MessageBox.Show("You MUST select a Weapon");
                    break;
            }

            string infInventory = "";
            string sndWeapon = cboxSndWeapon.Text;
            switch (sndWeapon)
            {
                case "Axe":
                    myCharacter.AddInventories(inventories, new Axe(r.Next(1, 9)));
                    infInventory += "Second weapon: Axe\n";
                    break;
                case "Spear":
                    myCharacter.AddInventories(inventories, new Spear(r.Next(1, 9)));
                    infInventory += "Second weapon: Spear\n";
                    break;
                case "Sword":
                    myCharacter.AddInventories(inventories, new Sword(r.Next(1, 9)));
                    infInventory += "Second weapon: Sword\n";
                    break;
                default:
                    MessageBox.Show("Are you sure you don't want a second weapon?");
                    break;
            }
            string defense = cboxDefense.Text;
            switch (defense)
            {
                case "Helmet":
                    myCharacter.AddInventories(inventories, new Helmet(r.Next(10, 51)));
                    infInventory += "Defense: Helmet\n";
                    break;
                case "Shield":
                    myCharacter.AddInventories(inventories, new Shield(r.Next(10, 51)));
                    infInventory += "Defense: Shield\n";
                    break;
                default:
                    MessageBox.Show("Are you sure you don't want a defense?");
                    break;
            }
            string cure = cboxHealing.Text;
            switch (cure)
            {
                case "Elixir":
                    myCharacter.AddInventories(inventories, new Elixir(r.Next(10, 21)));
                    infInventory += "Healing: Elixir\n";
                    break;
                case "Potion":
                    myCharacter.AddInventories(inventories, new Potion(r.Next(10, 51)));
                    infInventory += "Healing: Potion\n";
                    break;
                default:
                    MessageBox.Show("Are you sure you don't want a healing?");
                    break;
            }
            txtYourCharacter.Visibility = Visibility.Visible;
            txtOutput.Text = informationCharacter;
            txtYourInventory.Visibility = Visibility.Visible;
            txtOutputInventory.Text = infInventory;
            btnSave.Visibility = Visibility.Visible;
        }

        List<Character> characters = new List<Character>();
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            characters.Add(myCharacter);
            btnCreate.Visibility = Visibility.Hidden;
            btnNewCharacter.Visibility = Visibility.Visible;
            txtOutput.Text = "";
            txtOutputInventory.Text = "";
            foreach (Character c in characters)
            {
                 txtOutput.Text = c.ShowCharacter();
                txtOutputInventory.Text = c.InventoryInformation(inventories);
            }
        }

        private void btnNewCharacter_Click(object sender, RoutedEventArgs e)
        {
            btnCreate.Visibility = Visibility.Visible;
            btnSave.Visibility = Visibility.Hidden;
            btnNewCharacter.Visibility = Visibility.Hidden;
        }
    }
}
