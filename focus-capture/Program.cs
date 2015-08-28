using System;
using System.Windows.Forms;

namespace focus_capture {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            // if the user has multiple monitors, capture the screen that the cursor is currently on.
            var theScreen = System.Windows.Forms.Screen.FromPoint(
                new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y));

            // false === full screen screenshot
            if (args.Length > 0 && Convert.ToBoolean(args[0]) == false) {
                // take a screenshot :)
                Screen.Capture(
                    theScreen.Bounds.X,
                    theScreen.Bounds.Y,
                    theScreen.Bounds.Width,
                    theScreen.Bounds.Height,
                    args[1]
                );
            } else {
                // crop, or window screenshot
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CropForm(theScreen, args[1]));
            }
        }
    }
}
