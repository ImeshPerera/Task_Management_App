namespace Task_Management_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            signinbtn = new Button();
            tosignup = new Button();
            SuspendLayout();
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(189, 65);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(125, 27);
            usernametxt.TabIndex = 0;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(189, 117);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(125, 27);
            passwordtxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 68);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 120);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // signinbtn
            // 
            signinbtn.Location = new Point(136, 194);
            signinbtn.Name = "signinbtn";
            signinbtn.Size = new Size(94, 29);
            signinbtn.TabIndex = 4;
            signinbtn.Text = "Sign In";
            signinbtn.UseVisualStyleBackColor = true;
            signinbtn.Click += signinbtn_Click;
            // 
            // tosignup
            // 
            tosignup.Location = new Point(76, 243);
            tosignup.Name = "tosignup";
            tosignup.Size = new Size(216, 29);
            tosignup.TabIndex = 5;
            tosignup.Text = "New user ? Sign Up here";
            tosignup.UseVisualStyleBackColor = true;
            tosignup.Click += tosignup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 312);
            Controls.Add(tosignup);
            Controls.Add(signinbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Label label1;
        private Label label2;
        private Button signinbtn;
        private Button tosignup;
    }
}
