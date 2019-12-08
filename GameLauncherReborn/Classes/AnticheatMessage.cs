using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLauncherReborn.Classes {
    class AnticheatMessage {
        readonly Label label;
        public AnticheatMessage(Label mainlabel) {
            label = mainlabel;
        }

        public void ShowMessage() {
            Task.Factory.StartNew(() => {
                var task = await HttpRequestHandler.RequestAsync("https://sbrw.io/getUserInformation");
                Console.WriteLine(task.Result);
            });

            label.BackColor = Color.LightSkyBlue;
            label.Text = "TEST";
            label.AutoSize = false;
            label.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(0, 470);
            label.Size = new Size(820, 30);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Show();
            label.Click += (object x, EventArgs y) => { label.Hide(); };
        }
    }
}
