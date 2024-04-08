using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2__off_
{
    public partial class CaculateWaterBill : Form
    {
        public CaculateWaterBill()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHouseholdCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Type_1 type_1 = new Type_1();
            type_1.Show();
        }

        private void btnPublicServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Type_2 type_2 = new Type_2();
            type_2.Show();
        }

        private void btnProductionUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Type_3 type_3 = new Type_3();
            type_3.Show();
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            this.Hide();
            Type_4 type_4 = new Type_4();
            type_4.Show();
        }
    }
}
