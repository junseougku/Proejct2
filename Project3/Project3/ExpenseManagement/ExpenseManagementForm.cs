using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project3
{
    public partial class ExpenseManagementForm : Form
    {
        public ExpenseManagementForm()
        {
            InitializeComponent();
        }

        private void ExpenseManagementForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Today.ToString("d");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            expenseItemTxt.Text = "";
            expenseCostTxt.Text = "0";
            expenseContentTxt.Text = "";
        }

        private void expenseCostTxt_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            expenseCostTxt.Text = GlobalClass.Get_ValidatedCheckInt(expenseCostTxt.Text);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //그리드에 로우 추가
            expenseGrid.Rows.Add(dateLabel.Text, expenseItemTxt.Text, expenseCostTxt.Text, expenseContentTxt.Text);
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            expenseGrid.Visible = false;
        }
    }
}
