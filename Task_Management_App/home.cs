using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management_App
{
    public partial class home : Form
    {
        private string uname;
        private int uid;

        public home()
        {
            InitializeComponent();
            LoadTasks();
            LoadStatusOptions();
        }

        public home(int userId, string username)
        {
            InitializeComponent();
            uid = userId;
            uname = username;
            LoadTasks();
            LoadStatusOptions();
            userlabel.Text = " Hi " + uname;
        }

        private void LoadStatusOptions()
        {
            using (MySqlConnection con = DatabaseConnector.GetConnection())
            {
                string query = "SELECT * FROM `status`";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable statusTable = new DataTable();
                        statusTable.Load(reader);
                        stateComboBox.DisplayMember = "statusname";
                        stateComboBox.ValueMember = "id";
                        stateComboBox.DataSource = statusTable;
                    }
                }
            }
        }

        private void LoadTasks()
        {
            using (MySqlConnection con = DatabaseConnector.GetConnection())
            {

                DateTime today = DateTime.Today;
                string formattedToday = today.ToString("yyyy-MM-dd");

                string ongoingTasksQuery = "SELECT t.id, t.taskname, t.duedate, t.description, s.statusname as status FROM `task` t JOIN `status` s ON t.status = s.id WHERE s.statusname IN ('Pending', 'In Progress') AND t.user_id = '" + uid + "' ";
                string completedTasksQuery = "SELECT t.id, t.taskname, t.duedate, t.description, s.statusname as status FROM `task` t JOIN `status` s ON t.status = s.id WHERE s.statusname = 'Completed' AND t.user_id = '" + uid + "' ";
                string pastTasksQuery = "SELECT t.id, t.taskname, t.duedate, t.description, s.statusname as status FROM `task` t JOIN `status` s ON t.status = s.id WHERE s.statusname IN ('Pending', 'In Progress') AND t.user_id = '" + uid + "' AND t.duedate < '"+formattedToday+"' ";

                MySqlDataAdapter ongoingAdapter = new MySqlDataAdapter(ongoingTasksQuery, con);
                MySqlDataAdapter completedAdapter = new MySqlDataAdapter(completedTasksQuery, con);
                MySqlDataAdapter pastAdapter = new MySqlDataAdapter(pastTasksQuery, con);

                DataTable ongoingTasksTable = new DataTable();
                DataTable completedTasksTable = new DataTable();
                DataTable pastTasksTable = new DataTable();

                ongoingTasksDataGridView.Columns.Clear();
                completedTasksDataGridView.Columns.Clear();
                pastTasksDataGridView.Columns.Clear();

                ongoingAdapter.Fill(ongoingTasksTable);
                completedAdapter.Fill(completedTasksTable);
                pastAdapter.Fill(pastTasksTable);

                ongoingTasksDataGridView.DataSource = ongoingTasksTable;
                pastTasksDataGridView.DataSource = pastTasksTable;
                completedTasksDataGridView.DataSource = completedTasksTable;
            }
        }

        private void ClearTaskForm()
        {
            taskNameTextBox.Clear();
            dueDateDateTimePicker.Value = DateTime.Now;
            descriptionTextBox.Clear();
            stateComboBox.SelectedIndex = -1;
            updateid.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

            string taskName = taskNameTextBox.Text;
            DateTime rawDueDate = dueDateDateTimePicker.Value;
            string dueDate = rawDueDate.ToString("yyyy-MM-dd");
            string description = descriptionTextBox.Text;
            int stateId = (int)stateComboBox.SelectedValue;
            string editingTaskId = updateid.Text;

            using (MySqlConnection con = DatabaseConnector.GetConnection())
            {
                if (!string.IsNullOrEmpty(editingTaskId))
                {
                    string updateQuery = "UPDATE `task` SET `taskname` = '" + taskName + "', `duedate` = '" + dueDate + "', `description` = '" + description + "', `status` = '" + stateId + "' WHERE `id` = '" + editingTaskId + "'";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string insertQuery = "INSERT INTO `task` (`taskname`, `user_id`, `duedate`, `description`, `status`) VALUES ('" + taskName + "','" + uid + "', '" + dueDate + "', '" + description + "', '" + stateId + "')";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            LoadTasks();
            ClearTaskForm();
        }

        private void ongoingTasksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ongoingTasksDataGridView.Rows[e.RowIndex];
                updateid.Text = row.Cells["id"].Value.ToString();
                taskNameTextBox.Text = row.Cells["taskname"].Value.ToString();
                dueDateDateTimePicker.Value = DateTime.Parse(row.Cells["duedate"].Value.ToString());
                descriptionTextBox.Text = row.Cells["description"].Value.ToString();
            }
        }

        private void pastTasksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = pastTasksDataGridView.Rows[e.RowIndex];
                updateid.Text = row.Cells["id"].Value.ToString();
                taskNameTextBox.Text = row.Cells["taskname"].Value.ToString();
                dueDateDateTimePicker.Value = DateTime.Parse(row.Cells["duedate"].Value.ToString());
                descriptionTextBox.Text = row.Cells["description"].Value.ToString();
            }
        }
    }
}
