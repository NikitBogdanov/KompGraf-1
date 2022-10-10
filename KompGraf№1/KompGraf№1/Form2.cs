using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompGraf_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Получаем объект Graphics
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Red, 100, 105, 180, 220);
            g.DrawEllipse(Pens.Blue, 10, 20, 110, 45);
            g.DrawRectangle(Pens.Green, 10, 70, 110, 45);
            g.FillEllipse(Brushes.Blue, 130, 20, 110, 45);
            g.FillRectangle(Brushes.Green, 130, 70, 110, 45);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
