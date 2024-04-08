using Microsoft.VisualBasic;
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
    public partial class Type_2 : Form
    {
        public Type_2()
        {
            InitializeComponent();
        }

        private void Type_2_Load(object sender, EventArgs e)
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
                double money = waterNumber * 9955 * 1.1;

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

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    // Kiểm tra xem đã chọn một mục trong ListView chưa
        //    if (lstvResult.SelectedItems.Count > 0)
        //    {
        //        // Lấy mục được chọn
        //        ListViewItem selectedItem = lstvResult.SelectedItems[0];

        //        // Hiển thị một hộp thoại để nhập giá trị mới
        //        string newLastMonth = Interaction.InputBox("Enter new Last Month", "Edit Last Month", selectedItem.SubItems[1].Text);
        //        string newThisMonth = Interaction.InputBox("Enter new This Month", "Edit This Month", selectedItem.SubItems[2].Text);

        //        // Kiểm tra xem người dùng đã nhập giá trị mới chưa và có hợp lệ không
        //        if (!string.IsNullOrEmpty(newLastMonth) && !string.IsNullOrEmpty(newThisMonth))
        //        {
        //            int newLastMonthValue, newThisMonthValue;

        //            if (int.TryParse(newLastMonth, out newLastMonthValue) && int.TryParse(newThisMonth, out newThisMonthValue))
        //            {
        //                // Kiểm tra nước tiêu thụ trong tháng này có lớn hơn nước tiêu thụ trong tháng trước không
        //                if (newThisMonthValue >= newLastMonthValue)
        //                {
        //                    int waterNumber = newThisMonthValue - newLastMonthValue;
        //                    double money = waterNumber * 9955 * 1.1;

        //                    // Cập nhật thông tin của mục được chọn
        //                    selectedItem.SubItems[1].Text = newLastMonth;
        //                    selectedItem.SubItems[2].Text = newThisMonth;
        //                    selectedItem.SubItems[3].Text = waterNumber.ToString();
        //                    selectedItem.SubItems[4].Text = money.ToString();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("The water consumption of the previous month cannot be greater than that of the current month.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid input. Please enter valid numbers for Last Month and This Month.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter values for Last Month and This Month.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select an item to edit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
