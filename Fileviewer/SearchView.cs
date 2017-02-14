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
    public partial class SearchView : Form
    {
        private SearchViewController searchViewController;
        private XMLConfiguration settings;

        public SearchView(EditorContent rtbContent, XMLConfiguration settings)
        {
            InitializeComponent();
            this.settings = settings;
            searchViewController = new SearchViewController(this, tbSearchString, rtbContent, cbCaseSensitive, lbMatches, settings);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchViewController.search();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearchString_Enter(object sender, EventArgs e)
        {
            searchViewController.search();
        }

        private void SearchView_KeyDown(object sender, KeyEventArgs e)
        {
            searchViewController.keyDown(sender, e);
        }

        private void tbSearchString_KeyDown(object sender, KeyEventArgs e)
        {
            searchViewController.keyDown(sender, e);
        }
    }
}
