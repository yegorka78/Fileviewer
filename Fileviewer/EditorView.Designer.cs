namespace Fileviewer
{
    partial class EditorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorView));
            this.mstrpMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpacer1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpacer2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCloseCurrFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnformat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statStrMain = new System.Windows.Forms.StatusStrip();
            this.tsslNumChar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNumCharVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrRowVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrCol = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrColVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCTVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tss0 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFormat = new System.Windows.Forms.ToolStripButton();
            this.tsbUnformat = new System.Windows.Forms.ToolStripButton();
            this.tsbParagraphMarker = new System.Windows.Forms.ToolStripButton();
            this.mstrpMain.SuspendLayout();
            this.statStrMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrpMain
            // 
            this.mstrpMain.BackColor = System.Drawing.SystemColors.Control;
            this.mstrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiView,
            this.tsmiAdvanced});
            this.mstrpMain.Location = new System.Drawing.Point(0, 0);
            this.mstrpMain.Name = "mstrpMain";
            this.mstrpMain.Size = new System.Drawing.Size(1074, 24);
            this.mstrpMain.TabIndex = 0;
            this.mstrpMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSpacer1,
            this.tsmiSearch,
            this.tsmiSpacer2,
            this.tsmiCloseCurrFile,
            this.tsmiClose});
            this.tsmiFile.ForeColor = System.Drawing.Color.Black;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(35, 20);
            this.tsmiFile.Text = "file";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Image = global::Fileviewer.Properties.Resources.open;
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(206, 22);
            this.tsmiOpen.Text = "open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveAs,
            this.tsmiSaveDefault});
            this.tsmiSave.Image = global::Fileviewer.Properties.Resources.save;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(206, 22);
            this.tsmiSave.Text = "save";
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(183, 22);
            this.tsmiSaveAs.Text = "save as";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiSaveDefault
            // 
            this.tsmiSaveDefault.Name = "tsmiSaveDefault";
            this.tsmiSaveDefault.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSaveDefault.Size = new System.Drawing.Size(183, 22);
            this.tsmiSaveDefault.Text = "save";
            this.tsmiSaveDefault.Click += new System.EventHandler(this.tsmiSaveDefault_Click);
            // 
            // tsmiSpacer1
            // 
            this.tsmiSpacer1.Name = "tsmiSpacer1";
            this.tsmiSpacer1.Size = new System.Drawing.Size(203, 6);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Image = global::Fileviewer.Properties.Resources.search;
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiSearch.Size = new System.Drawing.Size(206, 22);
            this.tsmiSearch.Text = "search";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiSpacer2
            // 
            this.tsmiSpacer2.Name = "tsmiSpacer2";
            this.tsmiSpacer2.Size = new System.Drawing.Size(203, 6);
            // 
            // tsmiCloseCurrFile
            // 
            this.tsmiCloseCurrFile.Name = "tsmiCloseCurrFile";
            this.tsmiCloseCurrFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmiCloseCurrFile.Size = new System.Drawing.Size(206, 22);
            this.tsmiCloseCurrFile.Text = "close current file";
            this.tsmiCloseCurrFile.Click += new System.EventHandler(this.tsmiCloseCurrFile_Click);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiClose.Size = new System.Drawing.Size(206, 22);
            this.tsmiClose.Text = "close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFormat,
            this.tsmiUnformat});
            this.tsmiView.ForeColor = System.Drawing.Color.Black;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(43, 20);
            this.tsmiView.Text = "view";
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.Image = global::Fileviewer.Properties.Resources.format;
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmiFormat.Size = new System.Drawing.Size(242, 22);
            this.tsmiFormat.Text = "format content";
            this.tsmiFormat.Click += new System.EventHandler(this.tsmiFormat_Click);
            // 
            // tsmiUnformat
            // 
            this.tsmiUnformat.Image = global::Fileviewer.Properties.Resources.undo;
            this.tsmiUnformat.Name = "tsmiUnformat";
            this.tsmiUnformat.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiUnformat.Size = new System.Drawing.Size(242, 22);
            this.tsmiUnformat.Text = "unformat content";
            this.tsmiUnformat.Click += new System.EventHandler(this.tsmiUnformat_Click);
            // 
            // tsmiAdvanced
            // 
            this.tsmiAdvanced.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.tsmiHelp});
            this.tsmiAdvanced.ForeColor = System.Drawing.Color.Black;
            this.tsmiAdvanced.Name = "tsmiAdvanced";
            this.tsmiAdvanced.Size = new System.Drawing.Size(70, 20);
            this.tsmiAdvanced.Text = "advanced";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Image = global::Fileviewer.Properties.Resources.settings;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(152, 22);
            this.tsmiSettings.Text = "settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Image = global::Fileviewer.Properties.Resources.Help;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(152, 22);
            this.tsmiHelp.Text = "help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Image = global::Fileviewer.Properties.Resources.information;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "about";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // statStrMain
            // 
            this.statStrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNumChar,
            this.tsslNumCharVal,
            this.toolStripStatusLabel3,
            this.tsslCurrRow,
            this.tsslCurrRowVal,
            this.tsslCurrCol,
            this.tsslCurrColVal,
            this.toolStripStatusLabel8,
            this.tsslCT,
            this.tsslCTVal});
            this.statStrMain.Location = new System.Drawing.Point(0, 542);
            this.statStrMain.Name = "statStrMain";
            this.statStrMain.Size = new System.Drawing.Size(1074, 22);
            this.statStrMain.TabIndex = 1;
            this.statStrMain.Text = "statusStrip1";
            // 
            // tsslNumChar
            // 
            this.tsslNumChar.ForeColor = System.Drawing.Color.Black;
            this.tsslNumChar.Name = "tsslNumChar";
            this.tsslNumChar.Size = new System.Drawing.Size(123, 17);
            this.tsslNumChar.Text = "number of characters:";
            // 
            // tsslNumCharVal
            // 
            this.tsslNumCharVal.ForeColor = System.Drawing.Color.Black;
            this.tsslNumCharVal.Name = "tsslNumCharVal";
            this.tsslNumCharVal.Size = new System.Drawing.Size(13, 17);
            this.tsslNumCharVal.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel3.Text = " | ";
            // 
            // tsslCurrRow
            // 
            this.tsslCurrRow.ForeColor = System.Drawing.Color.Black;
            this.tsslCurrRow.Name = "tsslCurrRow";
            this.tsslCurrRow.Size = new System.Drawing.Size(30, 17);
            this.tsslCurrRow.Text = "row:";
            // 
            // tsslCurrRowVal
            // 
            this.tsslCurrRowVal.ForeColor = System.Drawing.Color.Black;
            this.tsslCurrRowVal.Name = "tsslCurrRowVal";
            this.tsslCurrRowVal.Size = new System.Drawing.Size(13, 17);
            this.tsslCurrRowVal.Text = "0";
            // 
            // tsslCurrCol
            // 
            this.tsslCurrCol.ForeColor = System.Drawing.Color.Black;
            this.tsslCurrCol.Name = "tsslCurrCol";
            this.tsslCurrCol.Size = new System.Drawing.Size(54, 17);
            this.tsslCurrCol.Text = " column:";
            // 
            // tsslCurrColVal
            // 
            this.tsslCurrColVal.ForeColor = System.Drawing.Color.Black;
            this.tsslCurrColVal.Name = "tsslCurrColVal";
            this.tsslCurrColVal.Size = new System.Drawing.Size(13, 17);
            this.tsslCurrColVal.Text = "0";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel8.Text = " | ";
            // 
            // tsslCT
            // 
            this.tsslCT.ForeColor = System.Drawing.Color.Black;
            this.tsslCT.Name = "tsslCT";
            this.tsslCT.Size = new System.Drawing.Size(77, 17);
            this.tsslCT.Text = "contenttype: ";
            // 
            // tsslCTVal
            // 
            this.tsslCTVal.ForeColor = System.Drawing.Color.Black;
            this.tsslCTVal.Name = "tsslCTVal";
            this.tsslCTVal.Size = new System.Drawing.Size(10, 17);
            this.tsslCTVal.Text = " ";
            // 
            // tcMain
            // 
            this.tcMain.AllowDrop = true;
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Location = new System.Drawing.Point(0, 52);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.ShowToolTips = true;
            this.tcMain.Size = new System.Drawing.Size(1074, 487);
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            this.tcMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.tcMain_DragDrop);
            this.tcMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.tcMain_DragEnter);
            this.tcMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcMain_KeyDown);
            // 
            // ofdMain
            // 
            this.ofdMain.FileName = "openFileDialog1";
            this.ofdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMain_FileOk);
            // 
            // sfdMain
            // 
            this.sfdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdMain_FileOk);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tss0,
            this.tsbCopy,
            this.tsbPaste,
            this.tsbSearch,
            this.tss1,
            this.tsbFormat,
            this.tsbUnformat,
            this.tsbParagraphMarker});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1074, 25);
            this.tsMain.TabIndex = 3;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::Fileviewer.Properties.Resources.open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "&open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::Fileviewer.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "&save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tss0
            // 
            this.tss0.Name = "tss0";
            this.tss0.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbCopy.Text = "&copy";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbPaste.Text = "&paste";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::Fileviewer.Properties.Resources.search;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbSearch.Text = "&search";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFormat
            // 
            this.tsbFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFormat.Image = global::Fileviewer.Properties.Resources.format;
            this.tsbFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFormat.Name = "tsbFormat";
            this.tsbFormat.Size = new System.Drawing.Size(23, 22);
            this.tsbFormat.Text = "&format";
            this.tsbFormat.Click += new System.EventHandler(this.tsbFormat_Click);
            // 
            // tsbUnformat
            // 
            this.tsbUnformat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnformat.Image = global::Fileviewer.Properties.Resources.undo;
            this.tsbUnformat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnformat.Name = "tsbUnformat";
            this.tsbUnformat.Size = new System.Drawing.Size(23, 22);
            this.tsbUnformat.Text = "&unformat";
            this.tsbUnformat.Click += new System.EventHandler(this.tsbUnformat_Click);
            // 
            // tsbParagraphMarker
            // 
            this.tsbParagraphMarker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbParagraphMarker.Image = global::Fileviewer.Properties.Resources.paragraphmarker;
            this.tsbParagraphMarker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbParagraphMarker.Name = "tsbParagraphMarker";
            this.tsbParagraphMarker.Size = new System.Drawing.Size(23, 22);
            this.tsbParagraphMarker.Text = "paragraph marker";
            this.tsbParagraphMarker.Click += new System.EventHandler(this.tsbParagraphMarker_Click);
            // 
            // EditorView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1074, 564);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.statStrMain);
            this.Controls.Add(this.mstrpMain);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstrpMain;
            this.Name = "EditorView";
            this.Text = "Fileviewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorView_FormClosing);
            this.Load += new System.EventHandler(this.EditorView_Load);
            this.Shown += new System.EventHandler(this.EditorView_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorView_KeyDown);
            this.mstrpMain.ResumeLayout(false);
            this.mstrpMain.PerformLayout();
            this.statStrMain.ResumeLayout(false);
            this.statStrMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrpMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveDefault;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseCurrFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnformat;
        private System.Windows.Forms.StatusStrip statStrMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslNumChar;
        private System.Windows.Forms.ToolStripStatusLabel tsslNumCharVal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrRow;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrRowVal;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrCol;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrColVal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel tsslCT;
        private System.Windows.Forms.ToolStripStatusLabel tsslCTVal;
        private System.Windows.Forms.ToolStripSeparator tsmiSpacer1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripSeparator tsmiSpacer2;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdvanced;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator tss0;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripButton tsbFormat;
        private System.Windows.Forms.ToolStripButton tsbUnformat;
        private System.Windows.Forms.ToolStripButton tsbParagraphMarker;
    }
}

