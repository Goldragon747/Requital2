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
            CreateAndPlaceBox(100, 100, 100, 100);
            CreateAndPlaceBox(200, 100, 100, 100);
            CreateAndPlaceBox(300, 100, 100, 100);
        }
        public void CreateAndPlaceBox(int width, int height,int x, int y)
        {
            Trigger t = new Trigger(width, height);
            Map.Children.Add(t.Box);
            Canvas.SetTop(t.Box, x);
            Canvas.SetLeft(t.Box, y);
        }
        
    }
}
