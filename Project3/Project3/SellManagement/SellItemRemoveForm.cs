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
    public partial class SellItemRemoveForm : Form
    {
        public event Send_EventHandler e_sendEvent;

        public SellItemRemoveForm()
        {
            InitializeComponent();
        }

        private void SellItemRemoveForm_Load(object sender, EventArgs e)
        {
            //매번 전부지우고 새로 추가
            sellItemRemoveCombo.Items.Clear();

            using (FileStream fs = new FileStream("sellItemListFile.log", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);

                //파일의 끝이나올때까지 항목을 읽어서 콤보박스에 추가
                string temp;
                while ((temp = sr.ReadLine()) != null)
                {
                    sellItemRemoveCombo.Items.Add(temp);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int removeIndex = 0;
            string temp;
            //하나씩 읽으면서 콤보박스 아이템과 비교
            using (FileStream fs = new FileStream("sellItemListFile.log", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                
                //원하는 콤보박스의 항목이 나올때까지 루프를돌면서 찾음
                while ((temp = sr.ReadLine()) != null)
                {
                    //콤보박스의 인덱스만 알아낸다.
                    if(temp.Equals(sellItemRemoveCombo.Text))
                    {
                        break;
                    }
                    removeIndex++;
                }
            }

            //일단 항목 전부 스트링 배열에 담는다
            string[] lines = File.ReadAllLines("sellItemListFile.log");

            //항목이 없다면 그냥 나간다 ( 예외처리 )
            if(lines.Length <= 0)
            {
                MessageBox.Show("삭제할 항목이 없습니다");
                Close();
                return;
            }

            using (FileStream fs = new FileStream("sellItemListFile.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                for(int i = 0; i < lines.Length;i++)
                {
                    //지워버릴 라인의 인덱스를 알았으니 그 라인에서만 쓰기를 건너뛴다
                    if (removeIndex == i) continue;
                    
                    sw.WriteLine(lines[i]);
                }

                sw.Flush();
            }

            //자식폼이 닫히기전 부모폼의 이벤트 실행 // 콤보박스 채우기
            e_sendEvent();

            MessageBox.Show("삭제가 완료되었습니다");

            Close();
        }
    }
}
