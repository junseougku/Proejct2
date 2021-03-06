﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project3.ScheduleManagement
{
    public partial class ScheduleManagementForm : Form
    {
        public ScheduleManagementForm()
        {
            InitializeComponent();
        }

        private void ScheduleManagementForm_Load(object sender, EventArgs e)
        {
            todayDateLabel.Text = DateTime.Today.ToString("d");

            yearTxt.Value = DateTime.Today.Year;
            monthCombo.Text = DateTime.Today.Month.ToString();
            dayCombo.Text = DateTime.Today.Day.ToString();
        }

        private void yearDownButton_Click(object sender, EventArgs e)
        {
            yearTxt.Value -= 1;
        }

        private void yearUpButton_Click(object sender, EventArgs e)
        {
            yearTxt.Value += 1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
