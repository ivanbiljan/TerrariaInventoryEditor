using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TerrariaInventoryEditor.TerrariaLib;

namespace TerrariaInventoryEditor.Forms
{
    public partial class MainForm : Form
    {
        private readonly Random _random = new Random();
        private readonly List<Button> _inventoryItems = new List<Button>();
        private Button _selectedItem;

        public MainForm()
        {
            InitializeComponent();

            playerBindingSource.DataSource = Terraria.Instance.Player;
            buffSearchBox.DataSource = Terraria.Instance.Buffs;
            itemSearchBox.DataSource = Terraria.Instance.Items;
            itemPrefixComboBox.DataSource = Enum.GetValues(typeof(ItemPrefix)).Cast<ItemPrefix>().ToList();

            for (var i = 0; i < 58; ++i)
            {
                if (!(Controls.Find($"inventoryItem{i}", true).SingleOrDefault() is Button item))
                {
                    continue;
                }

                item.Tag = i;
                _inventoryItems.Add(item);
            }

            playerPictureBox.Draw();
            DrawInventory();
        }

        #region Toolstrip Items

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = Terraria.Instance.Player = new Player();

            itemPrefixComboBox.SelectedIndex = 0;
            stackSizeUpDown.Value = 1;
            DrawInventory();
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

                playerPictureBox.Draw();
                DrawInventory();
            }
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

        #endregion

        #region Stats

        private void maxOutBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Health = player.MaxHealth = 32767;
            player.Mana = player.MaxMana = 200;
        }

        private void resetHealthBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Health = player.MaxHealth = 100;
            player.Mana = player.MaxMana = 20;
        }

        #endregion

        #region Appearance

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
                playerPictureBox.Draw();
            }
        }

        private void randomizeColorsBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.EyeColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            player.HairColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            player.PantsColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            player.ShirtColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            player.ShoeColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            player.SkinColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            player.UndershirtColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

            playerPictureBox.Draw();
        }

        private void randomizeHairBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Hair = _random.Next(134);
            player.HairColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

            playerPictureBox.Draw();
        }

        #endregion

        #region Buffs

        private void buffSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            var selectedBuff = (Buff) buffSearchBox.SelectedItem;
            player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].SetDefaults(selectedBuff.Id);
            player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].Time = int.MaxValue;
        }

        private void buffFilterTxtBox_TextChanged(object sender, EventArgs e)
        {
            buffSearchBox.SelectedIndexChanged -= buffSearchBox_SelectedIndexChanged;
            if (string.IsNullOrWhiteSpace(buffFilterTxtBox.Text))
            {
                buffSearchBox.DataSource = Terraria.Instance.Buffs;
            }
            else
            {
                buffSearchBox.DataSource = (from buff in Terraria.Instance.Buffs
                    where buff.Name.ToLowerInvariant().Contains(buffFilterTxtBox.Text.ToLowerInvariant())
                    select buff).ToList();
            }

            buffSearchBox.SelectedIndexChanged += buffSearchBox_SelectedIndexChanged;
        }

        private void deleteAllBuffsBtn_Click(object sender, EventArgs e)
        {
            foreach (var buff in Terraria.Instance.Player.Buffs.Where(b => b.Id != 0))
            {
                buff.SetDefaults(0);
            }

            buffDisplayGrid.Refresh();
        }

        private void deleteBuffBtn_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].SetDefaults(0);
            buffDisplayGrid.Refresh();
        }

        private void maxDurationBtn_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].Time = int.MaxValue;
            buffDisplayGrid.Refresh();
        }

        private void maxAllDurationsBtn_Click(object sender, EventArgs e)
        {
            foreach (var buff in Terraria.Instance.Player.Buffs.Where(b => b.Id != 0))
            {
                buff.Time = int.MaxValue;
            }

            buffDisplayGrid.Refresh();
        }

        #endregion

        #region Inventory

        private void deleteAllItemsBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            foreach (var item in player.Inventory.Where(i => i.NetId != 0))
            {
                item.SetDefaults(0);
            }

            DrawInventory();
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            player.Inventory[(int) _selectedItem.Tag] = new Item();

            _selectedItem.Image = new Bitmap("Data\\ItemTextures\\Item_0.png");
            _selectedItem.Text = string.Empty;
        }

        private void inventoryItem_GotFocus(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            var button = (Button) sender;

            button.BackColor = Color.DeepSkyBlue;
            foreach (var inventoryButton in _inventoryItems.Where(b => b != button))
            {
                inventoryButton.BackColor = Color.FromArgb(90, 90, 180);
            }

            _selectedItem = button;
            itemPrefixComboBox.SelectedItem = player.Inventory[(int) button.Tag].Prefix;
            stackSizeUpDown.Value = player.Inventory[(int) button.Tag].StackSize > 0
                ? player.Inventory[(int) button.Tag].StackSize
                : 1;
        }

        private void itemFilterTxtBox_TextChanged(object sender, EventArgs e)
        {
            itemSearchBox.SelectedIndexChanged -= itemSearchBox_SelectedIndexChanged;
            if (string.IsNullOrWhiteSpace(itemFilterTxtBox.Text))
            {
                itemSearchBox.DataSource = Terraria.Instance.Items;
            }
            else
            {
                itemSearchBox.DataSource = (from item in Terraria.Instance.Items
                    where item.Name.ToLowerInvariant().Contains(itemFilterTxtBox.Text.ToLowerInvariant())
                    select item).ToList();
            }

            itemSearchBox.SelectedIndexChanged += itemSearchBox_SelectedIndexChanged;
        }

        private void itemSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            if (_selectedItem == null)
            {
                return;
            }

            var selectedItem = (Item) itemSearchBox.SelectedItem;
            player.Inventory[(int) _selectedItem.Tag].SetDefaults(selectedItem.NetId);
            player.Inventory[(int) _selectedItem.Tag].StackSize = selectedItem.MaxStack;

            _selectedItem.Image = selectedItem.Image;
            _selectedItem.Text = selectedItem.StackSize.ToString();
        }

        private void maxAllStacksBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            foreach (var item in _inventoryItems)
            {
                if (player.Inventory[(int) item.Tag].NetId == 0)
                {
                    continue;
                }

                player.Inventory[(int) item.Tag].StackSize = player.Inventory[(int) item.Tag].MaxStack;
            }

            DrawInventory();
        }

        private void maxStackBtn_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            if (player.Inventory[(int) _selectedItem.Tag].NetId == 0)
            {
                return;
            }

            player.Inventory[(int) _selectedItem.Tag].StackSize = player.Inventory[(int) _selectedItem.Tag].MaxStack;
            _selectedItem.Text = player.Inventory[(int) _selectedItem.Tag].StackSize.ToString();
        }

        private void prefixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            if (player.Inventory[(int) _selectedItem.Tag].NetId == 0)
            {
                return;
            }

            player.Inventory[(int) _selectedItem.Tag].Prefix = (ItemPrefix) itemPrefixComboBox.SelectedItem;
        }

        private void stackSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            if (player.Inventory[(int) _selectedItem.Tag].NetId == 0)
            {
                return;
            }

            player.Inventory[(int) _selectedItem.Tag].StackSize = (int) stackSizeUpDown.Value;
            _selectedItem.Text = player.Inventory[(int) _selectedItem.Tag].StackSize.ToString();
        }

        #endregion

        #region Miscellaneous Methods

        private void DrawInventory()
        {
            var player = Terraria.Instance.Player;
            for (var i = 0; i < 58; ++i)
            {
                var item = _inventoryItems[i];

                item.Image = player.Inventory[i].Image;
                item.Text = player.Inventory[i].StackSize.ToString();
            }
        }

        #endregion
    }
}