using FirstFantasy.Classes;
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
           // String option = cboxCharacter.Text;

            Character myCharacter;

            List<Character> characterList = new List<Character>();

            Cleric cleric = new Cleric();
            cleric.Name = "David";
            cleric.Level = 1;
            cleric.Experience = 0;

            Rouge rouge = new Rouge { Name = "Santiago", Level = 1, Experience = 0 };

            characterList.Add(cleric);
            characterList.Add(rouge);
            characterList.Add(new Fighter { Name = "Velasco", Level = 1, Experience = 0 });
            characterList.Add(new Wizard { Name = "Daza", Level = 20, Experience =100 });

            txtOutput.Text = "";

            foreach(Character c in characterList)
            {
                txtOutput.Text += c.ShowCharacter() + "\n";
            }



            /*
            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric();
                    break;

                case "Fighter":
                    myCharacter = new Fighter();
                    break;

                case "Rouge":
                    myCharacter = new Rouge();
                    break;

                case "Wizard":
                    myCharacter = new Wizard();
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            if (myCharacter != null){
                txtOutput.Text = myCharacter.Taunt();
            }
            */
        }
    }
}
