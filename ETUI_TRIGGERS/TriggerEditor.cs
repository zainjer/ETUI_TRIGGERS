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
    public partial class TriggerEditor : Form
    {
        public FormTrigger myTriggerObject;
        public Dock dockObject;

        int positionX = 0, positionY = 0;
        int currentScreenHeight ,currentScreenWidth;
        public int triggerType;
        public int SELECTED_DISPLAY = 0;
        public bool isTriggerEdit;

        string[] typeRange = new string[]
        {
            "Fluid",
            "Recurring",
            "Time Delay",
            "Blink"
        };

        public TriggerEditor()
        {
            InitializeComponent();
            CreateTriggerObject(FormTrigger.TRIG_TYPE_FLUID);
            ConfigTrackBars();
            cmbobxTriggerType.Items.AddRange(typeRange);
            cmbobxTriggerType.SelectedIndex = 0;
        }

        private void CreateTriggerObject(int trigType)
        {         

            this.myTriggerObject = new FormTrigger(trigType);
            myTriggerObject.Height = 200;
            myTriggerObject.Width = 300;
            myTriggerObject.TopMost = true;
            myTriggerObject.Show();
            myTriggerObject.Location = new Point(positionX, positionY);
            txtbxXposition.Text = myTriggerObject.Location.X.ToString();
            txtbxYposition.Text = myTriggerObject.Location.X.ToString();             
            
            //GET TRIGGER OPERATIONS FROM SOMEWHERE
            //Or SET the 'triggerType' variable from somewhere
            
        }         
        private void ConfigTrackBars()
        {
            currentScreenHeight = Screen.AllScreens[SELECTED_DISPLAY].WorkingArea.Size.Height;
            currentScreenWidth = Screen.AllScreens[SELECTED_DISPLAY].WorkingArea.Size.Width;
            trkbarHeight.Maximum = currentScreenHeight;
            trkbarWidth.Maximum = currentScreenWidth;            
            trkbarPositionY.Maximum = currentScreenHeight - myTriggerObject.Height; 
            trkbarPositionY.Maximum = currentScreenHeight - myTriggerObject.Width;
            trkbarPositionX.Value = myTriggerObject.Location.X;
            trkbarPositionY.Value = myTriggerObject.Location.Y;
            trkbarHeight.Value = myTriggerObject.Height;
            trkbarWidth.Value = myTriggerObject.Width;

            myTriggerObject.Height = trkbarHeight.Value - myTriggerObject.Location.Y;
            trkbarPositionY.Maximum = currentScreenHeight - myTriggerObject.Height;
            trkbarPositionY.Value = myTriggerObject.Location.Y;

            myTriggerObject.Width = trkbarWidth.Value - myTriggerObject.Location.X;
            trkbarPositionX.Maximum = currentScreenWidth - myTriggerObject.Width;
            trkbarPositionX.Value = myTriggerObject.Location.X;
        }
        private void btnCreateTrigger_Click(object sender, EventArgs e)
        {

            if (!isTriggerEdit)
            {
                if (myTriggerObject.triggerType != FormTrigger.TRIG_TYPE_TIMEDELAY)
                {
                    txtBxTimeDelay.Text = "Dummy Text";
                }

                if (string.IsNullOrWhiteSpace(txtbxName.Text.ToString()))
                {
                    MessageBox.Show("Please enter a name for your Trigger", "Trigger Name is null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtBxTimeDelay.Text.ToString()))
                {

                    MessageBox.Show("Please enter a Time Delay in Seconds", "Time Delay null", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    this.Hide();

                    //this line activates the trigger
                    //myTriggerObject.isAlive = true;

                    myTriggerObject.triggerEditor = this;
                    //Adds a trigger and its info to the triggerList 

                    String name = txtbxName.Text.ToString();
                    int Type = myTriggerObject.triggerType;
                    TriggerInfo thisTriggerInfo = new TriggerInfo(myTriggerObject, name, Type);
                    dockObject.triggerList.Add(thisTriggerInfo);

                    //Updates Active Triggers in Dock
                    dockObject.UpdateActiveTriggers();
                    dockObject.Show();

                    isTriggerEdit = true;
                }


            }
            else
            {
                this.Hide();
            }
           
        }

        //Method for changing the Type of the trigger
        private void cmbobxTriggerType_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Apply logic based on the selected item in comboBox

            if (cmbobxTriggerType.SelectedItem.Equals("Fluid"))
            {

                myTriggerObject.BackColor = Color.Red;

                //Set Trigger Type in trigger Object;
                myTriggerObject.triggerType = FormTrigger.TRIG_TYPE_FLUID;


                myTriggerObject.isRecurringActive = false;
                labelTimeDelay.Hide();
                txtBxTimeDelay.Hide();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Recurring"))
            {
                myTriggerObject.BackColor = Color.Green;

                //Set Trigger Type in trigger Object;
                myTriggerObject.triggerType = FormTrigger.TRIG_TYPE_RECURRING;

                myTriggerObject.isRecurringActive = true;
                labelTimeDelay.Hide();
                txtBxTimeDelay.Hide();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Time Delay"))
            {
                myTriggerObject.BackColor = Color.Blue;

                //Set Trigger Type in trigger Object;
                myTriggerObject.triggerType = FormTrigger.TRIG_TYPE_TIMEDELAY;
                myTriggerObject.timeDelayInSeconds = 3f;


                myTriggerObject.isRecurringActive = false;
                labelTimeDelay.Show();
                txtBxTimeDelay.Show();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Blink"))
            {
                myTriggerObject.BackColor = Color.Yellow;

                //Set Trigger Type in trigger Object;
                myTriggerObject.triggerType = FormTrigger.TRIG_TYPE_BLINK;

                myTriggerObject.isRecurringActive = false;
                labelTimeDelay.Hide();
                txtBxTimeDelay.Hide();
            }
        }



        //Methods for Trigger Position (X,Y) on the Screen
        private void trkbarPositionX_Scroll(object sender, EventArgs e)
        {
          //  trkbarPositionX.Maximum = currentScreenHeight - triggerObj.Height;
            myTriggerObject.Location = new Point(trkbarPositionX.Value, myTriggerObject.Location.Y);
            txtbxXposition.Text = myTriggerObject.Location.X.ToString();
        }
        private void trkbarPositionY_Scroll(object sender, EventArgs e)
        {
          //  trkbarPositionY.Maximum = currentScreenWidth - triggerObj.Width;
            myTriggerObject.Location = new Point(myTriggerObject.Location.X, trkbarPositionY.Value);
            txtbxYposition.Text = myTriggerObject.Location.Y.ToString();


        }
       
        

        //Methods for Trigget Size [Width,Height]
        private void trkbarHeight_Scroll(object sender, EventArgs e)
        {
            myTriggerObject.Height = trkbarHeight.Value-myTriggerObject.Location.Y;
            trkbarPositionY.Maximum = currentScreenHeight - myTriggerObject.Height;
            trkbarPositionY.Value = myTriggerObject.Location.Y;
        }
        private void trkbarWidth_Scroll(object sender, EventArgs e)
        {
            myTriggerObject.Width = trkbarWidth.Value-myTriggerObject.Location.X;
            trkbarPositionX.Maximum = currentScreenWidth - myTriggerObject.Width;
            trkbarPositionX.Value = myTriggerObject.Location.X;
        }


        //The below code snippet will Disable the Close button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }


        //this public methods lets others set the name type etc of this form window
        public void setNameTypeOperation(string name,int type,string operation)
        {
            txtbxName.Text = name;
            this.Name = "Edit " + name + " [Trigger Editor]";
            cmbobxTriggerType.SelectedIndex = type;
            btnCreateTrigger.Text = "Save Changes";            
        }

        public void UpdateToEditMode(string name) {

            btnCreateTrigger.Text = "Edit Trigger: " + name;
            txtbxName.Enabled = false;
            txtBxTimeDelay.Enabled = false;
            cmbobxTriggerType.Enabled = false;
            cmbobxOperations.Enabled = false;
        }
    }
}
