using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActionLibraryWindows;


namespace ETUI_TRIGGERS
{
    [Serializable]
    public class Operation
    {
        #region Constant Values
        //Operation Types
        public static int TYPE_INPUTKEY = 101;
        public static int TYPE_ACTION = 102;
        public static int TYPE_POWERSHELL = 103;

        #region INPUT KEYS (KEYBOARD/MOUSE)
        //Event types 
        public static int EVENT_KEYPRESS = 501;
        public static int EVENT_KEYDOWN = 502;
        
        //Alphabets
        public static int KEY_A = 1001;
        public static int KEY_B = 1002;
        public static int KEY_C = 1003;
        public static int KEY_D = 1004;
        public static int KEY_E = 1005;
        public static int KEY_F = 1006;
        public static int KEY_G = 1007;
        public static int KEY_H = 1008;
        public static int KEY_I = 1009;
        public static int KEY_J = 1010;
        public static int KEY_K = 1011;
        public static int KEY_L = 1012;
        public static int KEY_M = 1013;
        public static int KEY_N = 1014;
        public static int KEY_O = 1015;
        public static int KEY_P = 1016;
        public static int KEY_Q = 1016;
        public static int KEY_R = 1016;
        public static int KEY_S = 1017;
        public static int KEY_T = 1018;
        public static int KEY_U = 1019;
        public static int KEY_V = 1020;
        public static int KEY_W = 1021;
        public static int KEY_X = 1022;
        public static int KEY_Y = 1023;
        public static int KEY_Z = 1024;

        //Formatting
        public static int KEY_ENTER = 2001;
        public static int KEY_TAB = 2002;
        public static int KEY_SPACE = 2003;
        public static int KEY_BACKSPACE = 2004;
        public static int KEY_INSERT = 2005;
        public static int KEY_DELETE = 2006;

        //Navigation
        public static int KEY_UP = 3001;
        public static int KEY_DOWN = 3002;
        public static int KEY_LEFT = 3003;
        public static int KEY_RIGHT = 3004;
        public static int KEY_HOME = 3005;
        public static int KEY_END = 3006;
        public static int KEY_PAGEUP = 3007;
        public static int KEY_PAGEDOWN = 3008;

        //Numbers
        public static int KEY_0 = 4001;
        public static int KEY_1 = 4002;
        public static int KEY_2 = 4003;
        public static int KEY_3 = 4004;
        public static int KEY_4 = 4005;
        public static int KEY_5 = 4006;
        public static int KEY_6 = 4007;
        public static int KEY_7 = 4008;
        public static int KEY_8 = 4009;
        public static int KEY_9 = 4010;

        //Function Keys
        public static int KEY_F1 = 5001;
        public static int KEY_F2 = 5002;
        public static int KEY_F3 = 5003;
        public static int KEY_F4 = 5004;
        public static int KEY_F5 = 5005;
        public static int KEY_F6 = 5006;
        public static int KEY_F7 = 5007;
        public static int KEY_F8 = 5008;
        public static int KEY_F9 = 5009;
        public static int KEY_F10 = 5010;
        public static int KEY_F11 = 5011;
        public static int KEY_F12 = 5012;

        //Control Keys
        public static int KEY_SHIFT = 6001;
        public static int KEY_CTRL = 6002;
        public static int KEY_ALT = 6003;
        public static int KEY_DEL = 6004;
        public static int KEY_ESC = 6005;

        //Arithematic Keys
        public static int KEY_MINUS = 7001;
        public static int KEY_PLUS = 7002;
        public static int KEY_DIVIDE = 7003;
        public static int KEY_MULTIPLY = 7004;

        //Mouse Keys
        public static int KEY_MOUSE_LEFT = 8001;
        public static int KEY_MOUSE_MIDDLE = 8002;
        public static int KEY_MOUSE_RIGHT = 8003;
        #endregion

        #region RUN Actions and Programs

        //System Actions
        public static int SYSTEM_LOCKSCREEN = 1101;
        public static int SYSTEM_SLEEP = 1102;
        public static int SYSTEM_HIBERNATE = 1103;
        public static int SYSTEM_LOGOFF = 1104;
        public static int SYSTEM_SHUTDOWN = 1105;
        public static int SYSTEM_RESTART = 1106;

        //Internet Browsers
        public static int BROWSER_CHROME = 1201;
        public static int BROWSER_FIREFOX = 1202;
        public static int BROWSER_EDGE = 1203;
        public static int BROWSER_IEXPLORER = 1204;

        //Windows Programs
        public static int WIN_TASKMANAGER = 1301;
        public static int WIN_EXPLORER = 1302;
        public static int WIN_COMMAND_PROMPT = 1303;
        public static int WIN_REGISTRY = 1304;
        public static int WIN_PROGRAM_AND_FEATURES = 1305;
        public static int WIN_DESKTOP_SETTINGS = 1306;
        public static int WIN_POWER_OPTIONS = 1307;
        public static int WIN_MOUSE_PROPERTIES = 1308;
        public static int WIN_SNIPPING_TOOL = 1309;
        public static int WIN_SYSTEM_CONFIG = 1310;
        public static int WIN_DISK_MANAGEMENT = 1311;
        public static int WIN_CALCULATOR = 1312;
        public static int WIN_COMPUTER_MANAGEMENT = 1313;
        public static int WIN_CLEAN_MANAGER = 1314;
        public static int WIN_SYSTEM_PROPERTIES = 1315;

        //Custom Application
        public static int APPLICATION = 1400;

        //Shell Command
        public static int POWERSHELL_COMMAND = 1500;
        #endregion
        #endregion

        #region Properties
        public int Type { get; set; }
        public int Action { get; set; }
        public int Key { get; set; }
        public int KeyEvent { get; set; }
        public string ApplicationPath { get; set; }
        public FormTrigger Trigger;
        public string PowerShellCommand { get; set; }
        #endregion
        
        #region Constructors
        public Operation(int action)
        {
            this.Type = Operation.TYPE_ACTION;
            this.Action = action;
        }
        public Operation(int key,int keyEvent)
        {
            this.Type = Operation.TYPE_INPUTKEY;
            this.Key = key;
            this.KeyEvent = keyEvent;
        }
        ActionLibrary al = new ActionLibrary();
        #endregion
        
        #region Methods



        public void HandleFluidTrigger()
        {
            //find out the trigger type 
            int type = GetOperationType();

            //Handling the types
            if (type == Operation.TYPE_INPUTKEY)
            {
                PerformAction(this.Key, this.KeyEvent);
            }
            else if(type == Operation.TYPE_ACTION)
            {
                PerformAction(this.Action);
            }
            else if(type == Operation.TYPE_POWERSHELL)
            {
                PerformAction(this.PowerShellCommand);
            }
            else  // if The returning value is 0
            {

            }
        }


        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        private void PerformAction(string powerShellCommand)
        {

        }

        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        private void PerformAction(int action)
        {

        }

        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        // I think this method will compare what actually 'key' is and then perform the specific action.  
        private void PerformAction(int key, int keyEvent)
        {
            var AL_Option = GetKeyEventType();
            if (key == Operation.KEY_A)
            {
                al.Keyboard_Key_A(AL_Option);
            }
        }
        


        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void HandleTimeDelayTrigger(float timeDelay)
        {

        }


        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void HandleRecurring(float timeDelay)
        {

        }

        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void HandleTimeBlink(float timeDelay)
        {

        }


        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void StopOperation()
        {
            //REMOVE THIS LINE
            al.Keyboard_Key_A(ActionLibrary.KeyUp);

        }


        //Method that'll run on our test button in OperationForms
        public void Run()
        {
            //find out the trigger type 
            int type = GetOperationType();

            //Handling the types
            if (type == Operation.TYPE_INPUTKEY)
            {
                PerformAction(this.Key, this.KeyEvent);
            }
            else if (type == Operation.TYPE_ACTION)
            {
                PerformAction(this.Action);
            }
            else if (type == Operation.TYPE_POWERSHELL)
            {
                PerformAction(this.PowerShellCommand);
            }
            else  // if The returning value is 0
            {
                System.Windows.Forms.MessageBox.Show("Operation has no TYPE!");
            }
        }

        int GetOperationType()
        {
            switch (this.Type)
            {
                case 101:  //InputKeys
                    return Operation.TYPE_INPUTKEY;
                    break;

                case 102: //Action
                    return Operation.TYPE_ACTION;
                    break;

                case 103: //PowerShell
                    return Operation.TYPE_POWERSHELL;
                    break;
            }
            return 0;
        }

        int GetKeyEventType()
        {
            if(this.KeyEvent == Operation.EVENT_KEYDOWN)
            {
                return ActionLibrary.KeyDown;
            }
            if (this.KeyEvent == Operation.EVENT_KEYPRESS)
            {
                return ActionLibrary.KeyPress;
            }
            else
            {
                return ActionLibrary.KeyUp;
            }
        }
        #endregion
    }
}
