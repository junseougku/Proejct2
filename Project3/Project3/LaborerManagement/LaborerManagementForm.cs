using Project3.LaborerManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            using (FileStream fs = new FileStream("gridSettingSaveFile.log", FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);

                string checkValue = sr.ReadLine();
                if (checkValue == null || checkValue.Equals("0"))
                {

                }
                else
                {
                    var column = new DataGridViewColumn();
                   
                   // laborGrid.Columns.Add()
                }
            }
        }

        //저장버튼
        private void saveButton_Click(object sender, EventArgs e)
        {
            //정말저장하시겠습니까?
            if (MessageBox.Show("정말 저장하시겠습니까?", "저장하기", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            //저장하기로 했는데 비어있는 칸은 0으로 대체
            if (laborcostTxt.Text.Equals("")) laborcostTxt.Text = "0";
            if (snakcostTxt.Text.Equals("")) snakcostTxt.Text = "0";

            //그리드에 로우 추가
            laborGrid.Rows.Add(dateLabel.Text, hireTotalCountLable.Text, laborcostTxt.Text, snakcostTxt.Text
                , GlobalClass.Get_Sum_StringToIntValue(laborcostTxt.Text,snakcostTxt.Text));

            resetButton_Click(sender, e);
        }

        //다시쓰기 버튼
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
            //문자열에서 숫자만 나올수 있게끔 
            womanHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(womanHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (womanHireCountCombo.Text.Equals("") == true) womanHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLable.Text = hireCount.ToString();
        }

        //남자고용수 콤보박스 클릭시 호출
        private void manHireCountCombo_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            manHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(manHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (manHireCountCombo.Text.Equals("") == true) manHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLable.Text = hireCount.ToString();
        }

        //저장버튼 
        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            saveButtonTooltip.ToolTipTitle = "저장버튼";
            saveButtonTooltip.SetToolTip(saveButton, "반드시 이 버튼을 눌러야 저장됩니다");
        }

        //그리드에 로우 클릭시 그 데이터가 위 입력항목들에게 표시
        private void laborGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //클릭한 로우
            int rowIndex = e.RowIndex;

            //헤더를 클릭하면 이벤트발생하지않음 
            if (rowIndex < 0) return;

            //데이터가 한번도 입력되지않은 곳도 이벤트발생하지않음
            if (laborGrid.Rows[rowIndex].Cells[0].Value == null) return;

            manHireCountCombo.Text = laborGrid.Rows[rowIndex].Cells[1].Value.ToString();
            womanHireCountCombo.Text = laborGrid.Rows[rowIndex].Cells[2].Value.ToString();
            laborcostTxt.Text = laborGrid.Rows[rowIndex].Cells[3].Value.ToString();
            snakcostTxt.Text = laborGrid.Rows[rowIndex].Cells[4].Value.ToString();
        }

        //표편집버튼
        private void gridModifyButton_Click(object sender, EventArgs e)
        {
            GridModifyForm gridModifyForm = new GridModifyForm();
            gridModifyForm.ShowDialog();
        }

        //인건비 텍스트박스 계산
        private void laborcostTxt_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            laborcostTxt.Text = GlobalClass.Get_ValidatedCheckInt(laborcostTxt.Text);

            //인건비와 간식비를 정수로 바꾼후 모두 더한다.
            if (laborcostTxt.Text.Equals("") == true) laborcostTxt.Text = "0";
            int sumcostValue = Convert.ToInt32(laborcostTxt.Text) + Convert.ToInt32(snakcostTxt.Text);

            sumcostLabel.Text = sumcostValue.ToString() + "원";
        }

        //간식비 텍스트박스 계산
        private void snakcostTxt_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            snakcostTxt.Text = GlobalClass.Get_ValidatedCheckInt(snakcostTxt.Text);

            //인건비와 간식비를 정수로 바꾼후 모두 더한다.
            if (snakcostTxt.Text.Equals("") == true) snakcostTxt.Text = "0";
            int sumcostValue = Convert.ToInt32(laborcostTxt.Text) + Convert.ToInt32(snakcostTxt.Text);

            sumcostLabel.Text = sumcostValue.ToString() + "원";
        }
    }
}
