namespace focus_capture {
    partial class CropForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cropPanel = new System.Windows.Forms.Panel();
            this.lblCoords = new System.Windows.Forms.Label();
            this.cropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cropPanel
            // 
            this.cropPanel.BackColor = System.Drawing.Color.White;
            this.cropPanel.Controls.Add(this.lblCoords);
            this.cropPanel.Location = new System.Drawing.Point(12, 12);
            this.cropPanel.Name = "cropPanel";
            this.cropPanel.Size = new System.Drawing.Size(200, 100);
            this.cropPanel.TabIndex = 0;
            // 
            // lblCoords
            // 
            this.lblCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoords.AutoSize = true;
            this.lblCoords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoords.Location = new System.Drawing.Point(87, 55);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(63, 21);
            this.lblCoords.TabIndex = 0;
            this.lblCoords.Text = "Coords";
            // 
            // CropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(573, 373);
            this.ControlBox = false;
            this.Controls.Add(this.cropPanel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CropForm";
            this.Opacity = 0.3D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CaptureForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CropForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CropForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CropForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CropForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CropForm_MouseUp);
            this.cropPanel.ResumeLayout(false);
            this.cropPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cropPanel;
        private System.Windows.Forms.Label lblCoords;
    }
}