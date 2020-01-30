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
    public partial class SelectTiggerToEdit : Form
    {

        string[] triggerNames;
        int selectedIndex;
        public TriggerInfo[] triggerList;
        public Dock dock;
       

        private void SelectTiggerToEdit_Load(object sender, EventArgs e)
        {
           
        }

        public SelectTiggerToEdit()
        {
            InitializeComponent();
        }

        
        private void BtnGoBack(object sender, EventArgs e)
        {
            dock.Show();
            this.Close();
        }

        private void BtnEditTrigger(object sender, EventArgs e)
        {
            var obj = triggerList[selectedIndex].obj.triggerEditor;

            
            obj.UpdateToEditMode(triggerList[selectedIndex].Name);
            obj.Text = "Edit Trigger: " + triggerList[selectedIndex].Name;
            obj.Show();
            this.Hide();
            dock.Show();
            // obj.setNameTypeOperation(triggerList[selectedIndex].Name, triggerList[selectedIndex].Type, triggerList[selectedIndex].Operation);            

        }

        private void cmbxRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedIndex = cmbxRange.SelectedIndex;
        }

        public void PopulateMe()
        {

            triggerNames = new string[triggerList.Length];

            for (int i = 0; i < triggerNames.Length; i++)
            {
                triggerNames[i] = triggerList[i].Name;
            }

            cmbxRange.Items.AddRange(triggerNames);
            cmbxRange.SelectedIndex = 0;
        }
    }
}
