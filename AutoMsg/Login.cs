using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AutoMsg
{
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private Timer rotationTimer;
        private int angle = 0;
        private Image originalImage;
        private Image newImage;

        public Login()
        {
            InitializeComponent();
            forDraggingForm();
            InitializeRotationTimer();
            if (pictureBox1.Image != null)
            {
                originalImage = (Image)pictureBox1.Image.Clone();
            }
        }

        private void forDraggingForm()
        {
            MouseDown += new MouseEventHandler(panel1_MouseDown);
            MouseUp += new MouseEventHandler(panel1_MouseUp);
            MouseMove += new MouseEventHandler(panel1_MouseMove);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SecretNameInput.Clear();
            PasswordInput.Clear();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = Control.MousePosition;
                Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
            }
        }

        private void InitializeRotationTimer()
        {
            rotationTimer = new Timer();
            rotationTimer.Interval = 15;
            rotationTimer.Tick += RotationTimer_Tick;
            newImage = Image.FromFile("J:\\c#_all\\vstudio\\Autom\\Icons\\OpenDoor.png");
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            angle += 5;
            RotatePictureBoxImage();
            if (angle >= 300)
            {
                rotationTimer.Stop();
                PlaySound();
                pictureBox1.Image = newImage;
                angle = 0;
            }
        }

        private void RotatePictureBoxImage()
        {
            if (pictureBox1.Image != null)
            {
                Image img = pictureBox1.Image;
                Bitmap rotatedImage = new Bitmap(img.Width, img.Height);
                using (Graphics g = Graphics.FromImage(rotatedImage))
                {
                    g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
                    g.RotateTransform(angle);
                    g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
                    g.DrawImage(img, new Point(0, 0));
                }
                pictureBox1.Image = rotatedImage;
            }
        }

        private void PlaySound()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("J:\\c#_all\\vstudio\\Autom\\Icons\\Opendoor.wav");
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private async Task WaitForSeconds()
        {
            await Task.Delay(2000);
            pictureBox1.Image = Image.FromFile("J:\\c#_all\\vstudio\\Autom\\Icons\\AutoMsgLogo.png");
        }

        private async void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            rotationTimer.Start();
            await WaitForSeconds();
            UnlockDetails unlockDetails = new UnlockDetails();
            unlockDetails.StartPosition = FormStartPosition.Manual;
            unlockDetails.Location = new Point(
                this.Location.X + (this.Width - unlockDetails.Width) / 2,
                this.Location.Y + (this.Height - unlockDetails.Height) / 2
            );
            unlockDetails.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void LoginDoneBtn_MouseHover(object sender, EventArgs e)
        {
            LoginDoneBtn.ForeColor = Color.SkyBlue;
        }

        private void LoginDoneBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginDoneBtn.ForeColor = Color.FromArgb(150, 150, 150);
        }

        private void ClearBtn_MouseHover(object sender, EventArgs e)
        {
            ClearBtn.ForeColor = Color.Red;
        }

        private void ClearBtn_MouseLeave(object sender, EventArgs e)
        {
            ClearBtn.ForeColor = Color.FromArgb(150, 150, 150);
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = !PasswordInput.UseSystemPasswordChar;
        }

        private async void LoginDoneBtn_Click(object sender, EventArgs e)
        {
            if ((SecretNameInput.Text) != String.Empty && (SecretNameInput.Text) == "automsg"
                && (PasswordInput.Text) != String.Empty && (PasswordInput.Text) == "1234mj#")
            {
                rotationTimer.Start();
                await Task.Delay(1800);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else if ((SecretNameInput.Text) != "automsg" && (SecretNameInput.Text) != String.Empty && (PasswordInput.Text) != String.Empty && (PasswordInput.Text) != "1234mj#")
            {
                WrongPass.Visible = true;
                WrongName.Visible = true;
                await Task.Delay(5000);
                WrongPass.Visible = false;
                WrongName.Visible = false;
            }
            else if ((SecretNameInput.Text) != "automsg" && (SecretNameInput.Text) != String.Empty)
            {
                WrongName.Visible = true;
                await Task.Delay(5000);
                WrongName.Visible = false;
            }
            else if ((PasswordInput.Text) != String.Empty && (PasswordInput.Text) != "1234mj#")
            {
                WrongPass.Visible = true;
                await Task.Delay(5000);
                WrongPass.Visible = false;
            }
            else
            {
                MessageBox.Show(this,"Enter Secret name and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
