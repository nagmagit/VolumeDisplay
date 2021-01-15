using System;
using System.Windows.Forms;

namespace VolumeDisplay
{
    public partial class MainForm : Form
    {
        private void AddEventHandlers()
        {
            Load += new EventHandler(MainForm_Load);

            volumeTrackBar.ValueChanged += new EventHandler(VolumeChanged);
        }

        private void MainForm_Load(object sender, EventArgs obj)
        {
            AlwaysOnTopHelper.Set(this.Handle);
            AeroGlassHelper.Set(this.Handle);
        }

        private void VolumeChanged(object sender, EventArgs e)
        {
            volumeLevelLabel.Text = $"{volumeTrackBar.Value}%";
        }
    }
}