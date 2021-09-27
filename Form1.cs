using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIsystem
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        

        private void txtWeight_TextChanged(object sender, EventArgs e)
            {

            }

        private void btnExit_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnReset_Click(object sender, EventArgs e)
            {
            txtWeight.Text = "";
            txtHeight.Text = "";
            txtResult.Text = "";

            radBtnKg.Checked = false;
            radBtnPound.Checked = false;
            }

        private void btnCal_Click(object sender, EventArgs e)
            {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double result = 0.0;
            string result2 = "";

            if (radBtnKg.Checked)
                {
                weight = weight / (height * height);
                result = weight;
                }
            else
            if (radBtnPound.Checked)
                {
                weight = weight / 2.205;
                result = weight / (height * height);
                }

            if (result < 18.5)
                {
                result2 = "Your'e in the underweight range";
                }
            else
             if (result > 18.5)
                {
                result2 = "Your'e in the healthy weight range";
                }
            else
             if (result > 29.9)
                {
                result2 = "Your'e in the overweight range";
                }
            else
             if (result > 39.9)
                {
                result2 = "Your'e in the obese range";
                }
                
                
            txtResult.Text = "Your BMI is " + Math.Round(result, 5) +"\r\n"+ result2;
             }
        }
    }
