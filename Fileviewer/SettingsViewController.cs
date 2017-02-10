using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fileviewer
{
    class SettingsViewController
    {
        private SettingsView view;
        private FontDialog fdMain;
        private ColorDialog cdMain;
        private NumericUpDown nudColStartsWith;
        private NumericUpDown nudRowStartsWith;
        private Label lbFont;
        private Label lbFontColor;
        private Label lbBackgroundColor;
        private Label lbPreview;
        private Label lbMatchColor;
        private TextBox tbBase64Header;

        public SettingsViewController(SettingsView view, ColorDialog cdMain, FontDialog fdMain, NumericUpDown nudColStartsWith, NumericUpDown nudRowStartsWith, Label lbFont, Label lbFontColor, Label lbBackgroundColor, Label lbPreview, Label lbMatchColor, TextBox tbBase64Header)
        {
            this.view = view;
            this.fdMain = fdMain;
            this.cdMain = cdMain;
            this.nudColStartsWith = nudColStartsWith;
            this.nudRowStartsWith = nudRowStartsWith;
            this.lbFont = lbFont;
            this.lbFontColor = lbFontColor;
            this.lbBackgroundColor = lbBackgroundColor;
            this.lbPreview = lbPreview;
            this.lbMatchColor = lbMatchColor;
            this.tbBase64Header = tbBase64Header;
        }

        public void save()
        {
            Properties.Settings.Default.columnStartsWith = Convert.ToInt32(nudColStartsWith.Value);
            Properties.Settings.Default.rowStartsWith = Convert.ToInt32(nudRowStartsWith.Value);
            Properties.Settings.Default.defaultFont = lbFont.Tag as Font;
            Properties.Settings.Default.defaultFontColor = lbFontColor.BackColor;
            Properties.Settings.Default.backgroundColor = lbBackgroundColor.BackColor;
            Properties.Settings.Default.matchColor = lbMatchColor.BackColor;
            Properties.Settings.Default.base64Header = tbBase64Header.Text;
            Properties.Settings.Default.Save();
            view.Close();
        }

        public void update()
        {
            nudColStartsWith.Value = Properties.Settings.Default.columnStartsWith;
            nudRowStartsWith.Value = Properties.Settings.Default.rowStartsWith;
            lbFont.Tag = Properties.Settings.Default.defaultFont;
            Font newFont = Properties.Settings.Default.defaultFont;
            lbFont.Text = newFont.FontFamily.Name + "; " + newFont.SizeInPoints.ToString();
            lbFontColor.BackColor = Properties.Settings.Default.defaultFontColor;
            lbBackgroundColor.BackColor = Properties.Settings.Default.backgroundColor;
            lbPreview.BackColor = lbBackgroundColor.BackColor;
            lbPreview.ForeColor = lbFontColor.BackColor;
            lbPreview.Font = lbFont.Tag as Font;
            lbMatchColor.BackColor = Properties.Settings.Default.matchColor;
            tbBase64Header.Text = Properties.Settings.Default.base64Header;
        }

        public void updateDefaultFont()
        {
            if (fdMain.ShowDialog() == DialogResult.OK)
            {
                Font newFont = fdMain.Font;
                lbFont.Tag = newFont;
                lbFont.Text = newFont.FontFamily.Name + "; " + newFont.SizeInPoints.ToString();
                lbPreview.Font = newFont;
            }
        }

        public void updateDefaultFontColor()
        {
            if (cdMain.ShowDialog() == DialogResult.OK)
            {
                lbFontColor.BackColor = cdMain.Color;
                lbPreview.ForeColor = cdMain.Color;
            }
        }

        public void updateBackgroundColor()
        {
            if (cdMain.ShowDialog() == DialogResult.OK)
            {
                lbBackgroundColor.BackColor = cdMain.Color;
                lbPreview.BackColor = cdMain.Color;
            }
        }
        
        public void updateMatchColor()
        {
            if (cdMain.ShowDialog() == DialogResult.OK)
            {
                lbMatchColor.BackColor = cdMain.Color;
            }
        }
    }
}
