using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        private Player _player;
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
            Width = DpiManager.Scale(687);
            Height = DpiManager.Scale(298);

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

            // Create the default player
            _player = new Player();

            // Setup data sources
            playerBindingSource.DataSource = _player;
            listBoxEquips.DataSource = GetFilteredEquipmentList();
            listBoxBuffs.DataSource = Terraria.Instance.Buffs;
            comboBoxItemPrefix.DataSource = Enum.GetValues(typeof(ItemPrefix)).Cast<ItemPrefix>().ToList();

            // Draw the character, inventory, equips etc.
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
            foreach (var buff in _player.Buffs.Where(b => b.Id != 0))
            {
                buff.SetDefaults(0);
            }

            gridViewBuffs.Refresh();
        }

        private void buttonDeleteAllItems_Click(object sender, EventArgs e)
        {
            foreach (var item in _player.Inventory.Where(i => i.NetId != 0))
            {
                item.SetDefaults(0);
            }

            DrawInventory();
        }

        private void buttonDeleteAllStorageItems_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 40; ++i)
            {
                _player.PiggyBank[i].SetDefaults(0);
                _player.Safe[i].SetDefaults(0);
                _player.Forge[i].SetDefaults(0);
            }

            DrawStorage();
        }

        private void buttonDeleteBuff_Click(object sender, EventArgs e)
        {
            if (gridViewBuffs.CurrentCell == null)
            {
                return;
            }

            _player.Buffs[gridViewBuffs.CurrentCell.RowIndex].SetDefaults(0);
            gridViewBuffs.Refresh();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            _player.Inventory[(int) _selectedItem.Tag].SetDefaults(0);
            _selectedItem.Image = new Bitmap("Data\\ItemTextures\\Item_0.png");
            _selectedItem.Text = "0";
        }

        private void buttonDeleteStorageItem_Click(object sender, EventArgs e)
        {
            if (_selectedStorageButton == null)
            {
                return;
            }

            var tag = (int) _selectedStorageButton.Tag;
            if (tag < _player.PiggyBank.Length)
            {
                _player.PiggyBank[tag].SetDefaults(0);
            }
            else if (tag < _player.PiggyBank.Length + _player.Safe.Length)
            {
                _player.Safe[tag - _player.PiggyBank.Length].SetDefaults(0);
            }
            else
            {
                _player.Forge[tag - (_player.PiggyBank.Length + _player.Safe.Length)].SetDefaults(0);
            }

            _selectedStorageButton.Image = new Bitmap("Data\\ItemTextures\\Item_0.png");
            _selectedStorageButton.Text = "0";
        }

        private void buttonEditHair_Click(object sender, EventArgs e)
        {
            using (var hairDesignerDialog = new HairDesignerForm(_player.Hair, _player.HairColor))
            {
                if (hairDesignerDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                _player.Hair = hairDesignerDialog.HairId - 1;
                _player.HairColor = hairDesignerDialog.HairColor;
                playerPictureBox.Draw();
            }
        }

        private void buttonMaxAllBuffs_Click(object sender, EventArgs e)
        {
            foreach (var buff in _player.Buffs.Where(b => b.Id != 0))
            {
                buff.Time = int.MaxValue;
            }

            gridViewBuffs.Refresh();
        }

        private void buttonMaxAllStacks_Click(object sender, EventArgs e)
        {
            foreach (var item in _inventoryItems)
            {
                if (_player.Inventory[(int) item.Tag].NetId == 0)
                {
                    continue;
                }

                _player.Inventory[(int) item.Tag].StackSize = _player.Inventory[(int) item.Tag].MaxStack;
            }

            DrawInventory();
        }

        private void buttonMaxBuff_Click(object sender, EventArgs e)
        {
            _player.Buffs[gridViewBuffs.CurrentCell.RowIndex].Time = int.MaxValue;
            gridViewBuffs.Refresh();
        }

        private void buttonMaxOut_Click(object sender, EventArgs e)
        {
            _player.Health = _player.MaxHealth = 500;
            _player.Mana = _player.MaxMana = 200;
        }

        private void buttonMaxStack_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            if (_player.Inventory[(int) _selectedItem.Tag].NetId == 0)
            {
                return;
            }

            _player.Inventory[(int) _selectedItem.Tag].StackSize = _player.Inventory[(int) _selectedItem.Tag].MaxStack;
            _selectedItem.Text = _player.Inventory[(int) _selectedItem.Tag].StackSize.ToString();
        }

        private void buttonRandomColors_Click(object sender, EventArgs e)
        {
            _player.EyeColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            _player.HairColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            _player.PantsColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            _player.ShirtColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            _player.ShoeColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            _player.SkinColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
            _player.UndershirtColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

            playerPictureBox.Draw();
        }

        private void buttonRandomHair_Click(object sender, EventArgs e)
        {
            _player.Hair = _random.Next(134);
            _player.HairColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

            playerPictureBox.Draw();
        }

        private void buttonResetDefaults_Click(object sender, EventArgs e)
        {
            _player.Health = _player.MaxHealth = 100;
            _player.Mana = _player.MaxMana = 20;
        }

        private void comboBoxItemPrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            if (_player.Inventory[(int) _selectedItem.Tag].NetId == 0)
            {
                return;
            }

            _player.Inventory[(int) _selectedItem.Tag].Prefix = (ItemPrefix) comboBoxItemPrefix.SelectedItem;
        }

        private void DrawEquipment()
        {
            for (var i = 0; i < _player.Armor.Length - 2; ++i) // TODO: Temporarily unsupported hidden accessory slots
            {
                if (i < _player.Dye.Length - 1)
                {
                    _dyeItems[i].Image = _player.Dye[(int) _dyeItems[i].Tag].Image;
                }

                _equipmentItems[i].Image = _player.Armor[(int) _equipmentItems[i].Tag].Image;
            }
        }

        private void DrawInventory()
        {
            for (var i = 0; i < _player.Inventory.Length; ++i)
            {
                var item = _inventoryItems[i];
                item.Image = _player.Inventory[i].Image;
                item.Text = _player.Inventory[i].StackSize.ToString();
            }
        }

        private void DrawStorage()
        {
            for (var i = 0; i < _player.PiggyBank.Length + _player.Safe.Length + _player.Forge.Length; ++i)
            {
                var item = _storageItems[i];
                if (i < _player.PiggyBank.Length)
                {
                    item.Image = _player.PiggyBank[i].Image;
                    item.Text = _player.PiggyBank[i].StackSize.ToString();
                }
                else if (i < _player.PiggyBank.Length + _player.Safe.Length)
                {
                    item.Image = _player.Safe[i - _player.PiggyBank.Length].Image;
                    item.Text = _player.Safe[i - _player.PiggyBank.Length].StackSize.ToString();
                }
                else
                {
                    item.Image = _player.Forge[i - (_player.PiggyBank.Length + _player.Safe.Length)].Image;
                    item.Text = _player.Forge[i - (_player.PiggyBank.Length + _player.Safe.Length)].StackSize
                        .ToString();
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
            if (_dyeItems.Contains(button))
            {
                _player.Dye[(int) button.Tag].SetDefaults(0);
            }
            else
            {
                _player.Armor[(int) button.Tag].SetDefaults(0);
            }

            button.Image = new Bitmap("Data\\ItemTextures\\Item_0.png");
        }

        private void inventoryItem_GotFocus(object sender, EventArgs e)
        {
            var button = (Button) sender;

            button.BackColor = Color.FromArgb(0, 171, 229);
            foreach (var inventoryButton in _inventoryItems.Where(b => b != button))
            {
                inventoryButton.BackColor = Color.FromArgb(90, 90, 180);
            }

            _selectedItem = button;
            comboBoxItemPrefix.SelectedItem = _player.Inventory[(int) button.Tag].Prefix;
            upDownStackSize.Value = _player.Inventory[(int) button.Tag].StackSize > 0
                ? _player.Inventory[(int) button.Tag].StackSize
                : 1;
        }

        private void itemFilterInventory_SelectedItemIndexChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            _selectedItem.Text = itemFilterInventory.SelectedItem.StackSize.ToString();
            _selectedItem.Image = itemFilterInventory.SelectedItem.Image;
            _player.Inventory[(int) _selectedItem.Tag].SetDefaults(itemFilterInventory.SelectedItem.NetId);
        }

        private void itemFilterStorage_SelectedItemIndexChanged(object sender, EventArgs e)
        {
            if (_selectedStorageButton == null)
            {
                return;
            }

            _selectedStorageButton.Text = itemFilterStorage.SelectedItem.StackSize.ToString();
            _selectedStorageButton.Image = itemFilterStorage.SelectedItem.Image;

            var tag = (int) _selectedStorageButton.Tag;
            if (tag < 40)
            {
                _player.PiggyBank[tag].SetDefaults(itemFilterStorage.SelectedItem.NetId);
            }
            else if (tag < 80)
            {
                _player.Safe[tag - 40].SetDefaults(itemFilterStorage.SelectedItem.NetId);
            }
            else
            {
                _player.Forge[tag - 80].SetDefaults(itemFilterStorage.SelectedItem.NetId);
            }
        }

        private void listBoxBuffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gridViewBuffs.CurrentCell == null)
            {
                return;
            }

            var buffIndex = gridViewBuffs.CurrentCell.RowIndex;
            var selectedBuff = (Buff) listBoxBuffs.SelectedItem;
            _player.Buffs[buffIndex].SetDefaults(selectedBuff.Id);
            _player.Buffs[buffIndex].Time = int.MaxValue;
        }

        private void listBoxEquips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedEquip == null)
            {
                return;
            }

            var selectedItem = (Item) listBoxEquips.SelectedItem;
            if (_dyeItems.Contains(_selectedEquip))
            {
                _player.Dye[(int) _selectedEquip.Tag].SetDefaults(selectedItem.NetId);
            }
            else
            {
                _player.Armor[(int) _selectedEquip.Tag].SetDefaults(selectedItem.NetId);
            }

            _selectedEquip.Image = _player.Armor[(int) _selectedEquip.Tag].Image;
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
                    Width = DpiManager.Scale(687);
                    Height = DpiManager.Scale(298);
                    break;
                case 1:
                    Width = DpiManager.Scale(950);
                    Height = DpiManager.Scale(583);
                    break;
                case 2:
                    Width = DpiManager.Scale(800);
                    Height = DpiManager.Scale(512);
                    break;
                case 3:
                    Width = DpiManager.Scale(870);
                    Height = DpiManager.Scale(526);
                    break;
                case 4:
                    Width = DpiManager.Scale(1060);
                    Height = DpiManager.Scale(600);
                    break;
            }
        }

        private void textBoxBuffName_TextChanged(object sender, EventArgs e)
        {
            listBoxBuffs.SelectedIndexChanged -= listBoxBuffs_SelectedIndexChanged;

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
            playerBindingSource.DataSource = _player = new Player();
            RedrawTextures();
        }

        private void toolstripMenuItemOpen_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.AddExtension = true;
                openFileDialog.Filter = "Terraria Player Files (*.plr)|*.plr|All Files (*.*)|*.*";
                openFileDialog.InitialDirectory =
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        "My Games\\Terraria\\Players");
                openFileDialog.Title = "Select a Player File";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Unable to load player file!", "TerrariaInventoryEditor", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                _player.Load(openFileDialog.FileName);
            }

            RedrawTextures();
        }

        private void toolstripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_player.FilePath))
            {
                _player.Save(_player.FilePath);
                MessageBox.Show($"Player file saved! Path: {_player.FilePath}",
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
                saveFileDialog.FileName = _player.Name;
                saveFileDialog.Filter = "Terraria Player File (*.plr)|*.plr";
                saveFileDialog.InitialDirectory =
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        "My Games\\Terraria\\Players");

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Save cancelled.", "TerrariaInventoryEditor", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                _player.FilePath = saveFileDialog.FileName;
                _player.Save(saveFileDialog.FileName);
            }
        }

        private void upDownStackSize_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            if (_player.Inventory[(int) _selectedItem.Tag].NetId == 0)
            {
                return;
            }

            _player.Inventory[(int) _selectedItem.Tag].StackSize = (int) upDownStackSize.Value;
            _selectedItem.Text = _player.Inventory[(int) _selectedItem.Tag].StackSize.ToString();
        }
    }
}