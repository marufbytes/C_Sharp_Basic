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

namespace EPL
{
    public partial class ShowAll : Form
    {
        string connectionString = "data source = DESKTOP-EDVHTJF\\SQLEXPRESS; database=Football; integrated security=SSPI";

        public ShowAll()
        {
            InitializeComponent();
            string query = "SELECT * FROM EPL";
            FillDataGridView(query);
        }

        private void FillDataGridView(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        private void ShowAll_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();
            string query = "SELECT ClubName form EPL WHERE ClubName LIKE @SearchTerm";
            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + "searchValue")
;                }
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
