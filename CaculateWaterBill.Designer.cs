namespace ASM_2__off_
{
    partial class CaculateWaterBill
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
            groupBox1 = new GroupBox();
            btnBusiness = new Button();
            btnProductionUnits = new Button();
            btnPublicServices = new Button();
            btnHouseholdCustomer = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 37);
            label1.Name = "label1";
            label1.Size = new Size(498, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Caculate System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 23);
            label2.Name = "label2";
            label2.Size = new Size(661, 41);
            label2.TabIndex = 1;
            label2.Text = "Please Choice Type Of Customer";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkOrchid;
            groupBox1.Controls.Add(btnBusiness);
            groupBox1.Controls.Add(btnProductionUnits);
            groupBox1.Controls.Add(btnPublicServices);
            groupBox1.Controls.Add(btnHouseholdCustomer);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(127, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 503);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnBusiness
            // 
            btnBusiness.BackColor = Color.LightYellow;
            btnBusiness.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBusiness.Location = new Point(591, 173);
            btnBusiness.Name = "btnBusiness";
            btnBusiness.Size = new Size(138, 218);
            btnBusiness.TabIndex = 5;
            btnBusiness.Text = "Business Services ";
            btnBusiness.UseVisualStyleBackColor = false;
            btnBusiness.Click += btnBusiness_Click;
            // 
            // btnProductionUnits
            // 
            btnProductionUnits.BackColor = Color.LightYellow;
            btnProductionUnits.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductionUnits.Location = new Point(409, 173);
            btnProductionUnits.Name = "btnProductionUnits";
            btnProductionUnits.Size = new Size(138, 218);
            btnProductionUnits.TabIndex = 4;
            btnProductionUnits.Text = "Production Units";
            btnProductionUnits.UseVisualStyleBackColor = false;
            btnProductionUnits.Click += btnProductionUnits_Click;
            // 
            // btnPublicServices
            // 
            btnPublicServices.BackColor = Color.LightYellow;
            btnPublicServices.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPublicServices.Location = new Point(232, 173);
            btnPublicServices.Name = "btnPublicServices";
            btnPublicServices.Size = new Size(146, 218);
            btnPublicServices.TabIndex = 3;
            btnPublicServices.Text = "Administrative Agency, Public Services";
            btnPublicServices.UseVisualStyleBackColor = false;
            btnPublicServices.Click += btnPublicServices_Click;
            // 
            // btnHouseholdCustomer
            // 
            btnHouseholdCustomer.BackColor = Color.LightYellow;
            btnHouseholdCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHouseholdCustomer.Location = new Point(46, 173);
            btnHouseholdCustomer.Name = "btnHouseholdCustomer";
            btnHouseholdCustomer.Size = new Size(145, 218);
            btnHouseholdCustomer.TabIndex = 2;
            btnHouseholdCustomer.Text = "Household Customer";
            btnHouseholdCustomer.UseVisualStyleBackColor = false;
            btnHouseholdCustomer.Click += btnHouseholdCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(893, 643);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // CaculateWaterBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(999, 684);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CaculateWaterBill";
            Text = "CaculateWaterBill";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnHouseholdCustomer;
        private Button btnBusiness;
        private Button btnProductionUnits;
        private Button btnPublicServices;
        private Button btnExit;
    }
}