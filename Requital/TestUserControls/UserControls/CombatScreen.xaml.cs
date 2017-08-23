using Requital;
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
        private List<Characters> dreamTeam = new List<Characters>();
        public List<Characters> CombatTeam { get { return dreamTeam; }
            set {
                for (int i = 0; i < 4; i++) {
                    if(value.ElementAt(i).CharacterClass == "Cleric") {
                        dreamTeam.Add(new Cleric(value.ElementAt(i).characterName));
                    }
                    if (value.ElementAt(i).CharacterClass == "Mage") {
                        dreamTeam.Add(new Mage(value.ElementAt(i).characterName));
                    }
                    if (value.ElementAt(i).CharacterClass == "Rogue")
                    {
                        dreamTeam.Add(new Rogue(value.ElementAt(i).characterName));
                    }
                    if (value.ElementAt(i).CharacterClass == "Warrior")
                    {
                        dreamTeam.Add(new Warrior(value.ElementAt(i).characterName));
                    }
                }
            }
        }
        private List<Characters> enemies = new List<Characters>();

        public List<Characters> Enemies { get { return enemies; }
            set { enemies = value; }
        }

        public CombatScreen(List<Characters> chars)
        {
            CombatTeam = chars;
            InitializeComponent();
            if (CombatControl.Visibility == Visibility.Visible)
                StartControl();

        }

        private void StartControl()
        {
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
        private void MonsterMiniStat(List<Characters> enemies)
        {
            for (int i = 0; i < enemies.Count; i++) {
                Label l = new Label();
                l.Content = $"{enemies.ElementAt(i).characterName} \nHp: {enemies.ElementAt(i).Health} Mp: {enemies.ElementAt(i).Mana}";
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
                Binding bind = new Binding("Health");
                bind.Mode = BindingMode.OneWay;
                l.DataContext = CombatTeam.ElementAt(i);

                l.Content = $"{CombatTeam.ElementAt(i).characterName} \nHp: {CombatTeam.ElementAt(i).Health} Mp: {CombatTeam.ElementAt(i).Mana}";
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
            for (int i = 0; i < dreamTeam.Count; i++)
            {
                Button b = new Button();
                b.Width = 50;
                b.Height = 75;
                b.Content = $"{CombatTeam.ElementAt(i).characterName}";
                b.Background = Brushes.Aqua;
                CharacterGrid.Children.Add(b);
            }
        }
        private void EnemyGrid(List<Characters> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Button b = new Button();
                b.Width = 50;
                b.Height = 75;
                b.Content = $"{enemies.ElementAt(i).characterName}";
                b.Background = Brushes.Crimson;
                MonsterGrid.Children.Add(b);
            }
        }
        int pauseCounter = 0;
        private void Pause_Command(object sender, ExecutedRoutedEventArgs e)
        {
            pauseCounter++;
            if(pauseCounter == 1)
                CharacterStats.Visibility = Visibility.Visible;
            else
            {
                CharacterStats.Visibility = Visibility.Hidden;
                pauseCounter = 0;
            }
        }
    }
}
