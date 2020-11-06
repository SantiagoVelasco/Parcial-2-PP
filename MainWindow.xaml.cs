using FirstFantasy.Classes;
using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
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

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Character myCharacter;
            string option = cboxCharacter.Text;
            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric {Name= txtName.Text, Experience = 0, Level = 1 };
                    break;

                case "Fighter":
                    myCharacter = new Fighter { Name = txtName.Text, Experience = 0, Level = 1 };
                    break;

                case "Rouge":
                    myCharacter = new Rouge { Name = txtName.Text, Experience = 0, Level = 1 };
                    break;

                case "Wizard":
                    myCharacter = new Wizard { Name = txtName.Text, Experience = 0, Level = 1 };
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
                    break;
                case "Spear":
                    myCharacter.Characterweapon = new Spear(r.Next(1, 9));
                    break;
                case "Sword":
                    myCharacter.Characterweapon = new Sword(r.Next(1, 9));
                    break;
                default:
                    myCharacter.Characterweapon = null;
                    MessageBox.Show("You MUST select a Weapon");
                    break;
            }
            txtOutput.Text = myCharacter.ShowCharacter();
        }
    }
}
