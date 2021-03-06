﻿using System;
using ActionLibraryWindows;
using System.Threading;

namespace ETUI_TRIGGERS
{
    [Serializable]
    public class Operation
    {
        #region Class Variables

        ActionLibrary al = new ActionLibrary();
        Thread mythread;

       // public FormTrigger myTrigger;

        #endregion

        #region Constant Values

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
        public static int KEY_Q = 1017;
        public static int KEY_R = 1018;
        public static int KEY_S = 1019;
        public static int KEY_T = 1020;
        public static int KEY_U = 1021;
        public static int KEY_V = 1022;
        public static int KEY_W = 1023;
        public static int KEY_X = 1024;
        public static int KEY_Y = 1025;
        public static int KEY_Z = 1026;

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
        public string PowerShellCommand { get; set; }
        #endregion

        #region Core Operation Types
        public static int TYPE_INPUTKEY = 101;
        public static int TYPE_ACTION = 102;
        public static int TYPE_POWERSHELL = 103;
        #endregion

        #region Constructors
        public Operation(int action)                                //Constructor for [Application Execution] Operations
        {
            this.Type = Operation.TYPE_ACTION;
            this.Action = action;
            this.Key = -1;
        }
        public Operation(int action, string powerShellCommand)       //Constructor for [Shell Command Execution] Operation
        {
            this.Type = Operation.TYPE_POWERSHELL;
            this.Action = action;
            this.PowerShellCommand = powerShellCommand;
            this.Key = -1;
        }
        public Operation(int key, int keyEvent)                      //Constructor for [Keyboard/Mouse Input] Operations 
        {
            this.Type = Operation.TYPE_INPUTKEY;
            this.Key = key;
            this.KeyEvent = keyEvent;
            this.Action = -1;
        }

        #endregion

        #region Methods

     
        #region Perform Action Methods

        // Implemented  // 
        private void PerformAction(string powerShellCommand)
        {
           // System.Windows.Forms.MessageBox.Show(" about to call ActionLibrary : " + powerShellCommand);

            al.start_CMD_Commands(powerShellCommand);
        }

        // Implemented  // 
        private void PerformAction(int action)
        {

            #region System Actions
            if (action == Operation.SYSTEM_LOCKSCREEN)
            {
                al.system_LockScreen();
            }

            else if (action == Operation.SYSTEM_HIBERNATE)
            {
                al.system_Hibernate();
            }
            else if (action == Operation.SYSTEM_LOGOFF)
            {
                al.system_Logoff();
            }
            else if (action == Operation.SYSTEM_SHUTDOWN)
            {
                al.system_Shutdown();
            }
            else if (action == Operation.SYSTEM_SLEEP)
            {
                al.system_Sleep();
            }
            else if (action == Operation.SYSTEM_RESTART)
            {
                al.system_Restart();
            }
            #endregion

            #region Windows Actions

            else if (action == Operation.WIN_EXPLORER)
            {
                al.start_Explorer();
            }
            else if (action == Operation.WIN_TASKMANAGER)
            {
                al.start_TaskManager();
            }
            else if (action == Operation.WIN_COMMAND_PROMPT)
            {
                al.start_CommandPrompt();
            }
            else if (action == Operation.WIN_REGISTRY)
            {
                al.start_Registry();
            }
            else if (action == Operation.WIN_PROGRAM_AND_FEATURES)
            {
                al.start_ProgramAndFeatures();
            }
            else if (action == Operation.WIN_DESKTOP_SETTINGS)
            {
                al.start_DesktopSettings();
            }
            else if (action == Operation.WIN_POWER_OPTIONS)
            {
                al.start_PowerOptions();
            }
            else if (action == Operation.WIN_MOUSE_PROPERTIES)
            {
                al.start_MouseProperties();
            }
            else if (action == Operation.WIN_SNIPPING_TOOL)
            {
                al.start_SnippingTool();
            }
            else if (action == Operation.WIN_SYSTEM_CONFIG)
            {
                al.start_SystemConfig();
            }
            else if (action == Operation.WIN_DISK_MANAGEMENT)
            {
                al.start_DiskManagement();
            }
            else if (action == Operation.WIN_CALCULATOR)
            {
                al.start_Calculator();
            }
            else if (action == Operation.WIN_COMPUTER_MANAGEMENT)
            {
                al.start_ComputerManagement();
            }
            else if (action == Operation.WIN_CLEAN_MANAGER)
            {
                al.start_CleanManager();
            }
            else if (action == Operation.WIN_SYSTEM_PROPERTIES)
            {
                al.start_SystemProperties();
            }

            #endregion

            #region browser Actions

            else if (action == Operation.BROWSER_CHROME)
            {
                al.start_chrome();
            }
            else if (action == Operation.BROWSER_FIREFOX)
            {
                al.start_firefox();
            }
            else if (action == Operation.BROWSER_IEXPLORER)
            {
                al.start_InternetExplorer();
            }
            else if (action == Operation.BROWSER_EDGE)
            {
                al.start_EdgeBrowser();
            }
            #endregion

            else if (action == Operation.APPLICATION)
            {
                al.start_With_Path(this.ApplicationPath);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Problem with performing action! Location: Operation -> PerformAction(action)");
            }
        }


        // Implemented  //        
        private void PerformAction(int key, int keyEvent)
        {
            var AL_Option = GetKeyEventType(keyEvent);

            #region ALPHABETIC
            if (key == Operation.KEY_A)
            {
                al.Keyboard_Key_A(AL_Option);
            }
            else if (key == Operation.KEY_B)
            {
                al.Keyboard_Key_B(AL_Option);
            }
            else if (key == Operation.KEY_C)
            {
                al.Keyboard_Key_C(AL_Option);
            }
            else if (key == Operation.KEY_D)
            {
                al.Keyboard_Key_D(AL_Option);
            }
            else if (key == Operation.KEY_E)
            {
                al.Keyboard_Key_E(AL_Option);
            }
            else if (key == Operation.KEY_F)
            {
                al.Keyboard_Key_F(AL_Option);
            }
            else if (key == Operation.KEY_G)
            {
                al.Keyboard_Key_G(AL_Option);
            }
            else if (key == Operation.KEY_H)
            {
                al.Keyboard_Key_H(AL_Option);
            }
            else if (key == Operation.KEY_I)
            {
                al.Keyboard_Key_I(AL_Option);
            }
            else if (key == Operation.KEY_J)
            {
                al.Keyboard_Key_J(AL_Option);
            }
            else if (key == Operation.KEY_K)
            {
                al.Keyboard_Key_K(AL_Option);
            }
            else if (key == Operation.KEY_L)
            {
                al.Keyboard_Key_L(AL_Option);
            }
            else if (key == Operation.KEY_M)
            {
                al.Keyboard_Key_M(AL_Option);
            }
            else if (key == Operation.KEY_N)
            {
                al.Keyboard_Key_N(AL_Option);
            }
            else if (key == Operation.KEY_O)
            {
                al.Keyboard_Key_O(AL_Option);
            }
            else if (key == Operation.KEY_P)
            {
                al.Keyboard_Key_P(AL_Option);
            }
            else if (key == Operation.KEY_Q)
            {
                al.Keyboard_Key_Q(AL_Option);
            }
            else if (key == Operation.KEY_R)
            {
                al.Keyboard_Key_R(AL_Option);
            }
            else if (key == Operation.KEY_S)
            {
                al.Keyboard_Key_S(AL_Option);
            }
            else if (key == Operation.KEY_T)
            {
                al.Keyboard_Key_T(AL_Option);
            }
            else if (key == Operation.KEY_U)
            {
                al.Keyboard_Key_U(AL_Option);
            }
            else if (key == Operation.KEY_V)
            {
                al.Keyboard_Key_V(AL_Option);
            }
            else if (key == Operation.KEY_W)
            {
                al.Keyboard_Key_W(AL_Option);
            }
            else if (key == Operation.KEY_X)
            {
                al.Keyboard_Key_X(AL_Option);
            }
            else if (key == Operation.KEY_Y)
            {
                al.Keyboard_Key_Y(AL_Option);
            }
            else if (key == Operation.KEY_Z)
            {
                al.Keyboard_Key_Z(AL_Option);
            }

            #endregion

            #region Formatting Keys


            else if (key == Operation.KEY_ENTER)
            {
                al.Keyboard_Key_ENTER(AL_Option);
            }
            else if (key == Operation.KEY_TAB)
            {
                al.Keyboard_Key_TAB(AL_Option);
            }
            else if (key == Operation.KEY_SPACE)
            {
                al.Keyboard_Key_SPACE(AL_Option);
            }
            else if (key == Operation.KEY_BACKSPACE)
            {
                al.Keyboard_Key_BACKSPACE(AL_Option);
            }
            else if (key == Operation.KEY_INSERT)
            {
                al.Keyboard_Key_INSERT(AL_Option);
            }
            else if (key == Operation.KEY_DELETE)
            {
                al.Keyboard_Key_DELETE(AL_Option);
            }

            #endregion

            #region Control Keys


            else if (key == Operation.KEY_SHIFT)
            {
                al.Keyboard_Key_SHIFT(AL_Option);
            }

            else if (key == Operation.KEY_CTRL)
            {
                al.Keyboard_Key_CONTROL(AL_Option);
            }

            else if (key == Operation.KEY_ALT)
            {
                al.Keyboard_Key_ALT(AL_Option);
            }

            else if (key == Operation.KEY_DEL)
            {
                al.Keyboard_Key_DELETE(AL_Option);
            }

            else if (key == Operation.KEY_ESC)
            {
                al.Keyboard_Key_ESC(AL_Option);
            }

            #endregion

            #region Function Keys


            else if (key == Operation.KEY_F1)
            {
                al.Keyboard_Key_F1(AL_Option);
            }

            else if (key == Operation.KEY_F2)
            {
                al.Keyboard_Key_F2(AL_Option);
            }
            else if (key == Operation.KEY_F3)
            {
                al.Keyboard_Key_F3(AL_Option);
            }
            else if (key == Operation.KEY_F4)
            {
                al.Keyboard_Key_F4(AL_Option);
            }
            else if (key == Operation.KEY_F5)
            {
                al.Keyboard_Key_F5(AL_Option);
            }
            else if (key == Operation.KEY_F6)
            {
                al.Keyboard_Key_F6(AL_Option);
            }
            else if (key == Operation.KEY_F7)
            {
                al.Keyboard_Key_F7(AL_Option);
            }
            else if (key == Operation.KEY_F8)
            {
                al.Keyboard_Key_F8(AL_Option);
            }
            else if (key == Operation.KEY_F9)
            {
                al.Keyboard_Key_F9(AL_Option);
            }
            else if (key == Operation.KEY_F10)
            {
                al.Keyboard_Key_F10(AL_Option);
            }
            else if (key == Operation.KEY_F11)
            {
                al.Keyboard_Key_F11(AL_Option);
            }
            else if (key == Operation.KEY_F12)
            {
                al.Keyboard_Key_F12(AL_Option);
            }
            #endregion

            #region Navigation Keys

            else if (key == Operation.KEY_UP)
            {
                al.Keyboard_Key_UP(AL_Option);
            }
            else if (key == Operation.KEY_DOWN)
            {
                al.Keyboard_Key_DOWN(AL_Option);
            }
            else if (key == Operation.KEY_LEFT)
            {
                al.Keyboard_Key_LEFT(AL_Option);
            }
            else if (key == Operation.KEY_RIGHT)
            {
                al.Keyboard_Key_RIGHT(AL_Option);
            }

            else if (key == Operation.KEY_HOME)
            {
                al.Keyboard_Key_HOME(AL_Option);
            }

            else if (key == Operation.KEY_END)
            {
                al.Keyboard_Key_END(AL_Option);
            }

            else if (key == Operation.KEY_PAGEUP)
            {
                al.Keyboard_Key_PAGEUP(AL_Option);
            }

            else if (key == Operation.KEY_PAGEDOWN)
            {
                al.Keyboard_Key_PAGEDOWN(AL_Option);
            }

            #endregion

            #region ARITHEMATIC KEYS


            else if (key == Operation.KEY_PLUS)
            {
                al.Keyboard_Key_ADD(AL_Option);
            }

            else if (key == Operation.KEY_MINUS)
            {
                al.Keyboard_Key_SUBTRACT(AL_Option);
            }

            else if (key == Operation.KEY_DIVIDE)
            {
                al.Keyboard_Key_DIVIDE(AL_Option);
            }

            else if (key == Operation.KEY_MULTIPLY)
            {
                al.Keyboard_Key_MULTIPLY(AL_Option);
            }

            #endregion

            #region Mouse Keys

            else if (key == Operation.KEY_MOUSE_LEFT)
            {
                al.Mouse_Key_LEFT(AL_Option);
            }

            else if (key == Operation.KEY_MOUSE_MIDDLE)
            {
                al.Mouse_Key_MIDDLE(AL_Option);
            }

            else if (key == Operation.KEY_MOUSE_RIGHT)
            {
                al.Mouse_Key_RIGHT(AL_Option);
            }

            #endregion

            #region Numberic Keys
            else if (key == Operation.KEY_0)
            {
                al.Keyboard_Key_0(AL_Option);
            }
            else if (key == Operation.KEY_1)
            {
                al.Keyboard_Key_1(AL_Option);
            }
            else if (key == Operation.KEY_2)
            {
                al.Keyboard_Key_2(AL_Option);
            }
            else if (key == Operation.KEY_3)
            {
                al.Keyboard_Key_3(AL_Option);
            }
            else if (key == Operation.KEY_4)
            {
                al.Keyboard_Key_4(AL_Option);
            }
            else if (key == Operation.KEY_5)
            {
                al.Keyboard_Key_5(AL_Option);
            }
            else if (key == Operation.KEY_6)
            {
                al.Keyboard_Key_6(AL_Option);
            }
            else if (key == Operation.KEY_7)
            {
                al.Keyboard_Key_7(AL_Option);
            }
            else if (key == Operation.KEY_8)
            {
                al.Keyboard_Key_8(AL_Option);
            }
            else if (key == Operation.KEY_9)
            {
                al.Keyboard_Key_9(AL_Option);
            }
            #endregion
            else
            {
                System.Windows.Forms.MessageBox.Show("Error! could not perform action. Location: Operation.CS -> PerformAction(int key, int keyEvent)");
            }
        }

        #endregion

        #region Trigger Handlers
        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void HandleFluidTrigger()
        {
            var x = new ThreadedOperations(Operation.EVENT_KEYPRESS, this);
            if (this.Type==Operation.TYPE_INPUTKEY)
            {                
                mythread = new Thread(x.RunRecursive);
                mythread.Start();
            }
            else
            {
                Run(Operation.EVENT_KEYPRESS);
            }           
        }

        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void HandleTimeDelayTrigger(float timeDelay)
        {
            var tOp = new ThreadedOperations((int)Math.Round(timeDelay), Operation.EVENT_KEYPRESS,this);

            if (this.Type == Operation.TYPE_INPUTKEY)
            {
                mythread = new Thread(tOp.RunRecursive);
                mythread.Start();
            }
            else
            {
                mythread = new Thread(tOp.RunThread);
                mythread.Start();
            }           
        }
        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void HandleRecurringTrigger(float timeDelay,FormTrigger trigger)
        {
            if (!trigger.isRecurringActive)
            {
                var tOp = new ThreadedOperations((int)Math.Round(timeDelay), Operation.EVENT_KEYPRESS, this);

                if (this.Type == Operation.TYPE_INPUTKEY)
                {
                    mythread = new Thread(tOp.RunRecursive);
                    mythread.IsBackground = true;
                    mythread.Start();
                }
                else
                {
                    mythread = new Thread(tOp.RunThread);
                    mythread.IsBackground = true;
                    mythread.Start();
                }

                trigger.BackColor = System.Drawing.Color.Green;
                trigger.isRecurringActive = true;
            }
            else
            {
                var x = new ThreadedOperations((int)Math.Round(timeDelay));
                x.SleepOnly();

                trigger.BackColor = System.Drawing.Color.Red;
                if (mythread != null)
                {
                    mythread.Abort();
                }
                trigger.isRecurringActive = false;

            }

        }
        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void HandleTimeBlinkTrigger(float timeDelay)
        {
            var x = new ThreadedOperations((int)Math.Round(timeDelay),Operation.EVENT_KEYPRESS,this);

            var t = new Thread(x.RunThread);
            t.Start();
        }

        // NEED TO IMPLEMENT  ---------------------------------------------------------------------------------
        public void StopOperation()
        {
            if (mythread != null)
            {
                mythread.Abort();
            }
        }
        #endregion    

        public void Run(int KeyEvent)  //Method that Runs the show!
        {
            //find out the Operation type 
            int type = GetOperationType();

            //Handling the types
            if (type == Operation.TYPE_INPUTKEY)
            {
                PerformAction(this.Key, KeyEvent);
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



        int GetOperationType()  //Method that returns the current Operation Type 
        {
            switch (this.Type)
            {
                case 101:  //InputKeys
                    return Operation.TYPE_INPUTKEY;

                case 102: //Action
                    return Operation.TYPE_ACTION;

                case 103: //PowerShell
                    return Operation.TYPE_POWERSHELL;
            }
            return 0;
        }

        int GetKeyEventType(int KeyEvent)   //Method that returns the current Key Event Type
        {
            if (KeyEvent == Operation.EVENT_KEYDOWN)
            {
                return ActionLibrary.KeyDown;
            }
            if (KeyEvent == Operation.EVENT_KEYPRESS)
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

    class ThreadedOperations
    {
        int Delay { get; set; }
        int KeyEventType { get; set; }
        Operation myOperation;

        public ThreadedOperations(int delay)
        {
            this.Delay = delay;
        }

        public ThreadedOperations(int delay,int keyEventType, Operation operation)
        {
            this.Delay = delay;
            this.KeyEventType = keyEventType;
            this.myOperation = operation;
        }

        public ThreadedOperations(int keyEventType, Operation operation)
        {
            this.KeyEventType = keyEventType;
            this.myOperation = operation;
            this.Delay = 0;
        }

        public void RunThread()
        {
            Thread.Sleep(Delay * 1000);
            myOperation.Run(KeyEventType);                           
           
        }
        public void RunRecursive()
        {
            Thread.Sleep(Delay * 1000);
            while (true)
            {
                myOperation.Run(KeyEventType);
                Thread.Sleep(100);
            }
        }

        public void SleepOnly()
        {
            Thread.Sleep(Delay);
        }
    }

}
