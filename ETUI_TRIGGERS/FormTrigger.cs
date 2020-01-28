using System;
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

        bool isActive = false;

        Thread triggerThread;

        public int triggerType { get; set; }

        public FormTrigger(int triggerType)
        {
            InitializeComponent();
            this.triggerType = triggerType;
        }

        private void Trigger_Load(object sender, EventArgs e)
        {

            //Initializes the Trigger Thread
            triggerThread = new Thread(this.TriggerThreadMethod);

            //Give it Background property
            triggerThread.IsBackground = true;




            //Givs the thread a color based  on its type
            this.SetColor();

        }
        private void mouseHover(object sender, EventArgs e)
        {

        }

        private void FormTrigger_MouseLeave(object sender, EventArgs e)
        {
            
                 
            Console.WriteLine("Mouse Leave");
            this.BackColor = currentColor;

            //This starts a thread that gives System, some input           
            triggerThread.Abort();


        }
        private void mouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("Mouse Enter");
            this.BackColor = Color.Green;

            //this will kill the thread;
            triggerThread.Start();
        }

        void TriggerThreadMethod()
        {

            while (true)
            {
                while (isActive)
                {
                    Console.WriteLine("Thread Active");
                }                
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
    }

}
