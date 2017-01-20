using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fileviewer
{
    public partial class EditorView : Form, IView
    {
        private EditorViewController editorViewController;
        private AboutView aboutView;
        private SettingsView settingsView;
        private String fileToOpen;

        public EditorView(EditorModel editorModel, string fileToOpen)
        {
            InitializeComponent();
            editorViewController = new EditorViewController(editorModel, this, tcMain, tsslCTVal, tsslNumCharVal, ofdMain, tsslCurrRowVal, tsslCurrColVal, sfdMain);
            aboutView = new AboutView();
            settingsView = new SettingsView();
            this.fileToOpen = fileToOpen;
        }

        #region observer
        public void update()
        {
            editorViewController.update();
        }

        private void EditorView_Load(object sender, EventArgs e)
        {
            editorViewController.addView();
        }

        private void EditorView_FormClosing(object sender, FormClosingEventArgs e)
        {
            editorViewController.removeView();
        }
        #endregion

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            editorViewController.close();
        }

        private void EditorView_KeyDown(object sender, KeyEventArgs e)
        {
            editorViewController.keyPressEvent(e.KeyCode, Control.ModifierKeys);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            ofdMain.ShowDialog();
        }

        private void ofdMain_FileOk(object sender, CancelEventArgs e)
        {
            editorViewController.openFile();
        }

        private void tsmiCloseCurrFile_Click(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                editorViewController.closeFile();
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                editorViewController.updateFileType();
                editorViewController.updateWindowTitle();
                editorViewController.updateNumberOfCharacter();
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                sfdMain.ShowDialog();
            }
        }

        private void tsmiSaveDefault_Click(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                DialogResult msgResult = MessageBox.Show(this, "You may overwrite the original file. Would you like to continue?", "Fileviewer - save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (msgResult == DialogResult.Yes)
                {
                    editorViewController.saveFile(true);
                }
            }
        }

        private void sfdMain_FileOk(object sender, CancelEventArgs e)
        {
            editorViewController.saveFile(false);
        }

        private void tsmiFormat_Click(object sender, EventArgs e)
        {
            editorViewController.formatFile();
        }

        private void tsmiUnformat_Click(object sender, EventArgs e)
        {
            editorViewController.unformatFile();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                SearchView searchView = new SearchView(tcMain.SelectedTab.Controls[0] as EditorContent);
                searchView.ShowDialog();                
            }
        }

        private void tcMain_DragDrop(object sender, DragEventArgs e)
        {
            editorViewController.dragAndDropFile(sender, e);
        }

        private void tcMain_DragEnter(object sender, DragEventArgs e)
        {
            editorViewController.dragEnterFile(sender, e);
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            settingsView.ShowDialog();
            if (settingsView.DialogResult == DialogResult.OK)
            {
                update();
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            aboutView.ShowDialog();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            ofdMain.ShowDialog();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                DialogResult msgResult = MessageBox.Show(this, "Do you really want to overwrite the original file?", "Fileviewer - save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (msgResult == DialogResult.Yes)
                {
                    editorViewController.saveFile(true);
                }
            }
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                EditorContent rtbContent = tcMain.SelectedTab.Controls[0] as EditorContent;
                rtbContent.Copy();
            }
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            editorViewController.newAnonymousFile();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count > 0)
            {
                SearchView searchView = new SearchView(tcMain.SelectedTab.Controls[0] as EditorContent);
                searchView.ShowDialog();
            }
        }

        private void tsbFormat_Click(object sender, EventArgs e)
        {
            editorViewController.formatFile();
        }

        private void tsbUnformat_Click(object sender, EventArgs e)
        {
            editorViewController.unformatFile();
        }

        private void tcMain_KeyDown(object sender, KeyEventArgs e)
        {
            editorViewController.keyPressEvent(e.KeyCode, Control.ModifierKeys);
        }

        private void tsbParagraphMarker_Click(object sender, EventArgs e)
        {
            editorViewController.paragraphMarker();
        }

        private void EditorView_Shown(object sender, EventArgs e)
        {
            if (fileToOpen != "")
            {
                ofdMain.FileName = fileToOpen;
                editorViewController.openFile();
            }
        }
    }
}