using Project3.ScheduleManagement;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void laborerManagementButton_Click(object sender, EventArgs e)
        {
            LaborerManagementForm laborerManagementForm = new LaborerManagementForm();
            laborerManagementForm.ShowDialog();
        }

        private void expenseManagementButton_Click(object sender, EventArgs e)
        {
            ExpenseManagementForm expenseManagementForm = new ExpenseManagementForm();
            expenseManagementForm.ShowDialog();
        }

        private void memoButton_Click(object sender, EventArgs e)
        {
            MemoForm memoForm = new MemoForm();
            memoForm.ShowDialog();
        }

        private void scheduleManagementButton_Click(object sender, EventArgs e)
        {
            ScheduleManagementForm scheduleManagementForm = new ScheduleManagementForm();
            scheduleManagementForm.ShowDialog();
        }
    }
}
