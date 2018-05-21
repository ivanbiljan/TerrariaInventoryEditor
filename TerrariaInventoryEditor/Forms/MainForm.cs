using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TerrariaInventoryEditor.Framework;
using TerrariaInventoryEditor.TerrariaLib;

namespace TerrariaInventoryEditor.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<Button> _dyeItems = new List<Button>();
        private readonly List<Button> _equipmentItems = new List<Button>();
        private readonly List<Button> _inventoryItems = new List<Button>();
        private readonly Random _random = new Random();

        private Button _selectedEquip;
        private Button _selectedItem;

        public MainForm()
        {
            InitializeComponent();

            // Set the default size 
            Width = 687;
            Height = 298;

            // Initialize player texture files
            TextureManager.Instance.Load();

            // Setup data sources
            playerBindingSource.DataSource = Terraria.Instance.Player;
            equipmentSearchBox.DataSource = GetFilteredEquipmentList();
            buffSearchBox.DataSource = Terraria.Instance.Buffs;
            itemSearchBox.DataSource = Terraria.Instance.Items;
            itemPrefixComboBox.DataSource = Enum.GetValues(typeof(ItemPrefix)).Cast<ItemPrefix>().ToList();

            // Store dye labels
            for (var i = 0; i < 10; i++)
            {
                if (!(Controls.Find($"dyeItem{i}", true).SingleOrDefault() is Button dyeItem))
                {
                    continue;
                }

                dyeItem.Tag = i;
                _dyeItems.Add(dyeItem);
            }

            // Store equipment labels
            for (var i = 0; i < 20; ++i)
            {
                if (!(Controls.Find($"equipmentItem{i}", true).SingleOrDefault() is Button equipmentItem))
                {
                    continue;
                }

                equipmentItem.Tag = i;
                _equipmentItems.Add(equipmentItem);
            }

            // Store inventory labels
            for (var i = 0; i < 58; ++i)
            {
                if (!(Controls.Find($"inventoryItem{i}", true).SingleOrDefault() is Button inventoryItem))
                {
                    continue;
                }

                inventoryItem.Tag = i;
                _inventoryItems.Add(inventoryItem);
            }

            // Draw the character
            playerPictureBox.Draw();
            DrawEquipment();
            DrawInventory();
        }

        private static List<Item> GetFilteredEquipmentList(string filter = null)
        {
            var items = (from item in Terraria.Instance.Items
                where item.BodySlot > 0 || item.HeadSlot > 0 || item.LegSlot > 0 || item.IsAccessory
                orderby item.Name
                select item).ToList();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                return items.Where(i => i.Name.ToLowerInvariant().Contains(filter.ToLowerInvariant())).ToList();
            }

            return items;
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

        private void buffSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buffDisplayGrid.CurrentCell == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            var selectedBuff = (Buff) buffSearchBox.SelectedItem;
            player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].SetDefaults(selectedBuff.Id);
            player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].Time = int.MaxValue;
        }

        private void deleteAllBuffsBtn_Click(object sender, EventArgs e)
        {
            foreach (var buff in Terraria.Instance.Player.Buffs.Where(b => b.Id != 0))
            {
                buff.SetDefaults(0);
            }

            buffDisplayGrid.Refresh();
        }

        private void deleteAllItemsBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            foreach (var item in player.Inventory.Where(i => i.NetId != 0))
            {
                item.SetDefaults(0);
            }

            DrawInventory();
        }

        private void deleteBuffBtn_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].SetDefaults(0);
            buffDisplayGrid.Refresh();
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

        private void DrawEquipment()
        {
            var player = Terraria.Instance.Player;
            for (var i = 0; i < player.Armor.Length - 2; ++i) // TODO: Temporarily unsupported hidden accessory slots
            {
                if (i < player.Dye.Length - 1)
                {
                    _dyeItems[i].Image = player.Dye[(int) _dyeItems[i].Tag].Image;
                }

                _equipmentItems[i].Image = player.Armor[(int) _equipmentItems[i].Tag].Image;
            }
        }

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

        private void equipmentFilterTxtBox_TextChanged(object sender, EventArgs e)
        {
            equipmentSearchBox.DataSource = GetFilteredEquipmentList(equipmentFilterTxtBox.Text);
        }

        private void equipmentItem_GotFocus(object sender, EventArgs e)
        {
            var button = (Button) sender;

            button.BackColor = Color.FromArgb(0, 171, 229);
            foreach (var equipmentButton in _equipmentItems.Concat(_dyeItems).Where(b => b != button))
            {
                equipmentButton.BackColor = Color.FromArgb(90, 90, 180);
            }

            _selectedEquip = button;
        }

        private void equipmentItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            var button = (Button) sender;
            if (e.Location.X < 0 || e.Location.X > button.Width)
            {
                return;
            }
            if (e.Location.Y < 0 || e.Location.Y > button.Height)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            if (_dyeItems.Contains(button))
            {
                player.Dye[(int) button.Tag].SetDefaults(0);
            }
            else
            {
                player.Armor[(int) button.Tag].SetDefaults(0);
            }

            button.Image = new Bitmap("Data\\ItemTextures\\Item_0.png");
        }

        private void equipmentSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedEquip == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            var selectedItem = (Item) equipmentSearchBox.SelectedItem;

            if (_dyeItems.Contains(_selectedEquip))
            {
                player.Dye[(int) _selectedEquip.Tag].SetDefaults(selectedItem.NetId);
            }
            else
            {
                player.Armor[(int) _selectedEquip.Tag].SetDefaults(selectedItem.NetId);
            }

            _selectedEquip.Image = player.Armor[(int) _selectedEquip.Tag].Image;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                playerPictureBox.Draw();
            }
        }

        private void inventoryItem_GotFocus(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            var button = (Button) sender;

            button.BackColor = Color.FromArgb(0, 171, 229);
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

        private void maxAllDurationsBtn_Click(object sender, EventArgs e)
        {
            foreach (var buff in Terraria.Instance.Player.Buffs.Where(b => b.Id != 0))
            {
                buff.Time = int.MaxValue;
            }

            buffDisplayGrid.Refresh();
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

        private void maxDurationBtn_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Buffs[buffDisplayGrid.CurrentCell.RowIndex].Time = int.MaxValue;
            buffDisplayGrid.Refresh();
        }

        private void maxOutBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Health = player.MaxHealth = 32767;
            player.Mana = player.MaxMana = 200;
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = Terraria.Instance.Player = new Player();

            itemPrefixComboBox.SelectedIndex = 0;
            stackSizeUpDown.Value = 1;

            playerPictureBox.Draw();
            DrawEquipment();
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
            }

            playerPictureBox.Draw();
            DrawEquipment();
            DrawInventory();
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

        private void resetHealthBtn_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Health = player.MaxHealth = 100;
            player.Mana = player.MaxMana = 20;
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

        private void tabControl_TabSelected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    Width = 687;
                    Height = 298;
                    break;
                case 1:
                    Width = 950;
                    Height = 583;
                    break;
                case 2:
                    Width = 800;
                    Height = 512;
                    break;
                case 3:
                    Width = 852;
                    Height = 526;
                    break;
            }
        }
    }
}