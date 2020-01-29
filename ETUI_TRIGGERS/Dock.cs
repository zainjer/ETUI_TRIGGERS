using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETUI_TRIGGERS
{
    public partial class Dock : Form
    {
        //Welcome Screen Object        
        public WelcomeScreen WelcomeScreenObj;         

        //Draggable Code
        Point lastPoint;
       
        public Dock()
        {
            InitializeComponent();
        }
        private void TextbxActiveTrigger_MouseEnter(object sender, EventArgs e)
        {
            txtBxTriggerActives.ForeColor = Color.Black;
            txtBxTriggerActives.BackColor = Color.White;
            
        }

        private void TextbxActiveTrigger_MouseLeave(object sender, EventArgs e)
        {
            txtBxTriggerActives.ForeColor = Color.White;
            txtBxTriggerActives.BackColor = Color.Black;

        }

        private void Dock_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = new Point(0, 0);
        }

        private void DraggingOn(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }       
        private void DraggingOff(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void btnBacktoMain_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Close All Triggers?", "Close Control Panel | ETUI © 2020", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                WelcomeScreenObj.Show();
                this.Close();
            }

        }
    }
}
