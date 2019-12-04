using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameLauncherReborn.Classes {
    class MBox {
        public static void ErrorMessage(String message) {
            MessageBox.Show(null, message, "GameLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
