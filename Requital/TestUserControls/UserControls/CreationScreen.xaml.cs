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
using Requital;
using System.Collections.ObjectModel;

namespace TestUserControls.UserControls
{
    public partial class CreationScreen : UserControl
    {
            ObservableCollection<Characters> charList = new ObservableCollection<Characters>()
            {
                new Warrior(), new Rogue(), new Mage(), new Cleric(),
            };
        public CreationScreen()
        {
            InitializeComponent();
            ItemsComboBox.ItemsSource = charList;
        }
        int createCounter = 0;
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if(NameLabel.Content != null)
            {
                if (createCounter < 4)
                {
                    Characters p = new Characters();
                    p.CharacterClass = NameLabel.Content.ToString();
                    Label b = new Label();
                    b.Background = Brushes.Moccasin;
                    b.Width = 100;
                    b.Height = 100;
                    b.Content = $"Name: {Username.Text} \nClass: {NameLabel.Content}";
                    b.HorizontalContentAlignment = HorizontalAlignment.Center;
                    b.VerticalContentAlignment = VerticalAlignment.Center;
                    b.DataContext = p;
                    b.MouseLeftButtonDown += B_Click;
                    b.MouseRightButtonDown += DeleteHero_Click;

                    TeamGrid.Children.Add(b);
                    createCounter++;
                }
            }
            

            if (createCounter == 4)
                ReadyButton.Visibility = Visibility.Visible;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Label b = ((Label)sender);
            Characters p = (Characters)b.DataContext;
            
            for (int i = 0; i < charList.Count; i++)
            {
                if (charList.ElementAt(i).CharacterClass == p.CharacterClass)
                    StatsPanel.DataContext = charList.ElementAt(i);
            }
        }

        //private void ShowStats_Click(object sender, RoutedEventArgs e)
        //{
        //    Characters p = new Characters();
        //    p.CharacterClass = ShowStatsButton.Content.ToString();

        //    for (int i = 0; i < charList.Count; i++)
        //    {
        //        if (charList.ElementAt(i).CharacterClass == p.CharacterClass)
        //            StatsPanel.DataContext = charList.ElementAt(i);
        //    }
        //}
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Team is ready to slay");
        }

        private void DeleteHero_Click(object sender, RoutedEventArgs e)
        {
            createCounter--;
            Label l = (Label)sender;
            TeamGrid.Children.Remove(l);
            ReadyButton.Visibility = Visibility.Hidden;

        }

    }
}