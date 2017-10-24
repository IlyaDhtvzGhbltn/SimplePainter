using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using WindowsFormsApplication1.Figures.Interfaces;
using WindowsFormsApplication1.Serveses;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Figures.FigurePainterStatemets
{
    class CircleStatement : IFigureStatement
    {


        public void Paint(PictureBox Holst)
        {
            Icircle Painted = new Circle(Form1.FigureWidth, Form1.CircleRadius, Form1.SelectedColor, Form1.X, Form1.Y);
            Graphics g = Holst.CreateGraphics();
            {
                Pen PenColor = new Pen(Painted.FigureColor, Painted.ConturWidth);
                g.DrawEllipse(PenColor, Painted.Xstrt, Painted.Ystrt, Painted.Radius, Painted.Radius);
            }
        }

      
     }
}

