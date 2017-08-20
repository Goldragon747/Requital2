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
        List<Characters> charList = new List<Characters>() {
            new Warrior(), new Rogue(), new Mage(), new Cleric(),
        };
        List<Image> tempImg = new List<Image>();
        public CreationScreen()
        {
            InitializeComponent();
            ItemsComboBox.ItemsSource = charList;
        }
        int createCounter = 0;
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if(CheapLabel.Content != null)
            {
                if (createCounter < 4)
                {
                    Binding bind = new Binding("CharacterClass");
                    Characters p = new Characters();
                    Image i = new Image();
                    Label l = new Label();

                    WrapPanel wp = new WrapPanel();
                    wp.Orientation = Orientation.Vertical;
                    wp.HorizontalAlignment = HorizontalAlignment.Center;
                    wp.VerticalAlignment = VerticalAlignment.Center;
                    wp.Children.Add(l);
                    wp.Children.Add(i);

                    bind.Mode = BindingMode.OneWay;
                    bind.Converter = c2iConverter;
                    p.CharacterClass = CheapLabel.Content.ToString();
                    p.characterName = Username.Text;
                    i.SetBinding(Image.SourceProperty, bind);
                    i.Width = 100;
                    i.Height = 100;

                    l.Content = Username.Text;
                    l.HorizontalContentAlignment = HorizontalAlignment.Center;
                    l.VerticalContentAlignment = VerticalAlignment.Center;

                    i.DataContext = p;
                    i.MouseLeftButtonDown += B_Click;
                    i.MouseRightButtonDown += DeleteHero_Click;

                    TeamGrid.Children.Add(wp);
                    tempImg.Add(i);
                    createCounter++;
                }
            }
            if (createCounter == 4)
                ReadyButton.Visibility = Visibility.Visible;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Image b = ((Image)sender);
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
        public List<Characters> dreamTeam = new List<Characters>(); //Has the official team roster
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            dreamTeam.Clear();
            for (int i = 0; i < tempImg.Count; i++)
            {
                Characters c = (Characters)tempImg.ElementAt(i).DataContext;
                dreamTeam.Add(c);
            }
            MessageBox.Show($"Team is ready to slay");
            CreationScreenControl.Visibility = Visibility.Collapsed;
        }

        private void DeleteHero_Click(object sender, RoutedEventArgs e)
        {
            createCounter--;
            Image i = (Image)sender;
            TeamGrid.Children.Remove((WrapPanel)i.Parent);

            for (int x = 0; x < tempImg.Count; x++) {
                if (tempImg.ElementAt(x) == i)
                    tempImg.RemoveAt(x);
            }
            ReadyButton.Visibility = Visibility.Hidden;
        }

    }
}