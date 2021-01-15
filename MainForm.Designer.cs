using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace VolumeDisplay
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Components of the form.
        /// </summary>
        private IContainer components = null;
        private TrackBar volumeTrackBar = new TrackBar();
        private Label volumeLevelLabel = new Label();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();

            //
            // Form setup
            //
            AutoScaleMode = AutoScaleMode.Font;

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.Manual;
            
            AllowTransparency = true;
            TransparencyKey = Color.Gray;

            DesktopBounds = new Rectangle(48, 48, 64, 192);

            Text = "0%";  // TODO: Replace with actual volume.

            //
            // volumeTrackBar setup
            //
            Controls.Add(volumeTrackBar);

            volumeTrackBar.Dock = DockStyle.Fill;
            volumeTrackBar.Orientation = Orientation.Vertical;
            volumeTrackBar.BackColor = TransparencyKey;

            volumeTrackBar.Minimum = 0;
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.TickFrequency = 25;
            volumeTrackBar.TickStyle = TickStyle.Both;
            volumeTrackBar.Value = 0;   // TODO: Replace with actual volume.

        }
    }
}
