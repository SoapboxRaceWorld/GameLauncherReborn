using GameLauncherReborn.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GameLauncherReborn {
    public partial class MainWindow : Form {
        public MainWindow(string[] args) {
            Self.args = args;
            Self.mainform = this;
            InitializeComponent();
            Text = Text + " v"+ Application.ProductVersion + " | Build: " + Self.ApplicationHash.Substring(0, 8) + " | HWID: " + Self.HWID + " | GPU: " + ManagementObjects.getGPU;

            Thread startPinging = new Thread(() => {
                while(true) { 
                    new AnticheatMessage(AnticheatLabel).ShowMessage();
                    Thread.Sleep(500);
                }
            }) { IsBackground = true };

            startPinging.Start();
        }
    }
}
