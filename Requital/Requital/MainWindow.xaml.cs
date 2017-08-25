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
        public Movement caveMovementLogic;
        public Movement desertMovementLogic;
        public Encounters encounter;
        public List<Characters> dreamTeam;
        private bool triggered = false;
        int counter = 0;
        public bool Triggered { get => triggered; set => triggered = value; }

        public MainWindow()
        {
            InitializeComponent();
            assets = new Assets();
            assets.LoadImages();
            Menu.MenuSource = assets.title;
            encounter = new Encounters();
            caveMovementLogic = new Movement(this, -2750, -4300);
            desertMovementLogic = new Movement(this, 0, 0);
            BuildCanvas();
            HitBox hitboxes = new HitBox(Cave.Map);
        }
        
        public void BuildCanvas()
        {
            Cave.MovementBackground = assets.cave;
            Cave.Sprite = assets.rouge_right_1;
            Cave.ExclamSource = assets.ex;
            Desert.MovementBackground = assets.desert;
            Desert.Sprite = assets.rouge_right_1;
            Desert.ExclamSource = assets.ex;
            MoveCanvasTop(caveMovementLogic.Y); //--//
            MoveCanvasLeft(caveMovementLogic.X);
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
            this.KeyUp += new KeyEventHandler(OnButtonKeyUp);
        }
        public void MoveCanvasTop(double x)
        {
            if (Cave.IsVisible)
            {
                Canvas.SetTop(Cave.Map, x);
            } else if (Desert.IsVisible)
            {
                Canvas.SetTop(Desert.Map, x);
            }

        }
        public void MoveCanvasLeft(double y)
        {
            if (Cave.IsVisible)
            {
                Canvas.SetLeft(Cave.Map, y);
            }
            else if (Desert.IsVisible)
            {
                Canvas.SetLeft(Desert.Map, y);
            }
        }
        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            if (Cave.IsVisible)
            {
                caveMovementLogic.OnButtonKeyDown(sender, e);
            }
            if (Desert.IsVisible)
            {
                desertMovementLogic.OnButtonKeyDown(sender, e);
            }
        }
        private void OnButtonKeyUp(object sender, KeyEventArgs e)
        {
            if (Cave.IsVisible)
            {
                caveMovementLogic.OnButtonKeyUp(sender, e);
            }
            if (Desert.IsVisible)
            {
                desertMovementLogic.OnButtonKeyUp(sender, e);
            }
        }

        public bool HitDetection()
        {
            bool returnBool = false;
            foreach (UIElement item in Cave.Map.Children)
            {
                if (item is Rectangle)
                {
                    Rectangle t = (Rectangle)item;
                    double x1 = caveMovementLogic.X - 570;
                    double y1 = caveMovementLogic.Y - 300;
                    double leftBound = -(Canvas.GetLeft(t));
                    double rightBound = -(Canvas.GetLeft(t) + t.Width);
                    double topBound = -(Canvas.GetTop(t));
                    double bottomBound = -(Canvas.GetTop(t) + t.Height);
                    counter++;
                    Cave.Debug.Content = $"{counter} : x1 {x1} : y1 {y1} : { triggered } left {leftBound} : right {rightBound} : bottom {bottomBound} : top {topBound} ";
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
            //Cave.ExclamVisibility = Visibility.Visible;
            Desert.ExclamVisibility = Visibility.Visible;
            desertMovementLogic.disable = true;
            //caveMovementLogic.disable = true;
            desertMovementLogic.isMoving = false;
            desertMovementLogic.movementTimer.Stop();
            desertMovementLogic.dispatcherTimer.Stop();
            await Task.Delay(1600);
            //Cave.Visibility = Visibility.Hidden;
            Desert.Visibility = Visibility.Hidden;
            CS.Enemies = encounter.pickEncounter();
            CS.dreamTeam = dreamTeam;
            CS.StartControl();
            CS.Visibility = Visibility.Visible;
        }

        private void CreateCharacters_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(CreateCharacters.Visibility == Visibility.Collapsed)
            {
                //Cave.Visibility = Visibility.Visible;
                Desert.Visibility = Visibility.Visible;
                dreamTeam = CreateCharacters.DreamTeam;
            }
        }

        private void Menu_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Menu.Visibility == Visibility.Hidden)
                CreateCharacters.Visibility = Visibility.Visible;
        }
    }
}
