using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Text = "0";
            txtResults1.Text = "0";

        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            float num1, results1;
            num1 = float.Parse(txtNum1.Text);
            results1 = num1 * num1;
            txtResults1.Text = results1.ToString();

            double num2, results2;
            num2 = double.Parse(txtNum2.Text);
            results2 = Math.Sqrt(num2);
            txtResults2.Text = results2.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
