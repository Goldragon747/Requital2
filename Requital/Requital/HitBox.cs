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

        Canvas CaveMap;
        Canvas DesertMap;
        public HitBox(Canvas window1,Canvas window2)
        {
            CaveMap = window1;
            DesertMap = window2;
            BuildTriggers();
        }
        public void BuildTriggers()
        {
            CreateAndPlaceBoxCave(720, 800, 3540, 3970);
            CreateAndPlaceBoxCave(720, 800, 3680, 4500);
            CreateAndPlaceBoxCave(720, 800, 3950, 4600);
            CreateAndPlaceBoxCave(100, 300, 4600, 4500);
            CreateAndPlaceBoxCave(100, 300, 4700, 4400);
            CreateAndPlaceBoxCave(600, 300, 4800, 4100);
            CreateAndPlaceBoxCave(600, 3000, 5120, 2670);
            CreateAndPlaceBoxCave(600, 3000, 5180, 2580);
            CreateAndPlaceBoxCave(600, 3000, 5230, 2530);
            CreateAndPlaceBoxCave(600, 3000, 5300, 2100);
            CreateAndPlaceBoxCave(600, 1500, 5000, 800);
            CreateAndPlaceBoxCave(3500, 100, 2500, 930);
            CreateAndPlaceBoxCave(500, 130, 4480, 980);
            CreateAndPlaceBoxCave(500, 130, 4530, 1020);
            CreateAndPlaceBoxCave(500, 130, 4680, 1060);
            CreateAndPlaceBoxCave(300, 200, 4910, 1100);
            CreateAndPlaceBoxCave(500, 130, 3740, 980);
            CreateAndPlaceBoxCave(500, 130, 3600, 1060);
            CreateAndPlaceBoxCave(80, 870, 3720, 1060);
            CreateAndPlaceBoxCave(980, 120, 2780, 1810);
            CreateAndPlaceBoxCave(120, 120, 2720, 1790);
            CreateAndPlaceBoxCave(120, 120, 2680, 1680);
            CreateAndPlaceBoxCave(290, 100, 2650, 1600);
            CreateAndPlaceBoxCave(290, 100, 2780, 1690);
            CreateAndPlaceBoxCave(320, 130, 2810, 1760);
            CreateAndPlaceBoxCave(220, 130, 3510, 1720);
            CreateAndPlaceBoxCave(120, 120, 3680, 1610);
            CreateAndPlaceBoxCave(120, 120, 3630, 1660);
            CreateAndPlaceBoxCave(120, 120, 3680, 1190);
            CreateAndPlaceBoxCave(120, 120, 3560, 1120);
            CreateAndPlaceBoxCave(700, 120, 2900, 1070);
            CreateAndPlaceBoxCave(120, 120, 2860, 1120);
            CreateAndPlaceBoxCave(280, 120, 2610, 1160);
            CreateAndPlaceBoxCave(2500, 300, 610, 880);
            CreateAndPlaceBoxCave(330, 1700, 410, 880);
            CreateAndPlaceBoxCave(1000, 250, 410, 2400);
            CreateAndPlaceBoxCave(330, 1000, 1350, 1580);
            CreateAndPlaceBoxCave(3280, 580, 1350, 2280);
            CreateAndPlaceBoxCave(395, 980, 4220, 1440);
            CreateAndPlaceBoxCave(445, 620, 3610, 2840);
            CreateAndPlaceBoxCave(525, 220, 2270, 2720);
            CreateAndPlaceBoxCave(1665, 220, 670, 2695);
            CreateAndPlaceBoxCave(195, 1620, 580, 2695);
            CreateAndPlaceBoxCave(905, 300, 580, 4200);
            CreateAndPlaceBoxCave(70, 400, 1390, 3600);
            CreateAndPlaceBoxCave(140, 400, 1390, 3900);
            CreateAndPlaceBoxCave(1025, 435, 1390, 3340);
            CreateAndPlaceBoxCave(180, 435, 1390, 4150);
            CreateAndPlaceBoxCave(180, 135, 1450, 4220);
            CreateAndPlaceBoxCave(180, 135, 1500, 4275);
            CreateAndPlaceBoxCave(180, 135, 1550, 4340);
            CreateAndPlaceBoxCave(180, 135, 1590, 4400);
            CreateAndPlaceBoxCave(180, 135, 1640, 4470);
            CreateAndPlaceBoxCave(550, 135, 1640, 4500);
            CreateAndPlaceBoxCave(180, 135, 2110, 4470);
            CreateAndPlaceBoxCave(180, 135, 2170, 4400);
            CreateAndPlaceBoxCave(180, 135, 2220, 4370);
            CreateAndPlaceBoxCave(180, 135, 2300, 4340);
            CreateAndPlaceBoxCave(180, 135, 2350, 4280);
            CreateAndPlaceBoxCave(180, 135, 2410, 4230);
            CreateAndPlaceBoxCave(180, 135, 2460, 4165);
            CreateAndPlaceBoxCave(470, 135, 2530, 4065);
            CreateAndPlaceBoxCave(135, 135, 2930, 4135);
            CreateAndPlaceBoxCave(135, 135, 2970, 4165);
            CreateAndPlaceBoxCave(135, 605, 3020, 4245);
            CreateAndPlaceBoxCave(550, 135, 3020, 4745);

            CreateAndPlaceBoxDesert(550, 360, 500, 0);
            CreateAndPlaceBoxDesert(450, 480, 500, 0);
            CreateAndPlaceBoxDesert(335, 860, 500, 0);
            CreateAndPlaceBoxDesert(285, 360, 500, 500);
            CreateAndPlaceBoxDesert(235, 460, 500, 490);
            CreateAndPlaceBoxDesert(235, 320, 455, 890);
            CreateAndPlaceBoxDesert(235, 320, 365, 980);
            CreateAndPlaceBoxDesert(235, 320, 285, 1050);
            CreateAndPlaceBoxDesert(235, 320, 235, 1350);
            CreateAndPlaceBoxDesert(235, 320, 295, 1465);
            CreateAndPlaceBoxDesert(235, 320, 365, 1535);
            CreateAndPlaceBoxDesert(235, 320, 425, 1615);
            CreateAndPlaceBoxDesert(235, 320, 450, 1640);
            CreateAndPlaceBoxDesert(235, 320, 520, 1840);
            CreateAndPlaceBoxDesert(235, 320, 560, 1890);
            CreateAndPlaceBoxDesert(235, 320, 560, 1890);
        }
        public void CreateAndPlaceBoxCave(int width, int height,int x, int y)
        {
            Rectangle t = new Rectangle();
            t.Width = width;
            t.Height = height;
            SolidColorBrush sb = new SolidColorBrush();
            sb.Color = Color.FromArgb(120, 124, 124, 0);
            //t.Fill = sb;
            CaveMap.Children.Add(t);
            Canvas.SetTop(t, y);
            Canvas.SetLeft(t, x);
        }
        public void CreateAndPlaceBoxDesert(int width, int height, int x, int y)
        {
            Rectangle t = new Rectangle();
            t.Width = width;
            t.Height = height;
            SolidColorBrush sb = new SolidColorBrush();
            sb.Color = Color.FromArgb(120, 124, 124, 0);
            t.Fill = sb;
            DesertMap.Children.Add(t);
            Canvas.SetTop(t, y);
            Canvas.SetLeft(t, x);
        }

    }
}
