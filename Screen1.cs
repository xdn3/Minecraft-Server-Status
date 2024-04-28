using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;

namespace Minecraft_Server_Status
{
    public partial class Screen1 : Form
    {
        internal static Structs.ServerInfo serverInfo;
        public Screen1()
        {
            InitializeComponent();
        }

        private async void CheckButton_click(object sender, EventArgs e)
        {
            checkButton.Enabled = false;
            checkButton.Text = "Getting data...";
            await Task.Run(() =>
            {
                string? addr = serverTextBox.Text;
                if (string.IsNullOrWhiteSpace(addr))
                {
                    MessageBox.Show("Server addresss is empty.", "Invalid server address.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (javaRadioButton.Checked)
                {
                    serverInfo = Api.GetInfoJava(addr).Result;
                }
                else if (bedrockRadioButton.Checked)
                {
                    serverInfo = Api.GetInfoBedrock(addr).Result;
                }
            });
            try
            {
                if (serverInfo.online == true) { statusLabel.ForeColor = System.Drawing.Color.Green; statusLabel.Text = "Online"; } else if (serverInfo.online == false) { statusLabel.ForeColor = System.Drawing.Color.Red; statusLabel.Text = "Offline"; } else { statusLabel.ForeColor = System.Drawing.Color.Black; statusLabel.Text = "Unknown"; }
                if (serverInfo.ip != null) { ipaddrLabel.Text = serverInfo.ip; } else { ipaddrLabel.Text = "Unknown"; }
                if (serverInfo.port != null) { portLabel.Text = serverInfo.port.ToString(); } else { portLabel.Text = "Unknown"; }
                if (serverInfo.hostname != null) { hostnameLabel.Text = serverInfo.hostname; } else { hostnameLabel.Text = "Unknown"; }
                if (serverInfo.protocol != null) { protocolnumLabel.Text = serverInfo.protocol.ToString(); } else { protocolnumLabel.Text = "Unknown"; }
                if (serverInfo.motd["html"] != null)
                {
                    string html = "";
                    foreach (var item in serverInfo.motd["html"])
                    {
                        html += item.ToString();
                    }
                    motdWebBrowser.DocumentText = html;
                    motdWebBrowser.Refresh();
                }
                else { motdWebBrowser.DocumentText = "Unknown"; }
                if (serverInfo.version != null) { versionLabel.Text = serverInfo.version; } else { versionLabel.Text = "Unknown"; }
                if (serverInfo.software != null) { softwareLabel.Text = serverInfo.software; } else { softwareLabel.Text = "Unknown"; }
                if (serverInfo.map != null) { worldNameLabel.Text = serverInfo.map; } else { worldNameLabel.Text = "Unknown"; }
                if (serverInfo.gamemode != null) { gamemodeLabel.Text = serverInfo.gamemode; } else { gamemodeLabel.Text = "Unknown"; }
                if (serverInfo.players.online != null) { onlineLabel.Text = serverInfo.players.online.ToString(); } else { onlineLabel.Text = "Unknown"; }
                if (serverInfo.players.max != null) { maximumText.Text = serverInfo.players.max.ToString(); } else { maximumText.Text = "Unknown"; }
                try
                {
                    playersListBox.Items.Clear();
                    foreach (var item in serverInfo.players.list)
                    {
                        playersListBox.Items.Add(item.ToString());
                    }
                }
                catch (NullReferenceException)
                {
                    playersListBox.Items.Clear();
                }
                try
                {
                    pluginsListBox.Items.Clear();
                    foreach (var item in serverInfo.plugins.raw)
                    {
                        pluginsListBox.Items.Add(item.ToString());
                    }
                }
                catch (NullReferenceException)
                {
                    playersListBox.Items.Clear();
                }
                try
                {
                    modsListBox.Items.Clear();
                    foreach (var item in serverInfo.mods.raw)
                    {
                        modsListBox.Items.Add(item.ToString());
                    }
                }
                catch (NullReferenceException)
                {
                    modsListBox.Items.Clear();
                }
                checkButton.Text = "Check";
                checkButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                checkButton.Text = "Check";
                checkButton.Enabled = true;
            }
        }

        private void ShowUuidButton_click(object sender, EventArgs e)
        {
            string player;
            try
            {
                player = playersListBox.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No player selected. Please select a player from the list.", "No player selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (serverInfo.players.list.Count == 0)
            {
                MessageBox.Show("No data. Please first specify a server and click 'Check'.", "No data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"UUID of {player}: {serverInfo.players.uuid[player]}", "UUID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

    }
}
