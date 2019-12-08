using GameLauncherReborn.Classes;
using GameLauncherReborn.Events;
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
        }
    }
}
