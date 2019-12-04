using GameLauncherReborn.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameLauncherReborn {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
            Text = Text + " v"+ Application.ProductVersion + " | Build: " + Self.ApplicationHash.Substring(0, 8) + " | HWID: " + Self.HWID;
        }
    }
}
