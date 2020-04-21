using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    public partial class CustomCheckBox : System.Windows.Forms.Control
    {
        private bool m_check = false;

        public bool Check
        {
            get
            {
                return m_check;
            }
            set
            {
                m_check = value;
                Invalidate();
            }
        }

        public CustomCheckBox()
        {
            InitializeComponent();
        }

        public CustomCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //커스텀된 체크박스 그리기
        protected override void OnPaint(PaintEventArgs pe)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            Graphics g = pe.Graphics;

            g.FillRectangle(new SolidBrush(Color.Transparent), this.ClientRectangle);

            ControlPaint.DrawCheckBox(g, 1, 1
               , this.ClientRectangle.Height - 2, this.ClientRectangle.Height - 2, m_check ? ButtonState.Checked : ButtonState.Normal);

            if (Enabled == false)
                g.DrawString(this.Text, this.Font, new SolidBrush(Color.DarkGray), this.ClientRectangle.Height + 2
                    , (this.Height - g.MeasureString(this.Text, this.Font).Height) / 2);
            else 
                g.DrawString(this.Text, this.Font, new SolidBrush(Color.Black), this.ClientRectangle.Height + 2
                    , (this.Height - g.MeasureString(this.Text, this.Font).Height) / 2);

        }

        private void CustomCheckBox_Click(object sender, System.EventArgs e)
        {
            m_check = !m_check;
            Invalidate();
        }


    }
}