using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project3
{
    enum eToolTipMessages { SAVE, CLOSE, RESET}
    static class ToolTipManager
    {
        static public void DisplayToolTipInit(ref DrawToolTipEventArgs _e, eToolTipMessages _msg)
        {
            string tooptipMessage;
            if (_msg == eToolTipMessages.SAVE)
                tooptipMessage = "반드시 이 버튼을 눌러야 저장됩니다";
            else if (_msg == eToolTipMessages.SAVE)
                tooptipMessage = "모두 지울려면 클릭하시오";
            else if (_msg == eToolTipMessages.SAVE)
                tooptipMessage = "현재 창을 끄려면 클릭하시오";
            else tooptipMessage = "정보없음";
            _e.DrawBackground();
            _e.DrawBorder();
            _e.Graphics.DrawString(tooptipMessage, new Font("굴림", 16), Brushes.Black, new PointF(2, 2));
        }
    }
}
