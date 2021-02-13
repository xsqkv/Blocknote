using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Блокнот
{
    public partial class О_программе : Form
    {
        public О_программе()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/artemccom");
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DeepSkyBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Fuchsia;
        }
    }
}
