namespace ASM_2__off_
{
    partial class Type_3
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
            txtThisMonth = new TextBox();
            txtLastMonth = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCaculate = new Button();
            label1 = new Label();
            label5 = new Label();
            lstvResult = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(txtThisMonth);
            groupBox1.Controls.Add(txtLastMonth);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCaculate);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(86, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 443);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(375, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 54);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(566, 408);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(265, 250);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(313, 27);
            txtThisMonth.TabIndex = 7;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(265, 168);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(313, 27);
            txtLastMonth.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(265, 98);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(313, 27);
            txtUsername.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 253);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 4;
            label4.Text = "Water Number This Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 175);
            label3.Name = "label3";
            label3.Size = new Size(197, 20);
            label3.TabIndex = 3;
            label3.Text = "Water Number Last Month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 105);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(54, 343);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(205, 54);
            btnCaculate.TabIndex = 1;
            btnCaculate.Text = "Add";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 33);
            label1.Name = "label1";
            label1.Size = new Size(273, 31);
            label1.TabIndex = 0;
            label1.Text = "Production Units";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 514);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 1;
            label5.Text = "Result";
            // 
            // lstvResult
            // 
            lstvResult.Location = new Point(86, 537);
            lstvResult.Name = "lstvResult";
            lstvResult.Size = new Size(666, 153);
            lstvResult.TabIndex = 2;
            lstvResult.UseCompatibleStateImageBehavior = false;
            // 
            // Type_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(818, 717);
            Controls.Add(lstvResult);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Name = "Type_3";
            Text = "Type_3";
            Load += Type_3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtThisMonth;
        private TextBox txtLastMonth;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCaculate;
        private Button btnBack;
        private Label label5;
        private ListView lstvResult;
        private Button btnClear;
    }
}