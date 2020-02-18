using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GameLauncherReborn.Forms;
using GameLauncherReborn.Classes.JSON;
using System.IO;
using System.Net;

namespace GameLauncherReborn.Panels {
    public partial class StartWindow : UserControl {
        private static ServerInformation _ServerList = new ServerInformation();

        public StartWindow() {
            InitializeComponent();

            ServerListOpenBtn.Click += (handler, error) => { 
                new ServerList().ShowDialog();
                serverNameTest.Text = ServerName.serverName;

                if (!string.IsNullOrEmpty(ServerName.bannerUrl)) {
                    Image image;
                    var memoryStream = new MemoryStream(new WebClient().DownloadData(ServerName.bannerUrl));
                    image = Image.FromStream(memoryStream);
                    verticalBanner.Image = image;
                    verticalBanner.BackColor = Color.Black;
                }
            };
        }

        public static ServerInformation ServerName {
            get { return _ServerList; }
            set { _ServerList = value; }
        }
    }
}
