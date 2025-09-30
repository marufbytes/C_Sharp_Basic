using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPL
{
    public partial class Form1 : Form
    {
        string connectionString = "data source = DESKTOP-EDVHTJF\\SQLEXPRESS; database=Football; integrated security=SSPI";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rank = textBox1.Text.Trim();
            string clubName = textBox2.Text.Trim();
            string mp = textBox3.Text.Trim();
            string pts = textBox4.Text.Trim();

            string query = "INSERT INTO EPL (Rank,ClubName,MP,Pts) VALUES(@Rank,@ClubName,@MP,@Pts)";

            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Rank", rank);
                    cmd.Parameters.AddWithValue("ClubName", clubName);
                    cmd.Parameters.AddWithValue("MP", mp);
                    cmd.Parameters.AddWithValue("Pts", pts);

                    connection.Open();

                    int rowCount = cmd.ExecuteNonQuery();

                    if (rowCount > 0)
                    {
                        MessageBox.Show("Successfully added values","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        ShowAll showAll = new ShowAll();
                        showAll.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
