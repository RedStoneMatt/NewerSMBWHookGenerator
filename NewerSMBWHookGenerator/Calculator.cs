using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace NewerSMBWHookGenerator
{
    partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void decInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(decInput.Text);
                string Base = Convert.ToString(number, 16).ToUpper();
                if (prefixCheck.Checked) {
                    hexOutput.Text = "0x" + Base;
                }
                else
                {
                    hexOutput.Text = Base;
                }
               
            }
            catch
            {

            }
        }

        private void hexOutput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string number = Convert.ToInt32(hexOutput.Text, 16).ToString();
                if (prefixCheck.Checked)
                {
                    decInput.Text = number.Replace("0x", "");
                }
                else
                {
                    decInput.Text = number;
                }

            }
            catch
            {

            }
        }
    }
}
