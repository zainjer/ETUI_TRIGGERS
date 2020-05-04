using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace ActionLibraryWindows
{
    public class ActionLibrary
    {
       
        //Constants for checking Key event type
        public static int KeyPress = 0;
        public static int KeyDown = 1;
        public static int KeyUp = 2;
        
        //Input Simulator Object;
        InputSimulator inputSimulator = new InputSimulator();

        public void start_With_Path(string path)
        {
            Program_Start(path);
        }
        
        public void start_CMD_Commands(string commands)
        {
            var p = new System.Diagnostics.Process();

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C "+commands;
            p.Start();
        }

        #region Windows Programs and Utilities Methods
        public void start_Explorer() { Program_Start("Explorer"); }
        public void start_TaskManager() { Program_Start("taskmgr"); }
        public void start_CommandPrompt() { Program_Start("cmd"); }
        public void start_Registry() { Program_Start("regedit"); }
        public void start_ProgramAndFeatures() { Program_Start("appwiz.cpl"); }
        public void start_DesktopSettings() { Program_Start("desk.cpl"); }
        public void start_PowerOptions() { Program_Start("powercfg.cpl"); }
        public void start_MouseProperties() { Program_Start("main.cpl"); }
        public void start_SnippingTool() { Program_Start("snippingtool"); }
        public void start_SystemConfig() { Program_Start("msconfig"); }
        public void start_DiskManagement() { Program_Start("diskmgmt.msc"); }
        public void start_Calculator() { Program_Start("calc"); }
        public void start_ComputerManagement() { Program_Start("compmgmt.msc"); }
        public void start_CleanManager(){ Program_Start("cleanmgr");}
        public void start_SystemProperties(){ Program_Start("sysdm.cpl");}
        #endregion
        #region browser Methods
        public void start_chrome() { Program_Start("chrome"); }
        public void start_firefox() { Program_Start("firefox"); }
        public void start_InternetExplorer() { Program_Start("iexplore"); }
        public void start_EdgeBrowser() {Program_Start("microsoft-edge:");}
        #endregion
        #region System Methods
        [DllImport("user32")]
        public static extern void LockWorkStation();  //For locking screen
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason); //For log off
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent); //for Sleep or Hibernate
        public void system_LockScreen() { LockWorkStation(); }
        public void system_Sleep(){ SetSuspendState(false, true, true); }
        public void system_Hibernate(){ SetSuspendState(true, true, true); }
        public void system_Logoff() { ExitWindowsEx(0, 0); }
        public void system_Shutdown() { Process.Start("shutdown","/s /t 0"); }
        public void system_Restart() { Process.Start("shutdown", "/r /t 0");}
        #endregion
        #region Keyboard Input Methods
        
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        // Get a handle to an application window.

        #region AlphaNumeric and Typing Keys
                
        public void Keyboard_Key_DECIMAL(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.DECIMAL); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.DECIMAL);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.DECIMAL);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_0(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_0); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_0);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_0);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_1(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_1); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_1);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_1);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_2(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_2); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_2);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_2);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_3(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_3); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_3);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_3);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_4(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_4); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_4);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_4);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_5(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_5); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_5);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_5);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_6(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_6); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_6);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_6);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_7(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_7); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_7);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_7);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_8(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_8); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_8);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_8);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_9(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_9); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_9);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_9);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_A(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_A); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_A);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_A);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_B(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_B); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_B);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_B);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_C(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_C); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_C);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_C);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_D(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_D); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_D);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_D);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_E(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_E); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_E);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_E);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_F(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_F); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_F);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_F);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_G(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_G); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_G);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_G);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_H(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_H); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_H);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_H);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_I(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_I); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_I);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_I);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_J(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_J); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_J);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_J);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_K(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_K); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_K);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_K);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_L(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_L); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_L);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_L);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_M(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_M); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_M);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_M);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_N(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_N); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_N);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_N);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_O(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_O); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_O);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_O);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_P(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_P); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_P);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_P);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_Q(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_Q); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Q);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_Q);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_R(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_R); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_R);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_R);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_S(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_S); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_S);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_S);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_T(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_T); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_T);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_T);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_U(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_U); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_U);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_U);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_V(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_V); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_V);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_V);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_W(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_W); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_X(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_X); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_X);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_X);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_Y(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_Y); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Y);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_Y);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_Z(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_Z); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Z);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_Z);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_SPACE(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SPACE); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SPACE);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.SPACE);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        #endregion

        #region Function Keys

          public void Keyboard_Key_UP(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.UP); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_DOWN(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.DOWN); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.DOWN);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.DOWN);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_LEFT(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LEFT); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_RIGHT(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RIGHT); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        
        public void Keyboard_Key_ENTER(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RETURN);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.RETURN);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_LSHIFT(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LSHIFT); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
        public void Keyboard_Key_RSHIFT(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RSHIFT); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RSHIFT);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_SHIFT(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SHIFT); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SHIFT);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.SHIFT);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_BACKSPACE(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.BACK); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.BACK);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.BACK);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        
        public void Keyboard_Key_LCONTROL(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LCONTROL); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_RCONTROL(int option)
            {
                if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RCONTROL); }
                else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RCONTROL);}
                else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.RCONTROL);}
                else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
            }
        public void Keyboard_Key_CONTROL(int option)
            {
                if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.CONTROL); }
                else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.CONTROL);}
                else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.CONTROL);}
                else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
            }

        public void Keyboard_Key_ALT(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.MENU); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.MENU);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.MENU);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }

        public void Keyboard_Key_LWINDOWS(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LWIN); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LWIN);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.LWIN);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_RWINDOWS(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RWIN); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RWIN);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.RWIN);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        
        public void Keyboard_Key_CAPSLOCK(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.CAPITAL); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.CAPITAL);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.CAPITAL);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        
        public void Keyboard_Key_TAB(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.TAB);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.TAB);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_NUMLOCK(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.NUMLOCK); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.NUMLOCK);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.NUMLOCK);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_PRINTSCREEN(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SNAPSHOT); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SNAPSHOT);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.SNAPSHOT);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_PAUSE(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.PAUSE); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.PAUSE);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.PAUSE);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_SCROLLLOCK(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SCROLL); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SCROLL);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.SCROLL);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        
        public void Keyboard_Key_INSERT(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.INSERT); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.INSERT);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.INSERT);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_DELETE(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.DELETE); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.DELETE);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.DELETE);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_HOME(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.HOME); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.HOME);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.HOME);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_END(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.END); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.END);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.END);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_PAGEUP(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.PRIOR); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.PRIOR);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.PRIOR);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        public void Keyboard_Key_PAGEDOWN(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.NEXT); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.NEXT);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.NEXT);}
            else { Console.WriteLine("invaild KeyEvent opton. please use KeyPress, KeyDown or KeyUp"); }
        }
        
        public void Keyboard_Key_ESC(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.ESCAPE); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.ESCAPE);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.ESCAPE);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }        
        public void Keyboard_Key_F1(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F1); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F1);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F1);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }        
        public void Keyboard_Key_F2(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F2); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F2);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F2);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F3(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F3); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F3);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F3);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F4(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F4); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F4);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F4);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F5(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F5); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F5);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F5);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F6(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F6); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F6);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F6);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F7(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F7); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F7);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F7);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F8(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F8); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F8);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F8);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F9(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F9); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F9);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F9);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F10(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F10); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F10);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F10);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F11(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F11); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F11);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F11);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        
        public void Keyboard_Key_F12(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F12); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.F12);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.F12);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }        

        
        #endregion


        #region Arithematic Operations Keys

          public void Keyboard_Key_DIVIDE(int option)
                {
                    if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.DIVIDE); }
                    else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.DIVIDE);}
                    else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.DIVIDE);}
                    else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
                }
          
          public void Keyboard_Key_MULTIPLY(int option)
          {
              if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.MULTIPLY); }
              else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.MULTIPLY);}
              else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.MULTIPLY);}
              else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
          }
          public void Keyboard_Key_ADD(int option)
          {
              if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.ADD); }
              else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.ADD);}
              else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.ADD);}
              else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
          }
          public void Keyboard_Key_SUBTRACT(int option)
          {
              if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SUBTRACT); }
              else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SUBTRACT);}
              else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.SUBTRACT);}
              else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
          }
          
        #endregion
        
        #endregion
        #region Mouse Input Methods

        public void Mouse_Key_LEFT(int option)
        {
            if (option == KeyPress) { inputSimulator.Mouse.LeftButtonClick();}
            else if (option == KeyDown) { inputSimulator.Mouse.LeftButtonDown();}
            else if (option == KeyUp) { inputSimulator.Mouse.LeftButtonUp();}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        
        public void Mouse_Key_RIGHT(int option)
        {
            if (option == KeyPress) { inputSimulator.Mouse.RightButtonClick(); }
            else if (option == KeyDown) { inputSimulator.Mouse.RightButtonDown();}
            else if (option == KeyUp) { inputSimulator.Mouse.RightButtonUp();}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        
        public void Mouse_Key_MIDDLE(int option)
        {
            if (option == KeyPress) { inputSimulator.Keyboard.KeyPress(VirtualKeyCode.MBUTTON); }
            else if (option == KeyDown) { inputSimulator.Keyboard.KeyDown(VirtualKeyCode.MBUTTON);}
            else if (option == KeyUp) { inputSimulator.Keyboard.KeyUp(VirtualKeyCode.MBUTTON);}
            else { Console.WriteLine("invaild KeyEvent option. please use KeyPress, KeyDown or KeyUp"); }
        }
        #endregion


        public void Program_Start(string processName)
        {
            var x = new ThreadManager(processName);
            Thread t = new Thread(x.StartProcess_String);
            t.Start();
        }
    }
    public class ThreadManager
    {
        string processString { get; set; }
        string processCommand { get; set; }

        #region Constructors
        public ThreadManager(string processString) { this.processString = processString; }
       
        public ThreadManager(string processString, string processCommand)
        {
            this.processCommand = processCommand;
            this.processString = processString;
        }
        #endregion
               
        public void StartProcess_String()
        {
            try
            {
                var p = new Process();
                p.StartInfo.FileName = processString;
                if (p.Start())
                {
                    Console.WriteLine("Process: "+processString+" has stated successfully");
                    //Thread.CurrentThread.Abort();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void StartProcess_Command()
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C " + this.processCommand;
            p.Start();
        }
    }
}

