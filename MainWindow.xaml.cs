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
        List<Inventory> inventories;
        public void btnCreate_Click(object sender, RoutedEventArgs e)
        {

            string informationCharacter = "";
            string option = cboxCharacter.Text;
            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric { Name = txtName.Text, Experience = 0, Level = 1 };
                    inventories = new List<Inventory>();
                    informationCharacter += "Character: Cleric\n";
                    break;

                case "Fighter":
                    myCharacter = new Fighter { Name = txtName.Text, Experience = 0, Level = 1 };
                    inventories = new List<Inventory>();
                    informationCharacter += "Character: Fighter\n";
                    break;

                case "Rouge":
                    myCharacter = new Rouge { Name = txtName.Text, Experience = 0, Level = 1 };
                    inventories = new List<Inventory>();
                    informationCharacter += "Character: Rouge\n";
                    break;

                case "Wizard":
                    myCharacter = new Wizard { Name = txtName.Text, Experience = 0, Level = 1 };
                    inventories = new List<Inventory>();
                    informationCharacter += "Character: Wizard\n";
                    break;

                default:
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
            btnSave.Visibility = Visibility.Hidden;
            btnNewCharacter.Visibility = Visibility.Visible;
            btnAttack.Visibility = Visibility.Visible;
            txtOutput.Text = "";
            txtOutputInventory.Text = "";
            foreach (Character c in characters)
            {
                txtOutput.Text = c.ShowCharacter();
                txtOutputInventory.Text = c.InventoryInformation(c.Inventories);
            }
            btnShow.Visibility = Visibility.Visible;
        }

        public void Reset()
        {
            txtName.Text = "";
            cboxCharacter.SelectedIndex = 0;
            cboxDefense.SelectedIndex = 0;
            cboxFstWeapon.SelectedIndex = 0;
            cboxHealing.SelectedIndex = 0;
            cboxSndWeapon.SelectedIndex = 0;
        }

        private void btnNewCharacter_Click(object sender, RoutedEventArgs e)
        {
            btnConfirmEdit.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Hidden;
            btnEditCharacter.Visibility = Visibility.Hidden;
            txtOutput.Visibility = Visibility.Visible;
            btnCreate.Visibility = Visibility.Visible;
            btnSave.Visibility = Visibility.Hidden;
            btnNewCharacter.Visibility = Visibility.Hidden;
            txtInstructionEdit.Visibility = Visibility.Hidden;
            lblCharacterName.Visibility = Visibility.Visible;
            lblIndex.Visibility = Visibility.Hidden;
            lblCharacterType.Visibility = Visibility.Visible;
            cboxCharacter.Visibility = Visibility.Visible;
            rtnWhite.Visibility = Visibility.Hidden;
            lblShowCharacters.Visibility = Visibility.Hidden;
            txtShowCharacters.Visibility = Visibility.Hidden;
            txtOutput.Text = "";
            txtOutputInventory.Text = "";
            txtYourCharacter.Visibility = Visibility.Hidden;
            txtYourInventory.Visibility = Visibility.Hidden;
            lblIndexWeapon.Visibility = Visibility.Hidden;
            txtIndexWeapon.Visibility = Visibility.Hidden;
            lblWeapon.Visibility = Visibility.Visible;
            lblSndWeapon.Visibility = Visibility.Visible;
            lblDefense.Visibility = Visibility.Visible;
            lblHealing.Visibility = Visibility.Visible;
            cboxFstWeapon.Visibility = Visibility.Visible;
            cboxSndWeapon.Visibility = Visibility.Visible;
            cboxDefense.Visibility = Visibility.Visible;
            cboxHealing.Visibility = Visibility.Visible;
            Reset();

        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            btnDelete.Visibility = Visibility.Hidden;
            btnNewCharacter.Visibility = Visibility.Visible;
            txtYourCharacter.Visibility = Visibility.Hidden;
            txtOutput.Visibility = Visibility.Hidden;
            lblIndex.Visibility = Visibility.Hidden;
            rtnWhite.Visibility = Visibility.Visible;
            lblShowCharacters.Visibility = Visibility.Visible;
            txtShowCharacters.Visibility = Visibility.Visible;
            btnEditCharacter.Visibility = Visibility.Visible;
            txtInstructionEdit.Visibility = Visibility.Hidden;
            int index = 1;
            lblIndexWeapon.Visibility = Visibility.Hidden;
            txtIndexWeapon.Visibility = Visibility.Hidden;
            txtShowCharacters.Text = "";
            foreach (Character c in characters)
            {
                txtShowCharacters.Text += index.ToString() + ".   ";
                txtShowCharacters.Text += c.ShowCharacter();
                txtShowCharacters.Text += "\n" + "Inventory:" + "\n" + c.InventoryInformation(c.Inventories) + "\n";
                index += 1;
            }
        }

        private void btnEditCharacter_Click(object sender, RoutedEventArgs e)
        {
            rtnWhite.Visibility = Visibility.Hidden;
            lblShowCharacters.Visibility = Visibility.Visible;
            txtShowCharacters.Visibility = Visibility.Visible;
            txtOutput.Text = "";
            txtOutputInventory.Text = "";
            txtYourCharacter.Visibility = Visibility.Hidden;
            txtYourInventory.Visibility = Visibility.Hidden;
            lblIndexWeapon.Visibility = Visibility.Hidden;
            txtIndexWeapon.Visibility = Visibility.Hidden;
            lblWeapon.Visibility = Visibility.Visible;
            lblSndWeapon.Visibility = Visibility.Visible;
            lblDefense.Visibility = Visibility.Visible;
            lblHealing.Visibility = Visibility.Visible;
            cboxFstWeapon.Visibility = Visibility.Visible;
            cboxSndWeapon.Visibility = Visibility.Visible;
            cboxDefense.Visibility = Visibility.Visible;
            cboxHealing.Visibility = Visibility.Visible;
            Reset();
            txtInstructionEdit.Visibility = Visibility.Visible;
            lblCharacterName.Visibility = Visibility.Hidden;
            btnEditCharacter.Visibility = Visibility.Hidden;
            btnConfirmEdit.Visibility = Visibility.Visible;
            lblIndex.Visibility = Visibility.Visible;
            rtnWhite.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Visible;
            txtInstructionEdit.Text = "You can edit the inventory and the first weapon. \n Write the index of the character. \n " +
                "You have to select all the new inventory. The last inventory is empty. \n If you want to delate a character, just write the index and " +
                "click delete.";
            lblCharacterType.Visibility = Visibility.Hidden;
            cboxCharacter.Visibility = Visibility.Hidden;
            txtShowCharacters.Text = "";
            int secondindex = 1;
            foreach (Character c in characters)
            {
                txtShowCharacters.Text += secondindex.ToString() + ".   ";
                txtShowCharacters.Text += c.ShowCharacter();
                txtShowCharacters.Text += "\n" + "Inventory:" + "\n" + c.InventoryInformation(c.Inventories) + "\n";
                secondindex += 1;
            }
        }

        private void btnConfirmEdit_Click(object sender, RoutedEventArgs e)
        {
            inventories = new List<Inventory>();
            Random r = new Random();

            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("You must select a index");
            }
            else
            {
                int index = Int16.Parse(txtName.Text);
                index -= 1;
                characters[index].Inventories.Clear();
                string sndWeapon = cboxSndWeapon.Text;
                string gun = cboxFstWeapon.Text;
                switch (gun)
                {
                    case "Axe":
                        characters[index].Characterweapon = new Axe(r.Next(1, 9));
                        break;
                    case "Spear":
                        characters[index].Characterweapon = new Spear(r.Next(1, 9));
                        break;
                    case "Sword":
                        characters[index].Characterweapon = new Sword(r.Next(1, 9));
                        break;
                    default:
                        MessageBox.Show("You MUST select a Weapon");
                        break;
                }
                switch (sndWeapon)
                {
                    case "Axe":
                        characters[index].AddInventories(inventories, new Axe(r.Next(1, 9)));
                        break;
                    case "Spear":
                        characters[index].AddInventories(inventories, new Spear(r.Next(1, 9)));
                        break;
                    case "Sword":
                        characters[index].AddInventories(inventories, new Sword(r.Next(1, 9)));
                        break;
                    default:
                        MessageBox.Show("Are you sure you don't want a second weapon?");
                        break;
                }
                string defense = cboxDefense.Text;
                switch (defense)
                {
                    case "Helmet":
                        characters[index].AddInventories(inventories, new Helmet(r.Next(10, 51)));
                        break;
                    case "Shield":
                        characters[index].AddInventories(inventories, new Shield(r.Next(10, 51)));
                        break;
                    default:
                        MessageBox.Show("Are you sure you don't want a defense?");
                        break;
                }
                string cure = cboxHealing.Text;
                switch (cure)
                {
                    case "Elixir":
                        characters[index].AddInventories(inventories, new Elixir(r.Next(10, 21)));
                        break;
                    case "Potion":
                        characters[index].AddInventories(inventories, new Potion(r.Next(10, 51)));
                        break;
                    default:
                        MessageBox.Show("Are you sure you don't want a healing?");
                        break;
                }
                int secondindex = 1;
                txtShowCharacters.Text = "";
                foreach (Character c in characters)
                {
                    txtShowCharacters.Text += secondindex.ToString() + ".   ";
                    txtShowCharacters.Text += c.ShowCharacter();
                    txtShowCharacters.Text += "\n" + "Inventory:" + "\n" + c.InventoryInformation(c.Inventories) + "\n";
                    secondindex += 1;
                }
                btnConfirmEdit.Visibility = Visibility.Hidden;
                btnEditCharacter.Visibility = Visibility.Visible;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            btnConfirmEdit.Visibility = Visibility.Hidden;
            btnEditCharacter.Visibility = Visibility.Visible;
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("You must select a index");
            }
            else
            {
                int index = Int16.Parse(txtName.Text);
                index -= 1;
                characters.RemoveAt(index);
            }
            int secondindex = 1;
            txtShowCharacters.Text = "";
            foreach (Character c in characters)
            {
                txtShowCharacters.Text += secondindex.ToString() + ".   ";
                txtShowCharacters.Text += c.ShowCharacter();
                txtShowCharacters.Text += "\n" + "Inventory:" + "\n" + c.InventoryInformation(c.Inventories) + "\n";
                secondindex += 1;
            }
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            rtnWhite.Visibility = Visibility.Hidden;
            btnNewCharacter.Visibility = Visibility.Hidden;
            lblCharacterName.Visibility = Visibility.Hidden;
            btnAttack.Visibility = Visibility.Hidden;
            btnConfirmAttack.Visibility = Visibility.Visible;
            btnShow.Visibility = Visibility.Hidden;
            lblIndex.Visibility = Visibility.Visible;
            txtOutput.Visibility = Visibility.Hidden;
            txtOutputInventory.Visibility = Visibility.Hidden;
            txtYourCharacter.Visibility = Visibility.Hidden;
            txtYourInventory.Visibility = Visibility.Hidden;
            txtShowCharacters.Visibility = Visibility.Visible;
            Reset();
            txtIndexWeapon.Text = "";
            lblCharacterType.Visibility = Visibility.Hidden;
            lblDefense.Visibility = Visibility.Hidden;
            lblHealing.Visibility = Visibility.Hidden;
            lblWeapon.Visibility = Visibility.Hidden;
            lblSndWeapon.Visibility = Visibility.Hidden;
            lblShowCharacters.Visibility = Visibility.Visible;
            cboxCharacter.Visibility = Visibility.Hidden;
            cboxDefense.Visibility = Visibility.Hidden;
            cboxHealing.Visibility = Visibility.Hidden;
            cboxSndWeapon.Visibility = Visibility.Hidden;
            cboxFstWeapon.Visibility = Visibility.Hidden;
            lblIndexWeapon.Visibility = Visibility.Visible;
            txtIndexWeapon.Visibility = Visibility.Visible;
            txtInstructionEdit.Visibility = Visibility.Visible;
            txtInstructionEdit.Text = "Attack\n" +
                "Select the character you want to attack. \n" +
                "Select the index of the weapon with which you want it to do it (1 first weapon. 2 second weapon)";
            int index = 1;
            txtShowCharacters.Text = "";
            foreach (Character c in characters)
            {
                txtShowCharacters.Text += index.ToString() + ".   ";
                txtShowCharacters.Text += c.ShowCharacter();
                txtShowCharacters.Text += "\n" + "Inventory:" + "\n" + c.InventoryInformation(c.Inventories) + "\n";
                index += 1;
            }
        }

        private void btnConfirmAttack_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("You must select a index");
            }
            else
            {
                int indexCharacter = Int16.Parse(txtName.Text);
                indexCharacter -= 1;
                int indexWeapon = Int16.Parse(txtIndexWeapon.Text);
                if (indexWeapon == 1)
                {
                    int hurt = characters[indexCharacter].Attack(characters[indexCharacter].Characterweapon);
                    txtShowCharacters.Text = "The damage is: " + hurt.ToString();
                }
                else
                {
                    foreach(Inventory inventory in characters[indexCharacter].Inventories)
                    {
                        if (inventory is Weapon)
                        {
                            int hurt = characters[indexCharacter].Attack((Weapon)inventory);
                            txtShowCharacters.Text = "The damage is: " + hurt.ToString();
                        }
                    }
                    
                }
                    
            }
            btnConfirmAttack.Visibility = Visibility.Hidden;
            btnAttack.Visibility = Visibility.Visible;
            btnShow.Visibility = Visibility.Visible;
            btnNewCharacter.Visibility = Visibility.Visible;
        }
    }
}
