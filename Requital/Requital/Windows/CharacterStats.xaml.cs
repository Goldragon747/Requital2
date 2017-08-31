using Requital;
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

namespace TestUserControls.UserControls
{
    public partial class CharacterStats : UserControl
    {
        private ClassToImagesConverter c2iConverter = new ClassToImagesConverter();
        public List<Characters> charList { get; set; }
        public CharacterStats(List<Characters> statTeam)
        {
            InitializeComponent();
            charList = statTeam;
            CharacterButtons();
            //ExitButton();
        }

        private void ExitButton()
        {
            Thickness margin = new Thickness();
            margin.Left = 500;
            margin.Top = 50;
            Button b = new Button();
            b.Content = "Exit to Menu";
            b.Width = 150;
            b.Height = 50;
            b.FontSize = 24;
            b.FontWeight = FontWeights.DemiBold;
            b.Margin = margin;
            b.Click += ExitToMenu;

            ButtonPanel.Children.Add(b);
        }

        private void ExitToMenu(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void CharacterButtons()
        {
            for (int x = 0; x < 4; x++)
            {
                Binding bind = new Binding("CharacterClass");
                Image i = new Image();
                Label l = new Label();
                Thickness margin = new Thickness();

                WrapPanel wp = new WrapPanel();
                wp.Orientation = Orientation.Vertical;
                wp.HorizontalAlignment = HorizontalAlignment.Center;
                wp.VerticalAlignment = VerticalAlignment.Center;
                wp.Children.Add(l);
                wp.Children.Add(i);

                bind.Mode = BindingMode.OneWay;
                bind.Converter = c2iConverter;
                i.SetBinding(Image.SourceProperty, bind);
                i.Width = 100;
                i.Height = 100;
                margin.Left = 150;
                i.Margin = margin;
                i.DataContext = charList.ElementAt(x);
                i.MouseLeftButtonDown += ShowStats;

                l.Margin = margin;
                l.Content = charList.ElementAt(x).characterName;
                l.HorizontalContentAlignment = HorizontalAlignment.Center;
                l.VerticalContentAlignment = VerticalAlignment.Center;

                ButtonPanel.Children.Add(wp);
            }
        }

        private void ShowStats(object sender, RoutedEventArgs e)
        {
            Image b = ((Image)sender);
            Characters p = (Characters)b.DataContext;

            for (int i = 0; i < charList.Count; i++)
            {
                if (charList.ElementAt(i).CharacterClass == p.CharacterClass)
                    MainPanel.DataContext = charList.ElementAt(i);
            }
        }
    }
}
