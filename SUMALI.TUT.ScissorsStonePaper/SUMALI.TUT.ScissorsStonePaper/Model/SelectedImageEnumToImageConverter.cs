using SUMALI.TUT.ScissorsStonePaper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SUMALI.TUT.ScissorsStonePaper.Model
{
    /// <summary>
    /// Konvertiert den ENUM Wert in einen Bildpfad um
    /// </summary>
    public class SelectedImageEnumToImageConverter : IValueConverter
    {
        /// <summary>
        /// Konvertiert den ENUM Wert in ein Bildpfad um für die Anzeige
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string imageName = "icon_none";
            if (value is SelectedImage)
            {
                switch ((SelectedImage)value) {
                    case SelectedImage.Scissors:
                        imageName = "icon_cut";
                        break;
                    case SelectedImage.Paper:
                        imageName = "icon_paper";
                        break;
                    case SelectedImage.Stone:
                        imageName = "icon_stone";
                        break;
                    case SelectedImage.Lizard:
                        imageName = "icon_lizard";
                        break;
                    case SelectedImage.Spock:
                        imageName = "icon_spock";
                        break;
                    default:
                        break;
                }
            }
            
            return $@"/Includes/{imageName}.png";
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
