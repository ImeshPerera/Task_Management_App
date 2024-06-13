using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace Task_Management_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int? AuthenticateUser(string username, string password)
        {
            using (MySqlConnection con = DatabaseConnector.GetConnection())
            {
                string query = "SELECT `id` FROM `user` WHERE `name` = @username AND `password` = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32("id");
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            try
            {
                int? userId = AuthenticateUser(username, password);
                if (userId.HasValue)
                {
                    var homeForm = new home(userId.Value, username); 
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void tosignup_Click(object sender, EventArgs e)
        {
            var registrationForm = new registration();
            registrationForm.Show();
            this.Hide();
        }
    }
}
