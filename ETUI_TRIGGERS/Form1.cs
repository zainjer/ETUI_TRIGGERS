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
    public partial class CreateNewTrigger : Form
    {         
        FormTrigger triggerObj;

        int positionX = 0, positionY = 0;
        int currentScreenHeight ,currentScreenWidth;
        public int triggerType;

        

        string[] typeRange = new string[]
        {
            "Fluid",
            "Recurring",
            "Time Delay",
            "Blink"
        };

        public CreateNewTrigger()
        {
            InitializeComponent();
            CreateTriggerObject(FormTrigger.TRIG_TYPE_FLUID);
            ConfigTrackBars();
            cmbobxTriggerType.Items.AddRange(typeRange);
            cmbobxTriggerType.SelectedIndex = 0;
        }

        private void CreateTriggerObject(int trigType)
        {         
            this.triggerObj = new FormTrigger(trigType);
            triggerObj.Height = 200;
            triggerObj.Width = 300;
            triggerObj.TopMost = true;
            triggerObj.Show();
            triggerObj.Location = new Point(positionX, positionY);
            txtbxXposition.Text = triggerObj.Location.X.ToString();
            txtbxYposition.Text = triggerObj.Location.X.ToString();             
            //GET TRIGGER OPERATIONS FROM SOMEWHERE
            //Or SET the 'triggerType' variable from somewhere                
        }         
        private void ConfigTrackBars()
        {
            currentScreenHeight = Screen.PrimaryScreen.WorkingArea.Size.Height;
            currentScreenWidth = Screen.PrimaryScreen.WorkingArea.Size.Width;
            trkbarHeight.Maximum = currentScreenHeight;
            trkbarWidth.Maximum = currentScreenWidth;            
            trkbarPositionY.Maximum = currentScreenHeight - triggerObj.Height; 
            trkbarPositionY.Maximum = currentScreenHeight - triggerObj.Width;
            trkbarPositionX.Value = triggerObj.Location.X;
            trkbarPositionY.Value = triggerObj.Location.Y;
            trkbarHeight.Value = triggerObj.Height;
            trkbarWidth.Value = triggerObj.Width;

            triggerObj.Height = trkbarHeight.Value - triggerObj.Location.Y;
            trkbarPositionY.Maximum = currentScreenHeight - triggerObj.Height;
            trkbarPositionY.Value = triggerObj.Location.Y;

            triggerObj.Width = trkbarWidth.Value - triggerObj.Location.X;
            trkbarPositionX.Maximum = currentScreenWidth - triggerObj.Width;
            trkbarPositionX.Value = triggerObj.Location.X;
        }
        private void btnCreateTrigger_Click(object sender, EventArgs e)
        {

            if(triggerObj.triggerType != FormTrigger.TRIG_TYPE_TIMEDELAY)
            {
                txtBxTimeDelay.Text = "Dummy Text";
            }

            if (string.IsNullOrWhiteSpace(txtbxName.Text.ToString()) )
            {
                MessageBox.Show("Please enter a name for your Trigger","Trigger Name is null", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtBxTimeDelay.Text.ToString())){

                MessageBox.Show("Please enter a Time Delay in Seconds", "Time Delay null", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               // this.Hide();
            }

            
            
        }
        private void trkbarPositionX_Scroll(object sender, EventArgs e)
        {
          //  trkbarPositionX.Maximum = currentScreenHeight - triggerObj.Height;
            triggerObj.Location = new Point(trkbarPositionX.Value, triggerObj.Location.Y);
            txtbxXposition.Text = triggerObj.Location.X.ToString();
        }
        private void trkbarPositionY_Scroll(object sender, EventArgs e)
        {
          //  trkbarPositionY.Maximum = currentScreenWidth - triggerObj.Width;
            triggerObj.Location = new Point(triggerObj.Location.X, trkbarPositionY.Value);
            txtbxYposition.Text = triggerObj.Location.Y.ToString();


        }
        private void cmbobxTriggerType_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Apply logic based on the selected item in comboBox

            if (cmbobxTriggerType.SelectedItem.Equals("Fluid")){

                triggerObj.BackColor = Color.Red;
                
                //Set Trigger Type in trigger Object;
                triggerObj.triggerType = FormTrigger.TRIG_TYPE_FLUID;


                triggerObj.isRecurringActive = false;
                labelTimeDelay.Hide();
                txtBxTimeDelay.Hide();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Recurring"))
            {
                triggerObj.BackColor = Color.Green;

                //Set Trigger Type in trigger Object;
                triggerObj.triggerType = FormTrigger.TRIG_TYPE_RECURRING;

                triggerObj.isRecurringActive = true;
                labelTimeDelay.Hide();
                txtBxTimeDelay.Hide();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Time Delay"))
            {
                triggerObj.BackColor = Color.Blue;

                //Set Trigger Type in trigger Object;
                triggerObj.triggerType = FormTrigger.TRIG_TYPE_TIMEDELAY;
                triggerObj.timeDelayInSeconds = 3f;


                triggerObj.isRecurringActive = false;
                labelTimeDelay.Show();
                txtBxTimeDelay.Show();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Blink"))
            {
                triggerObj.BackColor = Color.Yellow;

                //Set Trigger Type in trigger Object;
                triggerObj.triggerType = FormTrigger.TRIG_TYPE_BLINK;

                triggerObj.isRecurringActive = false;
                labelTimeDelay.Hide();
                txtBxTimeDelay.Hide();
            }
        }
        private void trkbarHeight_Scroll(object sender, EventArgs e)
        {
            triggerObj.Height = trkbarHeight.Value-triggerObj.Location.Y;
            trkbarPositionY.Maximum = currentScreenHeight - triggerObj.Height;
            trkbarPositionY.Value = triggerObj.Location.Y;
        }
        private void trkbarWidth_Scroll(object sender, EventArgs e)
        {
            triggerObj.Width = trkbarWidth.Value-triggerObj.Location.X;
            trkbarPositionX.Maximum = currentScreenWidth - triggerObj.Width;
            trkbarPositionX.Value = triggerObj.Location.X;
        }
    }
}
