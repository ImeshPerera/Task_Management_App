namespace Task_Management_App
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            userlabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            taskNameTextBox = new TextBox();
            descriptionTextBox = new RichTextBox();
            stateComboBox = new ComboBox();
            submitbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            ongoingTasksDataGridView = new DataGridView();
            taskname = new DataGridViewTextBoxColumn();
            duedate = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            pastTasksDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            updateid = new Label();
            titlelabel = new Label();
            dueDateDateTimePicker = new DateTimePicker();
            completedTasksDataGridView = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ongoingTasksDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pastTasksDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)completedTasksDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(784, 3);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 0;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // userlabel
            // 
            userlabel.AutoSize = true;
            userlabel.Dock = DockStyle.Left;
            userlabel.Location = new Point(43, 0);
            userlabel.Name = "userlabel";
            userlabel.Padding = new Padding(20, 10, 20, 5);
            userlabel.Size = new Size(105, 40);
            userlabel.TabIndex = 1;
            userlabel.Text = "Hi User1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(taskNameTextBox, 3, 2);
            tableLayoutPanel1.Controls.Add(descriptionTextBox, 3, 4);
            tableLayoutPanel1.Controls.Add(stateComboBox, 3, 6);
            tableLayoutPanel1.Controls.Add(submitbtn, 3, 7);
            tableLayoutPanel1.Controls.Add(label3, 2, 4);
            tableLayoutPanel1.Controls.Add(label2, 2, 3);
            tableLayoutPanel1.Controls.Add(label1, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 6);
            tableLayoutPanel1.Controls.Add(ongoingTasksDataGridView, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 3, 0);
            tableLayoutPanel1.Controls.Add(userlabel, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 8);
            tableLayoutPanel1.Controls.Add(pastTasksDataGridView, 1, 9);
            tableLayoutPanel1.Controls.Add(updateid, 2, 7);
            tableLayoutPanel1.Controls.Add(titlelabel, 2, 1);
            tableLayoutPanel1.Controls.Add(dueDateDateTimePicker, 3, 3);
            tableLayoutPanel1.Controls.Add(completedTasksDataGridView, 1, 16);
            tableLayoutPanel1.Controls.Add(label8, 1, 15);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 22;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(970, 812);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Dock = DockStyle.Fill;
            taskNameTextBox.Location = new Point(755, 73);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(172, 27);
            taskNameTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Location = new Point(755, 153);
            descriptionTextBox.Name = "descriptionTextBox";
            tableLayoutPanel1.SetRowSpan(descriptionTextBox, 2);
            descriptionTextBox.Size = new Size(172, 74);
            descriptionTextBox.TabIndex = 9;
            descriptionTextBox.Text = "";
            // 
            // stateComboBox
            // 
            stateComboBox.Dock = DockStyle.Fill;
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(755, 233);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(172, 28);
            stateComboBox.TabIndex = 11;
            // 
            // submitbtn
            // 
            submitbtn.Dock = DockStyle.Fill;
            submitbtn.Location = new Point(755, 273);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(172, 34);
            submitbtn.TabIndex = 4;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(577, 150);
            label3.Name = "label3";
            tableLayoutPanel1.SetRowSpan(label3, 2);
            label3.Size = new Size(172, 80);
            label3.TabIndex = 6;
            label3.Text = "Description";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(577, 110);
            label2.Name = "label2";
            label2.Size = new Size(172, 40);
            label2.TabIndex = 5;
            label2.Text = "Due Date";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(577, 70);
            label1.Name = "label1";
            label1.Size = new Size(172, 40);
            label1.TabIndex = 3;
            label1.Text = "Task Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(577, 230);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 10, 20, 5);
            label4.Size = new Size(172, 40);
            label4.TabIndex = 10;
            label4.Text = "State";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ongoingTasksDataGridView
            // 
            ongoingTasksDataGridView.AllowUserToAddRows = false;
            ongoingTasksDataGridView.AllowUserToDeleteRows = false;
            ongoingTasksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ongoingTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ongoingTasksDataGridView.Columns.AddRange(new DataGridViewColumn[] { taskname, duedate, description, state });
            ongoingTasksDataGridView.Dock = DockStyle.Fill;
            ongoingTasksDataGridView.Location = new Point(43, 73);
            ongoingTasksDataGridView.Name = "ongoingTasksDataGridView";
            ongoingTasksDataGridView.ReadOnly = true;
            ongoingTasksDataGridView.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(ongoingTasksDataGridView, 5);
            ongoingTasksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ongoingTasksDataGridView.Size = new Size(528, 194);
            ongoingTasksDataGridView.TabIndex = 2;
            ongoingTasksDataGridView.CellDoubleClick += ongoingTasksDataGridView_CellDoubleClick;
            // 
            // taskname
            // 
            taskname.HeaderText = "Task Name";
            taskname.MinimumWidth = 6;
            taskname.Name = "taskname";
            taskname.ReadOnly = true;
            taskname.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // duedate
            // 
            duedate.HeaderText = "Due Date";
            duedate.MinimumWidth = 6;
            duedate.Name = "duedate";
            duedate.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // state
            // 
            state.HeaderText = "State";
            state.MinimumWidth = 6;
            state.Name = "state";
            state.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(43, 40);
            label5.Name = "label5";
            label5.Size = new Size(528, 30);
            label5.TabIndex = 12;
            label5.Text = "Ongoing Tasks";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(43, 310);
            label6.Name = "label6";
            label6.Size = new Size(528, 30);
            label6.TabIndex = 13;
            label6.Text = "Over Due Tasks";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pastTasksDataGridView
            // 
            pastTasksDataGridView.AllowUserToAddRows = false;
            pastTasksDataGridView.AllowUserToDeleteRows = false;
            pastTasksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pastTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pastTasksDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            pastTasksDataGridView.Dock = DockStyle.Fill;
            pastTasksDataGridView.Location = new Point(43, 343);
            pastTasksDataGridView.Name = "pastTasksDataGridView";
            pastTasksDataGridView.ReadOnly = true;
            pastTasksDataGridView.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(pastTasksDataGridView, 5);
            pastTasksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pastTasksDataGridView.Size = new Size(528, 194);
            pastTasksDataGridView.TabIndex = 14;
            pastTasksDataGridView.CellDoubleClick += pastTasksDataGridView_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Task Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Due Date";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "State";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // updateid
            // 
            updateid.AutoSize = true;
            updateid.Location = new Point(577, 270);
            updateid.Name = "updateid";
            updateid.Size = new Size(0, 20);
            updateid.TabIndex = 16;
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(titlelabel, 2);
            titlelabel.Dock = DockStyle.Fill;
            titlelabel.Location = new Point(577, 40);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(350, 30);
            titlelabel.TabIndex = 17;
            titlelabel.Text = "Add New Task";
            titlelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dueDateDateTimePicker
            // 
            dueDateDateTimePicker.Dock = DockStyle.Fill;
            dueDateDateTimePicker.Location = new Point(755, 113);
            dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            dueDateDateTimePicker.Size = new Size(172, 27);
            dueDateDateTimePicker.TabIndex = 18;
            // 
            // completedTasksDataGridView
            // 
            completedTasksDataGridView.AllowUserToAddRows = false;
            completedTasksDataGridView.AllowUserToDeleteRows = false;
            completedTasksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            completedTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            completedTasksDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            completedTasksDataGridView.Dock = DockStyle.Fill;
            completedTasksDataGridView.Location = new Point(43, 593);
            completedTasksDataGridView.Name = "completedTasksDataGridView";
            completedTasksDataGridView.ReadOnly = true;
            completedTasksDataGridView.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(completedTasksDataGridView, 5);
            completedTasksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            completedTasksDataGridView.Size = new Size(528, 194);
            completedTasksDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Task Name";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Due Date";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Description";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "State";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(43, 560);
            label8.Name = "label8";
            label8.Size = new Size(528, 30);
            label8.TabIndex = 20;
            label8.Text = "Completed Tasks";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 812);
            Controls.Add(tableLayoutPanel1);
            Name = "home";
            Text = "home";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ongoingTasksDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pastTasksDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)completedTasksDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label userlabel;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView ongoingTasksDataGridView;
        private Button submitbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox taskNameTextBox;
        private RichTextBox descriptionTextBox;
        private Label label4;
        private ComboBox stateComboBox;
        private Label label5;
        private Label label6;
        private DataGridView pastTasksDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label updateid;
        private Label titlelabel;
        private DateTimePicker dueDateDateTimePicker;
        private DataGridViewTextBoxColumn taskname;
        private DataGridViewTextBoxColumn duedate;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn state;
        private DataGridView completedTasksDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label8;
    }
}