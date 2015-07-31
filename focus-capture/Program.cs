using System;

namespace focus_capture {
    class Program {
        static void Main(string[] args) {
            // false === full screen screenshot
            if (Convert.ToBoolean(args[0]) == false) {
                Screen.Capture(
                    System.Windows.Forms.Screen.PrimaryScreen.Bounds.X,
                    System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y,
                    System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width,
                    System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height,
                    args[1]
                );
            } else {
                // crop, or window screenshot

            }
        }
    }
}
