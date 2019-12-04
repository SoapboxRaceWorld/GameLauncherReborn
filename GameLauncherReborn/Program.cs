using GameLauncherReborn.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace GameLauncherReborn {
    static class Program {
        static void Main(string[] args) {
            if (IsRunning.AllRunning()) {
                MBox.ErrorMessage("An instance of the application is already running.");
            } else {
                Mutex mutex = new Mutex(false, Self.LauncherMutex);
                try {
                    if (mutex.WaitOne(0, false)) {
                        if (args.Length != 0) {
                            MBox.ErrorMessage("Arguments are not supported yet!\n\nPassed Arguments:\n" + String.Join(" ", args));
                        }

                        //Register all components for launcher, including its settings and configs.
                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));

                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(true);
                        Application.Run(new MainWindow());
                    }
                } finally {
                    mutex.Close();
                }
            }
        }
    }
}