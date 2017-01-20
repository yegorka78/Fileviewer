using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fileviewer
{
    public class EditorContent : RichTextBox
    {
        private bool paragraphMarkerStatus;

        public EditorContent(String text){
            Text = text;
            ReadOnly = true;
            WordWrap = false;
            Width = 200;
            ScrollBars = RichTextBoxScrollBars.Both;
            Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            ForeColor = Properties.Settings.Default.defaultFontColor;
            BackColor = Properties.Settings.Default.backgroundColor;
            Font = Properties.Settings.Default.defaultFont;
            paragraphMarkerStatus = false;
        }

        public bool getParagraphMarkerStatus()
        {
            return paragraphMarkerStatus;
        }

        public void setParagraphMarkerStatus(bool status)
        {
            paragraphMarkerStatus = status;
        }
    }
}
