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

        public Operation operation;
        
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
            "End",
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

        string[] rangeArithematic = new string[]
        {
            "-",
            "+",
            "/",
            "*"
        };

        string[] rangeMouseButton = new string[]
        {
            "Left Mouse button",
            "Right Mouse button",
            "Middle Mouse button"

        };

        string[] rangeEventType = new string[]
        {
            "Key Press",            
            "Key Down"

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


        //Form Constructor
        public SelectOperation()
        {
            InitializeComponent();

            #region Adding Ranges to Dropdown menus
            cbAlphabets.Items.AddRange(rangeAlphabets);
            cbAlphabets.SelectedIndex = 0;
           
            cbFormatting.Items.AddRange(rangeFormatting);
            cbFormatting.SelectedIndex = 0;

            cbNavigation.Items.AddRange(rangeNavigation);
            cbNavigation.SelectedIndex = 0;

            cbNumbers.Items.AddRange(rangeNumber);
            cbNumbers.SelectedIndex = 0;

            cbFuntionKeys.Items.AddRange(rangeFuncKey);
            cbFuntionKeys.SelectedIndex = 0;

            cbControlKeys.Items.AddRange(rangeCtrlKey);
            cbControlKeys.SelectedIndex = 0;

            cbArithematic.Items.AddRange(rangeArithematic);
            cbArithematic.SelectedIndex = 0;

            cbMouseButton.Items.AddRange(rangeMouseButton);
            cbMouseButton.SelectedIndex = 0;

            cbEventType.Items.AddRange(rangeEventType);
            cbEventType.SelectedIndex = 0;

            cbInternetBrowser.Items.AddRange(rangeIntBrowser);
            cbInternetBrowser.SelectedIndex = 0;

            cbSystemActions.Items.AddRange(rangeSystemActions);
            cbSystemActions.SelectedIndex = 0;

            cbWindowsPrograms.Items.AddRange(rangeWindowsPrograms);
            cbWindowsPrograms.SelectedIndex = 0;
            #endregion

            rbKeyboardMouse.Checked = true;

        }

        #region Methods for UI

        void DisableAll()
        {
            cbAlphabets.Enabled = false;
            cbFuntionKeys.Enabled = false;
            cbFormatting.Enabled = false;
            cbControlKeys.Enabled = false;
            cbNavigation.Enabled = false;
            cbArithematic.Enabled = false;
            cbNumbers.Enabled = false;
            cbMouseButton.Enabled = false;            
            cbSystemActions.Enabled = false;
            cbInternetBrowser.Enabled = false;
            cbWindowsPrograms.Enabled = false;
            tbApplicationPath.Enabled = false;
            rtbPowershellCommands.Enabled = false;
        }

        private void SelectOperation_Load(object sender, EventArgs e)
        {
                
        }    
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbKeyboardMouse_CheckedChanged(object sender, EventArgs e)
        {
            gbKeyboardMouse.Enabled = true;
            gbPowershell.Enabled = false;
            gbRun.Enabled = false;
            rbAlphabets.Checked = true;
        }

        private void rbRun_CheckedChanged(object sender, EventArgs e)
        {
            gbKeyboardMouse.Enabled = false;
            gbPowershell.Enabled = false;
            gbRun.Enabled = true;

            rbSystemActions.Checked = true;
        }

        private void rbPowershell_CheckedChanged(object sender, EventArgs e)
        {
            gbKeyboardMouse.Enabled = false;
            gbPowershell.Enabled = true;
            gbRun.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbAlphabets.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbFormatting.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbNavigation.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbNumbers.Enabled = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbFuntionKeys.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbControlKeys.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbArithematic.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbMouseButton.Enabled = true;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            if (rbApplication.Checked)
            {
                MessageBox.Show("Add OpenFileDialog here");
            }                
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbSystemActions.Enabled = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbInternetBrowser.Enabled = true;

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            cbWindowsPrograms.Enabled = true;
        }

        private void btnCreateOperation_Click(object sender, EventArgs e)
        {
            ConstructOperation();            
        }

        #endregion


        #region Operation Generator
        void ConstructOperation()
        {
            if (rbKeyboardMouse.Checked)
            {
                KeyboardMouseOperationHandler();
            }
            else if (rbRun.Checked)
            {
                RunOperationHandler();
            }
            else if (rbPowershell.Checked)
            {
                PowerShellOperationHandler();
            }
            else
            {
                MessageBox.Show("Please Select an Operation Type");
            }

            MessageBox.Show("Operation Type: " + operation.Type + " Operation Key: " + operation.Key + " with KeyEvent: " + operation.KeyEvent);

        }
        void PowerShellOperationHandler()
        {
            Operation op = new Operation(Operation.POWERSHELL_COMMAND);
            op.PowerShellCommand = rtbPowershellCommands.Text;
            this.operation = op;
        }
        void RunOperationHandler()
        {
            if (rbSystemActions.Checked)
            {
                switch (cbSystemActions.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.SYSTEM_LOCKSCREEN);                                
                        break;
                    case 1:
                        operation = new Operation(Operation.SYSTEM_SLEEP);                                                        
                        break;
                    case 2:
                        operation = new Operation(Operation.SYSTEM_HIBERNATE);
                        break;
                    case 3:
                        operation = new Operation(Operation.SYSTEM_LOGOFF);
                        break;
                    case 4:
                        operation = new Operation(Operation.SYSTEM_SHUTDOWN);
                        break;
                    case 5:
                        operation = new Operation(Operation.SYSTEM_RESTART);
                        break;
                }
            }
            else if (rbInternet.Checked)
            {
                switch (cbInternetBrowser.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.BROWSER_CHROME);
                        break;
                    case 1:
                        operation = new Operation(Operation.BROWSER_FIREFOX);
                        break;
                    case 2:
                        operation = new Operation(Operation.BROWSER_EDGE);
                        break;
                    case 3:
                        operation = new Operation(Operation.BROWSER_IEXPLORER);
                        break;
                      
                }
            }
            else if (rbWindowsProgram.Checked)
            {
                switch (cbWindowsPrograms.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.WIN_TASKMANAGER);
                            break;
                    case 1:
                        operation = new Operation(Operation.WIN_EXPLORER);
                        break;
                    case 2:
                        operation = new Operation(Operation.WIN_COMMAND_PROMPT);
                        break;
                    case 3:
                        operation = new Operation(Operation.WIN_REGISTRY);
                        break;
                    case 4:
                        operation = new Operation(Operation.WIN_PROGRAM_AND_FEATURES);
                        break;
                    case 5:
                        operation = new Operation(Operation.WIN_DESKTOP_SETTINGS);
                        break;
                    case 6:
                        operation = new Operation(Operation.WIN_POWER_OPTIONS);
                        break;
                    case 7:
                        operation = new Operation(Operation.WIN_MOUSE_PROPERTIES);
                        break;
                    case 8:
                        operation = new Operation(Operation.WIN_SNIPPING_TOOL);
                        break;                       
                    case 9:
                        operation = new Operation(Operation.WIN_SYSTEM_CONFIG);
                        break;
                    case 10:
                        operation = new Operation(Operation.WIN_DISK_MANAGEMENT);
                        break;
                    case 11:
                        operation = new Operation(Operation.WIN_CALCULATOR);
                        break;
                    case 12:
                        operation = new Operation(Operation.WIN_COMPUTER_MANAGEMENT);
                        break;
                    case 13:
                        operation = new Operation(Operation.WIN_CLEAN_MANAGER);
                        break;
                    case 14:
                        operation = new Operation(Operation.WIN_SYSTEM_PROPERTIES);
                        break;                           
                }
            }
            else if (rbApplication.Checked)
            {
                operation = new Operation(Operation.APPLICATION);                
                operation.ApplicationPath = tbApplicationPath.Text;
                MessageBox.Show("Application Path:"+tbApplicationPath.Text);
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }
            //MessageBox.Show("Type: " + operation.Type + " Action: " + operation.Action);
        }
        void KeyboardMouseOperationHandler()
        {

            //Getting KeyEvent
            int keyEvt = GetKeyEvent();

            if (rbAlphabets.Checked)
            {
                switch (cbAlphabets.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_A, keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_B, keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_C, keyEvt);
                        break;
                    case 3:
                        operation = new Operation(Operation.KEY_D, keyEvt);
                        break;
                    case 4:
                        operation = new Operation(Operation.KEY_E, keyEvt);
                        break;
                    case 5:
                        operation = new Operation(Operation.KEY_F, keyEvt);
                        break;
                    case 6:
                        operation = new Operation(Operation.KEY_G, keyEvt);
                        break;
                    case 7:
                        operation = new Operation(Operation.KEY_H, keyEvt);
                        break;
                    case 8:
                        operation = new Operation(Operation.KEY_I, keyEvt);
                        break;
                    case 9:
                        operation = new Operation(Operation.KEY_J, keyEvt);
                        break;
                    case 10:
                        operation = new Operation(Operation.KEY_K, keyEvt);
                        break;
                    case 11:
                        operation = new Operation(Operation.KEY_L, keyEvt);
                        break;
                    case 12:
                        operation = new Operation(Operation.KEY_M, keyEvt);
                        break;
                    case 13:
                        operation = new Operation(Operation.KEY_N, keyEvt);
                        break;
                    case 14:
                        operation = new Operation(Operation.KEY_O, keyEvt);
                        break;
                    case 15:
                        operation = new Operation(Operation.KEY_P, keyEvt);
                        break;
                    case 16:
                        operation = new Operation(Operation.KEY_Q, keyEvt);
                        break;
                    case 17:
                        operation = new Operation(Operation.KEY_R, keyEvt);
                        break;
                    case 18:
                        operation = new Operation(Operation.KEY_S, keyEvt);
                        break;
                    case 19:
                        operation = new Operation(Operation.KEY_T, keyEvt);
                        break;
                    case 20:
                        operation = new Operation(Operation.KEY_U, keyEvt);
                        break;
                    case 21:
                        operation = new Operation(Operation.KEY_V, keyEvt);
                        break;
                    case 22:
                        operation = new Operation(Operation.KEY_W, keyEvt);
                        break;
                    case 23:
                        operation = new Operation(Operation.KEY_X, keyEvt);
                        break;
                    case 24:
                        operation = new Operation(Operation.KEY_Y, keyEvt);
                        break;
                    case 25:
                        operation = new Operation(Operation.KEY_Z, keyEvt);
                        break;

                }
            }
            else if (rbFormatting.Checked)
            {
                switch (cbFormatting.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_ENTER,keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_TAB,keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_SPACE, keyEvt);
                        break;
                    case 3:
                        operation = new Operation(Operation.KEY_BACKSPACE, keyEvt);
                        break;
                    case 4:
                        operation = new Operation(Operation.KEY_INSERT, keyEvt);
                        break;
                    case 5:
                        operation = new Operation(Operation.KEY_DELETE, keyEvt);
                        break;
                }
            }
            else if (rbNavigation.Checked)
            {
                switch (cbNavigation.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_UP, keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_DOWN, keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_LEFT, keyEvt);
                        break;
                    case 3:
                        operation = new Operation(Operation.KEY_RIGHT, keyEvt);
                        break;
                    case 4:
                        operation = new Operation(Operation.KEY_HOME, keyEvt);
                        break;
                    case 5:
                        operation = new Operation(Operation.KEY_END, keyEvt);
                        break;
                    case 6:
                        operation = new Operation(Operation.KEY_PAGEUP, keyEvt);
                        break;
                    case 7:
                        operation = new Operation(Operation.KEY_PAGEDOWN, keyEvt);
                        break;
                }
            }
            else if (rbNumbers.Checked)
            {
                switch (cbNumbers.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_0, keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_1, keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_2, keyEvt);
                        break;
                    case 3:
                        operation = new Operation(Operation.KEY_3, keyEvt);
                        break;
                    case 4:
                        operation = new Operation(Operation.KEY_4, keyEvt);
                        break;
                    case 5:
                        operation = new Operation(Operation.KEY_5, keyEvt);
                        break;
                    case 6:
                        operation = new Operation(Operation.KEY_6, keyEvt);
                        break;
                    case 7:
                        operation = new Operation(Operation.KEY_7, keyEvt);
                        break;
                    case 8:
                        operation = new Operation(Operation.KEY_8, keyEvt);
                        break;
                    case 9:
                        operation = new Operation(Operation.KEY_9, keyEvt);
                        break;
                }
            }
            else if (rbFunctionKeys.Checked)
            {
                switch (cbFuntionKeys.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_F1, keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_F2, keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_F3, keyEvt);
                        break;
                    case 3:
                        operation = new Operation(Operation.KEY_F4, keyEvt);
                        break;
                    case 4:
                        operation = new Operation(Operation.KEY_F5, keyEvt);
                        break;
                    case 5:
                        operation = new Operation(Operation.KEY_F6, keyEvt);
                        break;
                    case 6:
                        operation = new Operation(Operation.KEY_F7, keyEvt);
                        break;
                    case 7:
                        operation = new Operation(Operation.KEY_F8, keyEvt);
                        break;
                    case 8:
                        operation = new Operation(Operation.KEY_F9, keyEvt);
                        break;
                    case 9:
                        operation = new Operation(Operation.KEY_F10, keyEvt);
                        break;
                    case 10:
                        operation = new Operation(Operation.KEY_F11, keyEvt);
                        break;
                    case 11:
                        operation = new Operation(Operation.KEY_F12, keyEvt);
                        break;
                }
            }
            else if (rbControlKeys.Checked)
            {
                switch (cbControlKeys.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_SHIFT, keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_CTRL, keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_ALT, keyEvt);
                        break;
                    case 3:
                        operation = new Operation(Operation.KEY_DEL, keyEvt);
                        break;
                    case 4:
                        operation = new Operation(Operation.KEY_ESC, keyEvt);
                        break;
                }
            }
            else if (rbArithematic.Checked)
            {
                switch (cbArithematic.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_MINUS, keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_PLUS, keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_DIVIDE, keyEvt);
                        break;
                    case 3:
                        operation = new Operation(Operation.KEY_MULTIPLY, keyEvt);
                        break;                    
                }
            }
            else if (rbMouseButton.Checked)
            {
                switch (cbMouseButton.SelectedIndex)
                {
                    case 0:
                        operation = new Operation(Operation.KEY_MOUSE_LEFT,keyEvt);
                        break;
                    case 1:
                        operation = new Operation(Operation.KEY_MOUSE_MIDDLE, keyEvt);
                        break;
                    case 2:
                        operation = new Operation(Operation.KEY_MOUSE_RIGHT, keyEvt);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }
    }

        private int GetKeyEvent()
        {
            if (cbEventType.SelectedIndex == 0)
                return Operation.EVENT_KEYPRESS;
            else
                return Operation.EVENT_KEYDOWN;
        }
        #endregion
    }

}

