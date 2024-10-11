using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMsg
{
    public partial class MainForm : Form
    {
        private bool dragging;
        private Point startPoint = new Point(0, 0);
        private Timer moveTimer;
        public MainForm()
        {
            InitializeComponent();
            MouseDown += new MouseEventHandler(panel1_MouseDown);
            MouseUp += new MouseEventHandler(panel1_MouseUp);
            moveTimer = new Timer();
            moveTimer.Interval = 1;
            moveTimer.Tick += MoveTimer_Tick;
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Point currentScreenPos = Control.MousePosition;
            Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
        }

        private async void RolesBtn_DoubleClick(object sender, EventArgs e)
        {
            if (Roles.Visible == false)
            {
                Roles.Visible = true;
                await Task.Delay(5000);
                Roles.Visible = false;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void NumOfMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Warning.Visible = true;
                await Task.Delay(2000);
                Warning.Visible = false;
            }
        }

        private async void SendMsgBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CopyMsg.Text))
            {
                MessageBox.Show(this, "Message content cannot be empty. Please enter a message to send.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(NumOfMsg.Text, out int howManyTimes) && howManyTimes > 0)
            {
                string message = CopyMsg.Text;
                NumOfMsg.Clear();
                CopyMsg.Clear();
                NotificationBtn.Visible = true;

                for (int countdown = 5; countdown > 0; countdown--)
                {
                    Notification.Text = countdown.ToString();
                    Notification.Visible = true;
                    await Task.Delay(1000);
                }

                Notification.Text = "Start sending messages...";
                await Task.Delay(1000);

                for (int i = 0; i < howManyTimes; i++)
                {
                    CopyMsg.Focus();
                    SendKeys.Send(message);
                    SendKeys.Send("{ENTER}");
                    await Task.Delay(1000);
                }

                Notification.Text = "Message sent successfully.";
                await Task.Delay(3000);
                Notification.Visible = false;
                NotificationBtn.Visible = false;
            }
            else
            {
                MessageBox.Show(this, "Invalid input! Please ensure you enter a positive number for the number of messages.\n" +
                                "Make sure the field is not empty and contains only digits.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }



        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NumOfMsg.Clear();
            CopyMsg.Clear();
        }

        private void MinimizeBtn_MouseHover(object sender, EventArgs e)
        {
            MinimizeBtn.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBtn.BackColor = Color.Transparent;
        }

        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.Red;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.Transparent;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
            moveTimer.Start();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            moveTimer.Stop();
        }

        private void SendMsgBtn_MouseHover(object sender, EventArgs e)
        {
            SendMsgBtn.ForeColor = Color.SkyBlue;
        }

        private void SendMsgBtn_MouseLeave(object sender, EventArgs e)
        {
            SendMsgBtn.ForeColor = Color.FromArgb(150, 150, 150);
        }

        private void ClearBtn_MouseHover(object sender, EventArgs e)
        {
            ClearBtn.ForeColor = Color.Red;
        }

        private void ClearBtn_MouseLeave(object sender, EventArgs e)
        {
            ClearBtn.ForeColor = Color.FromArgb(150, 150, 150);
        }
    }
}
