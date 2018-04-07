using System;
using System.Windows.Forms;
using TerrariaInventoryEditor.TerrariaLib;

namespace TerrariaInventoryEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            playerBindingSource.DataSource = Terraria.Instance.Player;
            playerPictureBox.Draw();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hairClrPictureBox_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;
                colorDialog.AnyColor = true;
                colorDialog.SolidColorOnly = false;

                if (colorDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                hairClrPictureBox.BackColor = colorDialog.Color;
                playerPictureBox.Update(Terraria.Instance.Player);
                playerPictureBox.Draw();
            }
        }

        private void hairDesignerBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            using (var hairDesignerDialog = new HairDesignerForm(player.Hair, player.HairColor))
            {
                if (hairDesignerDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                player.Hair = hairDesignerDialog.HairId - 1;
                player.HairColor = hairDesignerDialog.HairColor;
                playerPictureBox.Update(player);
                playerPictureBox.Draw();
            }
        }

        private void maxOutBtn_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Health = Terraria.Instance.Player.MaxHealth = 500;
            Terraria.Instance.Player.Mana = 400;
            Terraria.Instance.Player.MaxMana = 200;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = Terraria.Instance.Player = new Player();
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

                Terraria.Instance.Player.Load(openFileDialog.FileName);
                playerBindingSource.DataSource = Terraria.Instance.Player;
                playerPictureBox.Update(Terraria.Instance.Player);
                playerPictureBox.Draw();
            }
        }

        private void playerClrPictureBox_Click(object sender, EventArgs e)
        {
            if (!(sender is PictureBox pictureBox))
            {
                return;
            }

            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;
                colorDialog.AnyColor = true;
                colorDialog.SolidColorOnly = false;

                if (colorDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                pictureBox.BackColor = colorDialog.Color;
                playerPictureBox.Update(Terraria.Instance.Player);
                playerPictureBox.Draw();
            }
        }

        private void resetHealthBtn_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Health = Terraria.Instance.Player.MaxHealth = 100;
            Terraria.Instance.Player.Mana = Terraria.Instance.Player.MaxMana = 20;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "plr";
                saveFileDialog.FileName = Terraria.Instance.Player.Name;
                saveFileDialog.Filter = "Terraria Player File (*.plr)|*.plr";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Save cancelled.", "TerrariaInventoryEditor", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                Terraria.Instance.Player.FilePath = saveFileDialog.FileName;
                Terraria.Instance.Player.Save(saveFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Terraria.Instance.Player.FilePath))
            {
                Terraria.Instance.Player.Save(Terraria.Instance.Player.FilePath);
                MessageBox.Show($"Player file saved! Path: {Terraria.Instance.Player.FilePath}",
                    "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }
    }
}