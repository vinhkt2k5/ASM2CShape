namespace ASM_2__off_
{
    partial class Type_1
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnBack = new Button();
            btnCaculate = new Button();
            label6 = new Label();
            txtThisMonth = new TextBox();
            txtLastMonth = new TextBox();
            txtMember = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            lstvResult = new ListView();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnCaculate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtThisMonth);
            groupBox1.Controls.Add(txtLastMonth);
            groupBox1.Controls.Add(txtMember);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Location = new Point(90, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 456);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(387, 361);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(189, 49);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(585, 421);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(71, 361);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(200, 49);
            btnCaculate.TabIndex = 10;
            btnCaculate.Text = "Add";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(183, 32);
            label6.Name = "label6";
            label6.Size = new Size(328, 31);
            label6.TabIndex = 9;
            label6.Text = "Household Customer";
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(248, 286);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(387, 27);
            txtThisMonth.TabIndex = 8;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(248, 229);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(387, 27);
            txtLastMonth.TabIndex = 7;
            // 
            // txtMember
            // 
            txtMember.Location = new Point(248, 174);
            txtMember.Name = "txtMember";
            txtMember.Size = new Size(387, 27);
            txtMember.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 293);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 4;
            label4.Text = "Number Water This Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 236);
            label3.Name = "label3";
            label3.Size = new Size(197, 20);
            label3.TabIndex = 3;
            label3.Text = "Number Water Last Month";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 181);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Number Member";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 127);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(248, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(387, 27);
            txtUsername.TabIndex = 0;
            // 
            // lstvResult
            // 
            lstvResult.Location = new Point(90, 546);
            lstvResult.Name = "lstvResult";
            lstvResult.Size = new Size(683, 227);
            lstvResult.TabIndex = 1;
            lstvResult.UseCompatibleStateImageBehavior = false;
            lstvResult.SelectedIndexChanged += lstvResult_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(90, 523);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 2;
            label5.Text = "Result";
            // 
            // Type_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(864, 805);
            Controls.Add(label5);
            Controls.Add(lstvResult);
            Controls.Add(groupBox1);
            Name = "Type_1";
            Text = "Type_1";
            Load += Type_1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private Label label6;
        private TextBox txtThisMonth;
        private TextBox txtLastMonth;
        private TextBox txtMember;
        private Button btnBack;
        private Button btnCaculate;
        private ListView lstvResult;
        private Label label5;
        private Button btnClear;
    }
}