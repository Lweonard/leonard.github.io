using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bungga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Menggambar kelopak bunga
            Brush petalBrush = new SolidBrush(Color.Red);
            for (int i = 0; i < 6; i++)
            {
                g.FillEllipse(petalBrush, 100, 100, 100, 200);
                g.RotateTransform(60); // Memutar untuk kelopak berikutnya
            }

            // Menggambar pusat bunga
            Brush centerBrush = new SolidBrush(Color.Yellow);
            g.FillEllipse(centerBrush, 130, 130, 40, 40);

            // Menggambar batang
            Pen stemPen = new Pen(Color.Green, 10);
            g.DrawLine(stemPen, 150, 230, 150, 400);
        }
    }
}