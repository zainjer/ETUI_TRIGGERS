﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ActionLibraryWindows;

namespace ETUI_TRIGGERS
{
    public partial class FormTrigger : Form
    {
        //Types of triggers
        public static int TRIG_TYPE_FLUID = 11;
        public static int TRIG_TYPE_RECURRING = 12;
        public static int TRIG_TYPE_TIMEDELAY = 13;
        public static int TRIG_TYPE_BLINK = 14;

        //Current color of trigger
        Color currentColor;

        //Thread and Loop controlling bools
        bool isTriggerActive = false;
        public bool isRecurringActive { get; set; }

        //Trigger Alive Bool
        public bool isAlive { get; set; }

        //Thread of this trigger
        public Thread triggerThread;

        //Properties to define trigger type and features
        public int TriggerType { get; set; }
        public float TimeDelayInSeconds { get; set; }

        //The editor of current trigger (Create Trigger Window)
        public TriggerEditor triggerEditor;

        public ActionLibrary actionLibrary = new ActionLibrary();

        public Operation myOperation;

        public FormTrigger(int triggerType)
        {
            InitializeComponent();
            this.TriggerType = triggerType;
            
        }

        private void Trigger_Load(object sender, EventArgs e)
        {

            //Give the thread a color based  on its type
            SetColor();
            TimeDelayInSeconds = 0;
         
        }

        private void FormTrigger_MouseLeave(object sender, EventArgs e)
        {
            if (isAlive)
            {
                // Console.WriteLine("Mouse Leave");
                //This will stop the Trigger from doing its job
                isTriggerActive = false;
                this.BackColor = currentColor;

                if (TriggerType != FormTrigger.TRIG_TYPE_RECURRING)
                {
                    myOperation.StopOperation();
                }                
                //This will start a new thread
                //triggerThread.Abort();
            }
           
        }
        private void mouseEnter(object sender, EventArgs e)
        {           
            if (isAlive && !triggerEditor.isDraggable)
            {
                this.BackColor = Color.White;
                this.BackColor = Color.Green;
                isTriggerActive = true;


                //Find out Trigger Type
                if (TriggerType == FormTrigger.TRIG_TYPE_FLUID)
                {
                    myOperation.HandleFluidTrigger();
                }
                else if (TriggerType == FormTrigger.TRIG_TYPE_RECURRING)
                {
                    myOperation.HandleRecurringTrigger(TimeDelayInSeconds,this);
                }
                else if (TriggerType == FormTrigger.TRIG_TYPE_TIMEDELAY)
                {
                    myOperation.HandleTimeDelayTrigger(TimeDelayInSeconds);
                }
                else if (TriggerType == FormTrigger.TRIG_TYPE_BLINK)
                {
                    myOperation.HandleTimeBlinkTrigger(TimeDelayInSeconds);
                }
                ////Initializes the Trigger Thread
                //triggerThread = new Thread(this.TriggerThreadMethod);
                //triggerThread.Start();

            }          
        }



        #region Thread Based Old Code
        void TriggerThreadMethod()
        {

            Console.WriteLine(" Trigger Type: " + TriggerType + " [Thread Active]");

            while (true)
            {
                this.ThreadLogic();
            }            
        }
        void ThreadLogic()
        {
            if (TriggerType == TRIG_TYPE_FLUID)
            {
                while (isTriggerActive)
                {
                    Thread.Sleep(1);
                    Console.WriteLine("Fluid Trigger Active");
                    if (!isTriggerActive)
                    {


                        actionLibrary.Keyboard_Key_A(ActionLibrary.KeyPress);


                        Console.WriteLine("Fluid Trigger Deactive");
                        break;
                    }
                }
            }
            else if (TriggerType == TRIG_TYPE_RECURRING)
            {
                bool isDown = false;
                while (isRecurringActive)
                {
                    Thread.Sleep(1);
                    Console.WriteLine("Recurring Trigger Active");
                }
            }
            else if (TriggerType == TRIG_TYPE_TIMEDELAY)
            {

                while (isTriggerActive)
                {
                    Console.WriteLine("Trigger Activated - Waiting for " + TimeDelayInSeconds + " seconds delay");
                    int timeInMiliSeconds = (Int32)(TimeDelayInSeconds * 1000);
                    Thread.Sleep(timeInMiliSeconds);
                    if (isTriggerActive)
                    {
                        while (true)
                        {
                            actionLibrary.Keyboard_Key_A(ActionLibrary.KeyPress);
                            Console.WriteLine("Trigger Active");
                            if (!isTriggerActive)
                            {
                                Console.WriteLine("Trigger Deactive");
                                break;
                            }
                        }
                    }
                    else Console.WriteLine("Time Delay Trigger Deactivated");
                }
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("Trigger Under Development");

            }
        }
        #endregion


        public void SetColor()
        {

            if (TriggerType == TRIG_TYPE_FLUID)
            {
                this.BackColor = Color.Red;
            }
            else if (TriggerType == TRIG_TYPE_RECURRING)
            {
                this.BackColor = Color.Cyan;
            }
            else if (TriggerType == TRIG_TYPE_TIMEDELAY)
            {
                this.BackColor = Color.Blue;
            }
            else if (TriggerType == TRIG_TYPE_BLINK)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.Black;
            }
            currentColor = this.BackColor;
        }
        
        #region Draggable Code
        Point lastPoint;
        private void DraggingOff(object sender, MouseEventArgs e)
        {
            if(triggerEditor.isDraggable)
                lastPoint = new Point(e.X, e.Y);
        }

        private void DraggingOn(object sender, MouseEventArgs e)
        {
            if (triggerEditor.isDraggable)
            {
                    if (e.Button == MouseButtons.Left)
                    {
                        var Left = this.Left + e.X - lastPoint.X;
                        var Top = this.Top + e.Y - lastPoint.Y;

                    if(Left + this.Width < triggerEditor.currentScreenWidth && Left > 0)
                        this.Left = Left;
                    if (Top + this.Height < triggerEditor.currentScreenHeight && Top > 0)
                        this.Top = Top;
                    }
            } 
        }
        #endregion

        public void toggleLogo()
        {
            if (picLogo.Visible)
                picLogo.Visible = false;
            else
                picLogo.Visible = true;
        }
    }

}
