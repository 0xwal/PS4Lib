namespace Demo
{
    partial class FrmMain
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnDetach = new System.Windows.Forms.Button();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNotifyType = new System.Windows.Forms.ComboBox();
            this.btnNotify = new System.Windows.Forms.Button();
            this.txtNotify = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoPeak = new System.Windows.Forms.RadioButton();
            this.rdoPoke = new System.Windows.Forms.RadioButton();
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(25, 51);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(74, 23);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContinue);
            this.groupBox1.Controls.Add(this.btnDetach);
            this.groupBox1.Controls.Add(this.btnCheckConnection);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.btnAttach);
            this.groupBox1.Controls.Add(this.btnConnection);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection / System";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(158, 83);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(229, 23);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnDetach
            // 
            this.btnDetach.Location = new System.Drawing.Point(346, 51);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(74, 23);
            this.btnDetach.TabIndex = 3;
            this.btnDetach.Text = "Detach";
            this.btnDetach.UseVisualStyleBackColor = true;
            this.btnDetach.Click += new System.EventHandler(this.btnDetach_Click);
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(453, 51);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(74, 23);
            this.btnCheckConnection.TabIndex = 3;
            this.btnCheckConnection.Text = "Check Connection";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(239, 51);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(74, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(6, 25);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(542, 20);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "192.168.100.0";
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(132, 51);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(74, 23);
            this.btnAttach.TabIndex = 0;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNotifyType);
            this.groupBox2.Controls.Add(this.btnNotify);
            this.groupBox2.Controls.Add(this.txtNotify);
            this.groupBox2.Location = new System.Drawing.Point(42, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification";
            // 
            // cmbNotifyType
            // 
            this.cmbNotifyType.FormattingEnabled = true;
            this.cmbNotifyType.Items.AddRange(new object[] {
            "-Blank-",
            "Unknown USB device connected.",
            "Too many USB hubs connected.",
            "Connect this device using a USB cable, or connect it again.",
            "%s battery level low.",
            "%s disconnected.",
            "Too many USB devices connected.",
            "Cannot connect another Bluetooth device.",
            "-Blank-",
            "Cannot connect another controller.",
            "Cannot connect another mouse or keyboard.",
            "Cannot use controller feature of keyboard.",
            "Device not supported.",
            "Cannot use wireless controllers for PS3.",
            "%s connected their companion app.",
            "%s disconnected their companion app.",
            "%s connected using Remote Play.",
            "%s disconnected from Remote Play.",
            "%s cannot see the screen due to Remote Play blocked scene.",
            "%s can see the screen again because Remote Play blocked scene ended.",
            "-Blank-",
            "-Blank-",
            "Less than %s free in system storage.",
            "LAN cable not connected.",
            "Wi-Fi network connection lost.",
            "Cannot connect to network.",
            "%s logged in to PS4.",
            "-Blank-",
            "Your account is banned from PlayStation Network.",
            "PlayStation Network access from this PS4 banned or temporarily suspended.",
            "Update the system software.",
            "PlayStation Network is currently busy.",
            "PlayStation Network is currently undergoing maintenance.",
            "PlayStation Network is no longer available.",
            "-Blank-",
            "Sign in to PSN to use network features.",
            "Signed out of PSN.",
            "Update application to use network features.",
            "Update system software to use network features.",
            "PlayStation Network features in this application unavailable due to age restricti" +
                "ons.",
            "Application will expire in %s minutes.",
            "Application suspending in %s minutes because license cannot be verified.",
            "Party chat audio prioritized.",
            "Game chat audio prioritized.",
            "-Blank-",
            "Cannot use voice chat with %s, possibly due to NAT type.",
            "Kicked out of party.",
            "No longer in party due to network error.",
            "Cannot take screenshot now.",
            "This is a blocked scene for gameplay recording.",
            "Cannot display menu now.",
            "Only microphone audio is being broadcast.",
            "-Blank-",
            "Broadcast stopped.",
            "Song playback stopped.",
            "-Blank-",
            "The PS4 automatically turned off due to power save settings.",
            "Only 4 users can be logged in at the same time.",
            "Deleted because you already have %s Bluetooth devices registered.",
            "Message sent.",
            "To switch to your screen, press the PS button.",
            "Gameplay recording paused because you entered blocked scene.",
            "Gameplay recording resumed because you exited blocked scene.",
            "-Snapshot Icon-",
            "-Recording Icon-",
            "-Blank-",
            "Chat audio switched to game.",
            "Chat audio switched to party.",
            "-Blank-",
            "Chat audio also muted for players on same PS4 as %s.",
            "-Blank-",
            "Cannot connect to server, so network features for this application unavailable.",
            "-Blank-",
            "Confirming your licenses for using content on this PS4.",
            "This ad will end soon.",
            "%s disconnected. Charge the battery.",
            "-Blank-",
            "%s disconnected. Charge the battery.",
            "Gameplay is currently not being recorded.",
            "%s joined the party. (Players: )",
            "%s left the party. (Players: )",
            "You are now party owner.",
            "Broadcast paused.",
            "Video clip saved.",
            "Microphone not connected.",
            "Both microphone audio and gameplay are being broadcast.",
            "Broadcast ends in %s minutes.",
            "Broadcasting only microphone audio because you entered a blocked scene.",
            "Broadcast paused because you entered a blocked scene.",
            "Broadcasting gameplay and microphone audio because you exited a blocked scene.",
            "Game closing in %s minutes due to inactivity.",
            "Game closed due to inactivity.",
            "-Blank-",
            "Game closing in %s minutes because time limit will be reached.",
            "Server maintenance starts in %s hours.",
            "-Blank-",
            "-Blank-",
            "Game closing soon because server maintenance starts in %s minutes.",
            "Screenshot saved.",
            "Network features for this application temporarily unavailable.",
            "Game closed due to insufficient internet connection quality.",
            "Cannot start game.",
            "Game closed because PS Now game was started on another device.",
            "Game closed because connection to server was lost.",
            "Game closed because time limit was reached.",
            "Game closed due to server maintenance.",
            "%s suggested players to invite to your party.",
            "Cannot connect another audio device.",
            "Broadcast started, and will end in %s.",
            "Microphone for PS camera muted, so players in party cannot hear you.",
            "The BD remote control is not supported by the PS4.",
            "Broadcast resumed.",
            "Broadcasting resumed because you exited blocked scene.",
            "Game closing in 1 minute due to inactivity.",
            "Insufficient free space to record your gameplay.",
            "Server maintenance starts in %s minutes.",
            "-Blank-",
            "PS Now game closing due to insufficient internet connection.",
            "Use the controller that was just connected.",
            "Gameplay recording is temporarily paused.",
            "You cannot control the system now.",
            "Cannot operate PS4 with voice now.",
            "This USB device\'s file system is unsupported.",
            "Feature unavailable for visitors.",
            "Cannot connect another USB device.",
            "-Blank-",
            "Cannot find face.",
            "Cannot find face because PS Camera is already in use.",
            "Share Play started as host.",
            "%s is connecting to your PS4 to join Share Play.",
            "Visitor cannot see game screen when you view non-game screens.",
            "You joined share play with %s (host).",
            "Visitor cannot see game screen due to blocked scene.",
            "Visitor can see game screen again.",
            "Cannot control Share Play game now.",
            "Visitor cannot control game due to restricted scene.",
            "Visitor can control game again.",
            "Share Play stops in %s minutes.",
            "Share Play will stop in 1 minute.",
            "Visitor cannot use selected feature.",
            "Controller given to visitor.",
            "-Blank-",
            "You can now play as host.",
            "You can now play together with host.",
            "Controller taken back by %s (host).",
            "%s (visitor) left Share Play.",
            "Cannot display all songs because there are more than %s.",
            "-Blank-",
            "Microphone switched to microphone for PS Camera.",
            "Microphone switched to headset connected to controller.",
            "-Blank-",
            "Microphone switched to USB microphone.",
            "Microphone switched to USB headset.",
            "Microphone switched to Bluetooth headset.",
            "Restart your PS4.",
            "-Blank-",
            "-Blank-",
            "%s could not connect to your PS4.",
            "Microphone switched to microphone on VR headset.",
            "Cannot use audio device you just connected while using VR headset.",
            "Cannot use this USB storage device.",
            "Gameplay recording paused.",
            "Gameplay recording resumed.",
            "Gameplay recording currently paused.",
            "Screen resolution changed by application.",
            "Information posted.",
            "Could not post information.",
            "Visitor cannot play or see game until you return to it.",
            "Invitation sent to %s.",
            "Private party created and invitation sent to %s.",
            "Keypad disconnected.",
            "Cannot use keypad because too many mice or keyboards are connected.",
            "-Blank-",
            "No microphone that you can use.",
            "All users\' microphones switched to microphone on PS Camera.",
            "-Blank-",
            "PS Camera disconnected, so now no users have a microphone.",
            "Insufficient free space to take screenshots.",
            "Controller type changed.",
            "Controller type changed, and you can play as host.",
            "Controller type changed, and you can play together with host.",
            "An event is about to start for the following user. -Subtext-%s",
            "-Blank-",
            "Cannot add one or more players.",
            "Cannot change group name.",
            "Cannot change group image.",
            "Cannot add group to [Favorite Groups].",
            "Cannot delete group from [Favorite Groups].",
            "Cannot leave group.",
            "Cannot listen to music in the background while using Remote Play.",
            "Cannot listen to music in the background while broadcasting.",
            "Cannot listen to music in the background while using Share Play.",
            "Group added to [Favorite Groups].",
            "-Blank-",
            "Invitations sent to players.",
            "msg_invitation_suggestion_sent_multiple",
            "msg_invitation_sent_player_priv_party_created_multiple",
            "Request sent to %s.",
            "Group deleted from [Favorite Groups].",
            "Cannot create new group.",
            "Group already added to [Favorite Groups].",
            "Cannot use another USB audio device while using VR headset.",
            "Virtual surround sound of the audio headset is temporarily disabled.",
            "-No Notification-",
            "Review surroundings and clear any obstacles before use. See important health and " +
                "safety warnings in the Settings menu.",
            "Start this game now to join a game session more quickly.",
            "-Blank-",
            "Cannot add some players because of their settings.",
            "Party invitation sent to group.",
            "Private party created and invitation sent to group.",
            "%s connected.",
            "Following %s.",
            "Cannot change the limit on the number of players.",
            "Group created.",
            "Cannot add some players because of their settings.",
            "-Blank-",
            "Cannot share event with message group.",
            "Cannot share event with Community.",
            "Cannot use audio features of this device.",
            "Cannot use audio features of some devices.",
            "Activity shared.",
            "Cannot share activity.",
            "%s",
            "Player blocked.",
            "Cannot send message.",
            "High-resolution captures unsupported by this application are not displayed.",
            "Song playback stopped because you reached the monthly free time limit.",
            "-Blank-",
            "-Blank-",
            "-Blank-",
            "-Blank-",
            "-Blank-",
            "3D audio of the audio headset is temporarily disabled.",
            "Players suggested to the party owner for invitation.",
            "Private party created and invitations sent to players.",
            "Song added to [Your Music].",
            "Song removed from [Your Music].",
            "Cannot add song to [Your Music].",
            "Cannot remove song from [Your Music].",
            "Your account is suspended from PlayStation Network.",
            "You have left the party."});
            this.cmbNotifyType.Location = new System.Drawing.Point(297, 19);
            this.cmbNotifyType.Name = "cmbNotifyType";
            this.cmbNotifyType.Size = new System.Drawing.Size(261, 21);
            this.cmbNotifyType.TabIndex = 2;
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(16, 45);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(542, 23);
            this.btnNotify.TabIndex = 1;
            this.btnNotify.Text = "Notify";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // txtNotify
            // 
            this.txtNotify.Location = new System.Drawing.Point(16, 19);
            this.txtNotify.Name = "txtNotify";
            this.txtNotify.Size = new System.Drawing.Size(275, 20);
            this.txtNotify.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPeak);
            this.groupBox3.Controls.Add(this.rdoPoke);
            this.groupBox3.Controls.Add(this.richBox);
            this.groupBox3.Controls.Add(this.btnExecute);
            this.groupBox3.Controls.Add(this.numLength);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtOffset);
            this.groupBox3.Location = new System.Drawing.Point(42, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 126);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Peak/Poke";
            // 
            // rdoPeak
            // 
            this.rdoPeak.AutoSize = true;
            this.rdoPeak.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoPeak.Checked = true;
            this.rdoPeak.Location = new System.Drawing.Point(116, 72);
            this.rdoPeak.Name = "rdoPeak";
            this.rdoPeak.Size = new System.Drawing.Size(50, 17);
            this.rdoPeak.TabIndex = 8;
            this.rdoPeak.TabStop = true;
            this.rdoPeak.Text = "Peak";
            this.rdoPeak.UseVisualStyleBackColor = true;
            // 
            // rdoPoke
            // 
            this.rdoPoke.AutoSize = true;
            this.rdoPoke.Location = new System.Drawing.Point(180, 72);
            this.rdoPoke.Name = "rdoPoke";
            this.rdoPoke.Size = new System.Drawing.Size(50, 17);
            this.rdoPoke.TabIndex = 7;
            this.rdoPoke.Text = "Poke";
            this.rdoPoke.UseVisualStyleBackColor = true;
            // 
            // richBox
            // 
            this.richBox.Location = new System.Drawing.Point(297, 20);
            this.richBox.Name = "richBox";
            this.richBox.Size = new System.Drawing.Size(261, 100);
            this.richBox.TabIndex = 6;
            this.richBox.Text = "";
            this.richBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOffset_KeyPress);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(70, 97);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(215, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(70, 46);
            this.numLength.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(215, 20);
            this.numLength.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "By BISOON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offset: 0x";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(70, 20);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(215, 20);
            this.txtOffset.TabIndex = 0;
            this.txtOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOffset_KeyPress);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 RTE Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.TextBox txtNotify;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnDetach;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ComboBox cmbNotifyType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoPeak;
        private System.Windows.Forms.RadioButton rdoPoke;
        private System.Windows.Forms.RichTextBox richBox;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOffset;
    }
}

