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
        public EditorContent(String text){
            Text = text;
            ReadOnly = true;
            WordWrap = false;
            Width = 200;
            ScrollBars = RichTextBoxScrollBars.Both;
            Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            ForeColor = System.Drawing.Color.Black;
            BackColor = System.Drawing.Color.White;
            Font = new Font("Consolas", 10);
        }
    }
}
