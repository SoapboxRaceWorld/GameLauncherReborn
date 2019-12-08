using GameLauncherReborn.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace GameLauncherReborn {
    static class Program {
        static void Main(string[] args) {
            Self.isDebugMode = Debugger.IsAttached;

            if (IsRunning.AllRunning()) {
                MBox.ErrorMessage("An instance of the application is already running.");
            } else {
                Mutex mutex = new Mutex(false, Self.LauncherMutex);
                try {
                    if (mutex.WaitOne(0, false)) {
                        if (args.Length != 0) {
                            MBox.ErrorMessage("Arguments are not supported yet!\n\nPassed Arguments:\n" + String.Join(" ", args));
                        }

                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));

                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                        Application.ThreadException += (sender, exception) => { ExceptionCapture((Exception)exception.Exception, "ThreadExceptionEventHandler"); };
                        AppDomain.CurrentDomain.UnhandledException += (sender, exception) => { ExceptionCapture((Exception)exception.ExceptionObject, "UnhandledExceptionEventHandler"); };
                        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(true);
                        Application.Run(new MainWindow(args));
                    }
                } finally {
                    mutex.Close();
                }
            }
        }

        public static void ExceptionCapture(Exception exception, String className) {
            MBox.ErrorMessage(className + ": " + exception.Message);
        }
    }
}