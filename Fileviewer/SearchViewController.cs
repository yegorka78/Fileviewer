using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fileviewer
{
    public class SearchViewController
    {
        private SearchView searchView;
        private TextBox tbSearchString;
        private EditorContent rtbContent;
        private CheckBox cbCaseSensitive;
        private Label lbMatches;

        public SearchViewController(SearchView searchView, TextBox tbSearchString, EditorContent rtbContent, CheckBox cbCaseSensitive, Label lbMatches)
        {
            this.searchView = searchView;
            this.tbSearchString = tbSearchString;
            this.rtbContent = rtbContent;
            this.cbCaseSensitive = cbCaseSensitive;
            this.lbMatches = lbMatches;
        }

        public void search()
        {
            int matches = 0;
            if (tbSearchString.Text.Length > 0)
            {
                String content = rtbContent.Text;
                int start = 0;
                resetRtbContent();
                int result = 0;
                while (result >= 0)
                {
                    result = searchInDocument(content, start, cbCaseSensitive.Checked);
                    start = result + tbSearchString.Text.Length;
                    if (result >= 0)
                    {
                        matches++;
                    }
                }
            }
            lbMatches.Text = matches.ToString() + " matches!";
        }

        public void resetRtbContent()
        {
            rtbContent.SelectAll();
            rtbContent.SelectionBackColor = Properties.Settings.Default.backgroundColor;
        }

        public int searchInDocument(String term, int start, bool caseSensitive)
        {
            RichTextBoxFinds option = RichTextBoxFinds.None;
            if (caseSensitive)
            {
                option = RichTextBoxFinds.MatchCase;
            }
            int indexToText = rtbContent.Find(tbSearchString.Text, start, option);
            if (indexToText >= 0)
            {
                start = indexToText + tbSearchString.Text.Length;
                rtbContent.Select(indexToText, tbSearchString.Text.Length);
                rtbContent.SelectionBackColor = Properties.Settings.Default.matchColor;
                return indexToText;
            }
            return -1;
        }

        public void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                searchView.Close();
            } else if (e.KeyCode == Keys.Return)
            {
                search();
            }
        }
    }
}
