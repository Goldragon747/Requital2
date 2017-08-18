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
using Requital.ValueConverters;

namespace TestUserControls.UserControls
{
    public partial class CreationScreen : UserControl
    {
        ClassToImagesConverter c2iConverter = new ClassToImagesConverter();
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
                    Binding bind = new Binding("CharacterClass");
                    Characters p = new Characters();
                    Image i = new Image();
                    Label l = new Label();

                    WrapPanel wp = new WrapPanel();
                    wp.Orientation = Orientation.Vertical;
                    wp.Children.Add(l);
                    wp.Children.Add(i);

                    bind.Mode = BindingMode.OneWay;
                    bind.Converter = c2iConverter;
                    p.CharacterClass = NameLabel.Content.ToString();
                    i.SetBinding(Image.SourceProperty, bind);
                    i.Width = 100;
                    i.Height = 100;

                    l.Content = $"{Username.Text}";
                    l.HorizontalContentAlignment = HorizontalAlignment.Center;
                    l.VerticalContentAlignment = VerticalAlignment.Center;

                    i.DataContext = p;
                    i.MouseLeftButtonDown += B_Click;
                    i.MouseRightButtonDown += DeleteHero_Click;

                    TeamGrid.Children.Add(wp);
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

        private void ShowStats_Click(object sender, RoutedEventArgs e)
        {
            Characters p = new Characters();
            p.CharacterClass = ShowStatsButton.Content.ToString();

            for (int i = 0; i < charList.Count; i++)
            {
                if (charList.ElementAt(i).CharacterClass == p.CharacterClass)
                    StatsPanel.DataContext = charList.ElementAt(i);
            }
        }
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Team is ready to slay");
        }

        private void DeleteHero_Click(object sender, RoutedEventArgs e)
        {
            createCounter--;
            //Label l = (Label)sender;
            Image i = (Image)sender;
            //i.Children.Clear();
            TeamGrid.Children.Remove((WrapPanel)i.Parent);
            ReadyButton.Visibility = Visibility.Hidden;

        }

    }
}