using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Figures
{
    class Polygon : Ipolygon
    {
        public Point[] Points { get; private set; }
        public int Corners { get; }
        public int Xstrt { get; set; }
        public int Ystrt { get; set; }
        public float ConturWidth { get; set; }
        public Color FigureColor { get; set; }
        public int Radius { get; set; }


        public Polygon(int Corners, int Radius, int X, int Y, float ConturWidth, Color FigureColor)
        {
            this.Corners = Corners;
            this.Xstrt = X;
            this.Ystrt = Y;
            this.Radius = Radius;
            this.ConturWidth = ConturWidth;
            this.FigureColor = FigureColor;
            PolygonPoints();
        }

        private void PolygonPoints()
        {
            double angle = -Math.PI * 0.5;
            Points = new Point[Corners];
            for (int i=0; i< Corners; i++)
            {
                Points[i] = new Point 
                ( Xstrt + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * i/ Corners) * Radius),
                  Ystrt + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * i/ Corners) * Radius));
            }
        }
    }
}
