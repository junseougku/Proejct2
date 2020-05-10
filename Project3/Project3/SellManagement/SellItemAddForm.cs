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
    public delegate void Send_EventHandler();

    public partial class SellItemAddForm : Form
    {
        //판매항목을 추가하면 다시 이전폼에서 콤보박스에 항목을 동적으로 추가하기위한 이벤트
        public event Send_EventHandler e_sendEvent;

        public SellItemAddForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //저장버튼
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("sellItemListFile.log", FileMode.Append))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                sw.WriteLine(newSellItemTxt.Text);
                sw.Flush();
            }

            //자식폼이 닫히기전 부모폼의 이벤트 실행// 콤보박스 채우기
            e_sendEvent();

            MessageBox.Show("성공적인 저장했습니다");

            Close();
        }
    }
}
