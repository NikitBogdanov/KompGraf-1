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
    public partial class Form1 : Form
    {
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pen myPen = new Pen(Color.Blue, 5);
                graphics.DrawRectangle(myPen, 0, 0, pictureBox1.Size.Width - 1, pictureBox1.Size.Height - 1);
                graphics.Dispose();
                Form2 form2 = new Form2();
                form2.Show();
            }
            catch { }
        }
    }
}
