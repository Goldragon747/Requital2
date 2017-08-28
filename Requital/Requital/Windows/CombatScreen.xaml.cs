using Requital;
using Requital.Spells;
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
using TestUserControls.UserControls;

namespace TestUserControls.UserControls
{
    /// <summary>
    /// Interaction logic for CombatScreen.xaml
    /// </summary>
    public partial class CombatScreen : UserControl
    {
        public List<Characters> dreamTeam { get; set; }
        //public List<Characters> CombatTeam { get { return dreamTeam; }
        //    set {
        //        for (int i = 0; i < 4; i++) {
        //            if(value.ElementAt(i).CharacterClass == "Cleric") {
        //                dreamTeam.Add(new Cleric(value.ElementAt(i).characterName));
        //            }
        //            if (value.ElementAt(i).CharacterClass == "Mage") {
        //                dreamTeam.Add(new Mage(value.ElementAt(i).characterName));
        //            }
        //            if (value.ElementAt(i).CharacterClass == "Rogue")
        //            {
        //                dreamTeam.Add(new Rogue(value.ElementAt(i).characterName));
        //            }
        //            if (value.ElementAt(i).CharacterClass == "Warrior")
        //            {
        //                dreamTeam.Add(new Warrior(value.ElementAt(i).characterName));
        //            }
        //        }
        //    }
        //}
        private List<Characters> enemies = new List<Characters>();

        public List<Characters> Enemies { get { return enemies; }
            set { enemies = value; }
        }
        private CharacterStats cs;
        public SolidColorBrush brush1 = new SolidColorBrush();
        List<Characters> turnList = new List<Characters>();
        Combat combat = new Combat();

        public CombatScreen()
        {
            InitializeComponent();
        }

        public void StartControl()
        {
            HeroGrid();
            CharMiniStat();
            EnemyGrid(Enemies);
            MonsterMiniStat(Enemies);
            cs = new CharacterStats(dreamTeam);
            Heal heal = new Heal();
            FireBall fb = new FireBall();
            Revive r = new Revive();
            MagicB_Description(heal.Name, heal.ManaCost);
            MagicB_Description(fb.Name, fb.ManaCost);
            MagicB_Description(r.Name, r.ManaCost);
            MagicB_Description("Thundaga", 10);

            for (int i = 0; i < 4; i++) turnList.Add(dreamTeam.ElementAt(i)); 
            for (int i = 0; i < enemies.Count; i++) turnList.Add(enemies.ElementAt(i));
        }

        int turnCounter = 0;

        private void EnemyAttack()
        {
            Random r = new Random();
            int index = r.Next(4);

            combat.physicalAttack(turnList.ElementAt(turnCounter), dreamTeam.ElementAt(index));
            if (turnCounter == turnList.Count - 1)
                turnCounter = 0;
        }

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
            for (int i = 0; i < enemies.Count; i++) {
                if (enemies.ElementAt(i).Background == Brushes.LightPink) {
                    MessageBox.Show($"{turnList.ElementAt(turnCounter)}");
                    combat.physicalAttack(turnList.ElementAt(turnCounter), enemies.ElementAt(i));
                }
            }
            turnCounter++;
            if (turnCounter > 3)
                EnemyAttack();
        }

        private void Defend_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{turnList.ElementAt(turnCounter)}");

            turnCounter++;
            if (turnCounter > 3)
                EnemyAttack();
        }

        private void Flee_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
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
                l.DataContext = dreamTeam.ElementAt(i);

                l.Content = $"{dreamTeam.ElementAt(i).characterName} \nHp: {dreamTeam.ElementAt(i).Health} Mp: {dreamTeam.ElementAt(i).Mana}";
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
                Binding bind = new Binding("Health");
                bind.Mode = BindingMode.TwoWay;
                b.DataContext = dreamTeam.ElementAt(i);
                b.SetBinding(ContentProperty, bind);

                b.Width = 50;
                b.Height = 75;
                b.Background = Brushes.Aqua;

                CharacterGrid.Children.Add(b);
            }
        }
        private void EnemyGrid(List<Characters> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Button b = new Button();
                Binding bind = new Binding("Health");
                bind.Mode = BindingMode.TwoWay;
                b.DataContext = enemies.ElementAt(i);
                b.SetBinding(ContentProperty, bind);

                b.Width = 50;
                b.Height = 75;
                b.Background = Brushes.Crimson;
                b.Click += SelectedEnemy;
                MonsterGrid.Children.Add(b);
            }
        }

        private void SelectedEnemy(object sender, RoutedEventArgs e)
        {
            Button en = (Button)sender;
            Characters enemy = (Characters)en.DataContext;

            for (int i = 0; i < enemies.Count; i++) {
                if (enemy == enemies.ElementAt(i))
                    enemy.Background = Brushes.LightPink;
                else
                    enemies.ElementAt(i).Background = Brushes.Crimson;
            }
        }

        int pauseCounter = 0;
        private void Pause_Command(object sender, ExecutedRoutedEventArgs e)
        {
            pauseCounter++;
;
            Grid.SetRow(cs, 0);
            Grid.SetColumn(cs, 0);
            Grid.SetRowSpan(cs, 2);
            Grid.SetColumnSpan(cs, 3);
            Options.Children.Add(cs);

            if (pauseCounter == 1)
                cs.Visibility = Visibility.Visible;

            else if (pauseCounter == 2)
            {
                cs.Visibility = Visibility.Hidden;
                pauseCounter = 0;
            }
        }
    }
}
