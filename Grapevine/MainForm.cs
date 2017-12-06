using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grapevine.Models;
using YAXLib;

namespace Grapevine
{
    public partial class MainForm : Form
    {
        // The current game object.
        public Game Game { get; set; }

        // path to the currently loaded gamefile.
        public string CurrentGameFile { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Game = new Game();
            EnableMenuItems();
        }

        private void SaveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YAXSerializer yax = new YAXSerializer(typeof(Game));
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(fileDialog.FileName, yax.Serialize(this.Game));
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void EnableMenuItems(bool enable = true)
        {
            saveGameToolStripMenuItem.Enabled = true;
            foreach (ToolStripMenuItem item in saveGameToolStripMenuItem.DropDownItems)
            {
                item.Enabled = enable;
            }

            saveGameAsToolStripMenuItem.Enabled = true;
            foreach (ToolStripMenuItem item in saveGameToolStripMenuItem.DropDownItems)
            {
                item.Enabled = enable;
            }
        }
    }
}
