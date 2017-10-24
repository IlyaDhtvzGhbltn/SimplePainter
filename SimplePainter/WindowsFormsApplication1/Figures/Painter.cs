using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Figures.Interfaces;

namespace WindowsFormsApplication1.Serveses
{
    class Painter
    {
        IFigureStatement State { get; set; }

        public Painter(IFigureStatement State)
        {
            this.State = State;
        }
        public void Paint(PictureBox PBx)
        {
            State.Paint(PBx);
        }
    }
}
