using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(txbOptions.Text);
            switch (choice)
            {
                case 1:
                    grbACO.Visible = false;
                    grbRectangle.Visible = true;
                    break;
                case 2:
                    grbACO.Visible = false;
                    grbCircle.Visible = true;
                    break;
                case 3:
                    grbACO.Visible = false;
                    grbTriangle.Visible = true;
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    MessageBox.Show("Invalid choice. Please choose again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txbLengthRec.Text);
            double width = double.Parse(txbWidthRec.Text);

            double area = length * width;
            MessageBox.Show($"The area of the rectangle is: {Math.Round(area,2)}", "Rectangle Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            grbACO.Visible = true;
            txbOptions.Text = "";
            grbRectangle.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(txbRadius.Text);

            double area = Math.PI * radius * radius;
            MessageBox.Show($"The area of the circle is: {Math.Round(area,2)}", "Circle Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grbACO.Visible = true;
            txbOptions.Text = "";
            grbCircle.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double baseLength = double.Parse(txbBaseLength.Text);
            double height = double.Parse(txbHeight.Text);

            double area = 0.5 * baseLength * height;
            Console.WriteLine($"The area of the triangle is: {Math.Round(area,2)}");
            MessageBox.Show($"The area of the triangle is: {Math.Round(area,2)}", "Triangle Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grbACO.Visible = true;
            txbOptions.Text = "";
            grbTriangle.Visible = false;
        }

        private void grbACO_Enter(object sender, EventArgs e)
        {

        }

        private void grbRectangle_Enter(object sender, EventArgs e)
        {

        }
    }
}