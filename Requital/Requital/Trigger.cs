using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Requital
{
    public class Trigger : UIElement
    {
        private Rectangle box;

        public Rectangle Box
        {
            get { return box; }
            set { box = value; }
        }
        
        public Trigger(int x, int y)
        {
            box = new Rectangle();
            box.Width = x;
            box.Height = y;
            box.Fill = Brushes.DarkSalmon;
        }

        public Trigger()
        {
        }
    }
}
