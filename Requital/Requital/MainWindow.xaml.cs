using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Requital
{
    public partial class MainWindow : Window
    {
        
        public Assets assets;
        public Movement movementLogic;
        private bool triggered = false;
        int counter = 0;
        public bool Triggered { get => triggered; set => triggered = value; }

        public MainWindow()
        {
            InitializeComponent();
            assets = new Assets();
            assets.LoadImages();
            movementLogic = new Movement(this);
            BuildCanvas();
            HitBox hitboxes = new HitBox(MovementScreen.Map);
        }
        
        public void BuildCanvas()
        {
            MovementScreen.MovementBackground = assets.cave;
            MovementScreen.Sprite = assets.rouge_right_1;
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
            this.KeyUp += new KeyEventHandler(OnButtonKeyUp);
        }
        public void MoveCanvasTop(double x)
        {
            Canvas.SetTop(MovementScreen.Map, x);
        }
        public void MoveCanvasLeft(double y)
        {
            Canvas.SetLeft(MovementScreen.Map, y);
        }
        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            if (MovementScreen.IsVisible)
            {
                movementLogic.OnButtonKeyDown(sender, e);
            }
        }
        private void OnButtonKeyUp(object sender, KeyEventArgs e)
        {
            if (MovementScreen.IsVisible)
            {
                movementLogic.OnButtonKeyUp(sender, e);
            }
        }

        public bool HitDetection()
        {
            foreach (UIElement item in MovementScreen.Map.Children)
            {
                if (item is Shape)
                {
                    Rectangle t = (Rectangle)item;
                    //double x1 = ((movementLogic.X + 570) - (Canvas.GetLeft(t)));
                    //double y1 = ((movementLogic.Y + 300) - (Canvas.GetTop(t)));
                    double x1 = movementLogic.X - 570;
                    double y1 = movementLogic.Y - 300;
                    counter++;
                    MovementScreen.Debug.Content = $"{counter} : {x1} : {y1} : { triggered }";
                    return (x1 >= (movementLogic.X + Canvas.GetLeft(t)) && x1 <= (movementLogic.X + Canvas.GetLeft(t)) + t.Width) 
                        && (y1 >= (movementLogic.Y + Canvas.GetTop(t)) && y1 <= (movementLogic.Y + Canvas.GetTop(t)) + t.Height);
                }
            }
            return false;
        }
    }
}
