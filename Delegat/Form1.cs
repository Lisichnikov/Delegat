using System;
using System.Drawing;
using System.Windows.Forms;

namespace Delegat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(this.button1_Click);
            radioButton2.CheckedChanged += new EventHandler(this.button2_Click);
            radioButton3.CheckedChanged += new EventHandler(this.button3_Click);
            radioButton4.CheckedChanged += new EventHandler(this.button4_Click);
            radioButton5.CheckedChanged += new EventHandler(this.button5_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];
            for (int x = -200, y, i = 0; x < 600; x++, i++)
            {
                y = -(x * x * x / 500) + 250;
                point[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];
            for (int x = -200, y, i = 0; x < 200; x++, i++)
            {
                y = -(x * x / 100) + 250;
                point[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];

            for (int x, y, i = 0; i < 800; i++)
            {
                float PI = (float)(Math.PI / (800 - 1));
                x = i - 400;
                y = (int)(float)(125 * Math.Sin(i * 10 * PI) + 250);
                point[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];
            for (int x = -400, y, i = 0; x < 401; x++, i++)
            {
                if (x != 0)
                {
                    y = (int)(-(1 / ((double)x / 1000)) + 250);
                    point[i] = new Point(i, y);
                }
                else
                    i--;
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
 * using System;
using System.Drawing;
using System.Windows.Forms;

namespace Funkcii
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
radioButton1.CheckedChanged += new EventHandler(this.AxisBtn);
radioButton2.CheckedChanged += new EventHandler(this.ParBtn);
radioButton3.CheckedChanged += new EventHandler(this.CubParBtn);
radioButton4.CheckedChanged += new EventHandler(this.SineBtn);
radioButton5.CheckedChanged += new EventHandler(this.HyperbolaBtn);
}
private void CubParBtn(object sender, EventArgs e)
{
Graphics graphics = pictureBox1.CreateGraphics();
graphics.Clear(Color.White);
Pen pen = new Pen(Color.Black, 1f);
Point[] point = new Point[800];
for (int x = -200, y, i = 0; x < 600; x++, i++)
{
y = -(x * x * x / 500) + 250;
point[i] = new Point(x + 400, y);
}
graphics.DrawLines(pen, point);
Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
graphics.DrawLines(pen, pointy);
graphics.DrawLines(pen, pointx);
}

private void ParBtn(object sender, EventArgs e)
{
Graphics graphics = pictureBox1.CreateGraphics();
graphics.Clear(Color.White);
Pen pen = new Pen(Color.Black, 1f);
Point[] point = new Point[800];
for (int x = -200, y, i = 0; x < 200; x++, i++)
{
y = -(x * x / 100) + 250;
point[i] = new Point(x + 400, y);
}
graphics.DrawLines(pen, point);
Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
graphics.DrawLines(pen, pointy);
graphics.DrawLines(pen, pointx);
}
private void AxisBtn(object sender, EventArgs e)
{
Graphics graphics = pictureBox1.CreateGraphics();
graphics.Clear(Color.White);
Pen pen = new Pen(Color.Black, 1f);
Point[] point = new Point[800];
graphics.DrawLines(pen, point);
Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
graphics.DrawLines(pen, pointy);
graphics.DrawLines(pen, pointx);
}

private void SineBtn(object sender, EventArgs e)
{
Graphics graphics = pictureBox1.CreateGraphics();
graphics.Clear(Color.White);
Pen pen = new Pen(Color.Black, 1f);
Point[] point = new Point[800];

for (int x, y, i = 0; i < 800; i++)
{
float PI = (float)(Math.PI / (800 - 1));
x = i - 400;
y = (int)(float)(125 * Math.Sin(i * 10 * PI) + 250);
point[i] = new Point(x + 400, y);
}
graphics.DrawLines(pen, point);
Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
graphics.DrawLines(pen, pointy);
graphics.DrawLines(pen, pointx);
}

private void HyperbolaBtn(object sender, EventArgs e)
{
Graphics graphics = pictureBox1.CreateGraphics();
graphics.Clear(Color.White);
Pen pen = new Pen(Color.Black, 1f);
Point[] point = new Point[800];
for (int x = -400, y, i = 0; x < 401; x++, i++)
{
if (x != 0)
{
y = (int)(-(1 / ((double)x/1000)) + 250);
point[i] = new Point(i, y);
}
else
i--;
}
graphics.DrawLines(pen, point);
Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
graphics.DrawLines(pen, pointy);
graphics.DrawLines(pen, pointx);
}
}
}
*/