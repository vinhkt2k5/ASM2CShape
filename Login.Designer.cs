namespace ASM_2__off_
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            txtPass = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 23);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 0;
            label1.Text = "Login ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(380, 25);
            label2.TabIndex = 1;
            label2.Text = "Caculate Water Bill System";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Sienna;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(195, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 393);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 158);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 90);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(181, 154);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(347, 27);
            txtPass.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(181, 86);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(347, 27);
            txtUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(88, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(440, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(884, 607);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(981, 639);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnLogin;
        private Label label4;
        private Label label3;
        private TextBox txtPass;
        private TextBox txtUsername;
        private Button btnExit;
    }
}
