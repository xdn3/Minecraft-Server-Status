namespace Minecraft_Server_Status
{
    partial class Screen1
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
            this.javaRadioButton = new System.Windows.Forms.RadioButton();
            this.bedrockRadioButton = new System.Windows.Forms.RadioButton();
            this.editionGroupBox = new System.Windows.Forms.GroupBox();
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ipaddrTextLabel = new System.Windows.Forms.Label();
            this.networkInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.protocolnumLabel = new System.Windows.Forms.Label();
            this.protocolnumberTextLabel = new System.Windows.Forms.Label();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.hostnameTextLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portTextLabel = new System.Windows.Forms.Label();
            this.ipaddrLabel = new System.Windows.Forms.Label();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.playersGroupBox = new System.Windows.Forms.GroupBox();
            this.showuuidButton = new System.Windows.Forms.Button();
            this.maximumText = new System.Windows.Forms.Label();
            this.maxTextLabel = new System.Windows.Forms.Label();
            this.onlineLabel = new System.Windows.Forms.Label();
            this.onlineTextLabel = new System.Windows.Forms.Label();
            this.motdGroupBox = new System.Windows.Forms.GroupBox();
            this.motdWebBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.softwareLabel = new System.Windows.Forms.Label();
            this.softwareTextLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionTextLabel = new System.Windows.Forms.Label();
            this.pluginsGroupBox = new System.Windows.Forms.GroupBox();
            this.plugincountLabel = new System.Windows.Forms.Label();
            this.plugincountTextLabel = new System.Windows.Forms.Label();
            this.pluginsListBox = new System.Windows.Forms.ListBox();
            this.modsGroupBox = new System.Windows.Forms.GroupBox();
            this.modcountLabel = new System.Windows.Forms.Label();
            this.modcountTextLabel = new System.Windows.Forms.Label();
            this.modsListBox = new System.Windows.Forms.ListBox();
            this.worldinfoGroupBox = new System.Windows.Forms.GroupBox();
            this.gamemodeLabel = new System.Windows.Forms.Label();
            this.gamemodeTextLabel = new System.Windows.Forms.Label();
            this.worldNameLabel = new System.Windows.Forms.Label();
            this.worldNameTextLabel = new System.Windows.Forms.Label();
            this.editionGroupBox.SuspendLayout();
            this.serverGroupBox.SuspendLayout();
            this.networkInfoGroupBox.SuspendLayout();
            this.playersGroupBox.SuspendLayout();
            this.motdGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pluginsGroupBox.SuspendLayout();
            this.modsGroupBox.SuspendLayout();
            this.worldinfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // javaRadioButton
            // 
            this.javaRadioButton.AutoSize = true;
            this.javaRadioButton.Location = new System.Drawing.Point(6, 19);
            this.javaRadioButton.Name = "javaRadioButton";
            this.javaRadioButton.Size = new System.Drawing.Size(83, 17);
            this.javaRadioButton.TabIndex = 0;
            this.javaRadioButton.TabStop = true;
            this.javaRadioButton.Text = "Java Edition";
            this.javaRadioButton.UseVisualStyleBackColor = true;
            // 
            // bedrockRadioButton
            // 
            this.bedrockRadioButton.AutoSize = true;
            this.bedrockRadioButton.Location = new System.Drawing.Point(95, 19);
            this.bedrockRadioButton.Name = "bedrockRadioButton";
            this.bedrockRadioButton.Size = new System.Drawing.Size(100, 17);
            this.bedrockRadioButton.TabIndex = 1;
            this.bedrockRadioButton.TabStop = true;
            this.bedrockRadioButton.Text = "Bedrock Edition";
            this.bedrockRadioButton.UseVisualStyleBackColor = true;
            // 
            // editionGroupBox
            // 
            this.editionGroupBox.Controls.Add(this.javaRadioButton);
            this.editionGroupBox.Controls.Add(this.bedrockRadioButton);
            this.editionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.editionGroupBox.Name = "editionGroupBox";
            this.editionGroupBox.Size = new System.Drawing.Size(196, 49);
            this.editionGroupBox.TabIndex = 2;
            this.editionGroupBox.TabStop = false;
            this.editionGroupBox.Text = "Minecraft Edition";
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.Controls.Add(this.serverTextBox);
            this.serverGroupBox.Location = new System.Drawing.Point(213, 12);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(209, 49);
            this.serverGroupBox.TabIndex = 3;
            this.serverGroupBox.TabStop = false;
            this.serverGroupBox.Text = "Server Address";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(7, 20);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(190, 20);
            this.serverTextBox.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(428, 29);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_click);
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.AutoSize = true;
            this.statusTextLabel.Location = new System.Drawing.Point(6, 16);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Size = new System.Drawing.Size(43, 13);
            this.statusTextLabel.TabIndex = 5;
            this.statusTextLabel.Text = "Status: ";
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(55, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(125, 13);
            this.statusLabel.TabIndex = 6;
            // 
            // ipaddrTextLabel
            // 
            this.ipaddrTextLabel.AutoSize = true;
            this.ipaddrTextLabel.Location = new System.Drawing.Point(6, 29);
            this.ipaddrTextLabel.Name = "ipaddrTextLabel";
            this.ipaddrTextLabel.Size = new System.Drawing.Size(61, 13);
            this.ipaddrTextLabel.TabIndex = 7;
            this.ipaddrTextLabel.Text = "IP Address:";
            // 
            // networkInfoGroupBox
            // 
            this.networkInfoGroupBox.Controls.Add(this.protocolnumLabel);
            this.networkInfoGroupBox.Controls.Add(this.protocolnumberTextLabel);
            this.networkInfoGroupBox.Controls.Add(this.hostnameLabel);
            this.networkInfoGroupBox.Controls.Add(this.hostnameTextLabel);
            this.networkInfoGroupBox.Controls.Add(this.portLabel);
            this.networkInfoGroupBox.Controls.Add(this.portTextLabel);
            this.networkInfoGroupBox.Controls.Add(this.ipaddrLabel);
            this.networkInfoGroupBox.Controls.Add(this.statusLabel);
            this.networkInfoGroupBox.Controls.Add(this.statusTextLabel);
            this.networkInfoGroupBox.Controls.Add(this.ipaddrTextLabel);
            this.networkInfoGroupBox.Location = new System.Drawing.Point(18, 87);
            this.networkInfoGroupBox.Name = "networkInfoGroupBox";
            this.networkInfoGroupBox.Size = new System.Drawing.Size(190, 92);
            this.networkInfoGroupBox.TabIndex = 8;
            this.networkInfoGroupBox.TabStop = false;
            this.networkInfoGroupBox.Text = "Network Information";
            // 
            // protocolnumLabel
            // 
            this.protocolnumLabel.Location = new System.Drawing.Point(139, 68);
            this.protocolnumLabel.Name = "protocolnumLabel";
            this.protocolnumLabel.Size = new System.Drawing.Size(46, 13);
            this.protocolnumLabel.TabIndex = 14;
            // 
            // protocolnumberTextLabel
            // 
            this.protocolnumberTextLabel.AutoSize = true;
            this.protocolnumberTextLabel.Location = new System.Drawing.Point(6, 68);
            this.protocolnumberTextLabel.Name = "protocolnumberTextLabel";
            this.protocolnumberTextLabel.Size = new System.Drawing.Size(127, 13);
            this.protocolnumberTextLabel.TabIndex = 13;
            this.protocolnumberTextLabel.Text = "Protocol Version Number:";
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.Location = new System.Drawing.Point(71, 55);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(118, 13);
            this.hostnameLabel.TabIndex = 12;
            // 
            // hostnameTextLabel
            // 
            this.hostnameTextLabel.AutoSize = true;
            this.hostnameTextLabel.Location = new System.Drawing.Point(6, 55);
            this.hostnameTextLabel.Name = "hostnameTextLabel";
            this.hostnameTextLabel.Size = new System.Drawing.Size(58, 13);
            this.hostnameTextLabel.TabIndex = 11;
            this.hostnameTextLabel.Text = "Hostname:";
            // 
            // portLabel
            // 
            this.portLabel.Location = new System.Drawing.Point(41, 42);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(44, 14);
            this.portLabel.TabIndex = 10;
            // 
            // portTextLabel
            // 
            this.portTextLabel.AutoSize = true;
            this.portTextLabel.Location = new System.Drawing.Point(6, 42);
            this.portTextLabel.Name = "portTextLabel";
            this.portTextLabel.Size = new System.Drawing.Size(29, 13);
            this.portTextLabel.TabIndex = 9;
            this.portTextLabel.Text = "Port:";
            // 
            // ipaddrLabel
            // 
            this.ipaddrLabel.Location = new System.Drawing.Point(74, 29);
            this.ipaddrLabel.Name = "ipaddrLabel";
            this.ipaddrLabel.Size = new System.Drawing.Size(77, 13);
            this.ipaddrLabel.TabIndex = 8;
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(13, 56);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(120, 173);
            this.playersListBox.TabIndex = 9;
            // 
            // playersGroupBox
            // 
            this.playersGroupBox.Controls.Add(this.showuuidButton);
            this.playersGroupBox.Controls.Add(this.maximumText);
            this.playersGroupBox.Controls.Add(this.maxTextLabel);
            this.playersGroupBox.Controls.Add(this.onlineLabel);
            this.playersGroupBox.Controls.Add(this.onlineTextLabel);
            this.playersGroupBox.Controls.Add(this.playersListBox);
            this.playersGroupBox.Location = new System.Drawing.Point(456, 87);
            this.playersGroupBox.Name = "playersGroupBox";
            this.playersGroupBox.Size = new System.Drawing.Size(145, 270);
            this.playersGroupBox.TabIndex = 10;
            this.playersGroupBox.TabStop = false;
            this.playersGroupBox.Text = "Players";
            // 
            // showuuidButton
            // 
            this.showuuidButton.Location = new System.Drawing.Point(13, 235);
            this.showuuidButton.Name = "showuuidButton";
            this.showuuidButton.Size = new System.Drawing.Size(117, 22);
            this.showuuidButton.TabIndex = 15;
            this.showuuidButton.Text = "Show UUID";
            this.showuuidButton.UseVisualStyleBackColor = true;
            this.showuuidButton.Click += new System.EventHandler(this.ShowUuidButton_click);
            // 
            // maximumText
            // 
            this.maximumText.Location = new System.Drawing.Point(73, 37);
            this.maximumText.Name = "maximumText";
            this.maximumText.Size = new System.Drawing.Size(56, 16);
            this.maximumText.TabIndex = 14;
            // 
            // maxTextLabel
            // 
            this.maxTextLabel.AutoSize = true;
            this.maxTextLabel.Location = new System.Drawing.Point(13, 37);
            this.maxTextLabel.Name = "maxTextLabel";
            this.maxTextLabel.Size = new System.Drawing.Size(54, 13);
            this.maxTextLabel.TabIndex = 13;
            this.maxTextLabel.Text = "Maximum:";
            // 
            // onlineLabel
            // 
            this.onlineLabel.Location = new System.Drawing.Point(60, 20);
            this.onlineLabel.Name = "onlineLabel";
            this.onlineLabel.Size = new System.Drawing.Size(73, 13);
            this.onlineLabel.TabIndex = 11;
            // 
            // onlineTextLabel
            // 
            this.onlineTextLabel.AutoSize = true;
            this.onlineTextLabel.Location = new System.Drawing.Point(13, 20);
            this.onlineTextLabel.Name = "onlineTextLabel";
            this.onlineTextLabel.Size = new System.Drawing.Size(40, 13);
            this.onlineTextLabel.TabIndex = 10;
            this.onlineTextLabel.Text = "Online:";
            // 
            // motdGroupBox
            // 
            this.motdGroupBox.Controls.Add(this.motdWebBrowser);
            this.motdGroupBox.Location = new System.Drawing.Point(213, 87);
            this.motdGroupBox.Name = "motdGroupBox";
            this.motdGroupBox.Size = new System.Drawing.Size(236, 92);
            this.motdGroupBox.TabIndex = 12;
            this.motdGroupBox.TabStop = false;
            this.motdGroupBox.Text = "Message of the day (MOTD)";
            // 
            // motdWebBrowser
            // 
            this.motdWebBrowser.AllowNavigation = false;
            this.motdWebBrowser.AllowWebBrowserDrop = false;
            this.motdWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.motdWebBrowser.Location = new System.Drawing.Point(6, 15);
            this.motdWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.motdWebBrowser.Name = "motdWebBrowser";
            this.motdWebBrowser.Size = new System.Drawing.Size(224, 66);
            this.motdWebBrowser.TabIndex = 13;
            this.motdWebBrowser.TabStop = false;
            this.motdWebBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.softwareLabel);
            this.groupBox1.Controls.Add(this.softwareTextLabel);
            this.groupBox1.Controls.Add(this.versionLabel);
            this.groupBox1.Controls.Add(this.versionTextLabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 54);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software Information";
            // 
            // softwareLabel
            // 
            this.softwareLabel.Location = new System.Drawing.Point(66, 33);
            this.softwareLabel.Name = "softwareLabel";
            this.softwareLabel.Size = new System.Drawing.Size(78, 13);
            this.softwareLabel.TabIndex = 3;
            // 
            // softwareTextLabel
            // 
            this.softwareTextLabel.AutoSize = true;
            this.softwareTextLabel.Location = new System.Drawing.Point(7, 33);
            this.softwareTextLabel.Name = "softwareTextLabel";
            this.softwareTextLabel.Size = new System.Drawing.Size(55, 13);
            this.softwareTextLabel.TabIndex = 2;
            this.softwareTextLabel.Text = "Software: ";
            // 
            // versionLabel
            // 
            this.versionLabel.Location = new System.Drawing.Point(86, 20);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(94, 13);
            this.versionLabel.TabIndex = 1;
            // 
            // versionTextLabel
            // 
            this.versionTextLabel.AutoSize = true;
            this.versionTextLabel.Location = new System.Drawing.Point(7, 20);
            this.versionTextLabel.Name = "versionTextLabel";
            this.versionTextLabel.Size = new System.Drawing.Size(76, 13);
            this.versionTextLabel.TabIndex = 0;
            this.versionTextLabel.Text = "Game Version:";
            // 
            // pluginsGroupBox
            // 
            this.pluginsGroupBox.Controls.Add(this.plugincountLabel);
            this.pluginsGroupBox.Controls.Add(this.plugincountTextLabel);
            this.pluginsGroupBox.Controls.Add(this.pluginsListBox);
            this.pluginsGroupBox.Location = new System.Drawing.Point(18, 247);
            this.pluginsGroupBox.Name = "pluginsGroupBox";
            this.pluginsGroupBox.Size = new System.Drawing.Size(189, 110);
            this.pluginsGroupBox.TabIndex = 14;
            this.pluginsGroupBox.TabStop = false;
            this.pluginsGroupBox.Text = "Plugins";
            // 
            // plugincountLabel
            // 
            this.plugincountLabel.Location = new System.Drawing.Point(81, 91);
            this.plugincountLabel.Name = "plugincountLabel";
            this.plugincountLabel.Size = new System.Drawing.Size(99, 13);
            this.plugincountLabel.TabIndex = 2;
            // 
            // plugincountTextLabel
            // 
            this.plugincountTextLabel.AutoSize = true;
            this.plugincountTextLabel.Location = new System.Drawing.Point(7, 91);
            this.plugincountTextLabel.Name = "plugincountTextLabel";
            this.plugincountTextLabel.Size = new System.Drawing.Size(70, 13);
            this.plugincountTextLabel.TabIndex = 1;
            this.plugincountTextLabel.Text = "Plugin Count:";
            // 
            // pluginsListBox
            // 
            this.pluginsListBox.FormattingEnabled = true;
            this.pluginsListBox.Location = new System.Drawing.Point(10, 19);
            this.pluginsListBox.Name = "pluginsListBox";
            this.pluginsListBox.Size = new System.Drawing.Size(170, 69);
            this.pluginsListBox.TabIndex = 0;
            // 
            // modsGroupBox
            // 
            this.modsGroupBox.Controls.Add(this.modcountLabel);
            this.modsGroupBox.Controls.Add(this.modcountTextLabel);
            this.modsGroupBox.Controls.Add(this.modsListBox);
            this.modsGroupBox.Location = new System.Drawing.Point(213, 247);
            this.modsGroupBox.Name = "modsGroupBox";
            this.modsGroupBox.Size = new System.Drawing.Size(237, 110);
            this.modsGroupBox.TabIndex = 15;
            this.modsGroupBox.TabStop = false;
            this.modsGroupBox.Text = "Mods";
            // 
            // modcountLabel
            // 
            this.modcountLabel.Location = new System.Drawing.Point(75, 91);
            this.modcountLabel.Name = "modcountLabel";
            this.modcountLabel.Size = new System.Drawing.Size(99, 13);
            this.modcountLabel.TabIndex = 2;
            // 
            // modcountTextLabel
            // 
            this.modcountTextLabel.AutoSize = true;
            this.modcountTextLabel.Location = new System.Drawing.Point(7, 91);
            this.modcountTextLabel.Name = "modcountTextLabel";
            this.modcountTextLabel.Size = new System.Drawing.Size(62, 13);
            this.modcountTextLabel.TabIndex = 1;
            this.modcountTextLabel.Text = "Mod Count:";
            // 
            // modsListBox
            // 
            this.modsListBox.FormattingEnabled = true;
            this.modsListBox.Location = new System.Drawing.Point(10, 19);
            this.modsListBox.Name = "modsListBox";
            this.modsListBox.Size = new System.Drawing.Size(220, 69);
            this.modsListBox.TabIndex = 0;
            // 
            // worldinfoGroupBox
            // 
            this.worldinfoGroupBox.Controls.Add(this.gamemodeLabel);
            this.worldinfoGroupBox.Controls.Add(this.gamemodeTextLabel);
            this.worldinfoGroupBox.Controls.Add(this.worldNameLabel);
            this.worldinfoGroupBox.Controls.Add(this.worldNameTextLabel);
            this.worldinfoGroupBox.Location = new System.Drawing.Point(215, 186);
            this.worldinfoGroupBox.Name = "worldinfoGroupBox";
            this.worldinfoGroupBox.Size = new System.Drawing.Size(235, 54);
            this.worldinfoGroupBox.TabIndex = 16;
            this.worldinfoGroupBox.TabStop = false;
            this.worldinfoGroupBox.Text = "World Information";
            // 
            // gamemodeLabel
            // 
            this.gamemodeLabel.Location = new System.Drawing.Point(77, 32);
            this.gamemodeLabel.Name = "gamemodeLabel";
            this.gamemodeLabel.Size = new System.Drawing.Size(100, 13);
            this.gamemodeLabel.TabIndex = 3;
            // 
            // gamemodeTextLabel
            // 
            this.gamemodeTextLabel.AutoSize = true;
            this.gamemodeTextLabel.Location = new System.Drawing.Point(7, 32);
            this.gamemodeTextLabel.Name = "gamemodeTextLabel";
            this.gamemodeTextLabel.Size = new System.Drawing.Size(64, 13);
            this.gamemodeTextLabel.TabIndex = 2;
            this.gamemodeTextLabel.Text = "Gamemode:";
            // 
            // worldNameLabel
            // 
            this.worldNameLabel.Location = new System.Drawing.Point(82, 19);
            this.worldNameLabel.Name = "worldNameLabel";
            this.worldNameLabel.Size = new System.Drawing.Size(100, 13);
            this.worldNameLabel.TabIndex = 1;
            // 
            // worldNameTextLabel
            // 
            this.worldNameTextLabel.AutoSize = true;
            this.worldNameTextLabel.Location = new System.Drawing.Point(7, 19);
            this.worldNameTextLabel.Name = "worldNameTextLabel";
            this.worldNameTextLabel.Size = new System.Drawing.Size(69, 13);
            this.worldNameTextLabel.TabIndex = 0;
            this.worldNameTextLabel.Text = "World Name:";
            // 
            // Screen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 380);
            this.Controls.Add(this.worldinfoGroupBox);
            this.Controls.Add(this.modsGroupBox);
            this.Controls.Add(this.pluginsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.motdGroupBox);
            this.Controls.Add(this.playersGroupBox);
            this.Controls.Add(this.networkInfoGroupBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.serverGroupBox);
            this.Controls.Add(this.editionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(628, 419);
            this.MinimumSize = new System.Drawing.Size(628, 419);
            this.Name = "Screen1";
            this.Text = "Minecraft Server Status";
            this.editionGroupBox.ResumeLayout(false);
            this.editionGroupBox.PerformLayout();
            this.serverGroupBox.ResumeLayout(false);
            this.serverGroupBox.PerformLayout();
            this.networkInfoGroupBox.ResumeLayout(false);
            this.networkInfoGroupBox.PerformLayout();
            this.playersGroupBox.ResumeLayout(false);
            this.playersGroupBox.PerformLayout();
            this.motdGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pluginsGroupBox.ResumeLayout(false);
            this.pluginsGroupBox.PerformLayout();
            this.modsGroupBox.ResumeLayout(false);
            this.modsGroupBox.PerformLayout();
            this.worldinfoGroupBox.ResumeLayout(false);
            this.worldinfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton javaRadioButton;
        private System.Windows.Forms.RadioButton bedrockRadioButton;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label statusTextLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label ipaddrTextLabel;
        private System.Windows.Forms.Label ipaddrLabel;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.Label hostnameTextLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label portTextLabel;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Label maximumText;
        private System.Windows.Forms.Label maxTextLabel;
        private System.Windows.Forms.Label onlineLabel;
        private System.Windows.Forms.Label onlineTextLabel;
        private System.Windows.Forms.Button showuuidButton;
        private System.Windows.Forms.Label protocolnumLabel;
        private System.Windows.Forms.Label protocolnumberTextLabel;
        private System.Windows.Forms.WebBrowser motdWebBrowser;
        private System.Windows.Forms.Label softwareLabel;
        private System.Windows.Forms.Label softwareTextLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label versionTextLabel;
        private System.Windows.Forms.Label plugincountLabel;
        private System.Windows.Forms.Label plugincountTextLabel;
        private System.Windows.Forms.ListBox pluginsListBox;
        private System.Windows.Forms.Label modcountLabel;
        private System.Windows.Forms.Label modcountTextLabel;
        private System.Windows.Forms.ListBox modsListBox;
        private System.Windows.Forms.Label gamemodeTextLabel;
        private System.Windows.Forms.Label worldNameLabel;
        private System.Windows.Forms.Label worldNameTextLabel;
        private System.Windows.Forms.Label gamemodeLabel;
        private System.Windows.Forms.GroupBox editionGroupBox;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox networkInfoGroupBox;
        private System.Windows.Forms.GroupBox playersGroupBox;
        private System.Windows.Forms.GroupBox motdGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox pluginsGroupBox;
        private System.Windows.Forms.GroupBox modsGroupBox;
        private System.Windows.Forms.GroupBox worldinfoGroupBox;
    }
}

