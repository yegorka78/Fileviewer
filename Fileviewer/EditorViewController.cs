using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fileviewer
{
    public class EditorViewController
    {
        private EditorModel editorModel;
        private EditorView editorView;
        private TabControl tcMain;
        private ToolStripStatusLabel tsslCTVal;
        private OpenFileDialog ofdMain;
        private ToolStripStatusLabel tsslNumCharVal;
        private ToolStripStatusLabel tsslCurrRowVal;
        private ToolStripStatusLabel tsslCurrColVal;
        private SaveFileDialog sfdMain;

        public EditorViewController(EditorModel editorModel, EditorView editorView, TabControl tcMain, ToolStripStatusLabel tsslCTVal, ToolStripStatusLabel tsslNumCharVal, OpenFileDialog ofdMain, ToolStripStatusLabel tsslCurrRowVal, ToolStripStatusLabel tsslCurrColVal, SaveFileDialog sfdMain)
        {
            this.editorModel = editorModel;
            this.editorView = editorView;
            this.tcMain = tcMain;
            this.tsslCTVal = tsslCTVal;
            this.ofdMain = ofdMain;
            this.tsslNumCharVal = tsslNumCharVal;
            this.tsslCurrColVal = tsslCurrColVal;
            this.tsslCurrRowVal = tsslCurrRowVal;
            editorView.Text = "Fileviewer - no open file";
            this.sfdMain = sfdMain;
        }

        public void update()
        {
            foreach (TabPage tabPage in tcMain.TabPages)
            {
                tcMain.TabPages.Remove(tabPage);
            }
            foreach (Document file in editorModel.getFiles())
            {
                TabPage tabPage = new TabPage();
                tabPage.Tag = file;
                tabPage.Text = file.getName();
                tabPage.ToolTipText = file.getPath();
                EditorContent rtbContent = new EditorContent(file.getContent());
                rtbContent.SelectionChanged += EditorContent_SelectionChanged;
                rtbContent.KeyDown += EditorContent_KeyPress;
                rtbContent.DragEnter += dragEnterFile;
                rtbContent.DragDrop += dragAndDropFile;
                rtbContent.AllowDrop = true;
                tabPage.Controls.Add(rtbContent);
                tcMain.TabPages.Add(tabPage);
            }
        }

        public void addView()
        {
            editorModel.addView(editorView);
        }

        public void removeView()
        {
            editorModel.removeView(editorView);
        }

        public void openFile()
        {
            editorModel.addFile(editorModel.readFile(new Document(ofdMain.FileName, String.Empty, String.Empty, String.Empty)));
            updateWindowTitle();
            updateFileType();
            updateNumberOfCharacter();
        }

        public void closeFile()
        {
            editorModel.removeFile(tcMain.SelectedTab.Tag as Document);
            if (tcMain.TabPages.Count == 0)
            {
                tsslCTVal.Text = String.Empty;
                tsslNumCharVal.Text = "0";
                editorView.Text = "Fileviewer - no open file";
            }
            else
            {
                updateWindowTitle();
                updateFileType();
                updateNumberOfCharacter();
            }
        }

        public void saveFile(bool overwrite)
        {
            if (tcMain.TabPages.Count > 0)
            {
                Document file = tcMain.SelectedTab.Tag as Document;
                if (!overwrite)
                {
                    file.setPath(sfdMain.FileName);
                }
                editorModel.saveFile(file);
            }
        }

        public void formatFile()
        {
            if (tcMain.TabPages.Count > 0)
            {
                Document file = tcMain.SelectedTab.Tag as Document;
                editorModel.formatFile(file);
            }
        }

        public void unformatFile()
        {
            if (tcMain.TabPages.Count > 0)
            {
                Document file = tcMain.SelectedTab.Tag as Document;
                editorModel.unformatFile(file);
            }
        }

        public void close()
        {
            editorView.Close();
        }

        public void keyPressEvent(Keys keyCode, Keys modifierKeys)
        {
            if (keyCode == Keys.Escape)
            {
                resetBackColor();
            }
        }

        public void updateFileType()
        {
            Document file = tcMain.SelectedTab.Tag as Document;
            tsslCTVal.Text = file.getType();
        }

        public void updateWindowTitle()
        {
            Document file = tcMain.SelectedTab.Tag as Document;
            editorView.Text = "Fileviewer -" + file.getName();
        }

        public void updateNumberOfCharacter()
        {
            EditorContent rtbContent = tcMain.SelectedTab.Controls[0] as EditorContent;
            if (rtbContent.SelectedText.Length > 0)
            {
                tsslNumCharVal.Text = rtbContent.SelectedText.Length.ToString();
            }
            else
            {
                Document file = tcMain.SelectedTab.Tag as Document;
                tsslNumCharVal.Text = file.getContent().Count<char>().ToString();
            }
        }

        public void updateCursorPosition()
        {
            EditorContent rtbContent = tcMain.SelectedTab.Controls[0] as EditorContent;
            int position = rtbContent.SelectionStart;
            tsslCurrRowVal.Text = rtbContent.GetLineFromCharIndex(position).ToString();
            tsslCurrColVal.Text = (position - rtbContent.GetFirstCharIndexOfCurrentLine()).ToString();
        }

        private void EditorContent_SelectionChanged(object sender, EventArgs e)
        {
            updateCursorPosition();
            updateNumberOfCharacter();
        }

        private void EditorContent_KeyPress(object sender, KeyEventArgs e)
        {
            keyPressEvent(e.KeyCode, Keys.Modifiers);
        }

        public void resetBackColor()
        {
            if (tcMain.TabPages.Count > 0)
            {                
                EditorContent rtbContent = tcMain.SelectedTab.Controls[0] as EditorContent;
                String content = rtbContent.Text;
                rtbContent.Clear();
                rtbContent.Text = content;
            }
        }

        public void dragEnterFile(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        public void dragAndDropFile(object sender, DragEventArgs e)
        {
            string[] fileNames = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (fileNames != null)
            {
                foreach (string name in fileNames)
                {
                    ofdMain.FileName = name;
                    openFile();
                }
            }
        }
    }
}
