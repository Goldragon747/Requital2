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
    /// Interaction logic for CombatScreen.xaml
    /// </summary>
    public partial class CombatScreen : UserControl
    {
        public int Enemies { get; set; } = 6;
        public CombatScreen()
        {
            InitializeComponent();

            HeroGrid();
            CharMiniStat();
            EnemyGrid(Enemies);
            MonsterMiniStat(Enemies);

            MagicB_Description("Slash", 2);
            MagicB_Description("Firaga", 10);
            MagicB_Description("Stonedaga", 10);
            MagicB_Description("Thundaga", 10);

        }
        public SolidColorBrush brush1 = new SolidColorBrush();


        private void Magic_Click(object sender, RoutedEventArgs e)
        {
            
            ViewMagicGrid.Width = ActualWidth;
            ViewMagicGrid.Height = ActualHeight;
            ViewMagicGrid.Visibility = Visibility.Visible;

            BackButton.Content = "Back";
            BackButton.FontSize = 16;
            BackButton.VerticalContentAlignment = VerticalAlignment.Top;
            BackButton.Background = Brushes.Aqua;
            BackButton.Width = ActualWidth;
            
            
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
            ViewMagicGrid.Visibility = Visibility.Hidden;
        }
        private void MagicB_Description(string name, int mp)
        {
            Button b = new Button();
            b.Name = name;
            b.Content = $"{name} \tMp: {mp}";
            b.FontSize = 24;
            b.Height = 160;
            b.Width = 309;
            b.Background = Brushes.CadetBlue;
            b.FontStyle = FontStyles.Italic;
            b.BorderBrush = Brushes.CornflowerBlue;
            b.BorderThickness = new Thickness(1);
            ViewMagic.Children.Add(b);
        }
        private void MonsterMiniStat(int monsterAmount)
        {
            for (int i = 0; i < monsterAmount; i++) {
                Label l = new Label();
                //l.Background = Brushes.OldLace;
                l.Content = $"Monster{i} Hp: 0 Mp: 0";
                l.Width = 183.25;
                l.Height = 61.25;
                l.HorizontalContentAlignment = HorizontalAlignment.Center;
                l.VerticalContentAlignment = VerticalAlignment.Center;
                l.BorderBrush = Brushes.Black;
                l.BorderThickness = new Thickness(1);
                MonStats.Children.Add(l);
            }
        }
        private void CharMiniStat()
        {
            for (int i = 0; i < 4; i++) {
                Label l = new Label();
                //l.Background = Brushes.OldLace;
                l.Content = $"Char{i} Hp: 0 Mp: 0";
                l.Width = 206;
                l.Height = 92;
                l.BorderBrush = Brushes.Black;
                l.HorizontalContentAlignment = HorizontalAlignment.Center;
                l.VerticalContentAlignment = VerticalAlignment.Center;
                l.BorderThickness = new Thickness(1);
                CharStats.Children.Add(l);
            }
        }
        private void HeroGrid()
        {
            for (int i = 0; i < 4; i++)
            {
                Button b = new Button();
                b.Width = 50;
                b.Height = 75;
                b.Content = $"Hero\n{i}";
                b.Background = Brushes.Aqua;
                CharacterGrid.Children.Add(b);
            }
            

        }
        private void EnemyGrid(int enemies)
        {
            for (int i = 0; i < enemies; i++)
            {
                Button b = new Button();
                b.Width = 50;
                b.Height = 75;
                b.Content = $"Enemy\n{i}";
                b.Background = Brushes.Crimson;
                MonsterGrid.Children.Add(b);
            }
        }
    }
}
