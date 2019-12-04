using GameLauncherReborn.Classes.Hash;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncherReborn.Classes {
    class HttpRequestHandler {
        public static String Request(String address, Dictionary<string, string> data = null) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(address);
            request.UserAgent = Self.UserAgent;
            request.Headers["X-HWID"]               = Self.LegacyHWID;
            request.Headers["X-NewHWID"]            = Self.HWID;
            request.Headers["X-UserAgent"]          = Self.XUserAgent;
            request.Headers["X-GameLauncherHash"]   = Self.ApplicationHash;
            request.Headers["X-DiscordID"]          = Self.DiscordID;
            request.Timeout                         = 5000;

            if(data.Count != 0) {
                byte[] PostBytes = Encoding.ASCII.GetBytes(string.Join("&", data.Select(x => x.Key + "=" + x.Value).ToArray()));

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = PostBytes.Length;

                using (var stream = request.GetRequestStream()) {
                    stream.Write(PostBytes, 0, PostBytes.Length);
                }
            }

            WebResponse response;

            try { 
                response = request.GetResponse();
            } catch (WebException ex) {
                response = (WebResponse)ex.Response;
            }

            using(StreamReader return_response = new StreamReader(response.GetResponseStream())) {
                return return_response.ReadToEnd();
            }
        }
    }
}
