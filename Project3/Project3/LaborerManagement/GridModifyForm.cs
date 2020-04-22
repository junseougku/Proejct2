using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project3.LaborerManagement
{
    public partial class GridModifyForm : Form
    {
        public delegate void Send_EventHandler();
        public event Send_EventHandler sendEvent;

        public GridModifyForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("gridSettingColumnsSaveFile.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                sw.WriteLine(1);
                if (manCheckBox.Check == false) sw.WriteLine(0);
                else sw.WriteLine(1);
                if (womanCheckBox.Check == false) sw.WriteLine(0);
                else sw.WriteLine(1);
                if (hireCountCheckBox.Check == false) sw.WriteLine(0);
                else sw.WriteLine(1);
                if (laborcostCheckBox.Check == false) sw.WriteLine(0);
                else sw.WriteLine(1);
                if (snakCheckBox.Check == false) sw.WriteLine(0);
                else sw.WriteLine(1);
                if (sumcostCheckBox.Check == false) sw.WriteLine(0);
                else sw.WriteLine(1);

                sw.Flush();
            }

            using (FileStream fs = new FileStream("gridSettingLayoutSaveFile.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                sw.WriteLine(130);
                sw.WriteLine(145);
                sw.WriteLine(145);
                sw.WriteLine(150);
                sw.WriteLine(150);
                sw.WriteLine(150);
                sw.WriteLine(140);

                sw.Flush();
            }

            sendEvent();

            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridModifyForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("gridSettingColumnsSaveFile.log", FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);

                string checkValue = sr.ReadLine();
                dateCheckBox.Check = true;

                checkValue = sr.ReadLine();
                if (checkValue == null || checkValue.Equals("0")) manCheckBox.Check = false;
                else manCheckBox.Check = true;

                checkValue = sr.ReadLine();
                if (checkValue == null || checkValue.Equals("0")) womanCheckBox.Check = false;
                else womanCheckBox.Check = true;

                checkValue = sr.ReadLine();
                if (checkValue == null || checkValue.Equals("0")) hireCountCheckBox.Check = false;
                else hireCountCheckBox.Check = true;

                checkValue = sr.ReadLine();
                if (checkValue == null || checkValue.Equals("0")) laborcostCheckBox.Check = false;
                else laborcostCheckBox.Check = true;

                checkValue = sr.ReadLine();
                if (checkValue == null || checkValue.Equals("0")) snakCheckBox.Check = false;
                else snakCheckBox.Check = true;

                checkValue = sr.ReadLine();
                if (checkValue == null || checkValue.Equals("0")) sumcostCheckBox.Check = false;
                else sumcostCheckBox.Check = true;          
            }
        }
    }
}
