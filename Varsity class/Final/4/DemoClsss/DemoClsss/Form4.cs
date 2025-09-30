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
    public partial class Form4 : Form
    {
        string connectionString = "data source=DESKTOP-EDVHTJF\\SQLEXPRESS; database=KK; integrated security=SSPI";

        int id;
        public Form4(int i)
        {
            id = i;
            InitializeComponent();
            LoadDetails();
        }

        private void LoadDetails()
        {
            string query = "SELECT Id,Name,Age,Address WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        textBox1.Text = dataReader["Id"].ToString();
                        textBox2.Text = dataReader["Name"].ToString();
                        textBox3.Text = dataReader["Age"].ToString();
                        textBox4.Text = dataReader["Address"].ToString();
                    }

                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close(); // Close the form if no data is found
                    }

                }
            }

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
