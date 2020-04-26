using Project3.DB;
using Project3.LaborerManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project3
{
    public partial class LaborerManagementForm : Form
    {
        int m_selectRowIndex;

        public LaborerManagementForm() => InitializeComponent();

        private void DisplayColumns()
        {
            //파일을 이용하여 그리드에 무슨항목을 표시할것인지 결정
            using (FileStream fs = new FileStream("gridSettingColumnsSaveFile.log", FileMode.Open))
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
            todayDateLabel.Text = DateTime.Today.ToString("d");

            DisplayColumns();

            //선택된로우가 없으니 -1로 초기화
            m_selectRowIndex = -1;

            //처음 폼이로드될떄는 로우를 선택할 수 없으므로 삭제버튼 비활성화
            rowRemoveButton.Enabled = false;

            //인력관리테이블에서 모두 셀렉트
            List<object> selectDataList = DBManager.DBSelect(5);
            int i = 0;
            while (selectDataList.Count > i)
            {
                //테이블로우번호는 필요없으므로 i를 일부로 +1한다
                i++;
                
                DateTime saveDate = Convert.ToDateTime(selectDataList[i]);
                i++;

                byte manHireCount = Convert.ToByte(selectDataList[i]);
                i++;

                byte womanHireCount = Convert.ToByte(selectDataList[i]);
                i++;

                int laborerCost = Convert.ToInt32(selectDataList[i]);
                i++;
                
                int snakCost = Convert.ToInt32(selectDataList[i]);
                i++;

                //그리드에 로우 추가
                laborGrid.Rows.Add(saveDate.ToString("d"), manHireCount.ToString()
                    , womanHireCount.ToString(), (manHireCount+womanHireCount).ToString()
                    , laborerCost.ToString(), snakCost.ToString()
                    , GlobalClass.Get_Sum_StringToIntValue(laborerCost.ToString(), snakCost.ToString()));
            }

        }

        //신규입력탭 저장버튼
        private void todaySaveButton_Click(object sender, EventArgs e)
        {
            //정말저장하시겠습니까?
            if (MessageBox.Show("새로운 입력 데이터를 정말 저장하시겠습니까?", "저장하기", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            //저장하기로 했는데 비어있는 칸은 0으로 대체
            if (todayLaborcostTxt.Text.Equals("")) todayLaborcostTxt.Text = "0";
            if (todaySnakcostTxt.Text.Equals("")) todaySnakcostTxt.Text = "0";

            //그리드에 로우 추가
            laborGrid.Rows.Add(todayDateLabel.Text, todayManHireCountCombo.Text
                , todayWomanHireCountCombo.Text, todayHireTotalCountLabel.Text, todayLaborcostTxt.Text, todaySnakcostTxt.Text
                , GlobalClass.Get_Sum_StringToIntValue(todayLaborcostTxt.Text, todaySnakcostTxt.Text));

            DBManager.DBInsert(todayDateLabel.Text, todayManHireCountCombo.Text, todayWomanHireCountCombo.Text
                , todayLaborcostTxt.Text, todaySnakcostTxt.Text);
            
            //저장후 리셋하는것이 자연스러움
            todayResetButton_Click(sender, e);
        }

        //신규입력탭 다시쓰기 버튼
        private void todayResetButton_Click(object sender, EventArgs e)
        {
            todayManHireCountCombo.Text = "0";
            todayWomanHireCountCombo.Text = "0";
            todayHireTotalCountLabel.Text = "0";

            todayLaborcostTxt.Text = "0";
            todaySnakcostTxt.Text = "0";
        }

        //신규입력탭 여자고용수 콤보박스 수정시 호출
        private void todayWomanHireCountCombo_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            todayWomanHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(todayWomanHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (todayWomanHireCountCombo.Text.Equals("") == true) todayWomanHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(todayManHireCountCombo.Text) + Convert.ToInt32(todayWomanHireCountCombo.Text);
            todayHireTotalCountLabel.Text = hireCount.ToString();
        }

        //남자고용수 콤보박스 수정시 호출
        private void todayManHireCountCombo_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            todayManHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(todayManHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (todayManHireCountCombo.Text.Equals("") == true) todayManHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(todayManHireCountCombo.Text) + Convert.ToInt32(todayWomanHireCountCombo.Text);
            todayHireTotalCountLabel.Text = hireCount.ToString();
        }

        //신규탭 저장버튼툴팁 
        private void todaySaveButton_MouseHover(object sender, EventArgs e)
        {
            TooltipManager.DisplayTooltipSaveButton(ref saveButtonTooltip, ref todaySaveButton);
        }

        //수정탭 저장버튼툴팁 
        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            TooltipManager.DisplayTooltipSaveButton(ref saveButtonTooltip, ref saveButton);
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

            //몇번째 로우를 선택했는지 항상 멤버로 보관
            m_selectRowIndex = rowIndex;

            //어떤 로우를 클릭했다면 그뒤부터 삭제버튼은 사용가능
            rowRemoveButton.Enabled = true;

            //입력항목에 로우 데이터를 표시
            Copy_RowData(rowIndex);
        }

        private void Copy_RowData(int _rowIndex)
        {
            //입력항목에 로우 데이터를 표시
            dateLabel.Text = laborGrid.Rows[_rowIndex].Cells[0].Value.ToString();
            manHireCountCombo.Text = laborGrid.Rows[_rowIndex].Cells[1].Value.ToString();
            womanHireCountCombo.Text = laborGrid.Rows[_rowIndex].Cells[2].Value.ToString();

            laborcostTxt.Text = laborGrid.Rows[_rowIndex].Cells[4].Value.ToString();
            snakcostTxt.Text = laborGrid.Rows[_rowIndex].Cells[5].Value.ToString();
        }

        //표편집버튼
        private void gridModifyButton_Click(object sender, EventArgs e)
        {
            GridModifyForm gridModifyForm = new GridModifyForm();
            //컬럼정보
            gridModifyForm.sendEvent += new GridModifyForm.Send_EventHandler(DisplayColumns);
            gridModifyForm.ShowDialog();
        }

        //인건비 텍스트박스 계산
        private void todayLaborcostTxt_TextChanged(object sender, EventArgs e)
        {
            todaySumcostLabel.Text = CostTxt_TextChanged(todayLaborcostTxt.Text, todaySnakcostTxt.Text);
        }

        //간식비 텍스트박스 계산
        private void todaySnakcostTxt_TextChanged(object sender, EventArgs e)
        {
            todaySumcostLabel.Text = CostTxt_TextChanged(todaySnakcostTxt.Text, todayLaborcostTxt.Text);
        }

        //신규 수정 모두 인건비간식비 텍스트박스 이벤트 모두 안에서 처리
        private string CostTxt_TextChanged(string _str1, string _str2)
        {
            _str1 = GlobalClass.Get_ValidatedCheckInt(_str1);

            return GlobalClass.Get_Sum_StringToIntValue(_str1, _str2) + "원";
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

        //수정탭 저장버튼
        private void saveButton_Click(object sender, EventArgs e)
        {
            //정말저장하시겠습니까?
            if (MessageBox.Show("수정된 데이터를 정말 저장하시겠습니까?", "수정하기", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (m_selectRowIndex < 0)
            {
                MessageBox.Show("입력된 데이터가 없습니다.", "실패");
                return;
            }

            //로우데이터 입력항목의 값에맞게 수정
            var alterRow = laborGrid.Rows[m_selectRowIndex];
            if(alterRow.Cells[0].Value.Equals(""))
            {
                MessageBox.Show("입력된 데이터가 없습니다.","실패");
                return;
            }

            //저장하기로 했는데 비어있는 칸은 0으로 대체
            if (laborcostTxt.Text.Equals("")) laborcostTxt.Text = "0";
            if (snakcostTxt.Text.Equals("")) snakcostTxt.Text = "0";

            //로우데이터 입력항목의 값에맞게 수정
            alterRow.Cells[0].Value = dateLabel.Text;
            alterRow.Cells[1].Value = manHireCountCombo.Text;
            alterRow.Cells[2].Value = womanHireCountCombo.Text;
            alterRow.Cells[3].Value = hireTotalCountLabel.Text;
            alterRow.Cells[4].Value = laborcostTxt.Text;
            alterRow.Cells[5].Value = snakcostTxt.Text;
            alterRow.Cells[6].Value = GlobalClass.Get_Sum_StringToIntValue(laborcostTxt.Text, snakcostTxt.Text);

            DBManager.DBInsert(dateLabel.Text, manHireCountCombo.Text, womanHireCountCombo.Text
                , laborcostTxt.Text, snakcostTxt.Text);

            //저장후 리셋하는것이 자연스러움
            resetButton_Click(sender, e);
        }

        //수정탭 다시쓰기 버튼
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (m_selectRowIndex < 0) return;

            Copy_RowData(m_selectRowIndex);              
        }

        private void manHireCountCombo_TextChanged_1(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            manHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(manHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (manHireCountCombo.Text.Equals("") == true) manHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLabel.Text = hireCount.ToString();
        }

        private void womanHireCountCombo_TextChanged_1(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            womanHireCountCombo.Text = GlobalClass.Get_ValidatedCheckInt(womanHireCountCombo.Text);

            //남자 고용수 여자고용수를 모두 정수형으로 바꿔 더한다
            if (womanHireCountCombo.Text.Equals("") == true) womanHireCountCombo.Text = "0";
            int hireCount = Convert.ToInt32(manHireCountCombo.Text) + Convert.ToInt32(womanHireCountCombo.Text);
            hireTotalCountLabel.Text = hireCount.ToString();
        }

        //수정모드 
        private void laborcostTxt_TextChanged(object sender, EventArgs e)
        {
            sumcostLabel.Text = CostTxt_TextChanged(laborcostTxt.Text, snakcostTxt.Text);
        }

        private void snakcostTxt_TextChanged(object sender, EventArgs e)
        {
            sumcostLabel.Text = CostTxt_TextChanged(snakcostTxt.Text, laborcostTxt.Text);
        }

        //항목 숨김버튼
        private void rowHideButton_Click(object sender, EventArgs e)
        {
            //정말숨기시겠습니까?
            if (MessageBox.Show("선택한 기록을 정말 삭제하시겠습니까?", "삭제하기", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            //laborGrid.Rows[m_selectRowIndex]
        }
    }
}
