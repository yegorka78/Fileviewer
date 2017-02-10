using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fileviewer
{
    class GoToViewController
    {
        private GoToView goToView;
        private EditorContent rtbContent;
        private NumericUpDown nudRow;
        private NumericUpDown nudCol;
        private static int EM_LINEINDEX = 0xbb;
        [DllImport("user32.dll")]
        extern static int SendMessage(IntPtr hwnd, int message, int wparam, int lparam);

        public GoToViewController(EditorContent rtbContent, GoToView goToView, NumericUpDown nudRow, NumericUpDown nudCol)
        {
            this.rtbContent = rtbContent;
            this.goToView = goToView;
            this.nudRow = nudRow;
            this.nudCol = nudCol;
        }

        public void MoveTo()
        {
            int row = Convert.ToInt32(nudRow.Value);
            int col = Convert.ToInt32(nudCol.Value);
            if (row >= 0 && col >= 0)
            {
                int start = SendMessage(rtbContent.Handle, EM_LINEINDEX, row, 0);
                rtbContent.SelectionStart = start + col;
                rtbContent.SelectionLength = 0;
            }
        }

        public void keyDownEvents(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                goToView.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                MoveTo();
                goToView.Close();
            }
        }
    }
}
