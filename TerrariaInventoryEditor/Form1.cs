using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaInventoryEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Set default values
            playerNameTxtBox.Text = Terraria.Terraria.Instance.Player.Name;
            difficultyCmbBox.Text = Terraria.Terraria.Instance.Player.Difficulty.ToString();
            skinVariantUpDown.Value = Terraria.Terraria.Instance.Player.SkinVariant;
            currentHealthBox.Text = Terraria.Terraria.Instance.Player.Health.ToString();
            maxHealthBox.Text = Terraria.Terraria.Instance.Player.MaxHealth.ToString();
            currentManaBox.Text = Terraria.Terraria.Instance.Player.Mana.ToString();
            maxManaBox.Text = Terraria.Terraria.Instance.Player.MaxMana.ToString();
        }

        private void currentHealthBox_TextChanged(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Unable to load player file!", "Error", MessageBoxButtons.OK);
                    return;
                }

                Terraria.Terraria.Instance.Player.Load(openFileDialog.FileName);
                playerNameTxtBox.Text = Terraria.Terraria.Instance.Player.Name;
                difficultyCmbBox.Text = Terraria.Terraria.Instance.Player.Difficulty.ToString();
                skinVariantUpDown.Value = Terraria.Terraria.Instance.Player.SkinVariant;
                currentHealthBox.Text = Terraria.Terraria.Instance.Player.Health.ToString();
                maxHealthBox.Text = Terraria.Terraria.Instance.Player.MaxHealth.ToString();
                currentManaBox.Text = Terraria.Terraria.Instance.Player.Mana.ToString();
                maxManaBox.Text = Terraria.Terraria.Instance.Player.MaxMana.ToString();
            }
        }
    }
}
