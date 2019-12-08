using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;

namespace GameLauncherReborn.Classes {
    class AnticheatMessage {
        readonly Label label;
        public static Boolean StopPinging = false;
        public AnticheatMessage(Label mainlabel) {
            label = mainlabel;
        }

        public void CallInvoke(String text, Color back) {
            if (label.InvokeRequired) {
                label.Invoke(new Action(delegate () {
                    label.Text = "    [AC] " + text;
                    label.BackColor = back;
                }));
            } else {
                label.Text = "    " + text;
                label.BackColor = back;
            }
        }

        public void ShowMessage() {
            try {
                /* @TODO: Make use of HttpRequestHandler.RequestAsync() */
                using(WebClient anticheat_data = new WebClient()) {
                    anticheat_data.Headers["X-HWID"] = Self.LegacyHWID;
                    anticheat_data.Headers["X-NewHWID"] = Self.HWID;
                    anticheat_data.Headers["X-UserAgent"] = Self.XUserAgent;
                    anticheat_data.Headers["X-GameLauncherHash"] = Self.ApplicationHash;
                    anticheat_data.Headers["X-DiscordID"] = Self.DiscordID;

                    anticheat_data.CancelAsync();
                    anticheat_data.DownloadStringAsync(new Uri("http://launcher.worldunited.gg/get_user_info.json"));
                    anticheat_data.DownloadStringCompleted += (sender, e) => {
                        if (e.Cancelled) {
                            CallInvoke("Failed to load data... retrying...", Color.Black);
                        } else if (e.Error != null) {
                            CallInvoke("Failed to load data... retrying...", Color.Black);
                        }
                        else {
                            SimpleJSON.JSONNode anticheat_results = SimpleJSON.JSON.Parse(e.Result);
                            int getStatus = Convert.ToInt32(anticheat_results["status"]?.ToString());
                            string LastKnownUsername = anticheat_results["lastknownusername"]?.ToString().Replace("\"", String.Empty);
                            StopPinging = true;
                            switch (getStatus) {
                                case 1:
                                    CallInvoke(String.Format("Ready... Set... Go {0}!", LastKnownUsername), Color.Green);
                                    break;
                                case 2:
                                    CallInvoke(String.Format("{0}, You are banned from official servers.", LastKnownUsername), Color.DarkOrange);
                                    break;
                                case 3:
                                    CallInvoke(String.Format("{0}, You are banned from all servers.", LastKnownUsername), Color.Red);
                                    break;
                                default:
                                    CallInvoke("An error occurred reading system info.", Color.Blue);
                                    StopPinging = false;
                                    break;
                            }
                        }
                    };
                }
            } catch {
                CallInvoke("Failed to load data... retrying...", Color.Black);
            }
        }
    }
}
