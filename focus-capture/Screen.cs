using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace focus_capture {
    public static class Screen {
        public static void Capture(int x, int y, int width, int height, string fileName) {
            using (var bitmap = new Bitmap(width, height)) {
                using (var gfx = Graphics.FromImage(bitmap)) {
                    gfx.CopyFromScreen(x, y, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
                }
                var file = Path.GetTempPath() + fileName;
                bitmap.Save(file, ImageFormat.Png);
            }
        }
    }
}
