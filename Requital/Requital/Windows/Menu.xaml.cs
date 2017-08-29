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

namespace TestUserControls.UserControls
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public ImageSource MenuSource
        {
            get { return MenuImage.Source; }
            set { MenuImage.Source = value; }
        }

        public Menu()
        {
            InitializeComponent();
        }
        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            HelpLabel.Visibility = Visibility.Collapsed;
            CreditsLabel.Visibility = Visibility.Visible;
            CreditInformationLabel.Content = 
                "This game was done in the PRO100-SB2 \n" +
                "Creaters of this game those listed below: \n" +
                "   Gaberiel Barber \n" +
                "   Benjamin Beckwith \n" +
                "   Michael Brannen \n" +
                "   Elizabeth Bruschi \n" +
                "Thank you for playing and if there is any questions ask Please ask";
            
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            CreditsLabel.Visibility = Visibility.Collapsed;
            HelpLabel.Visibility = Visibility.Visible;
            HelpInformationLabel.Content = "To move: use WASD \n" +
                "Combat: ";
        }
        
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if(CreditsLabel.Visibility != Visibility.Visible && HelpLabel.Visibility != Visibility.Visible)
            {
                MenuControl.Visibility = Visibility.Hidden;
            }
            if (CreditsLabel.Visibility == Visibility.Visible || HelpLabel.Visibility == Visibility.Visible)
            {
                CreditsLabel.Visibility = Visibility.Hidden;
                HelpLabel.Visibility = Visibility.Hidden;
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            HelpLabel.Visibility = Visibility.Hidden;
            CreditsLabel.Visibility = Visibility.Hidden;
        }
    }
}
