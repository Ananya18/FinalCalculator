using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            double input = double.Parse(btn.Text);

            txtResult.Text = txtResult.Text + input + "";
        }
    }
}
