using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2_prep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void width_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double width, height, area;
                width = Convert.ToDouble(textBox1.Text);
                height = Convert.ToDouble(textBox2.Text);
                area = width * height;
                Label1.Text = "Area = " + area;
            }
            catch
            {
                MessageBox.Show("Try again you dafty");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Base, height, area;
                Base = Convert.ToDouble(textBox3.Text);
                height = Convert.ToDouble(textBox4.Text);
                area = Base * height / 2;
                label6.Text = "Area = " + area;
            }
            catch
            {
                MessageBox.Show("Try again you dafty");
            }
        }
    }
}
