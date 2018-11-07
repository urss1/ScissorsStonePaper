using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SUMALI.TUT.ScissorsStonePaper.Model
{
    /// <summary>
    /// Kehrt den Wert für ein Boolean um:
    /// TRUE wird FALSE
    /// FALSE wird TRUE
    /// </summary>
    public class BoolReverseConverter : IValueConverter
    {
        /// <summary>
        /// Convertiert TRUE zu FALSE und umgekehrt
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(bool)value)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Convert back - do not use, is not implementent
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // ConvertBack without using
            return false;
        }
    }
}
