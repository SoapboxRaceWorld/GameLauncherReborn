using GameLauncherReborn.Classes;
using GameLauncherReborn.Classes.JSON;
using GameLauncherReborn.Events;
using GameLauncherReborn.Forms;
using GameLauncherReborn.Panels;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using DiscordRPC;

namespace GameLauncherReborn {
    public partial class MainWindow : Form {
        public static DiscordRpcClient discordRpcClient;
        private readonly RichPresence _presence = new RichPresence();

        public MainWindow(string[] args) {
            Self.args = args;
            Self.mainform = this;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();
            Text = Text + " v"+ Application.ProductVersion + " | Build: " + Self.ApplicationHash.Substring(0, 8) + " | HWID: " + Self.HWID + " | GPU: " + ManagementObjects.getGPU;

            MouseDown   += new MouseEventHandler(WindowMoveEvent.MoveWindow_MouseDown);
            MouseMove   += new MouseEventHandler(WindowMoveEvent.MoveWindow_MouseMove);
            MouseUp     += new MouseEventHandler(WindowMoveEvent.MoveWindow_MouseUp);

            Thread startPinging = new Thread(() => {
                while(!AnticheatMessage.StopPinging) {
                    new AnticheatMessage(AnticheatLabel).ShowMessage();
                    Thread.Sleep(10000);
                }
            }) { IsBackground = true };

            startPinging.Start();
            startWindow1.BringToFront();

            MainMenuBtn.Click           += (handler, error) => { startWindow1.BringToFront(); };
            VinylManSettingsBtn.Click   += (handler, error) => { commingSoon1.BringToFront(); };
            AModNetSettingsBtn.Click    += (handler, error) => { commingSoon1.BringToFront(); };
            SettingsMenuBtn.Click       += (handler, error) => { commingSoon1.BringToFront(); };
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            discordRpcClient = new DiscordRpcClient(DiscordTokens.AppID);

            discordRpcClient.OnReady += (x, y) => {
                DiscordTokens.ID = y.User.ID.ToString();
                DiscordTokens.Username = y.User.Username.ToString();
                DiscordTokens.Discriminator = y.User.Username.ToString();
                DiscordTokens.Avatar = y.User.Avatar.ToString();
            };

            discordRpcClient.OnError += (x, y) => {
                MessageBox.Show($"Discord Error\n{y.Message}", y.Code.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            _presence.State = "MainWindow";
            _presence.Details = "In-Launcher: " + Application.ProductVersion;
            _presence.Assets = new Assets {
                LargeImageText = "SBRW",
                LargeImageKey = "nfsw"
            };

            discordRpcClient.SetPresence(_presence);

            discordRpcClient.Initialize();

        }
    }
}
