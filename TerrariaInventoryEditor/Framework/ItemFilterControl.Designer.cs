namespace TerrariaInventoryEditor.Framework
{
    partial class ItemFilterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSearchForItem = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.labelRarity = new System.Windows.Forms.Label();
            this.comboBoxRarity = new System.Windows.Forms.ComboBox();
            this.checkBoxRanged = new System.Windows.Forms.CheckBox();
            this.checkBoxThrown = new System.Windows.Forms.CheckBox();
            this.checkBoxMagic = new System.Windows.Forms.CheckBox();
            this.checkBoxAccessory = new System.Windows.Forms.CheckBox();
            this.checkBoxMelee = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelSearchForItem
            // 
            this.labelSearchForItem.AutoSize = true;
            this.labelSearchForItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchForItem.Location = new System.Drawing.Point(-3, 4);
            this.labelSearchForItem.Name = "labelSearchForItem";
            this.labelSearchForItem.Size = new System.Drawing.Size(137, 16);
            this.labelSearchForItem.TabIndex = 0;
            this.labelSearchForItem.Text = "Search for an item:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(3, 23);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(187, 20);
            this.textBoxItemName.TabIndex = 1;
            this.textBoxItemName.TextChanged += new System.EventHandler(this.textBoxItemName_TextChanged);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(3, 49);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(187, 212);
            this.listBoxItems.TabIndex = 2;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // labelRarity
            // 
            this.labelRarity.AutoSize = true;
            this.labelRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRarity.Location = new System.Drawing.Point(0, 264);
            this.labelRarity.Name = "labelRarity";
            this.labelRarity.Size = new System.Drawing.Size(53, 16);
            this.labelRarity.TabIndex = 3;
            this.labelRarity.Text = "Rarity:";
            // 
            // comboBoxRarity
            // 
            this.comboBoxRarity.FormattingEnabled = true;
            this.comboBoxRarity.Location = new System.Drawing.Point(3, 283);
            this.comboBoxRarity.Name = "comboBoxRarity";
            this.comboBoxRarity.Size = new System.Drawing.Size(187, 21);
            this.comboBoxRarity.TabIndex = 4;
            this.comboBoxRarity.SelectedIndexChanged += new System.EventHandler(this.comboBoxRarity_SelectedIndexChanged);
            // 
            // checkBoxRanged
            // 
            this.checkBoxRanged.AutoSize = true;
            this.checkBoxRanged.Location = new System.Drawing.Point(126, 310);
            this.checkBoxRanged.Name = "checkBoxRanged";
            this.checkBoxRanged.Size = new System.Drawing.Size(64, 17);
            this.checkBoxRanged.TabIndex = 65;
            this.checkBoxRanged.Text = "Ranged";
            this.checkBoxRanged.UseVisualStyleBackColor = true;
            this.checkBoxRanged.CheckedChanged += new System.EventHandler(this.checkBoxItemType_CheckedChanged);
            // 
            // checkBoxThrown
            // 
            this.checkBoxThrown.AutoSize = true;
            this.checkBoxThrown.Location = new System.Drawing.Point(126, 333);
            this.checkBoxThrown.Name = "checkBoxThrown";
            this.checkBoxThrown.Size = new System.Drawing.Size(62, 17);
            this.checkBoxThrown.TabIndex = 64;
            this.checkBoxThrown.Text = "Thrown";
            this.checkBoxThrown.UseVisualStyleBackColor = true;
            this.checkBoxThrown.CheckedChanged += new System.EventHandler(this.checkBoxItemType_CheckedChanged);
            // 
            // checkBoxMagic
            // 
            this.checkBoxMagic.AutoSize = true;
            this.checkBoxMagic.Location = new System.Drawing.Point(3, 333);
            this.checkBoxMagic.Name = "checkBoxMagic";
            this.checkBoxMagic.Size = new System.Drawing.Size(55, 17);
            this.checkBoxMagic.TabIndex = 63;
            this.checkBoxMagic.Text = "Magic";
            this.checkBoxMagic.UseVisualStyleBackColor = true;
            this.checkBoxMagic.CheckedChanged += new System.EventHandler(this.checkBoxItemType_CheckedChanged);
            // 
            // checkBoxAccessory
            // 
            this.checkBoxAccessory.AutoSize = true;
            this.checkBoxAccessory.Location = new System.Drawing.Point(3, 310);
            this.checkBoxAccessory.Name = "checkBoxAccessory";
            this.checkBoxAccessory.Size = new System.Drawing.Size(75, 17);
            this.checkBoxAccessory.TabIndex = 62;
            this.checkBoxAccessory.Text = "Accessory";
            this.checkBoxAccessory.UseVisualStyleBackColor = true;
            this.checkBoxAccessory.CheckedChanged += new System.EventHandler(this.checkBoxItemType_CheckedChanged);
            // 
            // checkBoxMelee
            // 
            this.checkBoxMelee.AutoSize = true;
            this.checkBoxMelee.Location = new System.Drawing.Point(3, 356);
            this.checkBoxMelee.Name = "checkBoxMelee";
            this.checkBoxMelee.Size = new System.Drawing.Size(55, 17);
            this.checkBoxMelee.TabIndex = 61;
            this.checkBoxMelee.Text = "Melee";
            this.checkBoxMelee.UseVisualStyleBackColor = true;
            this.checkBoxMelee.CheckedChanged += new System.EventHandler(this.checkBoxItemType_CheckedChanged);
            // 
            // ItemFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxRanged);
            this.Controls.Add(this.checkBoxThrown);
            this.Controls.Add(this.checkBoxMagic);
            this.Controls.Add(this.checkBoxAccessory);
            this.Controls.Add(this.checkBoxMelee);
            this.Controls.Add(this.comboBoxRarity);
            this.Controls.Add(this.labelRarity);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelSearchForItem);
            this.Name = "ItemFilterControl";
            this.Size = new System.Drawing.Size(193, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchForItem;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Label labelRarity;
        private System.Windows.Forms.ComboBox comboBoxRarity;
        private System.Windows.Forms.CheckBox checkBoxRanged;
        private System.Windows.Forms.CheckBox checkBoxThrown;
        private System.Windows.Forms.CheckBox checkBoxMagic;
        private System.Windows.Forms.CheckBox checkBoxAccessory;
        private System.Windows.Forms.CheckBox checkBoxMelee;
    }
}
