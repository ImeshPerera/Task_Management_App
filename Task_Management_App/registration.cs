using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management_App
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string rePassword = rePasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rePassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (password != rePassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            else
            {
                try
                {
                    using (MySqlConnection con = DatabaseConnector.GetConnection())
                    {
                        string query = "INSERT INTO `user` (`name`, `password`) VALUES ('" + username + "','" + password + "')";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration successful.");
                            var loginForm = new Form1();
                            loginForm.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void tosignin_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
