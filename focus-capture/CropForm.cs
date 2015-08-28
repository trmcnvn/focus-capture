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
        private bool isMouseDown = false;
        private System.Windows.Forms.Screen screen;
        private string fileName;

        public CropForm(System.Windows.Forms.Screen screen, string fileName) {
            InitializeComponent();
            this.screen = screen;
            this.fileName = fileName;
            
            // load the form up on the selected monitor
            Location = screen.Bounds.Location;

            // set to same w/h as the selected monitor
            Width = screen.Bounds.Width;
            Height = screen.Bounds.Height;

            cropPanel.Size = new Size { Width = 0, Height = 0 };
        }

        private void CropForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();
            } else if (e.KeyCode == Keys.Space) {
                // ...
            }
        }

        private void CropForm_FormClosed(object sender, FormClosedEventArgs e) {
            Dispose();
            Application.Exit();
        }

        private void CropForm_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                // enable flag
                isMouseDown = true;
                
                // initialize panel
                cropPanel.Left = e.X;
                cropPanel.Top = e.Y;
                cropPanel.Size = new Size { Width = 0, Height = 0 };
            }
        }

        private void CropForm_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && isMouseDown == true) {
                var width = Math.Abs((e.X - cropPanel.Left));
                var height = Math.Abs((e.Y - cropPanel.Top));

                cropPanel.Size = new Size {
                    Width = width,
                    Height = height
                };

                lblCoords.Text = string.Format("{0} x {1}", width, height);
            }
        }

        private void CropForm_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Close();
                Screen.Capture(cropPanel.Left, cropPanel.Top, cropPanel.Width, cropPanel.Height, fileName);
            }
        }
    }
}
