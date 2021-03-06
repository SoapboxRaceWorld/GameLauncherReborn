﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncherReborn.Classes.JSON {
    public class ServerInformation {
        public string messageSrv { get; set; }
        public string homePageUrl { get; set; }
        public string facebookUrl { get; set; }
        public string discordUrl { get; set; }
        public string serverName { get; set; }
        public string country { get; set; }
        public int timezone { get; set; }
        public string bannerUrl { get; set; }
        public string adminList { get; set; }
        public string ownerList { get; set; }
        public int numberOfRegistered { get; set; }
        public List<string> activatedHolidaySceneryGroups { get; set; }
        public List<string> disactivatedHolidaySceneryGroups { get; set; }
        public int onlineNumber { get; set; }
        public string requireTicket { get; set; }
        public string serverVersion { get; set; }
        public int maxUsersAllowed { get; set; }
        public string allowedCountries { get; set; }
        public string freeroamMapSocket { get; set; }
        public List<string> freeroamServers { get; set; }
        public string modernAuthSupport { get; set; }
        public int secondsToShutDown { get; set; }
        public string modsUrl { get; set; }
        public bool rwacallow { get; set; }
    }

    public class FreeroamObject {
        public int[] position { get; set; }
        public string username { get; set; }
    }
}
