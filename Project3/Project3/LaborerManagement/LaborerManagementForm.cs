using Project3.LaborerManagement;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project3
{
    public partial class LaborerManagementForm : Form
    {
        public LaborerManagementForm() => InitializeComponent();

        private void DisplayColumns()
        {
            //파일을 이용하여 그리드에 무슨항목을 표시할것인지 결정
            using (FileStream fs = new FileStream("gridSettingColumnsSaveFile.log", FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);

                string checkValue = sr.ReadLine();
                checkValue = sr.ReadLine();
                if (String.IsNullOrEmpty(checkValue) || checkValue.Equals("0"))
                    laborGrid.Columns[1].Visible = false;
                else
                    laborGrid.Columns[1].Visible = true;

                checkValue = sr.ReadLine();
                if (String.IsNullOrEmpty(checkValue) || checkValue.Equals("0"))
                    laborGrid.Columns[2].Visible = false;
                else
                    laborGrid.Columns[2].Visible = true;

                checkValue = sr.ReadLine();
                if (String.IsNullOrEmpty(checkValue) || checkValue.Equals("0"))
                    laborGrid.Columns[3].Visible = false;
                else
                    laborGrid.Columns[3].Visible = true;

                checkValue = sr.ReadLine();
                if (String.IsNullOrEmpty(checkValue) || checkValue.Equals("0"))
                    laborGrid.Columns[4].Visible = false;
                else
                    laborGrid.Columns[4].Visible = true;

                checkValue = sr.ReadLine();
                if (String.IsNullOrEmpty(checkValue) || checkValue.Equals("0"))
                    laborGrid.Columns[5].Visible = false;
                else
                    laborGrid.Columns[5].Visible = true;

                checkValue = sr.ReadLine();
                if (String.IsNullOrEmpty(checkValue) || checkValue.Equals("0"))
                    laborGrid.Columns[6].Visible = false;
                else
                    laborGrid.Columns[6].Visible = true;
            }

            //파일을 이용하여 그리드의 항목길이 결정
            using (FileStream fs = new FileStream("gridSettingLayoutSaveFile.log", FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);

                for(int i = 0; i < laborGrid.Columns.Count; i++)
                    laborGrid.Columns[i].Width = Convert.ToInt32(sr.ReadLine());
            }
        }

        //폼이 처음로드될때
        private void LaborerManagementForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Today.ToString("d");

            DisplayColumns();
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
            laborGrid.Rows.Add(dateLabel.Text,manHireCountCombo.Text,
                womanHireCountCombo.Text, hireTotalCountLabel.Text, laborcostTxt.Text, snakcostTxt.Text
                , GlobalClass.Get_Sum_StringToIntValue(laborcostTxt.Text,snakcostTxt.Text));

            //저장후 리셋하는것이 자연스러움
            resetButton_Click(sender, e);
        }

        //다시쓰기 버튼
        private void resetButton_Click(object sender, EventArgs e)
        {
            manHireCountCombo.Text = "0";
            womanHireCountCombo.Text = "0";
            hireTotalCountLabel.Text = "0";

            laborcostTxt.Text = "0";
            snakcostTxt.Text = "0";
        }

        //여자고용수 콤보박스 클릭시 호출
        private void womanHireCountCombo_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            womanHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(womanHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (womanHireCountCombo.Text.Equals("") == true) womanHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLabel.Text = hireCount.ToString();
        }

        //남자고용수 콤보박스 클릭시 호출
        private void manHireCountCombo_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            manHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(manHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (manHireCountCombo.Text.Equals("") == true) manHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLabel.Text = hireCount.ToString();
        }

        //저장버튼툴팁 
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

            //입력항목에 로우 데이터를 표시
            dateLabel.Text = laborGrid.Rows[rowIndex].Cells[0].Value.ToString();
            manHireCountCombo.Text = laborGrid.Rows[rowIndex].Cells[1].Value.ToString();
            womanHireCountCombo.Text = laborGrid.Rows[rowIndex].Cells[2].Value.ToString();
            laborcostTxt.Text = laborGrid.Rows[rowIndex].Cells[3].Value.ToString();
            snakcostTxt.Text = laborGrid.Rows[rowIndex].Cells[4].Value.ToString();
        }

        //표편집버튼
        private void gridModifyButton_Click(object sender, EventArgs e)
        {
            GridModifyForm gridModifyForm = new GridModifyForm();
            gridModifyForm.sendEvent += new GridModifyForm.Send_EventHandler(DisplayColumns);
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

        //창닫기버튼
        private void closeButton_Click(object sender, EventArgs e) => Close();

        //폼이 닫힐때
        private void LaborerManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream("gridSettingLayoutSaveFile.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                for (int i = 0; i < laborGrid.Columns.Count; i++)
                    sw.WriteLine(laborGrid.Columns[i].Width);

                sw.Flush();
            }
        }
    }
}
