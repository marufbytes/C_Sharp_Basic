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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        string connectionString = "data source=DESKTOP-EDVHTJF\\SQLEXPRESS; database=KK; integrated security=SSPI";
        int id;
        public Form3(int i)
        {
            id = i;
            InitializeComponent();
            string query = "SELECT * FROM section";
            FillDataGridView(query);
        }


        private void FillDataGridView(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
