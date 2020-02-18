using GameLauncherReborn.Classes;
using GameLauncherReborn.Classes.JSON;
using GameLauncherReborn.Panels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncherReborn.Forms {
    public partial class ServerList : Form {
        private int ID = 0;
        Dictionary<int, ServerInformation> rememberServerInformationID = new Dictionary<int, ServerInformation>();
        private ServerInformation ServerInfo;

        public ServerList() {
            InitializeComponent();

            ServerListRenderer.View = View.Details;
            ServerListRenderer.FullRowSelect = true;

            ServerListRenderer.Columns.Add("ID"); 
            ServerListRenderer.Columns[0].Width = 25;

            ServerListRenderer.Columns.Add("Name"); 
            ServerListRenderer.Columns[1].Width = 320;

            ServerListRenderer.Columns.Add("Players Online"); 
            ServerListRenderer.Columns[2].Width = 80;
            ServerListRenderer.Columns[2].TextAlign = HorizontalAlignment.Center;

            ServerListRenderer.Columns.Add("Ping"); 
            ServerListRenderer.Columns[3].Width = 47;
            ServerListRenderer.Columns[3].TextAlign = HorizontalAlignment.Center;

            String response = new WebClient().DownloadString("http://launcher.worldunited.gg/serverlist.txt");
            String[] substrings = response.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (var substring in substrings) {
                if (!String.IsNullOrEmpty(substring)) {
                    String[] substrings2 = substring.Split(new string[] { ";" }, StringSplitOptions.None);
                    
                    try {
                        ServerInformation content = JsonConvert.DeserializeObject<ServerInformation>(new WebClient().DownloadString(substrings2[1] + "/GetServerInformation"));

                        Console.Write(content);

                        if(content != null) { 
                        ServerListRenderer.Items.Add(new ListViewItem(
                            new[] {
                                ID.ToString(),
                                content.serverName != String.Empty ? content.serverName : substrings2[0],
                                content.onlineNumber + "/" + content.numberOfRegistered,
                                new Random().Next(10, 99) + "ms"
                            }
                        ));
                        }

                        rememberServerInformationID.Add(ID, content);
                        ID++;
                    } catch {

                    }
                }
            }

            ServerListRenderer.AllowColumnReorder = false;
            ServerListRenderer.ColumnWidthChanging += (handler, args) => {
                args.Cancel = true;
                args.NewWidth = ServerListRenderer.Columns[args.ColumnIndex].Width;
            };

            ServerListRenderer.DoubleClick += new EventHandler((handler, args) => {
                if (ServerListRenderer.SelectedItems.Count == 1) {
                    rememberServerInformationID.TryGetValue(ServerListRenderer.SelectedIndices[0], out ServerInfo);

                    StartWindow.ServerName = ServerInfo;

                    this.Close();
                }
            });
        }


        private void button1_Click(object sender, EventArgs e) {  }
    }
}
