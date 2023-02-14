using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Windows.Forms;

namespace ScannerCommands
{
    public partial class Form1 : Form
    {
        // Define a constant to represent the WM_SETFOCUS message.
        private const int WM_SETFOCUS = 0x0007;

        // Define a variable to store the handle of the main window.
        private IntPtr mainWindowHandle;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResumeLayout(false);
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            this.Top = 0;
            this.TopMost = true;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            mainWindowHandle = this.Handle;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Set Cancel to true to cancel the close operation
            e.Cancel = true;
        }
  



     
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
       

        // Define a variable to store the handle of the main window.
     

        private void Commandbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Printbutton_Click(object sender, EventArgs e)
        {



            // Get the process ID of Notepad.
            Process[] notepadProcesses = Process.GetProcessesByName("notepad");
            if (notepadProcesses.Length > 0)
            {
                int notepadProcessId = notepadProcesses[0].Id;

                // Get the main window handle of Notepad.
                IntPtr notepadWindowHandle = NativeMethods.GetMainWindowHandle(notepadProcessId);

                // Activate the Notepad window.
                NativeMethods.SetForegroundWindow(notepadWindowHandle);


                     SendKeys.SendWait("^a");
                     SendKeys.SendWait("{DELETE}");
                     SendKeys.SendWait(Commandbox.Text);
                // Send some keys to Notepad.
              

                // Activate the main window of the application.
                NativeMethods.SetForegroundWindow(mainWindowHandle);

                // Send a WM_SETFOCUS message to the main window to restore the focus.
                NativeMethods.SendMessage(mainWindowHandle, WM_SETFOCUS, IntPtr.Zero, IntPtr.Zero);
                Commandbox.Clear();
                Commandbox.Focus();
            }
            else
            {
                 
               
                NativeMethods.SendMessage(mainWindowHandle, WM_SETFOCUS, IntPtr.Zero, IntPtr.Zero);
                Commandbox.Clear();
                Commandbox.Focus();
                 
            }





          


        }



        internal static class NativeMethods
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll", SetLastError = true)]
            internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            internal static IntPtr GetMainWindowHandle(int processId)
            {
                IntPtr windowHandle = IntPtr.Zero;

                // Enumerate all top-level windows to find the main window of the target process.
                NativeMethods.EnumWindows((hwnd, lParam) =>
                {
                    int windowProcessId = 0;
                    NativeMethods.GetWindowThreadProcessId(hwnd, out windowProcessId);
                    if (windowProcessId == processId)
                    {
                        windowHandle = hwnd;
                        return false;
                    }
                    return true;
                }, IntPtr.Zero);

                return windowHandle;
            }

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

            internal delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

            [DllImport("user32.dll", SetLastError = true)]
            internal static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        }




    }
}