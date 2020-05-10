using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.SellManagement
{
    public partial class SellManagementForm : Form
    {
        public SellManagementForm()
        {
            InitializeComponent();
        }

        //판매항목 추가버튼
        private void SellItemAddButton_Click(object sender, EventArgs e)
        {
            SellItemAddForm sellItemAddForm = new SellItemAddForm();
            sellItemAddForm.e_sendEvent += new Send_EventHandler(Fill_SellItem);
            sellItemAddForm.ShowDialog();
        }

        //폼 로드
        private void SellManagementForm_Load(object sender, EventArgs e)
        {
            Fill_SellItem();
        }
        
        //콤보박스에 보여줄 판매항목 파일 불러오기
        private void Fill_SellItem()
        {
            //매번 전부지우고 새로 추가
            sellItemCombo.Items.Clear();

            using (FileStream fs = new FileStream("sellItemListFile.log", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);

                //파일의 끝이나올때까지 항목을 읽어서 콤보박스에 추가
                string temp;
                while ((temp = sr.ReadLine()) != null)
                {
                    sellItemCombo.Items.Add(temp);
                }
            }
        }

        private void sellItemCountTxt_TextChanged(object sender, EventArgs e)
        {
            //문자열에서 숫자만 나올수 있게끔 
            sellItemCountTxt.Text = GlobalClass.Get_ValidatedCheckInt(sellItemCountTxt.Text);
        }

        private void sellItemRemove_Click(object sender, EventArgs e)
        {
            SellItemRemoveForm sellItemRemoveForm = new SellItemRemoveForm();
            sellItemRemoveForm.e_sendEvent += new Send_EventHandler(Fill_SellItem);
            sellItemRemoveForm.ShowDialog();
        }
    }
}
