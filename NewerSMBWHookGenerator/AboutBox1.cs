using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerSMBWHookGenerator
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = "About";
        }


        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.githubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/RedStoneMatt/NewerSMBWHookGenerator");
        }

        private void youtubeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.youtubeLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://youtube.com/RedStoneMatt");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void youtubeIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
