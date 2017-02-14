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

        public EditorContent(String text, XMLConfiguration settings){
            Text = text;
            ReadOnly = true;
            WordWrap = false;
            Width = 200;
            ScrollBars = RichTextBoxScrollBars.Both;
            Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            FontConverter fontConverter = new FontConverter();
            ForeColor = ColorTranslator.FromHtml(settings.get("defaultFontColor"));
            BackColor = ColorTranslator.FromHtml(settings.get("backgroundColor"));
            Font = fontConverter.ConvertFromString(settings.get("defaultFont")) as Font;
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
