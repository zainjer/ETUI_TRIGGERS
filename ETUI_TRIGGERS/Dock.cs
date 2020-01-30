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
        public WelcomeScreen welcomeScreenObj;         

        //Draggable Code
        Point lastPoint;

        //Trigger List
        public List<TriggerInfo> triggerList = new List<TriggerInfo>();

        //Active Triggers
        int activeTriggers=0;

        public Dock()
        {
            InitializeComponent();
        }

        private void TextbxActiveTrigger_MouseEnter(object sender, EventArgs e)
        {
            txtBxTriggerActive.ForeColor = Color.Black;
            txtBxTriggerActive.BackColor = Color.White;            
        }

        private void TextbxActiveTrigger_MouseLeave(object sender, EventArgs e)
        {
            txtBxTriggerActive.ForeColor = Color.White;
            txtBxTriggerActive.BackColor = Color.Black;
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
                welcomeScreenObj.Show();
                this.Close();
            }
        }
        private void MinimizeMethod(object sender, EventArgs e)
        {
            
        }
       
        FormWindowState oldFormState;
       
        private void button3_Click(object sender, EventArgs e)
        {
            bool isPointerOnTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            oldFormState = this.WindowState;
            this.WindowState = FormWindowState.Minimized;

            if (this.WindowState == FormWindowState.Minimized && isPointerOnTaskbar)
            {
                //systemTrayIcon.Icon = SystemIcons.Information;
                systemTrayIcon.BalloonTipText = "Control Panel has been minimzed to System tray.";
                systemTrayIcon.ShowBalloonTip(2500);
                this.ShowInTaskbar = false;
                systemTrayIcon.Visible = true;
            }
        }
        private void MaximizeMethod(object sender, MouseEventArgs e)
        {
            this.WindowState = oldFormState;
            this.ShowInTaskbar = true;
            systemTrayIcon.Visible = false;
        }
        private void btnCreateTrigger_Click(object sender, EventArgs e)
        {
            var obj = new TriggerEditor();
            obj.Show();
            obj.dockObject = this;           
            this.Hide();
        }
        public void UpdateActiveTriggers()
        {
            activeTriggers = triggerList.Count;
            txtBxTriggerActive.Text = "Triggers Active: " + activeTriggers;
          
        }
        private void EditTrigger(object sender, EventArgs e)
        {
            if (activeTriggers > 0)
            {
                SelectTiggerToEdit obj = new SelectTiggerToEdit();
                obj.triggerList = triggerList.ToArray();
                obj.PopulateMe();
                obj.dock = this;
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: No Triggers are created yet.", "No Triggers Found", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }
        private void DeleteAllTriggers(object sender, EventArgs e)
        {

            //Create a triggerObject array
            FormTrigger[] allTriggers = new FormTrigger[triggerList.Count];


            //get each triggeObject from triggeList (TriggerInfo) and insert it into allTriggers array
            for(int i=0; i<triggerList.Count; i++)
            {
                allTriggers[i] = triggerList[i].obj;
            }

            //Destroy every object in allTrigges Array
            foreach(FormTrigger x in allTriggers)
            {

                //Closes the thread attached to this trigger
                x.triggerThread.Abort();

                //Closes the trigger itself
                x.Close();

            }

            activeTriggers = 0;
            UpdateActiveTriggers();

        }

        //Deactives the triggers by stopping their threads;
        private void ResetAllTriggers(object sender, EventArgs e)
        {
            FormTrigger[] allTriggers = new FormTrigger[triggerList.Count];
            
            //get each triggeObject from triggeList (TriggerInfo) and insert it into allTriggers array
            for (int i = 0; i < triggerList.Count; i++)
            {
                allTriggers[i] = triggerList[i].obj;
            }

            //Destroy every object in allTrigges Array
            foreach (FormTrigger x in allTriggers)
            {

                //Closes the thread attached to this trigger
                x.triggerThread.Abort();

                //Changes color to black to show that its deactive
                x.BackColor = Color.Black;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(TriggerInfo x in triggerList)
            {
                x.obj.isAlive = true;
            }
        }
    }
}
