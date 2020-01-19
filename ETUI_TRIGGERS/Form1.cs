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
        public CreateNewTrigger()
        {
            InitializeComponent();
        }

        private void btnCreateTrigger_Click(object sender, EventArgs e)
        {
            Trigger obj = new Trigger();

            int positionX, positionY;

            positionX = int.Parse(txtbxXposition.Text);
            positionY = int.Parse(txtbxYposition.Text);

            
   
            obj.Show();
            obj.Location = new Point(positionX, positionY);
            obj.Size = new Size(positionX, positionY);
        }
    }
}
