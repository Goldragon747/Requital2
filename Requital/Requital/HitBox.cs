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
            CreateAndPlaceBox(800, 800, 3900, 4000);
        }
        public void CreateAndPlaceBox(int width, int height,int x, int y)
        {
            Rectangle t = new Rectangle();
            t.Width = width;
            t.Height = height;
            t.Fill = Brushes.DarkSalmon;
            Map.Children.Add(t);
            Canvas.SetTop(t, y);
            Canvas.SetLeft(t, x);
        }
        
    }
}
