﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proejct2
{
    public partial class mainForm : DevExpress.XtraEditors.XtraForm
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
    }
}