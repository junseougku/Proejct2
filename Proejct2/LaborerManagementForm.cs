﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proejct2
{
    public partial class LaborerManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public LaborerManagementForm()
        {
            InitializeComponent();
        }

        private void LaborerManagementForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = "오늘날짜 : " +  DateTime.Today.ToString("d");
        }

        private void womanHireCountEdit_ValueChanged(object sender, EventArgs e)
        {
            int hireCount = (int)manHireCountEdit.Value + (int)womanHireCountEdit.Value;
            hireTotalCountLable.Text = hireCount.ToString() + "명";
        }

        private void manHireCountEdit_ValueChanged(object sender, EventArgs e)
        {
            int hireCount = (int)manHireCountEdit.Value + (int)womanHireCountEdit.Value;
            hireTotalCountLable.Text = hireCount.ToString() + "명";
        }
    }
}