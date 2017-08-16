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

namespace Requital.Windows
{
    /// <summary>
    /// Interaction logic for MovementScreen.xaml
    /// </summary>
    public partial class MovementScreen : UserControl
    {

        public ImageSource Sprite
        {
            get { return sprite.Source; }
            set { sprite.Source = value; }
        }
        public ImageSource MovementBackground
        {
            get { return _image.Source; }
            set { _image.Source = value; }
        }
        public Canvas MovementCanvas
        {
            get { return mainCanvas; }
            set { mainCanvas = value; }
        }
        public Canvas MapCanvas
        {
            get { return Map; }
            set { Map = value; }
        }
        public Image MovementImage
        {
            get { return _image; }
            set { _image = value; }
        }
        public Label DebugLabel {
            get {
                return Debug;
            }
            set {
                Debug = value;
            }
        }

        public MovementScreen()
        {
            InitializeComponent();
        }
    }
}
