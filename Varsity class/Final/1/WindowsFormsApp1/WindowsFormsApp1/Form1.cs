using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] nation = new string[3];
            nation[0] = "Bangladesh";
            nation[1] = "India";
            nation[2] = "Pakistan";

            nationalityComboBox1.DataSource = nation;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox1.Text;
            string id = idTextBox2.Text;
            string dob = dateTimePicker1.Text;
            string nationality = nationalityComboBox1.SelectedItem.ToString();
            string add = richTextBox1.Text;
            string gender;

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }

            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }

            else
            {
                gender = radioButton3.Text;
            }


             string details = name + "\n" + id + "\n" + dob + "\n" + nationality+"\n"+gender+"\n"+add;

            //MessageBox.Show("Given : " + details);

            Form2 form2 = new Form2(details);
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to execute when the form loads
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
