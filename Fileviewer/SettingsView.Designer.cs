namespace Fileviewer
{
    partial class SettingsView
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
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.gpCharCounter = new System.Windows.Forms.GroupBox();
            this.nudRowCounter = new System.Windows.Forms.NumericUpDown();
            this.lbCharCounterRow = new System.Windows.Forms.Label();
            this.nudColCounter = new System.Windows.Forms.NumericUpDown();
            this.lbCharCounterCol = new System.Windows.Forms.Label();
            this.tpStyle = new System.Windows.Forms.TabPage();
            this.lbPreview = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lbBackgroundColor = new System.Windows.Forms.Label();
            this.gbFont = new System.Windows.Forms.GroupBox();
            this.lbMatchColor = new System.Windows.Forms.Label();
            this.btnChangeMatchColor = new System.Windows.Forms.Button();
            this.lbFontColor = new System.Windows.Forms.Label();
            this.lbFont = new System.Windows.Forms.Label();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.btnChangeFontColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cdMain = new System.Windows.Forms.ColorDialog();
            this.fdMain = new System.Windows.Forms.FontDialog();
            this.gpHeaders = new System.Windows.Forms.GroupBox();
            this.lbBase64Header = new System.Windows.Forms.Label();
            this.tbBase64Header = new System.Windows.Forms.TextBox();
            this.tcSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.gpCharCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCounter)).BeginInit();
            this.tpStyle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFont.SuspendLayout();
            this.gpHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpGeneral);
            this.tcSettings.Controls.Add(this.tpStyle);
            this.tcSettings.Location = new System.Drawing.Point(0, 1);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(380, 298);
            this.tcSettings.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.gpHeaders);
            this.tpGeneral.Controls.Add(this.gpCharCounter);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(372, 272);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "general";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // gpCharCounter
            // 
            this.gpCharCounter.Controls.Add(this.nudRowCounter);
            this.gpCharCounter.Controls.Add(this.lbCharCounterRow);
            this.gpCharCounter.Controls.Add(this.nudColCounter);
            this.gpCharCounter.Controls.Add(this.lbCharCounterCol);
            this.gpCharCounter.Location = new System.Drawing.Point(6, 6);
            this.gpCharCounter.Name = "gpCharCounter";
            this.gpCharCounter.Size = new System.Drawing.Size(360, 86);
            this.gpCharCounter.TabIndex = 0;
            this.gpCharCounter.TabStop = false;
            this.gpCharCounter.Text = "char counter";
            // 
            // nudRowCounter
            // 
            this.nudRowCounter.Location = new System.Drawing.Point(104, 45);
            this.nudRowCounter.Name = "nudRowCounter";
            this.nudRowCounter.Size = new System.Drawing.Size(48, 20);
            this.nudRowCounter.TabIndex = 3;
            this.nudRowCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbCharCounterRow
            // 
            this.lbCharCounterRow.AutoSize = true;
            this.lbCharCounterRow.Location = new System.Drawing.Point(7, 47);
            this.lbCharCounterRow.Name = "lbCharCounterRow";
            this.lbCharCounterRow.Size = new System.Drawing.Size(74, 13);
            this.lbCharCounterRow.TabIndex = 2;
            this.lbCharCounterRow.Text = "row starts with";
            // 
            // nudColCounter
            // 
            this.nudColCounter.Location = new System.Drawing.Point(104, 18);
            this.nudColCounter.Name = "nudColCounter";
            this.nudColCounter.Size = new System.Drawing.Size(48, 20);
            this.nudColCounter.TabIndex = 1;
            this.nudColCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbCharCounterCol
            // 
            this.lbCharCounterCol.AutoSize = true;
            this.lbCharCounterCol.Location = new System.Drawing.Point(7, 20);
            this.lbCharCounterCol.Name = "lbCharCounterCol";
            this.lbCharCounterCol.Size = new System.Drawing.Size(91, 13);
            this.lbCharCounterCol.TabIndex = 0;
            this.lbCharCounterCol.Text = "column starts with";
            // 
            // tpStyle
            // 
            this.tpStyle.Controls.Add(this.lbPreview);
            this.tpStyle.Controls.Add(this.groupBox1);
            this.tpStyle.Controls.Add(this.gbFont);
            this.tpStyle.Location = new System.Drawing.Point(4, 22);
            this.tpStyle.Name = "tpStyle";
            this.tpStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tpStyle.Size = new System.Drawing.Size(372, 272);
            this.tpStyle.TabIndex = 1;
            this.tpStyle.Text = "style";
            this.tpStyle.UseVisualStyleBackColor = true;
            // 
            // lbPreview
            // 
            this.lbPreview.BackColor = System.Drawing.Color.Transparent;
            this.lbPreview.Location = new System.Drawing.Point(6, 193);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(358, 70);
            this.lbPreview.TabIndex = 5;
            this.lbPreview.Text = "Lorem ipsum dolor sit amet";
            this.lbPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackgroundColor);
            this.groupBox1.Controls.Add(this.lbBackgroundColor);
            this.groupBox1.Location = new System.Drawing.Point(6, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "background color";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(188, 16);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(164, 23);
            this.btnBackgroundColor.TabIndex = 4;
            this.btnBackgroundColor.Text = "change background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // lbBackgroundColor
            // 
            this.lbBackgroundColor.BackColor = System.Drawing.Color.Transparent;
            this.lbBackgroundColor.Location = new System.Drawing.Point(6, 16);
            this.lbBackgroundColor.Name = "lbBackgroundColor";
            this.lbBackgroundColor.Size = new System.Drawing.Size(176, 23);
            this.lbBackgroundColor.TabIndex = 4;
            this.lbBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbFont
            // 
            this.gbFont.Controls.Add(this.lbMatchColor);
            this.gbFont.Controls.Add(this.btnChangeMatchColor);
            this.gbFont.Controls.Add(this.lbFontColor);
            this.gbFont.Controls.Add(this.lbFont);
            this.gbFont.Controls.Add(this.btnChangeFont);
            this.gbFont.Controls.Add(this.btnChangeFontColor);
            this.gbFont.Location = new System.Drawing.Point(8, 6);
            this.gbFont.Name = "gbFont";
            this.gbFont.Size = new System.Drawing.Size(358, 119);
            this.gbFont.TabIndex = 2;
            this.gbFont.TabStop = false;
            this.gbFont.Text = "default font";
            // 
            // lbMatchColor
            // 
            this.lbMatchColor.BackColor = System.Drawing.Color.Transparent;
            this.lbMatchColor.Location = new System.Drawing.Point(6, 77);
            this.lbMatchColor.Name = "lbMatchColor";
            this.lbMatchColor.Size = new System.Drawing.Size(176, 23);
            this.lbMatchColor.TabIndex = 5;
            this.lbMatchColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeMatchColor
            // 
            this.btnChangeMatchColor.Location = new System.Drawing.Point(188, 77);
            this.btnChangeMatchColor.Name = "btnChangeMatchColor";
            this.btnChangeMatchColor.Size = new System.Drawing.Size(164, 23);
            this.btnChangeMatchColor.TabIndex = 4;
            this.btnChangeMatchColor.Text = "change match color";
            this.btnChangeMatchColor.UseVisualStyleBackColor = true;
            this.btnChangeMatchColor.Click += new System.EventHandler(this.btnChangeMatchColor_Click);
            // 
            // lbFontColor
            // 
            this.lbFontColor.BackColor = System.Drawing.Color.Transparent;
            this.lbFontColor.Location = new System.Drawing.Point(6, 48);
            this.lbFontColor.Name = "lbFontColor";
            this.lbFontColor.Size = new System.Drawing.Size(176, 23);
            this.lbFontColor.TabIndex = 3;
            this.lbFontColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFont
            // 
            this.lbFont.Location = new System.Drawing.Point(6, 19);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(176, 23);
            this.lbFont.TabIndex = 2;
            this.lbFont.Text = "Microsoft Sans Serif; 8.25pt";
            this.lbFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(188, 19);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(164, 23);
            this.btnChangeFont.TabIndex = 0;
            this.btnChangeFont.Text = "change font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnChangeFontColor
            // 
            this.btnChangeFontColor.Location = new System.Drawing.Point(188, 48);
            this.btnChangeFontColor.Name = "btnChangeFontColor";
            this.btnChangeFontColor.Size = new System.Drawing.Size(164, 23);
            this.btnChangeFontColor.TabIndex = 1;
            this.btnChangeFontColor.Text = "change font color";
            this.btnChangeFontColor.UseVisualStyleBackColor = true;
            this.btnChangeFontColor.Click += new System.EventHandler(this.btnChangeFontColor_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(216, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fdMain
            // 
            this.fdMain.Apply += new System.EventHandler(this.fdMain_Apply);
            // 
            // gpHeaders
            // 
            this.gpHeaders.Controls.Add(this.tbBase64Header);
            this.gpHeaders.Controls.Add(this.lbBase64Header);
            this.gpHeaders.Location = new System.Drawing.Point(8, 98);
            this.gpHeaders.Name = "gpHeaders";
            this.gpHeaders.Size = new System.Drawing.Size(358, 54);
            this.gpHeaders.TabIndex = 1;
            this.gpHeaders.TabStop = false;
            this.gpHeaders.Text = "headers";
            // 
            // lbBase64Header
            // 
            this.lbBase64Header.AutoSize = true;
            this.lbBase64Header.Location = new System.Drawing.Point(6, 22);
            this.lbBase64Header.Name = "lbBase64Header";
            this.lbBase64Header.Size = new System.Drawing.Size(47, 13);
            this.lbBase64Header.TabIndex = 0;
            this.lbBase64Header.Text = "BASE64";
            // 
            // tbBase64Header
            // 
            this.tbBase64Header.Location = new System.Drawing.Point(59, 19);
            this.tbBase64Header.Name = "tbBase64Header";
            this.tbBase64Header.Size = new System.Drawing.Size(293, 20);
            this.tbBase64Header.TabIndex = 1;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fileviewer - settings";
            this.Load += new System.EventHandler(this.SettingsView_Load);
            this.tcSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.gpCharCounter.ResumeLayout(false);
            this.gpCharCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCounter)).EndInit();
            this.tpStyle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbFont.ResumeLayout(false);
            this.gpHeaders.ResumeLayout(false);
            this.gpHeaders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpStyle;
        private System.Windows.Forms.GroupBox gpCharCounter;
        private System.Windows.Forms.NumericUpDown nudRowCounter;
        private System.Windows.Forms.Label lbCharCounterRow;
        private System.Windows.Forms.NumericUpDown nudColCounter;
        private System.Windows.Forms.Label lbCharCounterCol;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColorDialog cdMain;
        private System.Windows.Forms.FontDialog fdMain;
        private System.Windows.Forms.Button btnChangeFontColor;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.GroupBox gbFont;
        private System.Windows.Forms.Label lbFontColor;
        private System.Windows.Forms.Label lbFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Label lbBackgroundColor;
        private System.Windows.Forms.Label lbPreview;
        private System.Windows.Forms.Label lbMatchColor;
        private System.Windows.Forms.Button btnChangeMatchColor;
        private System.Windows.Forms.GroupBox gpHeaders;
        private System.Windows.Forms.TextBox tbBase64Header;
        private System.Windows.Forms.Label lbBase64Header;
    }
}