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
    public partial class SettingsView : Form
    {
        private SettingsViewController settingsViewController;
        private XMLConfiguration settings;

        public SettingsView(XMLConfiguration settings)
        {
            InitializeComponent();
            this.settings = settings;
            settingsViewController = new SettingsViewController(this, cdMain, fdMain, nudColCounter, nudRowCounter, lbFont, lbFontColor, lbBackgroundColor, lbPreview, lbMatchColor, tbBase64Header, settings);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingsViewController.save();
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            settingsViewController.updateDefaultFont();
        }

        private void btnChangeFontColor_Click(object sender, EventArgs e)
        {
            settingsViewController.updateDefaultFontColor();
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            settingsViewController.updateBackgroundColor();
        }

        private void fdMain_Apply(object sender, EventArgs e)
        {
            settingsViewController.updateDefaultFont();
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            settingsViewController.update();
        }

        private void btnChangeMatchColor_Click(object sender, EventArgs e)
        {
            settingsViewController.updateMatchColor();
        }
    }
}
