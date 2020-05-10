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
            //폰트창을 열었을때 수정할 수 있는 폰트크기를 제한하고 기본적으로 창을띄었을때 표시된 디폴트폰트 유지
            fontDialog.MaxSize = 20;
            fontDialog.MinSize = 10;
            fontDialog.Font = new Font("굴림", 16);

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                //ok버튼을 누르면 선택한 폰트설정대로 폼에적용
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
            //시간없이 날짜만 적용
            dateLabel.Text = DateTime.Today.ToString("d");
        }

        private void memoListButton_Click(object sender, EventArgs e)
        {
            MemoListForm memoListForm = new MemoListForm();
            memoListForm.ShowDialog();
        }
    }
}
