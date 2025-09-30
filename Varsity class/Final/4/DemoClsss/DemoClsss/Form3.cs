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
    public partial class Form3 : Form
    {
        string connectionString = "data source=DESKTOP-EDVHTJF\\SQLEXPRESS; database=DemoClass; integrated security=SSPI";
        int id;


        public Form3(int id)
        {
            InitializeComponent();
            string query = "SELECT * FROM DemoClass";
            DataGridView( query);
        }

        private void DataGridView(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT * FROM DemoClass
                            WHERE Id LIKE @SearchTerm
                            OR Name LIKE @SearchTerm
                            OR Age LIKE @SearchTerm 
                            OR Address LIKE @SearchTerm";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm","%" + searchValue + "%");
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching rows found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4(id);
            form4.Show();
        }
    }
}
