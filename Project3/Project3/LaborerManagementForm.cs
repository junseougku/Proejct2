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
    public partial class LaborerManagementForm : Form
    {
        public LaborerManagementForm()
        {
            InitializeComponent();
        }

        private void LaborerManagementForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Today.ToString("d");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 저장하시겠습니까?", "저장하기", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (laborcostTxt.Text.Equals("")) laborcostTxt.Text = "0";
            if (snakcostTxt.Text.Equals("")) snakcostTxt.Text = "0";

            //그리드에 로우 추가
            laborGrid.Rows.Add(dateLabel.Text, hireTotalCountLable.Text, laborcostTxt.Text, snakcostTxt.Text
                , GlobalClass.Get_Sum_StringToIntValue(laborcostTxt.Text,snakcostTxt.Text));

            resetButton_Click(sender, e);
        }

        //모두 초기화
        private void resetButton_Click(object sender, EventArgs e)
        {
            manHireCountCombo.Text = "0";
            womanHireCountCombo.Text = "0";

            laborcostTxt.Text = "";
            snakcostTxt.Text = "";
        }

        //여자고용수 콤보박스 클릭시 호출
        private void womanHireCountCombo_TextChanged(object sender, EventArgs e)
        {
            womanHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(womanHireCountCombo.Text);

            if (womanHireCountCombo.Text.Equals("") == true) womanHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLable.Text = hireCount.ToString();
        }

        //남자고용수 콤보박스 클릭시 호출
        private void manHireCountCombo_TextChanged(object sender, EventArgs e)
        {
            manHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(manHireCountCombo.Text);

            if (manHireCountCombo.Text.Equals("") == true) manHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLable.Text = hireCount.ToString();
        }

        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            saveButtonTooltip.ToolTipTitle = "저장버튼";
            saveButtonTooltip.SetToolTip(saveButton, "반드시 이 버튼을 눌러야 저장됩니다");
        }
    }
}
