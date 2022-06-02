using Gma.System.MouseKeyHook;
using System.Runtime.InteropServices;

namespace AutoMouseClick
{

    public partial class MainForm : Form
    {
        /* -- BEGIN -- */
        /*
         * Reference:   https://www.c-sharpcorner.com/article/timer-in-C-Sharp/
         * Purpose:     Simulated mouse click without user input
         */

        // This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        // This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
        /* -- END -- */

        /* -- BEGIN -- */
        /*
         * Reference    https://stackoverflow.com/questions/61817755/detect-mouse-clicks-outside-the-form-c-sharp
         * Purpose:     Retrieve mouse X and Y position globally even outside the form
         * Dependence:  Nuget package MouseKeyHook
         */
        private POINT oldMousePos;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static implicit operator System.Drawing.Point(POINT p)
            {
                return new System.Drawing.Point(p.X, p.Y);
            }

            public static implicit operator POINT(System.Drawing.Point p)
            {
                return new POINT(p.X, p.Y);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out POINT lpPoint);

        private void MouseMoveAll(object? sender, MouseEventArgs e)
        {
            POINT newMousePos;

            if (GetCursorPos(out newMousePos))
            {
                // if mouse is moved, stop the count down timer, start the timeout count down timer
                if (oldMousePos.X != newMousePos.X && oldMousePos.Y != newMousePos.Y && !btnStart.Enabled)
                {
                    // record position to check if mouse is moved
                    oldMousePos = newMousePos;

                    // update position
                    lblSystemMsg.Invoke((MethodInvoker)delegate
                    {
                        lblSystemMsg.ForeColor = Color.OrangeRed;
                        lblSystemMsg.Text = "Mouse movement detected: [" + Cursor.Position.X + "," + Cursor.Position.Y + "]";
                    });
                    
                    // Stop timer and wait movement time out
                    tmrCountDown.Enabled = false;
                    tmrCountDownMouseMovTimeout.Enabled = true;
                }
            }
        }
        /* -- END -- */

        public MainForm()
        {
            InitializeComponent();

            Hook.GlobalEvents().MouseMove += MouseMoveAll;
            oldMousePos = new POINT(Cursor.Position.X, Cursor.Position.Y);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Update progress bar and msg
            cpbProgress.Invoke((MethodInvoker)delegate
            {
                cpbProgress.Value = (long)ncCountDown.Value;
            });

            lblSystemMsg.Invoke((MethodInvoker)delegate
            {
                lblSystemMsg.Text = "";
            });

            // Disable the numeric up down controls
            ncCountDown.Enabled = false;
            ncMouseActivityTimeout.Enabled = false;

            // Start / Stop button
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            // Kick off timer tick
            tmrCountDown.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Update progress bar and msg
            cpbProgress.Invoke((MethodInvoker)delegate
            {
                cpbProgress.Value = (long)ncCountDown.Value;
            });

            lblSystemMsg.Invoke((MethodInvoker)delegate
            {
                lblSystemMsg.Text = "";
            });

            // Enable the numeric up down controls
            ncCountDown.Enabled = true;
            ncMouseActivityTimeout.Enabled = true;

            // Start / Stop button
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            // Disable CountDown timer and Mouse movement timeout timer
            tmrCountDown.Enabled = false;
            tmrCountDownMouseMovTimeout.Enabled = false;
        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            // Update the count down every 1 second
            // Simulate mouse click when count down to 0

            if (cpbProgress.Value > 1)
            {
                cpbProgress.Value--;
            }
            else
            {
                // Update progress bar
                cpbProgress.Invoke((MethodInvoker)delegate
                {
                    cpbProgress.Value = (long)ncCountDown.Value;
                });

                // Simulate left mouse click
                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;

                LeftMouseClick(x, y);
            }
        }

        private void tmrCountDownMouseMovTimeout_Tick(object sender, EventArgs e)
        {
            // Only continue if timer was not stopped
            if (!btnStart.Enabled)
            {
                // Timeout since last mouse movement reached, continue the count down
                tmrCountDown.Enabled = true;

                lblSystemMsg.Invoke((MethodInvoker)delegate
                {
                    lblSystemMsg.Text = "";
                });
            }
        }

        private void ncCountDown_ValueChanged(object sender, EventArgs e)
        {
            // Update progress bar
            cpbProgress.Invoke((MethodInvoker)delegate
            {
                cpbProgress.Maximum = (long)ncCountDown.Value;
                cpbProgress.Value = (long)ncCountDown.Value;
                cpbProgress.Text = cpbProgress.Value.ToString();
            });

            // Update count down in Minutes
            lblMinutes.Invoke((MethodInvoker)delegate
            {
                lblMinutes.Text = "(" + ((long)ncCountDown.Value / 60) + " min)";
            });
        }
        private void ncMouseActivityTimeout_ValueChanged(object sender, EventArgs e)
        {
            // Update mouse activity timeout
            lblMouseInactiveTimeoutMin.Invoke((MethodInvoker)delegate
            {
                lblMouseInactiveTimeoutMin.Text = "(" + ((long)ncMouseActivityTimeout.Value / 60) + " min)";
            });

            // Update mouse activity timeout timer interval
            tmrCountDownMouseMovTimeout.Interval = (int)ncMouseActivityTimeout.Value * 1000;
        }
    }
}