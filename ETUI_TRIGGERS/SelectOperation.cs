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
    public partial class SelectOperation : Form
    {
        #region Value Arrays

        string[] rangeAlphabets = new string[]
        {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"
        };

        string[] rangeFormatting = new string[]
        {
            "Enter",
            "Tab",
            "Space",
            "Backspace",
            "Insert",
            "Delete"

        };

        string[] rangeNavigation = new string[]
        {
            "Up",
            "Left",
            "Down",
            "Right",
            "Home",
            "Page-up",
            "Page-down"
        };

        string[] rangeNumber = new string[]
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"
        };

        string[] rangeFuncKey = new string[]
        {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"

        };

        string[] rangeCtrlKey = new string[]
        {
            "Shift",
            "Ctrl",
            "Alt",
            "Del",
            "Esc"
        };

        string[] rangeOther = new string[]
        {
            "-",
            "+",
            "/",
            "*",
            "!",
            "@",
            "#",
            "$",
        };

        string[] rangeMouse = new string[]
        {
            "Left Mouse Button",
            "Right Mouse Button",
            "Middle Mouse Button"

        };

        string[] rangeEventType = new string[]
        {
            "KeyDown",            
            "KeyPress"

        };

        string[] rangeIntBrowser = new string[]
        {
            "Chrome",
            "Firefox",
            "Edge",
            "Internet Explorer",

        };

        string[] rangeSystemActions = new string[]
        {
           "Lock Screen",
           "Sleep",
           "Hibernate",
           "Log Off",
           "Shut Down",
           "Restart"
        };

        string[] rangeWindowsPrograms = new string[] {

            "Task Manager",
            "Explorer",
            "Command Prompt",
            "Registry",
            "Programs and Features",
            "Desktop Settings",
            "Power Options",
            "Mouse Properties",
            "Snipping Tool",
            "System Config",
            "Disk Management",
            "Calculator",
            "Computer Management",
            "Clean Manager",
            "System Properties"
        };

        #endregion

        public SelectOperation()
        {
            InitializeComponent();

            #region Adding Ranges to Dropdown menus
            comboBox1.Items.AddRange(rangeAlphabets);
            comboBox1.SelectedIndex = 0;
           
            comboBox3.Items.AddRange(rangeFormatting);
            comboBox3.SelectedIndex = 0;

            comboBox5.Items.AddRange(rangeNavigation);
            comboBox5.SelectedIndex = 0;

            comboBox7.Items.AddRange(rangeNumber);
            comboBox7.SelectedIndex = 0;

            comboBox2.Items.AddRange(rangeFuncKey);
            comboBox2.SelectedIndex = 0;

            comboBox4.Items.AddRange(rangeCtrlKey);
            comboBox4.SelectedIndex = 0;

            comboBox6.Items.AddRange(rangeOther);
            comboBox6.SelectedIndex = 0;

            comboBox8.Items.AddRange(rangeMouse);
            comboBox8.SelectedIndex = 0;

            comboBox9.Items.AddRange(rangeEventType);
            comboBox9.SelectedIndex = 0;

            comboBox11.Items.AddRange(rangeIntBrowser);
            comboBox11.SelectedIndex = 0;

            comboBox10.Items.AddRange(rangeSystemActions);
            comboBox10.SelectedIndex = 0;

            comboBox12.Items.AddRange(rangeWindowsPrograms);
            comboBox12.SelectedIndex = 0;
            #endregion

        }

        private void SelectOperation_Load(object sender, EventArgs e)
        {
                
        }

    
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
