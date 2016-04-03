using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace focus_capture {
    public partial class CropForm : Form {
        private bool isDrawing = false;
        private System.Windows.Forms.Screen screen;
        private string fileName;
        private Point startingPoint;
        private Rectangle cropRect;

        public CropForm(System.Windows.Forms.Screen screen, string fileName) {
            InitializeComponent();
            this.screen = screen;
            this.fileName = fileName;
            
            // load the form up on the selected monitor
            Location = screen.Bounds.Location;

            // set to same w/h as the selected monitor
            Width = screen.Bounds.Width;
            Height = screen.Bounds.Height;
        }

        private void CropForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();
            } else if (e.KeyCode == Keys.Space) {
                // todo
            }
        }

        private void CropForm_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isDrawing = true;
                startingPoint = new Point(e.X, e.Y);
            }
        }

        private void CropForm_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && isDrawing) {
                if (e.X > startingPoint.X) {
                    cropRect = new Rectangle(
                        startingPoint.X <= e.X ? startingPoint.X : e.X,
                        startingPoint.Y <= e.Y ? startingPoint.Y : e.Y,
                        e.X - startingPoint.X <= 0 ? startingPoint.X - e.X : e.X - startingPoint.X,
                        e.Y - startingPoint.Y <= 0 ? startingPoint.Y - e.Y : e.Y - startingPoint.Y);
                } else {
                    cropRect = new Rectangle(
                        e.X <= startingPoint.X ? e.X : startingPoint.X,
                        e.Y <= startingPoint.Y ? e.Y : startingPoint.Y,
                        startingPoint.X - e.X <= 0 ? startingPoint.X - e.X : startingPoint.X - e.X,
                        startingPoint.Y - e.Y <= 0 ? e.Y - startingPoint.Y : startingPoint.Y - e.Y);
                }
            }
            Invalidate();
        }

        private void CropForm_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && isDrawing) {
                Close();
                Screen.Capture(cropRect.Left, cropRect.Top, cropRect.Width, cropRect.Height, fileName);
            }
        }

        private void CropForm_Paint(object sender, PaintEventArgs e) {
            using (Pen pen = new Pen(Color.White, 2)) {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, cropRect);
            }
        }

        private void CropForm_FormClosed(object sender, FormClosedEventArgs e) {
            Dispose();
            Application.Exit();
        }
    }
}
