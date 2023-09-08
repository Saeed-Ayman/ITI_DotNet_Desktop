namespace CSharpAdvancedDay3
{
    partial class LoginForm
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
            username_label = new Label();
            username_txt = new TextBox();
            password_txt = new TextBox();
            password_label = new Label();
            login_btn = new Button();
            remember_cb = new CheckBox();
            SuspendLayout();
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(46, 34);
            username_label.Margin = new Padding(5, 0, 5, 0);
            username_label.Name = "username_label";
            username_label.Size = new Size(101, 26);
            username_label.TabIndex = 0;
            username_label.Text = "Username";
            // 
            // username_txt
            // 
            username_txt.BorderStyle = BorderStyle.FixedSingle;
            username_txt.Location = new Point(46, 74);
            username_txt.Margin = new Padding(5);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(444, 33);
            username_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            password_txt.BorderStyle = BorderStyle.FixedSingle;
            password_txt.Location = new Point(46, 185);
            password_txt.Margin = new Padding(5);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(444, 33);
            password_txt.TabIndex = 3;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            password_label.ForeColor = Color.White;
            password_label.Location = new Point(46, 145);
            password_label.Margin = new Padding(5, 0, 5, 0);
            password_label.Name = "password_label";
            password_label.Size = new Size(94, 26);
            password_label.TabIndex = 2;
            password_label.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.Location = new Point(46, 321);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(444, 45);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += Login_btn_Click;
            // 
            // remember_cb
            // 
            remember_cb.AutoSize = true;
            remember_cb.ForeColor = Color.White;
            remember_cb.Location = new Point(46, 258);
            remember_cb.Name = "remember_cb";
            remember_cb.Size = new Size(162, 30);
            remember_cb.TabIndex = 5;
            remember_cb.Text = "Remember Me";
            remember_cb.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(530, 407);
            Controls.Add(remember_cb);
            Controls.Add(login_btn);
            Controls.Add(password_txt);
            Controls.Add(password_label);
            Controls.Add(username_txt);
            Controls.Add(username_label);
            Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username_label;
        private TextBox username_txt;
        private TextBox password_txt;
        private Label password_label;
        private Button login_btn;
        private CheckBox remember_cb;
    }
}