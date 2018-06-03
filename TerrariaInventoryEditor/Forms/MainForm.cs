using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TerrariaInventoryEditor.Framework;
using TerrariaInventoryEditor.TerrariaLib;

namespace TerrariaInventoryEditor.Forms
{
    /// <summary>
    ///     Represents the main form.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly List<Button> _dyeItems = new List<Button>();
        private readonly List<Button> _equipmentItems = new List<Button>();
        private readonly List<Button> _inventoryItems = new List<Button>();
        private readonly Random _random = new Random();
        private readonly List<Button> _storageItems = new List<Button>();

        private Button _selectedEquip;
        private Button _selectedItem;
        private Button _selectedStorageButton;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Set the default size 
            Width = 687;
            Height = 298;

            // Store dye items
            for (var i = 0; i < 10; i++)
            {
                if (!(Controls.Find($"dyeItem{i}", true).SingleOrDefault() is Button dyeItem))
                {
                    continue;
                }

                dyeItem.Tag = i;
                _dyeItems.Add(dyeItem);
            }

            // Store equipment items
            for (var i = 0; i < 20; ++i)
            {
                if (!(Controls.Find($"equipmentItem{i}", true).SingleOrDefault() is Button equipmentItem))
                {
                    continue;
                }

                equipmentItem.Tag = i;
                _equipmentItems.Add(equipmentItem);
            }

            // Store inventory items
            for (var i = 0; i < 58; ++i)
            {
                if (!(Controls.Find($"inventoryItem{i}", true).SingleOrDefault() is Button inventoryItem))
                {
                    continue;
                }

                inventoryItem.Tag = i;
                _inventoryItems.Add(inventoryItem);
            }

            // Store bank items
            for (var i = 0; i < 120; ++i)
            {
                if (!(Controls.Find($"storageItem{i}", true).SingleOrDefault() is Button storageItem))
                {
                    continue;
                }

                storageItem.Tag = i;
                _storageItems.Add(storageItem);
            }

            // Initialize player texture files
            TextureManager.Instance.Load();

            // Setup data sources
            playerBindingSource.DataSource = Terraria.Instance.Player;
            listBoxEquips.DataSource = GetFilteredEquipmentList();
            listBoxBuffs.DataSource = Terraria.Instance.Buffs;
            comboBoxItemPrefix.DataSource = Enum.GetValues(typeof(ItemPrefix)).Cast<ItemPrefix>().ToList();

            // Draw the character
            RedrawTextures();

            // Hook the required events
            itemFilterInventory.ItemListBoxSelectedIndexChanged += itemFilterInventory_SelectedItemIndexChanged;
            itemFilterStorage.ItemListBoxSelectedIndexChanged += itemFilterStorage_SelectedItemIndexChanged;
        }

        private static List<Item> GetFilteredEquipmentList(string filter = null)
        {
            var items = (from item in Terraria.Instance.Items
                where item.BodySlot > 0 || item.HeadSlot > 0 || item.LegSlot > 0 || item.IsAccessory
                orderby item.Name
                select item).ToList();

            return !string.IsNullOrWhiteSpace(filter)
                ? items.Where(i => i.Name.ToLowerInvariant().Contains(filter.ToLowerInvariant())).ToList()
                : items;
        }

        private void buttonDeleteAllBuffs_Click(object sender, EventArgs e)
        {
            foreach (var buff in Terraria.Instance.Player.Buffs.Where(b => b.Id != 0))
            {
                buff.SetDefaults(0);
            }

            gridViewBuffs.Refresh();
        }

        private void buttonDeleteAllItems_Click(object sender, EventArgs e)
        {
            foreach (var item in Terraria.Instance.Player.Inventory.Where(i => i.NetId != 0))
            {
                item.SetDefaults(0);
            }

            DrawInventory();
        }

        private void buttonDeleteAllStorageItems_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            for (var i = 0; i < 40; ++i)
            {
                player.PiggyBank[i].SetDefaults(0);
                player.Safe[i].SetDefaults(0);
                player.Forge[i].SetDefaults(0);
            }

            DrawStorage();
        }

        private void buttonDeleteBuff_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Buffs[gridViewBuffs.CurrentCell.RowIndex].SetDefaults(0);
            gridViewBuffs.Refresh();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            player.Inventory[(int) _selectedItem.Tag].SetDefaults(0);

            _selectedItem.Image = new Bitmap("Data\\ItemTextures\\Item_0.png");
            _selectedItem.Text = "0";
        }

        private void buttonDeleteStorageItem_Click(object sender, EventArgs e)
        {
            if (_selectedStorageButton == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            var tag = (int) _selectedStorageButton.Tag;
            if (tag < 40)
            {
                player.PiggyBank[tag].SetDefaults(0);
            }
            else if (tag < 80)
            {
                player.Safe[tag - 40].SetDefaults(0);
            }
            else
            {
                player.Forge[tag - 80].SetDefaults(0);
            }

            _selectedStorageButton.Image = new Bitmap("Data\\ItemTextures\\Item_0.png");
            _selectedStorageButton.Text = "0";
        }

        private void buttonEditHair_Click(object sender, EventArgs e)
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

        private void buttonMaxAllBuffs_Click(object sender, EventArgs e)
        {
            foreach (var buff in Terraria.Instance.Player.Buffs.Where(b => b.Id != 0))
            {
                buff.Time = int.MaxValue;
            }

            gridViewBuffs.Refresh();
        }

        private void buttonMaxAllStacks_Click(object sender, EventArgs e)
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

        private void buttonMaxBuff_Click(object sender, EventArgs e)
        {
            Terraria.Instance.Player.Buffs[gridViewBuffs.CurrentCell.RowIndex].Time = int.MaxValue;
            gridViewBuffs.Refresh();
        }

        private void buttonMaxOut_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Health = player.MaxHealth = 500;
            player.Mana = player.MaxMana = 200;
        }

        private void buttonMaxStack_Click(object sender, EventArgs e)
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

        private void buttonRandomColors_Click(object sender, EventArgs e)
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

        private void buttonRandomHair_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Hair = _random.Next(134);
            player.HairColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

            playerPictureBox.Draw();
        }

        private void buttonResetDefaults_Click(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            player.Health = player.MaxHealth = 100;
            player.Mana = player.MaxMana = 20;
        }

        private void comboBoxItemPrefix_SelectedIndexChanged(object sender, EventArgs e)
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

            player.Inventory[(int) _selectedItem.Tag].Prefix = (ItemPrefix) comboBoxItemPrefix.SelectedItem;
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
            for (var i = 0; i < player.Inventory.Length; ++i)
            {
                var item = _inventoryItems[i];
                item.Image = player.Inventory[i].Image;
                item.Text = player.Inventory[i].StackSize.ToString();
            }
        }

        private void DrawStorage()
        {
            var player = Terraria.Instance.Player;
            for (var i = 0; i < player.PiggyBank.Length + player.Safe.Length + player.Forge.Length; ++i)
            {
                var item = _storageItems[i];
                if (i < player.PiggyBank.Length)
                {
                    item.Image = player.PiggyBank[i].Image;
                    item.Text = player.PiggyBank[i].StackSize.ToString();
                }
                else if (i < player.PiggyBank.Length + player.Safe.Length)
                {
                    item.Image = player.Safe[i - player.PiggyBank.Length].Image;
                    item.Text = player.Safe[i - player.PiggyBank.Length].StackSize.ToString();
                }
                else
                {
                    item.Image = player.Forge[i - (player.PiggyBank.Length + player.Safe.Length)].Image;
                    item.Text = player.Forge[i - (player.PiggyBank.Length + player.Safe.Length)].StackSize.ToString();
                }
            }
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
            comboBoxItemPrefix.SelectedItem = player.Inventory[(int) button.Tag].Prefix;
            upDownStackSize.Value = player.Inventory[(int) button.Tag].StackSize > 0
                ? player.Inventory[(int) button.Tag].StackSize
                : 1;
        }

        private void itemFilterInventory_SelectedItemIndexChanged(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            if (_selectedItem == null)
            {
                return;
            }

            _selectedItem.Text = itemFilterInventory.SelectedItem.StackSize.ToString();
            _selectedItem.Image = itemFilterInventory.SelectedItem.Image;
            player.Inventory[(int) _selectedItem.Tag].SetDefaults(itemFilterInventory.SelectedItem.NetId);
        }

        private void itemFilterStorage_SelectedItemIndexChanged(object sender, EventArgs e)
        {
            var player = Terraria.Instance.Player;
            if (_selectedStorageButton == null)
            {
                return;
            }

            _selectedStorageButton.Text = itemFilterStorage.SelectedItem.StackSize.ToString();
            _selectedStorageButton.Image = itemFilterStorage.SelectedItem.Image;

            var tag = (int) _selectedStorageButton.Tag;
            if (tag < 40)
            {
                player.PiggyBank[tag].SetDefaults(itemFilterStorage.SelectedItem.NetId);
            }
            else if (tag < 80)
            {
                player.Safe[tag - 40].SetDefaults(itemFilterStorage.SelectedItem.NetId);
            }
            else
            {
                player.Forge[tag - 80].SetDefaults(itemFilterStorage.SelectedItem.NetId);
            }
        }

        private void listBoxBuffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gridViewBuffs.CurrentCell == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            var selectedBuff = (Buff) listBoxBuffs.SelectedItem;
            player.Buffs[gridViewBuffs.CurrentCell.RowIndex].SetDefaults(selectedBuff.Id);
            player.Buffs[gridViewBuffs.CurrentCell.RowIndex].Time = int.MaxValue;
        }

        private void listBoxEquips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedEquip == null)
            {
                return;
            }

            var player = Terraria.Instance.Player;
            var selectedItem = (Item) listBoxEquips.SelectedItem;

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

        private void pictureBox_Click(object sender, EventArgs e)
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

        private void RedrawTextures()
        {
            playerPictureBox.Draw();
            DrawEquipment();
            DrawInventory();
            DrawStorage();
        }

        private void storageItem_GotFocus(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BackColor = Color.FromArgb(0, 171, 229);
            foreach (var storageButton in _storageItems.Where(b => b != button))
            {
                storageButton.BackColor = Color.FromArgb(90, 90, 180);
            }

            _selectedStorageButton = button;
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
                    Width = 870;
                    Height = 526;
                    break;
                case 4:
                    Width = 1060;
                    Height = 600;
                    break;
            }
        }

        private void textBoxBuffName_TextChanged(object sender, EventArgs e)
        {
            listBoxBuffs.SelectedIndexChanged -= listBoxBuffs_SelectedIndexChanged;

            var buffs = Terraria.Instance.Buffs;
            if (string.IsNullOrWhiteSpace(textBoxBuffName.Text))
            {
                listBoxBuffs.DataSource = Terraria.Instance.Buffs;
            }
            else
            {
                listBoxBuffs.DataSource = (from buff in Terraria.Instance.Buffs
                    where buff.Name.ToLowerInvariant().Contains(textBoxBuffName.Text.ToLowerInvariant())
                    select buff).ToList();
            }

            listBoxBuffs.SelectedIndexChanged += listBoxBuffs_SelectedIndexChanged;
        }

        private void textBoxEquipName_TextChanged(object sender, EventArgs e)
        {
            listBoxEquips.DataSource = GetFilteredEquipmentList(textBoxEquipName.Text);
        }

        private void toolstripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolstripMenuItemNew_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = Terraria.Instance.Player = new Player();
            RedrawTextures();
        }

        private void toolstripMenuItemOpen_Click(object sender, EventArgs e)
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

            RedrawTextures();
        }

        private void toolstripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Terraria.Instance.Player.FilePath))
            {
                Terraria.Instance.Player.Save(Terraria.Instance.Player.FilePath);
                MessageBox.Show($"Player file saved! Path: {Terraria.Instance.Player.FilePath}",
                    "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                toolstripMenuItemSaveAs_Click(sender, e);
            }
        }

        private void toolstripMenuItemSaveAs_Click(object sender, EventArgs e)
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

        private void upDownStackSize_ValueChanged(object sender, EventArgs e)
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

            player.Inventory[(int) _selectedItem.Tag].StackSize = (int) upDownStackSize.Value;
            _selectedItem.Text = player.Inventory[(int) _selectedItem.Tag].StackSize.ToString();
        }
    }
}