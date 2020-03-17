using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerSMBWHookGenerator
{
    public partial class Sub2Address : Form
    {
        public Sub2Address()
        {
            InitializeComponent();
        }

        private void Sub2Address_Load(object sender, EventArgs e)
        {
            inputRegister.SelectedIndex = 0;
        }

        long r1 = 0x8043FF20;
        long r2 = 0x80433360;
        long r13 = 0x8042F980;

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = inputHex.Text.Replace("0x", "").Replace("-", "");
            int isNegative = (inputHex.Text.Contains("-")) ? -1 : 1;
            long input = Convert.ToInt64(inputText, 16);
            if (inputRegister.SelectedIndex == 0) //r1
            {
                outputHex.Text = "0x" + Convert.ToString((r1 + (input * isNegative)), 16).ToUpper();
            }
            if (inputRegister.SelectedIndex == 1) //r2
            {
                outputHex.Text = "0x" + Convert.ToString((r2 + (input * isNegative)), 16).ToUpper();
            }
            if (inputRegister.SelectedIndex == 2) //r13
            {
                outputHex.Text = "0x" + Convert.ToString((r13 + (input * isNegative)), 16).ToUpper();
            }
        }
    }
}
