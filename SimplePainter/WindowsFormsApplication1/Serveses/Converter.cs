using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Serveses
{
    class Converter
    {
        public float Tofloat(object obj)
        {
            float result = new float();
            try
            {
                result = Convert.ToSingle(obj);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ширины фигуры", "Неверный формат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            return result;
        }
    }
}
