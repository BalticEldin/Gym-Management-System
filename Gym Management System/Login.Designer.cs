namespace Gym_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label3 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUserName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(txtBoxUserName);
            panel1.Location = new Point(188, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 246);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Engravers MT", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 28);
            label3.Name = "label3";
            label3.Size = new Size(225, 24);
            label3.TabIndex = 5;
            label3.Text = "ENTER SPARTA";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Brown;
            btnLogin.Font = new Font("Engravers MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(74, 189);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 134);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 73);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(93, 154);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(100, 23);
            txtBoxPassword.TabIndex = 1;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUserName.Location = new Point(93, 100);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(100, 23);
            txtBoxUserName.TabIndex = 0;
            txtBoxUserName.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 492);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUserName;
    }
}