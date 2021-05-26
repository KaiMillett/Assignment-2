using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Reads the length, width and height from the textboxes.
                double Length = double.Parse(textBox1.Text);
                double Width = double.Parse(textBox2.Text);
                double Height = double.Parse(textBox3.Text);
                // Works out what the answers are
                double SurfaceArea = 2 * (Length * Height + Length * Width + Width * Height);
                double Volume = Length * Height * Width;
                // Puts the calculated numbers in the labels
                label1.Text = "SurfaceArea = " + SurfaceArea;
                label2.Text = "Volume = " + Volume;
            }
            catch
            {
                // Shows an error message on the screen if it fails.
                MessageBox.Show("You need to type numbers into all text boxes.");
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Reads the radius from the textbox.
                double Radius = double.Parse(textBox4.Text);
                // Works out what the answers are
                double SurfaceArea = 4 * Math.PI * (Radius * Radius);
                double Volume = 4/3 * Math.PI * (Radius * Radius * Radius);
                // Puts the calculated numbers in the labels
                label3.Text = "SurfaceArea = " + SurfaceArea;
                label4.Text = "Volume = " + Volume;
            }
            catch
            {
                // Shows an error message on the screen if it fails.
                MessageBox.Show("You need to type numbers into all text boxes.");
            }
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Reads the radius and height from the textboxes.
                double Radius = double.Parse(textBox7.Text);
                double Height = double.Parse(textBox9.Text);
                // Works out what the answers are
                double SurfaceArea = Math.PI * Radius*(Radius + (Math.Sqrt(Height * Height) + (Radius * Radius)));
                double Volume = 1/3 * Math.PI * (Radius * Radius) * Height;
                // Puts the calculated numbers in the labels
                label5.Text = "SurfaceArea = " + SurfaceArea;
                label6.Text = "Volume = " + Volume;
            }
            catch
            {
                // Shows an error message on the screen if it fails.
                MessageBox.Show("You need to type numbers into all text boxes.");
            }
        }
    }
}
