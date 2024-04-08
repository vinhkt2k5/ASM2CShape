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
    public partial class Type_3 : Form
    {
        public Type_3()
        {
            InitializeComponent();
        }

        private void Type_3_Load(object sender, EventArgs e)
        {
            lstvResult.View = View.Details;
            lstvResult.GridLines = true;
            lstvResult.FullRowSelect = true;
            // creat column
            lstvResult.Columns.Add("Full name", 150);
            lstvResult.Columns.Add("Last Water Number", 120);
            lstvResult.Columns.Add("This Water Number", 120);
            lstvResult.Columns.Add("Water number", 120);
            lstvResult.Columns.Add("Money", 150);
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lastMonth = txtLastMonth.Text.Trim();
            if (string.IsNullOrEmpty(lastMonth))
            {
                MessageBox.Show("Please enter Number Water Last Month", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string thisMonth = txtThisMonth.Text.Trim();
            if (string.IsNullOrEmpty(thisMonth))
            {
                MessageBox.Show("Please enter Number Water This Month", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(thisMonth, out _) && double.TryParse(lastMonth, out _))
            {
                MessageBox.Show("Water Number do not available", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int lastmonth = int.Parse(lastMonth);
            int thismonth = int.Parse(thisMonth);

            if (thismonth >= lastmonth)
            {
                int waterNumber = thismonth - lastmonth;
                double money = waterNumber * 11615 * 1.1;

                string waterNum = Convert.ToString(waterNumber);
                string result = Convert.ToString(money);

                ListViewItem item = new ListViewItem();
                item.Text = userName;
                item.SubItems.Add(lastMonth);
                item.SubItems.Add(thisMonth);
                item.SubItems.Add(waterNum);
                item.SubItems.Add(result);
                lstvResult.Items.Add(item);
            }
            else
            {
                MessageBox.Show("The water consumption of the previous month cannot be greater than that of the current month.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CaculateWaterBill waterBill = new CaculateWaterBill();
            waterBill.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstvResult.SelectedItems.Count > 0)
            {
                // User selects to delete a row in the ListView
                DialogResult dl = MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    lstvResult.Items.Remove(lstvResult.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please select data to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
