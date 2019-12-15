using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameLauncherReborn.Classes {
    class IsRunning {
        public static bool GameRunning() {
            return CheckMutex(Self.GameMutex);
        }

        public static bool LauncherRunning() {
            return CheckMutex(Self.LauncherMutex);
        }

        public static bool LegacyLauncherRunning() {
            return CheckMutex(Self.LegacyLauncherMutex);
        }

        public static bool AllRunning() {
            return LauncherRunning() || GameRunning() || LegacyLauncherRunning();
        }

        private static bool CheckMutex(String MutexID) {
            Mutex mutex = new Mutex(false, MutexID);
            try {
                return (!mutex.WaitOne(0, false)) ? true : false;
            } catch {
                return false;
            } finally {
                if (mutex != null) {
                    mutex.Close();
                }
            }
        }
    }
}
