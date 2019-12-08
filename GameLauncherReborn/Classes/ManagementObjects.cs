using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncherReborn.Classes {
    class ManagementObjects {

        public static String getGPU = GPUName();

        public static string GPUName() {
            using(ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration")) { 
                string graphicsCard = string.Empty;
                foreach (ManagementObject mo in searcher.Get()) {
                    foreach (PropertyData property in mo.Properties) {
                        if (property.Name == "Description") {
                            return property.Value.ToString();
                        }
                    }
                }
            }

            return String.Empty;
        }
    }
}
