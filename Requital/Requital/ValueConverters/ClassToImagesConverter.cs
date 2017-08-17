using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Requital.ValueConverters
{
    public class ClassToImagesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string c = (string)value;

            if (c == "Rogue")
                return new Uri(@"pack://application:,,,/Requital;component/assets/Rogue.png", UriKind.RelativeOrAbsolute);
            if (c == "Warrior")
                return new Uri("pack://application:,,,/Requital;component/assets/Warrior.png", UriKind.RelativeOrAbsolute);
            if (c == "Mage")
                return new Uri("pack://application:,,,/Requital;component/assets/Mage.png", UriKind.RelativeOrAbsolute);
            if (c == "Cleric")
                return new Uri("pack://application:,,,/Requital;component/assets/Cleric.png", UriKind.RelativeOrAbsolute);

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
