﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETUI_TRIGGERS
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

     
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to Quit ETUI?", "Quit ETUI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void BtnStartFresh(object sender, EventArgs e)
        {
            this.Hide();

            var obj = new Dock();
            obj.WelcomeScreenObj = this; 
            obj.Show();
        }

        private void BtnImportSettings(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Filter = "ETUI Config File (*.etuiconfig)|*.etuiconfig|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
