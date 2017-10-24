using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Figures.Interfaces;
using WindowsFormsApplication1.Serveses;

namespace WindowsFormsApplication1.Figures.FigurePainterStatemets
{
    class PolygonStatement : IFigureStatement
    {
        public void Paint(PictureBox Holst)
        {
            Ipolygon Painted = new Polygon(Form1.Corners, Form1.CircleRadius, Form1.X, Form1.Y, Form1.FigureWidth, Form1.SelectedColor);
            Graphics g = Holst.CreateGraphics();
            {
                Pen PenColor = new Pen(Painted.FigureColor, Painted.ConturWidth);
                g.DrawPolygon(PenColor, Painted.Points);
            }
        }
    }
}
