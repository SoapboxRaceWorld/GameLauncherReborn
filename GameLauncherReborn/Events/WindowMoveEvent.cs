using GameLauncherReborn.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncherReborn.Events {
    class WindowMoveEvent {
        private static readonly Form thisform = Self.mainform;
        private static Point _mouseDownPoint = Point.Empty;

        public static void MoveWindow_MouseDown(object sender, MouseEventArgs e) {
            if (e.Y <= 90) _mouseDownPoint = new Point(e.X, e.Y);
        }

        public static void MoveWindow_MouseUp(object sender, MouseEventArgs e) {
            _mouseDownPoint = Point.Empty;
            thisform.Opacity = 1;
        }

        public static void MoveWindow_MouseMove(object sender, MouseEventArgs e) {
            if (_mouseDownPoint.IsEmpty) { return; }
            var f = thisform as Form;
            f.Location = new Point(f.Location.X + (e.X - _mouseDownPoint.X), f.Location.Y + (e.Y - _mouseDownPoint.Y));
            thisform.Opacity = 0.9;
        }
    }
}
