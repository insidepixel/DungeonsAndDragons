using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNDClone
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            trackTextSpeed.Value = Properties.Settings.Default.TextSpeed;
            labelTextSpeed.Text = trackTextSpeed.Value.ToString();
            trackDifficulty.Value = Properties.Settings.Default.Difficulty;
            labelDifficulty.Text = trackDifficulty.Value.ToString();
        }

        private void trackTextSpeed_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.TextSpeed = trackTextSpeed.Value;
            labelTextSpeed.Text = trackTextSpeed.Value.ToString();
            Properties.Settings.Default.Save();
        }

        private void trackDifficulty_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = trackDifficulty.Value;
            labelDifficulty.Text = trackDifficulty.Value.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
