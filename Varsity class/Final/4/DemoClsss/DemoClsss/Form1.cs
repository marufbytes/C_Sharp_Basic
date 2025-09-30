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

namespace DemoClsss
{
    public partial class Form1 : Form
    {
        string connectionString = "data source = DESKTOP-EDVHTJF\\SQLEXPRESS; database = DemoClass; integrated security= SSPI";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("Please enter both Id and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM DemoClass WHERE @Id=Id AND @Name = Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.Parameters.AddWithValue("@Name", name);

                    connection.Open();

                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        Form3 form3 = new Form3(int.Parse(userId));
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Name.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
    }
}
