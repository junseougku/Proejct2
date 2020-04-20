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
    public partial class MemoForm : Form
    {
        public MemoForm()
        {
            InitializeComponent();
        }

        private void fontSettingButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                memoBox.Font = fontDialog.Font;
                memoTitleBox.Font = fontDialog.Font;
            };
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MemoForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Today.ToString("d");
        }

        private void memoListButton_Click(object sender, EventArgs e)
        {
            MemoListForm memoListForm = new MemoListForm();
            memoListForm.ShowDialog();
        }
    }
}
