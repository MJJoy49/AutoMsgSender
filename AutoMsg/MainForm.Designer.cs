namespace AutoMsg
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyMsg = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NumOfMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SendMsgBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Roles = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.Label();
            this.RolesBtn = new System.Windows.Forms.PictureBox();
            this.NotificationBtn = new System.Windows.Forms.PictureBox();
            this.Warning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 77);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(1220, 3);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(88, 71);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizeBtn.TabIndex = 15;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            this.MinimizeBtn.MouseLeave += new System.EventHandler(this.MinimizeBtn_MouseLeave);
            this.MinimizeBtn.MouseHover += new System.EventHandler(this.MinimizeBtn_MouseHover);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(1310, 3);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(88, 71);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            this.CloseBtn.MouseHover += new System.EventHandler(this.CloseBtn_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "AUTO MESSAGE SENDER.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(438, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your message ";
            // 
            // CopyMsg
            // 
            this.CopyMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CopyMsg.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CopyMsg.Location = new System.Drawing.Point(525, 251);
            this.CopyMsg.Multiline = true;
            this.CopyMsg.Name = "CopyMsg";
            this.CopyMsg.Size = new System.Drawing.Size(460, 195);
            this.CopyMsg.TabIndex = 3;
            this.CopyMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(422, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(422, 529);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // NumOfMsg
            // 
            this.NumOfMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NumOfMsg.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NumOfMsg.Location = new System.Drawing.Point(525, 546);
            this.NumOfMsg.Name = "NumOfMsg";
            this.NumOfMsg.Size = new System.Drawing.Size(460, 48);
            this.NumOfMsg.TabIndex = 18;
            this.NumOfMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOfMsg_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(438, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "How many times";
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClearBtn.Location = new System.Drawing.Point(799, 665);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(172, 44);
            this.ClearBtn.TabIndex = 21;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            this.ClearBtn.MouseLeave += new System.EventHandler(this.ClearBtn_MouseLeave);
            this.ClearBtn.MouseHover += new System.EventHandler(this.ClearBtn_MouseHover);
            // 
            // SendMsgBtn
            // 
            this.SendMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMsgBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SendMsgBtn.Location = new System.Drawing.Point(544, 665);
            this.SendMsgBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.SendMsgBtn.Size = new System.Drawing.Size(172, 44);
            this.SendMsgBtn.TabIndex = 20;
            this.SendMsgBtn.Text = "Send";
            this.SendMsgBtn.UseVisualStyleBackColor = true;
            this.SendMsgBtn.Click += new System.EventHandler(this.SendMsgBtn_Click);
            this.SendMsgBtn.MouseLeave += new System.EventHandler(this.SendMsgBtn_MouseLeave);
            this.SendMsgBtn.MouseHover += new System.EventHandler(this.SendMsgBtn_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Roles);
            this.panel2.Controls.Add(this.Notification);
            this.panel2.Controls.Add(this.RolesBtn);
            this.panel2.Controls.Add(this.NotificationBtn);
            this.panel2.Location = new System.Drawing.Point(0, 786);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 77);
            this.panel2.TabIndex = 22;
            // 
            // Roles
            // 
            this.Roles.AutoSize = true;
            this.Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roles.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Roles.Location = new System.Drawing.Point(586, 15);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(716, 50);
            this.Roles.TabIndex = 25;
            this.Roles.Text = "After clicking the send button, the mouse cursor point should be set in \r\nthe mes" +
    "sage typing box of the person to whom the message is to be sent.";
            this.Roles.Visible = false;
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Notification.Location = new System.Drawing.Point(86, 27);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(0, 25);
            this.Notification.TabIndex = 24;
            this.Notification.Visible = false;
            // 
            // RolesBtn
            // 
            this.RolesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RolesBtn.Image = ((System.Drawing.Image)(resources.GetObject("RolesBtn.Image")));
            this.RolesBtn.Location = new System.Drawing.Point(1307, 7);
            this.RolesBtn.Name = "RolesBtn";
            this.RolesBtn.Size = new System.Drawing.Size(87, 65);
            this.RolesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RolesBtn.TabIndex = 17;
            this.RolesBtn.TabStop = false;
            this.RolesBtn.DoubleClick += new System.EventHandler(this.RolesBtn_DoubleClick);
            // 
            // NotificationBtn
            // 
            this.NotificationBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotificationBtn.Image = ((System.Drawing.Image)(resources.GetObject("NotificationBtn.Image")));
            this.NotificationBtn.Location = new System.Drawing.Point(7, 7);
            this.NotificationBtn.Name = "NotificationBtn";
            this.NotificationBtn.Size = new System.Drawing.Size(73, 59);
            this.NotificationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NotificationBtn.TabIndex = 16;
            this.NotificationBtn.TabStop = false;
            this.NotificationBtn.Visible = false;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Warning.Location = new System.Drawing.Point(708, 507);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(274, 25);
            this.Warning.TabIndex = 26;
            this.Warning.Text = "Please enter numbers only.";
            this.Warning.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1400, 864);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SendMsgBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.NumOfMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CopyMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CopyMsg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox NumOfMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SendMsgBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox NotificationBtn;
        private System.Windows.Forms.PictureBox RolesBtn;
        private System.Windows.Forms.Label Notification;
        private System.Windows.Forms.Label Roles;
        private System.Windows.Forms.Label Warning;
    }
}