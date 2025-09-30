using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_task_4
{
    public partial class Form2 : Form
    {
        public Form2(string s)
        {
            InitializeComponent();
            richTextBox1.Text = s;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
