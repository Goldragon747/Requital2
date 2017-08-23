using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Requital
{
    public class HitBox
    {

        Canvas Map;
        public HitBox(Canvas window)
        {
            Map = window;
            BuildTriggers();
        }
        public void BuildTriggers()
        {
            CreateAndPlaceBox(720, 800, 3540, 3970);
            CreateAndPlaceBox(720, 800, 3680, 4500);
            CreateAndPlaceBox(720, 800, 3950, 4600);
            CreateAndPlaceBox(100, 300, 4600, 4500);
            CreateAndPlaceBox(100, 300, 4700, 4400);
            CreateAndPlaceBox(600, 300, 4800, 4100);
            CreateAndPlaceBox(600, 3000, 5120, 2670);
            CreateAndPlaceBox(600, 3000, 5180, 2580);
            CreateAndPlaceBox(600, 3000, 5230, 2530);
            CreateAndPlaceBox(600, 3000, 5300, 2100);
            CreateAndPlaceBox(600, 1500, 5000, 800);
            CreateAndPlaceBox(3500, 100, 2500, 930);
            CreateAndPlaceBox(500, 130, 4480, 980);
            CreateAndPlaceBox(500, 130, 4530, 1020);
            CreateAndPlaceBox(500, 130, 4680, 1060);
            CreateAndPlaceBox(300, 200, 4910, 1100);
            CreateAndPlaceBox(500, 130, 3740, 980);
            CreateAndPlaceBox(500, 130, 3600, 1060);
            CreateAndPlaceBox(80, 870, 3720, 1060);
            CreateAndPlaceBox(980, 120, 2780, 1810);
            CreateAndPlaceBox(120, 120, 2720, 1790);
            CreateAndPlaceBox(120, 120, 2680, 1680);
            CreateAndPlaceBox(290, 100, 2650, 1600);
            CreateAndPlaceBox(290, 100, 2780, 1690);
            CreateAndPlaceBox(320, 130, 2810, 1760);
            CreateAndPlaceBox(220, 130, 3510, 1720);
            CreateAndPlaceBox(120, 120, 3680, 1610);
            CreateAndPlaceBox(120, 120, 3630, 1660);
            CreateAndPlaceBox(120, 120, 3680, 1190);
            CreateAndPlaceBox(120, 120, 3560, 1120);
            CreateAndPlaceBox(700, 120, 2900, 1070);
            CreateAndPlaceBox(120, 120, 2860, 1120);
            CreateAndPlaceBox(280, 120, 2610, 1160);
            CreateAndPlaceBox(2500, 300, 610, 880);
            CreateAndPlaceBox(330, 1700, 410, 880);
            CreateAndPlaceBox(1000, 250, 410, 2400);
            CreateAndPlaceBox(330, 1000, 1350, 1580);
            CreateAndPlaceBox(3280, 580, 1350, 2280);
            CreateAndPlaceBox(395, 980, 4220, 1440);
            CreateAndPlaceBox(445, 620, 3610, 2840);
            CreateAndPlaceBox(525, 220, 2270, 2720);
            CreateAndPlaceBox(1665, 220, 670, 2695);
            CreateAndPlaceBox(195, 1620, 580, 2695);
            CreateAndPlaceBox(905, 300, 580, 4200);
            CreateAndPlaceBox(70, 400, 1390, 3600);
            CreateAndPlaceBox(140, 400, 1390, 3900);
            CreateAndPlaceBox(1025, 435, 1390, 3340);
            CreateAndPlaceBox(180, 435, 1390, 4150);
            CreateAndPlaceBox(180, 135, 1450, 4220);
            CreateAndPlaceBox(180, 135, 1500, 4275);
            CreateAndPlaceBox(180, 135, 1550, 4340);
            CreateAndPlaceBox(180, 135, 1590, 4400);
            CreateAndPlaceBox(180, 135, 1640, 4470);
            CreateAndPlaceBox(550, 135, 1640, 4500);
            CreateAndPlaceBox(180, 135, 2110, 4470);
            CreateAndPlaceBox(180, 135, 2170, 4400);
            CreateAndPlaceBox(180, 135, 2220, 4370);
            CreateAndPlaceBox(180, 135, 2300, 4340);
            CreateAndPlaceBox(180, 135, 2350, 4280);
            CreateAndPlaceBox(180, 135, 2410, 4230);
            CreateAndPlaceBox(180, 135, 2460, 4165);
            CreateAndPlaceBox(470, 135, 2530, 4065);
            CreateAndPlaceBox(135, 135, 2930, 4135);
            CreateAndPlaceBox(135, 135, 2970, 4165);
            CreateAndPlaceBox(135, 605, 3020, 4245);
            CreateAndPlaceBox(550, 135, 3020, 4745);
        }
        public void CreateAndPlaceBox(int width, int height,int x, int y)
        {
            Rectangle t = new Rectangle();
            t.Width = width;
            t.Height = height;
            SolidColorBrush sb = new SolidColorBrush();
            sb.Color = Color.FromArgb(120, 124, 124, 0);
            //t.Fill = sb;
            Map.Children.Add(t);
            Canvas.SetTop(t, y);
            Canvas.SetLeft(t, x);
        }
        
    }
}
