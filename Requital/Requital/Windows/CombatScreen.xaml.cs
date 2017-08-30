using Requital;
using Requital.Spells;
using Requital.ValueConverters;
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
        private ClassToImagesConverter c2iConverter = new ClassToImagesConverter();
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
        }

        int turnCounter = 0;

        private void EnemyAttack()
        {
            Random r = new Random();
            MessageBox.Show($"Enemy's Turn");
            for (int i = 0; i < enemies.Count; i++) {
                int index = r.Next(4);
                combat.physicalAttack(enemies.ElementAt(i), dreamTeam.ElementAt(index));
            }

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
                    combat.physicalAttack(dreamTeam.ElementAt(turnCounter), enemies.ElementAt(i));
                    turnCounter++;
                }
            }

            if (turnCounter > 3)
                EnemyAttack();
        }

        private void Defend_Click(object sender, RoutedEventArgs e)
        {
            combat.defend(dreamTeam.ElementAt(turnCounter));
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
            b.Click += UseMagic;
            ViewMagic.Children.Add(b);
        }

        private void UseMagic(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            ViewMagicGrid.Visibility = Visibility.Hidden;
            if(b.Name == "Heal")
            {
                for (int i = 0; i < dreamTeam.Count; i++) {
                    if (dreamTeam.ElementAt(i).Background == Brushes.LightBlue) {
                        combat.healSpells(dreamTeam.ElementAt(turnCounter), dreamTeam.ElementAt(i));
                        turnCounter++;
                    }
                }
            }
            if(b.Name == "Revive")
            {
                for (int i = 0; i < dreamTeam.Count; i++) {
                    if (dreamTeam.ElementAt(i).Background == Brushes.LightBlue) {
                        combat.revive(dreamTeam.ElementAt(turnCounter), dreamTeam.ElementAt(i));
                        turnCounter++;
                    }
                }
            }
            if(b.Name == "Fireball")
            {
                for (int i = 0; i < enemies.Count; i++) {
                    if (enemies.ElementAt(i).Background == Brushes.LightPink) {
                        combat.attackSpells(dreamTeam.ElementAt(turnCounter), enemies.ElementAt(i));
                        turnCounter++;
                    }
                }
            }

            if (turnCounter > 3)
                EnemyAttack();
        }

        private void MonsterMiniStat(List<Characters> enemies)
        {
            for (int i = 0; i < enemies.Count; i++) {
                StackPanel sp = new StackPanel();
                sp.Width = 183.25;
                sp.Height = 61.25;

                Label l = new Label();
                l.FontWeight = FontWeights.DemiBold;
                l.Content = $"{enemies.ElementAt(i).characterName}";
                l.HorizontalContentAlignment = HorizontalAlignment.Center;
                l.VerticalContentAlignment = VerticalAlignment.Center;

                DockPanel dp = new DockPanel();
                dp.HorizontalAlignment = HorizontalAlignment.Center;
                TextBlock health = new TextBlock();
                health.Text = "HP: ";
                Binding bindH = new Binding("Health");
                bindH.Mode = BindingMode.TwoWay;
                TextBlock tb1 = new TextBlock();
                tb1.DataContext = enemies.ElementAt(i);
                tb1.SetBinding(TextBlock.TextProperty, bindH);
                dp.Children.Add(health);
                dp.Children.Add(tb1);

                DockPanel dp2 = new DockPanel();
                dp2.HorizontalAlignment = HorizontalAlignment.Center;
                TextBlock mana = new TextBlock();
                mana.Text = "MP: ";
                Binding bindM = new Binding("Mana");
                bindM.Mode = BindingMode.TwoWay;
                TextBlock tb2 = new TextBlock();
                tb2.DataContext = enemies.ElementAt(i);
                tb2.SetBinding(TextBlock.TextProperty, bindM);
                dp2.Children.Add(mana);
                dp2.Children.Add(tb2);

                sp.Children.Add(l);
                sp.Children.Add(dp);
                sp.Children.Add(dp2);
                MonStats.Children.Add(sp);
            }
        }
        private void CharMiniStat()
        {
            for (int i = 0; i < 4; i++) {
                StackPanel sp = new StackPanel();
                sp.Width = 206;
                sp.Height = 92;

                Label l = new Label();
                l.Width = 206;
                l.Height = 46;
                l.FontWeight = FontWeights.DemiBold;
                l.Content = $"{dreamTeam.ElementAt(i).characterName}";
                l.HorizontalContentAlignment = HorizontalAlignment.Center;
                l.VerticalContentAlignment = VerticalAlignment.Center;

                DockPanel dp = new DockPanel();
                dp.HorizontalAlignment = HorizontalAlignment.Center;
                TextBlock health = new TextBlock();
                health.Text = "HP: ";
                Binding bindH = new Binding("Health");
                bindH.Mode = BindingMode.TwoWay;
                TextBlock tb1 = new TextBlock();
                tb1.DataContext = dreamTeam.ElementAt(i);
                tb1.SetBinding(TextBlock.TextProperty, bindH);
                dp.Children.Add(health);
                dp.Children.Add(tb1);

                DockPanel dp2 = new DockPanel();
                dp2.HorizontalAlignment = HorizontalAlignment.Center;
                TextBlock mana = new TextBlock();
                mana.Text = "MP: ";
                Binding bindM = new Binding("Mana");
                bindM.Mode = BindingMode.TwoWay;
                TextBlock tb2 = new TextBlock();
                tb2.DataContext = dreamTeam.ElementAt(i);
                tb2.SetBinding(TextBlock.TextProperty, bindM);
                dp2.Children.Add(mana);
                dp2.Children.Add(tb2);

                sp.Children.Add(l);
                sp.Children.Add(dp);
                sp.Children.Add(dp2);
                CharStats.Children.Add(sp);
            }
        }
        private void HeroGrid()
        {
            for (int i = 0; i < dreamTeam.Count; i++)
            {
                Image b = new Image();
                Binding bind = new Binding("CharacterClass");
                bind.Mode = BindingMode.OneWay;
                bind.Converter = c2iConverter;
                b.DataContext = dreamTeam.ElementAt(i);
                b.SetBinding(Image.SourceProperty, bind);
                b.FlowDirection = FlowDirection.RightToLeft;
                b.MouseLeftButtonDown += SelectedHero;

                b.Width = 100;
                b.Height = 100;

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

        private void SelectedHero(object sender, MouseButtonEventArgs e)
        {
            Image en = (Image)sender;
            Characters hero = (Characters)en.DataContext;

            for (int i = 0; i < dreamTeam.Count; i++)
            {
                if (hero == dreamTeam.ElementAt(i))
                    hero.Background = Brushes.LightBlue;
                else
                    dreamTeam.ElementAt(i).Background = Brushes.Black;
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
