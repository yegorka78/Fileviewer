namespace Fileviewer
{
    partial class GoToView
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
            this.lbCol = new System.Windows.Forms.Label();
            this.lbRow = new System.Windows.Forms.Label();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCol
            // 
            this.lbCol.AutoSize = true;
            this.lbCol.Location = new System.Drawing.Point(12, 30);
            this.lbCol.Name = "lbCol";
            this.lbCol.Size = new System.Drawing.Size(45, 13);
            this.lbCol.TabIndex = 0;
            this.lbCol.Text = "Column:";
            // 
            // lbRow
            // 
            this.lbRow.AutoSize = true;
            this.lbRow.Location = new System.Drawing.Point(162, 30);
            this.lbRow.Name = "lbRow";
            this.lbRow.Size = new System.Drawing.Size(32, 13);
            this.lbRow.TabIndex = 1;
            this.lbRow.Text = "Row:";
            // 
            // nudCol
            // 
            this.nudCol.Location = new System.Drawing.Point(63, 28);
            this.nudCol.Name = "nudCol";
            this.nudCol.Size = new System.Drawing.Size(65, 20);
            this.nudCol.TabIndex = 2;
            this.nudCol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudCol_KeyDown);
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(200, 28);
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(65, 20);
            this.nudRow.TabIndex = 3;
            this.nudRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudRow_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(190, 69);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOk_KeyDown);
            // 
            // GoToView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 104);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudRow);
            this.Controls.Add(this.nudCol);
            this.Controls.Add(this.lbRow);
            this.Controls.Add(this.lbCol);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GoToView";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCol;
        private System.Windows.Forms.Label lbRow;
        private System.Windows.Forms.NumericUpDown nudCol;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.Button btnOk;
    }
}