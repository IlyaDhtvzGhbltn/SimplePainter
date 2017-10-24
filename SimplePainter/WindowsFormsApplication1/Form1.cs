using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Figures;
using WindowsFormsApplication1.Figures.FigurePainterStatemets;
using WindowsFormsApplication1.Figures.Interfaces;
using WindowsFormsApplication1.Serveses;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Holst.MouseMove += new MouseEventHandler(GetCoordinates);
            SelectedColor = Color.Black;
            Corners = System.Convert.ToInt32(textBox2.Text);
            State = new CircleStatement();
        }
        Converter Convert = new Converter();
        ColorDialog Colordialog = new ColorDialog();

        Painter Printer { get; set; }
        IFigureStatement State { get; set; }
        public static Color SelectedColor { get; set; }
        public static float FigureWidth { get; set; }
        public static int CircleRadius { get; set; }
        public static int X { get; set; }
        public static int Y { get; set; }
        public static int Corners { get; set; }

       private void GetCoordinates(object sender, MouseEventArgs e)
        {
            label6.Text = e.X.ToString();
            label7.Text = e.Y.ToString();
            X = e.X;
            Y = e.Y;
        }
        private void Select_Color_Click(object sender, EventArgs e)
        {
            Colordialog.ShowDialog();
            SelectedColor = Colordialog.Color;
            Color_Indicator.BackColor = SelectedColor;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CircleRadiusT.Text = trackBar1.Value.ToString();
        }

        private void Holst_Click(object sender, EventArgs e)
        {
            FigureWidth = Convert.Tofloat(WidthSetter.Text);
            CircleRadius = System.Convert.ToInt32(CircleRadiusT.Text);
            Painter PrintFigure = new Painter(State);
            PrintFigure.Paint(Holst);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            WidthSetter.Text = trackBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Holst.CreateGraphics().Clear(Color.Coral);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar3.Value.ToString();
            Corners = trackBar3.Value;
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            State = new CircleStatement();
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            State = new PolygonStatement();
        }
    }
}
