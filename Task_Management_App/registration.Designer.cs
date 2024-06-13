namespace Task_Management_App
{
    partial class registration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rePasswordTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            signupbtn = new Button();
            tosignin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 64);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 158);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Re - Password";
            // 
            // rePasswordTextBox
            // 
            rePasswordTextBox.Location = new Point(194, 155);
            rePasswordTextBox.Name = "rePasswordTextBox";
            rePasswordTextBox.Size = new Size(137, 27);
            rePasswordTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(194, 110);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(137, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(194, 61);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(137, 27);
            usernameTextBox.TabIndex = 5;
            // 
            // signupbtn
            // 
            signupbtn.Location = new Point(150, 236);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(94, 29);
            signupbtn.TabIndex = 6;
            signupbtn.Text = "Sign Up";
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += signupbtn_Click;
            // 
            // tosignin
            // 
            tosignin.Location = new Point(61, 281);
            tosignin.Name = "tosignin";
            tosignin.Size = new Size(280, 29);
            tosignin.TabIndex = 7;
            tosignin.Text = "Already Registered ? Sign In Here";
            tosignin.UseVisualStyleBackColor = true;
            tosignin.Click += tosignin_Click;
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 334);
            Controls.Add(tosignin);
            Controls.Add(signupbtn);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(rePasswordTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registration";
            Text = "registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox rePasswordTextBox;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button signupbtn;
        private Button tosignin;
    }
}