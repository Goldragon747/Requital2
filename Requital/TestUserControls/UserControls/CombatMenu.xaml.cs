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
    /// Interaction logic for CombatMenu.xaml
    /// </summary>
    public partial class CombatScreen : UserControl
    {
        public CombatScreen()
        {
            InitializeComponent();
        }
        public SolidColorBrush brush1 = new SolidColorBrush();
        public SolidColorBrush brush2 = new SolidColorBrush();


        private void Magic_Click(object sender, RoutedEventArgs e)
        {
            brush1.Color = Color.FromArgb(70, 100, 100, 255);
            brush2.Color = Color.FromArgb(70, 0, 10, 255);

            ViewOptions.Width = 400;
            ViewOptions.Height = 200;
            ViewOptions.Background = brush1;
            ViewOptions.Visibility = Visibility.Visible;

            BackButton.Background = brush2;
            BackButton.Content = "Back";
            BackButton.FontSize = 12;
            BackButton.Width = 75;
            BackButton.Height = 25;
        }
        private void Attack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Defend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Flee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            ViewOptions.Visibility = Visibility.Hidden;
        }
    }
}
