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
        public Dock mainDockObject;
        public Operation myOperationObject;
        public SelectOperation mySelectOperationObject;


        int positionX = 0, positionY = 0;
        public int currentScreenHeight ,currentScreenWidth;
        public int triggerType;
        public int SELECTED_DISPLAY = 0;
        public bool isTriggerEdit;
        public bool isDraggable;


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
            myTriggerObject.triggerEditor = this;
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
                if (myTriggerObject.TriggerType == FormTrigger.TRIG_TYPE_FLUID)
                {
                    txtBxTimeDelay.Text = txtBxTimeDelay.Text+" x";
                }

                if (string.IsNullOrWhiteSpace(txtbxName.Text.ToString()))
                {
                    MessageBox.Show("Please enter a name for your Trigger", "Trigger Name is null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtBxTimeDelay.Text.ToString()))
                {

                    MessageBox.Show("Please enter a Time Delay in Seconds", "Time Delay null", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (myOperationObject==null)
                {
                    MessageBox.Show("Please create an Opearation for your Trigger", "Operation Not Created", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //this line activates the trigger
                    //myTriggerObject.isAlive = true;

                    myTriggerObject.triggerEditor = this;
                    
                    
                    //creates a triggerInfo 
                    String name = txtbxName.Text.ToString();
                    int Type = myTriggerObject.TriggerType;
                    TriggerInfo thisTriggerInfo = new TriggerInfo(myTriggerObject, name, Type);

                    //Checks if the name already exists
                    if (mainDockObject.triggerList.Count > 0)
                    {
                        foreach (var ti in mainDockObject.triggerList)
                        {
                            if(ti.Name == thisTriggerInfo.Name)
                            {
                                MessageBox.Show("Please provide a Unique name for your Trigger", "Trigger Name not Unique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if(myTriggerObject.TriggerType == FormTrigger.TRIG_TYPE_TIMEDELAY || myTriggerObject.TriggerType == FormTrigger.TRIG_TYPE_RECURRING || myTriggerObject.TriggerType == FormTrigger.TRIG_TYPE_BLINK)
                    {                      
                        float inputTime;
                        if (!float.TryParse(txtBxTimeDelay.Text.ToString().Trim(), out inputTime))
                        {
                            MessageBox.Show("Please enter a valid Time Delay value","Invalid Format",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            myTriggerObject.TimeDelayInSeconds = inputTime;
                        }
                    }

                    mainDockObject.triggerList.Add(thisTriggerInfo);

                    //Updates Active Triggers in Dock
                    mainDockObject.UpdateActiveTriggers();
                    mainDockObject.Show();

                    //updates bools 
                    isTriggerEdit = true;
                    isDraggable = false;
                    checkBox1.Checked = false;

                    //updates Visual Elements
                    myTriggerObject.toggleLogo();
                    myTriggerObject.SetColor();


                   
                    if (myTriggerObject.TriggerType == FormTrigger.TRIG_TYPE_RECURRING)
                    {
                        myTriggerObject.isRecurringActive = false;
                    }


                    this.Hide();
                }


            }
            else
            {
                myTriggerObject.toggleLogo();
                myTriggerObject.SetColor();
                mainDockObject.Show();
                
                this.Hide();
            }
           
        }

        //Method for changing the Type of the trigger
        private void cmbobxTriggerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Apply logic based on the selected item in comboBox

            if (cmbobxTriggerType.SelectedItem.Equals("Fluid"))
            {
                //Set Trigger Type in trigger Object;
                myTriggerObject.TriggerType = FormTrigger.TRIG_TYPE_FLUID;

                myTriggerObject.SetColor();

                myTriggerObject.isRecurringActive = false;
                labelTimeDelay.Hide();
                txtBxTimeDelay.Hide();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Recurring"))
            {             
                //Set Trigger Type in trigger Object;
                myTriggerObject.TriggerType = FormTrigger.TRIG_TYPE_RECURRING;

                myTriggerObject.SetColor();

                myTriggerObject.isRecurringActive = true;
                labelTimeDelay.Show();
                txtBxTimeDelay.Show();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Time Delay"))
            {

                //Set Trigger Type in trigger Object;
                myTriggerObject.TriggerType = FormTrigger.TRIG_TYPE_TIMEDELAY;
                myTriggerObject.SetColor();


                //float inputTime = -1f;
                //if(!float.TryParse(txtBxTimeDelay.Text.ToString(),out inputTime))
                //{
                //    MessageBox.Show("Enter a valid time delay");
                //}        
                //myTriggerObject.timeDelayInSeconds = inputTime;


                myTriggerObject.isRecurringActive = false;
                labelTimeDelay.Show();
                txtBxTimeDelay.Show();
            }
            else if (cmbobxTriggerType.SelectedItem.Equals("Blink"))
            {
                //Set Trigger Type in trigger Object;
                myTriggerObject.TriggerType = FormTrigger.TRIG_TYPE_BLINK;

                myTriggerObject.SetColor();

                myTriggerObject.isRecurringActive = false;
                labelTimeDelay.Show();
                txtBxTimeDelay.Show();
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


        #region This code snippet will Disable the Close button
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
        #endregion


        private void button5_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_TL);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_TC);
        }


        //this public methods lets others set the name type etc of this form window
        public void setNameTypeOperation(string name,int type,string operation)
        {
            txtbxName.Text = name;
            this.Name = "Edit " + name + " [Trigger Editor]";
            cmbobxTriggerType.SelectedIndex = type;
            btnCreateTrigger.Text = "Save Changes";
           
        }


        //----------This method invokes the Operation System
        private void btnSelectOperation_Click(object sender, EventArgs e)
        {
            mySelectOperationObject = new SelectOperation();
            mySelectOperationObject.myTriggerEditor = this;
            mySelectOperationObject.Show();
        }


        public void UpdateToEditMode(string name) {

            btnCreateTrigger.Text = "Edit Trigger: " + name;
            txtbxName.Enabled = false;
            txtBxTimeDelay.Enabled = false;
            cmbobxTriggerType.Enabled = false;
            //btnCreateTrigger.Enabled = false;
            btnClose.Text = "Delete";
            btnSelectOperation.Enabled = false;
        }

        private void closeBtn(object sender, EventArgs e)
        {
            if (!isTriggerEdit)
            {
                mainDockObject.Show();
                closeItAll();
            }
            else  //Delete the trigger
            {
                //remove item from list 
                TriggerInfo toRemove = new TriggerInfo();
                foreach(TriggerInfo ti in mainDockObject.triggerList)
                {
                    if(ti.obj == myTriggerObject)
                    {
                        toRemove = ti;
                    }
                }
                mainDockObject.triggerList.Remove(toRemove);

                mainDockObject.createdTriggers -= 1;
                mainDockObject.UpdateActiveTriggers();    
                
                mainDockObject.Show();
                closeItAll();

            }


            
        }

        private void closeItAll()
        {
            myTriggerObject.Close();
            this.Close();
        }

        #region Anchors Logic

        void SetAnchor(int anchorType)
        {
            switch (anchorType)
            {
                case ANK_TL:

                    myTriggerObject.Location = new Point(0, 0);
                    break;

                case ANK_TC:

                    tempAnkX = currentScreenWidth / 2;
                    tempAnkX = tempAnkX - (myTriggerObject.Width / 2);

                    myTriggerObject.Location = new Point(tempAnkX, 0);

                    break;
                case ANK_TR:

                    tempAnkX = currentScreenWidth - myTriggerObject.Width;
                    myTriggerObject.Location = new Point(tempAnkX, 0);



                    break;
                case ANK_CL:

                    tempAnkY = (currentScreenHeight / 2) - (myTriggerObject.Height / 2);
                    myTriggerObject.Location = new Point(0, tempAnkY);

                    break;
                case ANK_CC:

                    tempAnkY = (currentScreenHeight / 2) - (myTriggerObject.Height / 2);
                    tempAnkX = (currentScreenWidth / 2) - (myTriggerObject.Width / 2);
                    myTriggerObject.Location = new Point(tempAnkX, tempAnkY);

                    break;
                case ANK_CR:

                    tempAnkY = (currentScreenHeight / 2) - (myTriggerObject.Height / 2);
                    tempAnkX = currentScreenWidth - myTriggerObject.Width;
                    myTriggerObject.Location = new Point(tempAnkX, tempAnkY);

                    break;
                case ANK_BL:

                    tempAnkY = currentScreenHeight - myTriggerObject.Height;

                    myTriggerObject.Location = new Point(0, tempAnkY);

                    break;
                case ANK_BC:

                    tempAnkX = (currentScreenWidth / 2) - (myTriggerObject.Width / 2);
                    tempAnkY = currentScreenHeight - myTriggerObject.Height;

                    myTriggerObject.Location = new Point(tempAnkX, tempAnkY);

                    break;
                case ANK_BR:

                    tempAnkY = currentScreenHeight - myTriggerObject.Height;
                    tempAnkX = currentScreenWidth - myTriggerObject.Width;

                    myTriggerObject.Location = new Point(tempAnkX, tempAnkY);
                    break;
            }
        }

        private int tempAnkX;    //To calculate Screen positioning for anchors
        private int tempAnkY;    //To calculate Screen positioning for anchors
        //constants for Anchors 
        public const int ANK_TL = 77;
        public const int ANK_TC = 78;
        public const int ANK_TR = 79;
        public const int ANK_CL = 80;
        public const int ANK_CC = 81;
        public const int ANK_CR = 82;
        public const int ANK_BL = 83;
        public const int ANK_BC = 84;
        public const int ANK_BR = 85;
       

        private void button1_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_CL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_CC);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_CR);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_BL);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_BC);
        }

        private void Draggable(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isDraggable = true;
            }
            else
            {
                isDraggable = false;
            }
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_BR);
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            SetAnchor(ANK_TR);
        }
        #endregion


    }
}
