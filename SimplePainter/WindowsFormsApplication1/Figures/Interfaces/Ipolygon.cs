using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Figures
{
    interface Ipolygon : IFigure
    {
        Point[] Points { get; }
    }
}
