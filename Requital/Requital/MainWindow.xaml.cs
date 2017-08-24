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
        public Encounters encounter;
        private bool triggered = false;
        int counter = 0;
        public bool Triggered { get => triggered; set => triggered = value; }

        public MainWindow()
        {
            InitializeComponent();
            assets = new Assets();
            assets.LoadImages();
            encounter = new Encounters();
            movementLogic = new Movement(this);
            BuildCanvas();
            HitBox hitboxes = new HitBox(MovementScreen.Map);
        }
        
        public void BuildCanvas()
        {
            MovementScreen.MovementBackground = assets.cave;
            MovementScreen.Sprite = assets.rouge_right_1;
            MovementScreen.ExclamSource = assets.ex;
            MoveCanvasTop(movementLogic.Y);
            MoveCanvasLeft(movementLogic.X);
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
            bool returnBool = false;
            foreach (UIElement item in MovementScreen.Map.Children)
            {
                if (item is Rectangle)
                {
                    Rectangle t = (Rectangle)item;
                    double x1 = movementLogic.X - 570;
                    double y1 = movementLogic.Y - 300;
                    double leftBound = -(Canvas.GetLeft(t));
                    double rightBound = -(Canvas.GetLeft(t) + t.Width);
                    double topBound = -(Canvas.GetTop(t));
                    double bottomBound = -(Canvas.GetTop(t) + t.Height);
                    counter++;
                    MovementScreen.Debug.Content = $"{counter} : x1 {x1} : y1 {y1} : { triggered } left {leftBound} : right {rightBound} : bottom {bottomBound} : top {topBound} ";
                    if ((x1 <= leftBound && x1 >= rightBound) && (y1 >= bottomBound && y1 <= topBound) ||
                        (x1 - 65 <= leftBound && x1 - 100 >= rightBound) && (y1 >= bottomBound && y1 <= topBound) ||
                        (x1 - 65 <= leftBound && x1 - 100 >= rightBound) && (y1 - 100 >= bottomBound && y1 - 100 <= topBound) ||
                        (x1 <= leftBound && x1 >= rightBound) && (y1 - 100 >= bottomBound && y1 - 100 <= topBound))
                    {
                        returnBool = true;
                    } 
                }
            }
            return returnBool;
        }
        public void TryTriggerCombat()
        {
            Random ran = new Random();
            if ((ran.Next(120) == 55 && counter> 60000) || counter > 150000)
            {
                counter = 0;
                TriggerCombat();
            }
        }
        public async void TriggerCombat()
        {
            MovementScreen.ExclamVisibility = Visibility.Visible;
            movementLogic.disable = true;
            await Task.Delay(1600);
            MovementScreen.Visibility = Visibility.Hidden;
            CS.Enemies = encounter.pickEncounter();
            CS.Visibility = Visibility.Visible;
        }
    }
}
