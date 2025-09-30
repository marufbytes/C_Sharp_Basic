using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DemoClasss1
{
    public partial class Form1 : Form
    {
        string connectionString = "data source=DESKTOP-EDVHTJF\\SQLEXPRESS; database=KK; integrated security=SSPI";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId=textBox1.Text.Trim();
            string name = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Please enter both Id and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT COUNT(*) FROM DemoClass WHERE @Id=Id AND @Name = Name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.Parameters.AddWithValue("@Name", name);

                    connection.Open();

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Successful ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        Form3 form3 = new Form3(int.Parse(userId));
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
