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
    public partial class Form2 : Form
    {
        string connectionString = "data source = DESKTOP-EDVHTJF\\SQLEXPRESS; database = DemoClass; integrated security= SSPI";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Id = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string age = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(Id) || string.IsNullOrWhiteSpace(name) ||
                            string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!int.TryParse(age, out int parsedAge))
            {
                MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO DemoClass (Id,Name,Age,Address) VALUES (@Id,@Name,@Age,@Address) ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Address", address);

                    connection.Open();

                    int rowAffected = cmd.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
