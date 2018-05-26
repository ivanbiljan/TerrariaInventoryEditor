using System;
using System.Linq;
using System.Windows.Forms;
using TerrariaInventoryEditor.TerrariaLib;

namespace TerrariaInventoryEditor.Framework
{
    /// <summary>
    ///     Represents a common item filtering control.
    /// </summary>
    public partial class ItemFilterControl : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemFilterControl" /> class.
        /// </summary>
        public ItemFilterControl()
        {
            InitializeComponent();

            // Set default sources
            comboBoxRarity.DataSource = Enum.GetValues(typeof(ItemRarity)).Cast<ItemRarity>().ToList();
            comboBoxRarity.SelectedIndexChanged -= comboBoxRarity_SelectedIndexChanged;
            comboBoxRarity.SelectedIndex = (int) ItemRarity.All;
            comboBoxRarity.SelectedIndexChanged += comboBoxRarity_SelectedIndexChanged;
        }

        /// <summary>
        ///     Gets the currently selected item.
        /// </summary>
        public Item SelectedItem { get; private set; } = new Item();

        /// <summary>
        ///     Gets the currently selected item rarity.
        /// </summary>
        public ItemRarity SelectedRarity { get; private set; } = ItemRarity.All;

        /// <summary>
        ///     Occurs when the item listbox's SelectedIndex property changes.
        /// </summary>
        public event EventHandler ItemListBoxSelectedIndexChanged;

        private void checkBoxItemType_CheckedChanged(object sender, EventArgs e)
        {
            FilterItemList(textBoxItemName.Text);
        }

        private void comboBoxRarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRarity = (ItemRarity) comboBoxRarity.SelectedItem;
            FilterItemList(textBoxItemName.Text);
        }

        private void FilterItemList(string filter = null)
        {
            listBoxItems.SelectedIndexChanged -= listBoxItems_SelectedIndexChanged;

            var items = Terraria.Instance.Items.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                items = items.Where(i => i.Name.ToLowerInvariant().Contains(filter.ToLowerInvariant()));
            }

            ItemRarity itemRarity;
            if ((itemRarity = (ItemRarity) comboBoxRarity.SelectedItem) != ItemRarity.All)
            {
                items = items.Where(i => i.Rarity == itemRarity);
            }
            if (checkBoxAccessory.Checked)
            {
                items = items.Where(i => i.IsAccessory);
            }
            if (checkBoxMagic.Checked)
            {
                items = items.Where(i => i.IsMagic);
            }
            if (checkBoxMelee.Checked)
            {
                items = items.Where(i => i.IsMelee);
            }
            if (checkBoxRanged.Checked)
            {
                items = items.Where(i => i.IsRanged);
            }
            if (checkBoxThrown.Checked)
            {
                items = items.Where(i => i.IsThrown);
            }

            listBoxItems.DataSource = items.ToList();
            listBoxItems.SelectedIndexChanged += listBoxItems_SelectedIndexChanged;
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (Item) listBoxItems.SelectedItem;
            ItemListBoxSelectedIndexChanged?.Invoke(sender, e);
        }

        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {
            FilterItemList(textBoxItemName.Text);
        }
    }
}