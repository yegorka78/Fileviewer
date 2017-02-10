﻿using System;
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
    public partial class GoToView : Form
    {
        private GoToViewController goToViewController;

        public GoToView(EditorContent rtbContent)
        {
            InitializeComponent();
            goToViewController = new GoToViewController(rtbContent, this, nudRow, nudCol);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            goToViewController.MoveTo();
            Close();
        }

        private void GoToView_KeyDown(object sender, KeyEventArgs e)
        {
            goToViewController.keyDownEvents(e);
        }

        private void nudCol_KeyDown(object sender, KeyEventArgs e)
        {
            goToViewController.keyDownEvents(e);
        }

        private void nudRow_KeyDown(object sender, KeyEventArgs e)
        {
            goToViewController.keyDownEvents(e);
        }

        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {
            goToViewController.keyDownEvents(e);
        }
    }
}
