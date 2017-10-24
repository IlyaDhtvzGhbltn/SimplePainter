using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Figures.Interfaces;

namespace WindowsFormsApplication1.Figures
{
    class Circle : Icircle
    {
        public float ConturWidth { get; private set; }
        public Color FigureColor { get; private set; }

        public int Xstrt { get; set; }
        public int Ystrt { get; set; }
        public int Radius { get; set; }

        /// <summary>
        /// Конструктор по умолчанию для фигуры - Окружность
        /// </summary>
        /// <param name="ConturWidth">Ширина контура</param>
        /// <param name="Radius">Радиус</param>
        /// <param name="FigureColor">Цвет фигуры</param>
        /// <param name="X">Кординаты окружности по Х</param>
        /// <param name="Y">Кординаты окружности по Х</param>
        public Circle(float ConturWidth, int Radius, Color FigureColor, int X, int Y)
        {
            this.ConturWidth = ConturWidth;
            this.Radius = Radius;
            this.FigureColor = FigureColor;
            this.Xstrt = X - (Radius/2);
            this.Ystrt = Y - (Radius/2);
        }

    }
}
