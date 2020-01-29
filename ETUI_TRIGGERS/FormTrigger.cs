﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ETUI_TRIGGERS
{
    public partial class FormTrigger : Form
    {
        public static int TRIG_TYPE_FLUID = 11;
        public static int TRIG_TYPE_RECURRING = 12;
        public static int TRIG_TYPE_TIMEDELAY = 13;
        public static int TRIG_TYPE_BLINK = 14;
        Color currentColor;

        bool isTriggerActive = false;
        public bool isRecurringActive { get; set; } 
        Thread triggerThread;


        public int triggerType { get; set; }
        public float timeDelayInSeconds { get; set; }

        public FormTrigger(int triggerType)
        {
            InitializeComponent();
            this.triggerType = triggerType;
        }

        private void Trigger_Load(object sender, EventArgs e)
        {

            //Give the thread a color based  on its type
            this.SetColor();

            //Initializes the Trigger Thread
            triggerThread = new Thread(this.TriggerThreadMethod);

            //Give it Background property
            //triggerThread.IsBackground = true;

            //this will start the TriggerThread;
            triggerThread.Start();
        }

        private void FormTrigger_MouseLeave(object sender, EventArgs e)
        {   
            //This will stop the Trigger from doing its job
            isTriggerActive = false;

           // Console.WriteLine("Mouse Leave");

            this.BackColor = currentColor;
        }
        private void mouseEnter(object sender, EventArgs e)
        {
           // Console.WriteLine("Mouse Enter");

            this.BackColor = Color.Green;

            //Will Make the trigger active
            isTriggerActive = true;
        }

        void TriggerThreadMethod()
        {

            Console.WriteLine(" Trigger Type" + triggerType + " Active");

            while (true)
            {
                this.ThreadLogic();

                //while (isTriggerActive)
                //{
                //    Thread.Sleep(1);
                //    Console.WriteLine("Thread Active");
                //    if (!isTriggerActive)
                //    {
                //        Console.WriteLine("Thread Dead");
                //        break;
                //    }
                //}
            }            
        }    
        void SetColor()
        {

            if (triggerType == TRIG_TYPE_FLUID)
            {
                this.BackColor = Color.Red;
            }
            else if (triggerType == TRIG_TYPE_RECURRING)
            {
                this.BackColor = Color.Green;
            }
            else if (triggerType == TRIG_TYPE_TIMEDELAY)
            {
                this.BackColor = Color.Blue;
            }
            else if (triggerType == TRIG_TYPE_BLINK)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.Black;
            }
            currentColor = this.BackColor;
        }
        void ThreadLogic()
        {
            if (triggerType == TRIG_TYPE_FLUID)
            {
                while (isTriggerActive)
                {
                    Thread.Sleep(1);
                    Console.WriteLine("Fluid Trigger Active");
                    if (!isTriggerActive)
                    {
                        Console.WriteLine("Fluid Trigger Deactive");
                        break;
                    }
                }
            }else if(triggerType == TRIG_TYPE_RECURRING)
            {
                while (isRecurringActive)
                {
                    Thread.Sleep(1);
                    Console.WriteLine("Recurring Trigger Active");
                }
            }else if(triggerType == TRIG_TYPE_TIMEDELAY)
            {
              
                while (isTriggerActive)
                {
                    Console.WriteLine(triggerType + "Trigger Activated - Waiting for " + timeDelayInSeconds + " seconds delay");
                    int timeInMiliSeconds = (Int32)(timeDelayInSeconds * 1000);
                    Thread.Sleep(timeInMiliSeconds);
                    if (isTriggerActive)
                    {
                        while (true)
                        {
                            Thread.Sleep(1);
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
                Console.WriteLine("Blink Trigger Under Development");
                
            }
            


        }       
    }

}