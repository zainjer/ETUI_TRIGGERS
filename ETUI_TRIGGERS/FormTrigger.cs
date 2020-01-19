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
    public partial class FormTrigger : Form
    {
        public static int TRIG_TYPE_FLUID = 11;
        public static int TRIG_TYPE_RECURRING = 12;
        public static int TRIG_TYPE_TIMEDELAY = 13;
        public static int TRIG_TYPE_BLINK = 14;

        public int triggerType { get; set; }

   

        public FormTrigger(int triggerType)
        {
            InitializeComponent();
            this.triggerType = triggerType;
        }


        private void Trigger_Load(object sender, EventArgs e)
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
        }
     
    }
}
