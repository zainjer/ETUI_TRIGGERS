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
        public TriggerInfo[] triggerArray;
        public List<TriggerInfo> triggerList;

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
            var obj = triggerArray[selectedIndex].obj.triggerEditor;
            
            obj.UpdateToEditMode(triggerArray[selectedIndex].Name);
            obj.Text = "Edit Trigger: " + triggerArray[selectedIndex].Name;
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
            triggerNames = new string[triggerArray.Length];

            for (int i = 0; i < triggerNames.Length; i++)
            {
                triggerNames[i] = triggerArray[i].Name;
            }
            cmbxRange.Items.AddRange(triggerNames);
            cmbxRange.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(triggerArray.Length  == 1)
            {
                MessageBox.Show("Cannot delete last available item."+"","Cannot Empty List",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //code for deleting a trigger currently selected in the list
                TriggerInfo itemToDelete = triggerArray[selectedIndex];
                triggerList.Remove(itemToDelete);

                //this closes the trigger
                itemToDelete.obj.Close();

                //make sure the list is updated after the trigger is deleted.
                triggerArray = triggerList.ToArray();
                cmbxRange.Items.Clear();
                PopulateMe();
            }
            
           

            

        }
    }
}
