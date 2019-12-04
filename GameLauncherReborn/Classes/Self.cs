using GameLauncherReborn.Classes.Hash;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameLauncherReborn.Classes {
    class Self {
        public static String LauncherMutex      = "Global\\{67FBD5B0-B61F-456A-A9B8-7F05A8C654E2}";
        public static String GameMutex          = "Global\\{3E34CEFB-7B34-4e62-8034-33256B8BC2F7}";
        public static String HWID               = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "HWID-NOT-IMPL");
        public static String LegacyHWID         = Classes.LegacyHWID.Value();
        public static String UserAgent          = "GameLauncher (+https://github.com/SoapboxRaceWorld/GameLauncher_NFSW)";
        public static String XUserAgent         = "GameLauncher " + Application.ProductVersion + " (+https://sbrw.io/download)";
        public static String ApplicationHash    = SHA.HashFile(Application.ExecutablePath);
        public static String DiscordID          = String.Empty;
        public static int[] anticheatAddresses  = new int[]     { 418534,          418534,          4552702,     4476396,  4506534,     4587060,    4486168 };
        public static String[] anticheatNames   = new String[]  { "GMZ_MULTIHACK", "FAST_POWERUPS", "SPEEDHACK", "SWALLS", "TANKMODE",  "WALLHACK", "HANDLING" };
    }
}