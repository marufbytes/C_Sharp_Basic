using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Cafe_Management
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-EDVHTJF\SQLEXPRESS;Initial Catalog=Cafe;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.PasswordChar = registerShowPass.Checked ? '\0' : '*';
            registerConfirmPassword.PasswordChar = registerShowPass.Checked ? '\0' : '*';

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterSignIn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        public bool emptyFields()
        {
            if(registerUsername.Text==""|| registerPassword.Text == "" || registerConfirmPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-EDVHTJF\SQLEXPRESS;Initial Catalog=Cafe;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=True");
            if (emptyFields())
            {
                MessageBox.Show("All fields are require to be filled ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT FROM users WHERE username = @usern"; // already taken?
                        using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", registerUsername.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = registerUsername.Text.Substring(0, 1).ToUpper() + registerUsername.Text.Substring(1);
                                MessageBox.Show("This username is already taken", "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if(registerPassword!=registerConfirmPassword)
                            {
                                MessageBox.Show("Password not matched", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (registerPassword.Text.Length< 8)
                            {
                                MessageBox.Show("Password less than 8 characters!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "Insert into users(username, password, profile_image, role,status,date)" +
                                                        " values(@usern,@pass,@image,@role,@status,@date)";

                                DateTime today = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", registerUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", registerPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", "");
                                    cmd.Parameters.AddWithValue("@role ", "Cashier");
                                    cmd.Parameters.AddWithValue("@status", "Appeorved");
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registration Successful!", "Imformation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: "+ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }             
               
            }
        }
    }
}
