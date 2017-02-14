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
        private XMLConfiguration settings;

        public SettingsViewController(SettingsView view, ColorDialog cdMain, FontDialog fdMain, NumericUpDown nudColStartsWith, NumericUpDown nudRowStartsWith, Label lbFont, Label lbFontColor, Label lbBackgroundColor, Label lbPreview, Label lbMatchColor, TextBox tbBase64Header, XMLConfiguration settings)
        {
            this.settings = settings;
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
            settings.set("columnStartsWith", nudColStartsWith.Value.ToString());
            settings.set("rowStartsWith", nudRowStartsWith.Value.ToString());
            Font font = lbFont.Tag as Font;
            FontConverter fontConverter = new FontConverter();
            settings.set("defaultFont", fontConverter.ConvertToString(font));
            settings.set("defaultFontColor", "#" + lbFontColor.BackColor.R.ToString("X2") + lbFontColor.BackColor.G.ToString("X2") + lbFontColor.BackColor.B.ToString("X2"));
            settings.set("backgroundColor", "#" + lbBackgroundColor.BackColor.R.ToString("X2") + lbBackgroundColor.BackColor.G.ToString("X2") + lbBackgroundColor.BackColor.B.ToString("X2"));
            settings.set("matchColor", "#" + lbMatchColor.BackColor.R.ToString("X2") + lbMatchColor.BackColor.G.ToString("X2") + lbMatchColor.BackColor.B.ToString("X2"));
            settings.set("base64Header", tbBase64Header.Text);
            view.Close();
        }

        public void update()
        {
            nudColStartsWith.Value = Convert.ToDecimal(settings.get("columnStartsWith"));
            nudRowStartsWith.Value = Convert.ToDecimal(settings.get("rowStartsWith"));
            FontConverter fontConverter = new FontConverter();
            lbFont.Tag = fontConverter.ConvertFromString(settings.get("defaultFont")) as Font;
            Font newFont = fontConverter.ConvertFromString(settings.get("defaultFont")) as Font;
            lbFont.Text = newFont.FontFamily.Name + "; " + newFont.SizeInPoints.ToString();
            lbFontColor.BackColor = ColorTranslator.FromHtml(settings.get("defaultFontColor"));
            lbBackgroundColor.BackColor = ColorTranslator.FromHtml(settings.get("backgroundColor"));
            lbPreview.BackColor = lbBackgroundColor.BackColor;
            lbPreview.ForeColor = lbFontColor.BackColor;
            lbPreview.Font = lbFont.Tag as Font;
            lbMatchColor.BackColor = ColorTranslator.FromHtml(settings.get("matchColor"));
            tbBase64Header.Text = settings.get("base64Header");
        }

        public void updateDefaultFont()
        {
            fdMain.Font = lbFont.Tag as Font;
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
