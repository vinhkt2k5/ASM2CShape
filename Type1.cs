using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM_2__off_
{
    public partial class Type_1 : Form
    {
        public Type_1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string member = txtMember.Text.Trim();
            if (string.IsNullOrEmpty(member))
            {
                MessageBox.Show("Please enter Number Member", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (!int.TryParse(member, out _))
            {
                MessageBox.Show("Number Member of family not availible.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(thisMonth, out _) && double.TryParse(lastMonth, out _))
            {
                MessageBox.Show("Water Number do not available", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int lastmonth = int.Parse(lastMonth);
            int thismonth = int.Parse(thisMonth);
            int memberNumber = int.Parse(member);

            float waterNumber = thismonth - lastmonth;
            if (memberNumber >= 1)
            {
                if (thismonth >= lastmonth)
                {
                    float averageUsage = waterNumber / memberNumber;
                    double money;
                    if (averageUsage < 10 && averageUsage > 0)
                    {
                        money = averageUsage * 5973 * 1.1;
                    }
                    else if (averageUsage > 10 && averageUsage <= 20)
                    {
                        money = averageUsage * 7052 * 1.1;
                    }
                    else if (averageUsage > 20 && averageUsage <= 30)
                    {
                        money = averageUsage * 8699 * 1.1;
                    }
                    else
                    {
                        money = averageUsage * 15929 * 1.1;
                    }


                    string waterNum = Convert.ToString(waterNumber);
                    string result = Convert.ToString(money);

                    ListViewItem item = new ListViewItem();
                    item.Text = userName;
                    item.SubItems.Add(member);
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
            else
            {
                MessageBox.Show("Number Member of family not available", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }


        private void lstvResult_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Type_1_Load(object sender, EventArgs e)
        {
            lstvResult.View = View.Details;
            lstvResult.GridLines = true;
            lstvResult.FullRowSelect = true;
            // creat column
            lstvResult.Columns.Add("Full name", 150);

            lstvResult.Columns.Add("Member", 50);
            lstvResult.Columns.Add("Last Water Number", 120);
            lstvResult.Columns.Add("This Water Number", 120);
            lstvResult.Columns.Add("Water number", 120);
            lstvResult.Columns.Add("Money", 150);
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
