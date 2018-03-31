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
using Terraria = TerrariaInventoryEditor.Terraria.Terraria;

namespace TerrariaInventoryEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Set default values
            //playerNameTxtBox.Text = Terraria.Terraria.Instance.Player.Name;
            //difficultyCmbBox.Text = Terraria.Terraria.Instance.Player.Difficulty.ToString();
            //skinVariantUpDown.Value = Terraria.Terraria.Instance.Player.SkinVariant;
            //currentHealthBox.Text = Terraria.Terraria.Instance.Player.Health.ToString();
            //maxHealthBox.Text = Terraria.Terraria.Instance.Player.MaxHealth.ToString();
            //currentManaBox.Text = Terraria.Terraria.Instance.Player.Mana.ToString();
            //maxManaBox.Text = Terraria.Terraria.Instance.Player.MaxMana.ToString();
            playerBindingSource.DataSource = Terraria.Terraria.Instance.Player;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.AddExtension = true;
                openFileDialog.Filter = "Terraria Player Files (*.plr)|*.plr|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a Player File";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Unable to load player file!", "TerrariaInventoryEditor", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Terraria.Terraria.Instance.Player.Load(openFileDialog.FileName);
                playerBindingSource.DataSource = Terraria.Terraria.Instance.Player;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Terraria.Terraria.Instance.Player.FilePath))
            {
                Terraria.Terraria.Instance.Player.Save(Terraria.Terraria.Instance.Player.FilePath);
                MessageBox.Show($"Player file saved! Path: {Terraria.Terraria.Instance.Player.FilePath}", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "plr";
                saveFileDialog.FileName = Terraria.Terraria.Instance.Player.Name;
                saveFileDialog.Filter = "Terraria Player File (*.plr)|*.plr";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Save cancelled.", "TerrariaInventoryEditor", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                Terraria.Terraria.Instance.Player.Save(saveFileDialog.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = Terraria.Terraria.Instance.Player = new Terraria.Player();
        }

        private void resetHealthBtn_Click(object sender, EventArgs e)
        {
            Terraria.Terraria.Instance.Player.Health = Terraria.Terraria.Instance.Player.MaxHealth = 100;
            Terraria.Terraria.Instance.Player.Mana = Terraria.Terraria.Instance.Player.MaxMana = 20;
        }

        private void maxOutBtn_Click(object sender, EventArgs e)
        {
            Terraria.Terraria.Instance.Player.Health = Terraria.Terraria.Instance.Player.MaxHealth = 500;
            Terraria.Terraria.Instance.Player.Mana = 400;
            Terraria.Terraria.Instance.Player.MaxMana = 200;
        }
    }
}