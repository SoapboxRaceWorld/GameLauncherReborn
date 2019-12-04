﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncherReborn.Classes.Hash {
    class SHA {
        public static string HashPassword(string input) {
            HashAlgorithm algorithm = SHA1.Create();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in algorithm.ComputeHash(Encoding.UTF8.GetBytes(input)))
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }

        public static string HashFile(string filename) {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] retVal = sha1.ComputeHash(File.OpenRead(filename));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++) {
                sb.Append(retVal[i].ToString("x2"));
            }

            return sb.ToString().ToUpper();
        }
    }
}
