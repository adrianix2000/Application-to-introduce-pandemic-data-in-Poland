using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Data
{
    public class ColorsMenager
    {
        private List<string> GreyColors = new List<string>
        {
            "#414141",
            "#434343",
            "#464646",
            "#494949",
            "#4c4c4c",
            "#3a3a3a",
            "#4f4f4f",
        };

        private List<string> LightColors = new List<string>
        {
            "#64b5f6",
            "#9575cd",
            "#f06292",
            "#66bb6a",
            "#fff176",
            "#8d6e63",
            "#607d8b",
        };

        Random random = new Random();

        public Color DrawAColor()
        {
            int index = random.Next(0, GreyColors.Count - 1);
            return ColorTranslator.FromHtml(GreyColors[index]);
        }

        public Color DrawLightColor()
        {
            int index = random.Next(0, LightColors.Count - 1);
            return ColorTranslator.FromHtml(LightColors[index]);
        }

        public Color ChangeBrightness(Color color, double Correction)
        {
            double red = color.R;
            double blue = color.B;
            double green = color.G;

            if(Correction < 0)
            {
                Correction = 1 + Correction;
                red *= Correction;
                blue *= Correction;
                green *= Correction;
            }
            else
            {
                red = (255 - red) * Correction + red;
                blue = (255 - blue) * Correction + blue;
                green = (255 - green) * Correction + green;
            }

            Color result = Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
            return result;

        }
        
    }
}
