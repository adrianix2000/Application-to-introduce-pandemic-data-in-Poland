using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_Data.Forms
{
    class ElipseControl : Component
    {
        [DllImportAttribute("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Control Cntrl;

        private int CornerRadius = 20;

        public Control TargetControl
        {
            get { return Cntrl; }
            set
            {
                Cntrl = value;
                Cntrl.SizeChanged += Cntrl_SizeChanged;
            }
        }

        public int CorrenerRadius
        {
            get { return CornerRadius; }
            set
            {
                CornerRadius = value;

                if(Cntrl != null)
                    Cntrl.Region = Cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,
                                           Cntrl.Width,
                                           Cntrl.Height,
                                           CornerRadius,
                                           CornerRadius));
            }
        }

        private void Cntrl_SizeChanged(object sender, EventArgs e)
        {
            Cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 
                                           Cntrl.Width, 
                                           Cntrl.Height, 
                                           CornerRadius,
                                           CornerRadius));
        }
    }
}
