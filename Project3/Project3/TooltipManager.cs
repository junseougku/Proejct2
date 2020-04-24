using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project3
{
    static class TooltipManager
    {
        static public void DisplayTooltipSaveButton(ref ToolTip _tooltip,ref Button _button)
        {
            _tooltip.ToolTipTitle = "저장버튼";
            _tooltip.SetToolTip(_button, "반드시 이 버튼을 눌러야 저장됩니다");
        }
    }
}
