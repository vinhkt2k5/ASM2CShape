﻿namespace ASM_2__off_
{
    partial class Type_2
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
            label1 = new Label();
            txtThisMonth = new TextBox();
            txtLastMonth = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtThisMonth);
            groupBox1.Controls.Add(txtLastMonth);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(95, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 425);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(384, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(204, 47);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(596, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(66, 318);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(201, 47);
            btnCaculate.TabIndex = 8;
            btnCaculate.Text = "Add";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 23);
            label1.Name = "label1";
            label1.Size = new Size(254, 31);
            label1.TabIndex = 7;
            label1.Text = "Public Services";
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(261, 230);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(378, 27);
            txtThisMonth.TabIndex = 6;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(261, 161);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(378, 27);
            txtLastMonth.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(261, 95);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(378, 27);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 237);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 3;
            label4.Text = "Water Number This Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 161);
            label3.Name = "label3";
            label3.Size = new Size(197, 20);
            label3.TabIndex = 2;
            label3.Text = "Number Water Last Month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 95);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // lstvResult
            // 
            lstvResult.Location = new Point(95, 542);
            lstvResult.Name = "lstvResult";
            lstvResult.Size = new Size(696, 189);
            lstvResult.TabIndex = 1;
            lstvResult.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(95, 519);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 2;
            label5.Text = "Result";
            // 
            // Type_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(897, 787);
            Controls.Add(label5);
            Controls.Add(lstvResult);
            Controls.Add(groupBox1);
            Name = "Type_2";
            Text = "Type_2";
            Load += Type_2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtThisMonth;
        private TextBox txtLastMonth;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBack;
        private Button btnCaculate;
        private ListView lstvResult;
        private Label label5;
        private Button btnClear;
    }
}