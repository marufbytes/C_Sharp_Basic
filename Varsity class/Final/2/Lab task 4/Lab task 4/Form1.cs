using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] gender = new string[2];
            gender[0] = "Male";
            gender[1] = "Female";

            comboBox1.DataSource = gender;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string joining = dateTimePicker1.Text;
            string email = textBox3.Text;
            string dept;

            if (radioButton1.Checked)
            {
                dept = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                dept = radioButton2.Text;
            }
            else
            {
                dept = radioButton3.Text;
            }

            string gender = comboBox1.SelectedItem.ToString();
            string address = richTextBox1.Text;

            string details = id + "\n" + name + "\n" + joining + "\n" + email + "\n" + dept + "\n" + gender + "\n" + address;

            //MessageBox.Show("Detqails : " + details);

            Form2 form2 = new Form2(details);
            form2.Show();

        }
    }
}
