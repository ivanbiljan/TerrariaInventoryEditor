namespace TerrariaInventoryEditor.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.healthManaGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonMaxOut = new System.Windows.Forms.Button();
            this.buttonResetDefaults = new System.Windows.Forms.Button();
            this.manaBar = new System.Windows.Forms.ProgressBar();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxMaxMana = new System.Windows.Forms.TextBox();
            this.textBoxCurrentMana = new System.Windows.Forms.TextBox();
            this.manaLabel = new System.Windows.Forms.Label();
            this.textBoxMaxHealth = new System.Windows.Forms.TextBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.textBoxCurrentHealth = new System.Windows.Forms.TextBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.playerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxHotbarLocked = new System.Windows.Forms.CheckBox();
            this.textBoxTaxMoney = new System.Windows.Forms.TextBox();
            this.taxMoneyLbl = new System.Windows.Forms.Label();
            this.checkBoxExtraAccessory = new System.Windows.Forms.CheckBox();
            this.textBoxPlayTime = new System.Windows.Forms.TextBox();
            this.playTimeLbl = new System.Windows.Forms.Label();
            this.upDownAnglerQuests = new System.Windows.Forms.NumericUpDown();
            this.upDownSkinVariant = new System.Windows.Forms.NumericUpDown();
            this.anglerLbl = new System.Windows.Forms.Label();
            this.skinVariantLbl = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.difficultyLbl = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.appearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.btnLoadAppearance = new System.Windows.Forms.Button();
            this.btnSaveAppearance = new System.Windows.Forms.Button();
            this.buttonRandomColors = new System.Windows.Forms.Button();
            this.buttonRandomHair = new System.Windows.Forms.Button();
            this.buttonEditHair = new System.Windows.Forms.Button();
            this.pictureBoxShoeColor = new System.Windows.Forms.PictureBox();
            this.labelShoeColor = new System.Windows.Forms.Label();
            this.pictureBoxPantsColor = new System.Windows.Forms.PictureBox();
            this.labelPantsColor = new System.Windows.Forms.Label();
            this.pictureBoxUndershirtColor = new System.Windows.Forms.PictureBox();
            this.labelUndershirtColor = new System.Windows.Forms.Label();
            this.pictureBoxShirtColor = new System.Windows.Forms.PictureBox();
            this.labelShirtColor = new System.Windows.Forms.Label();
            this.pictureBoxEyeColor = new System.Windows.Forms.PictureBox();
            this.labelEyeColor = new System.Windows.Forms.Label();
            this.pictureBoxSkinColor = new System.Windows.Forms.PictureBox();
            this.labelSkinColor = new System.Windows.Forms.Label();
            this.pictureBoxHairColor = new System.Windows.Forms.PictureBox();
            this.labelHairColor = new System.Windows.Forms.Label();
            this.playerPictureBox = new TerrariaInventoryEditor.Framework.PlayerPictureBox();
            this.appearanceTab = new System.Windows.Forms.TabPage();
            this.dyeItem8 = new System.Windows.Forms.Button();
            this.dyeItem7 = new System.Windows.Forms.Button();
            this.dyeItem6 = new System.Windows.Forms.Button();
            this.dyeItem5 = new System.Windows.Forms.Button();
            this.dyeItem4 = new System.Windows.Forms.Button();
            this.dyeItem3 = new System.Windows.Forms.Button();
            this.equipmentItem18 = new System.Windows.Forms.Button();
            this.equipmentItem8 = new System.Windows.Forms.Button();
            this.equipmentItem7 = new System.Windows.Forms.Button();
            this.equipmentItem6 = new System.Windows.Forms.Button();
            this.equipmentItem5 = new System.Windows.Forms.Button();
            this.equipmentItem4 = new System.Windows.Forms.Button();
            this.equipmentItem3 = new System.Windows.Forms.Button();
            this.equipmentItem2 = new System.Windows.Forms.Button();
            this.equipmentItem1 = new System.Windows.Forms.Button();
            this.equipmentItem0 = new System.Windows.Forms.Button();
            this.equipmentItem17 = new System.Windows.Forms.Button();
            this.equipmentItem16 = new System.Windows.Forms.Button();
            this.equipmentItem15 = new System.Windows.Forms.Button();
            this.equipmentItem14 = new System.Windows.Forms.Button();
            this.equipmentItem13 = new System.Windows.Forms.Button();
            this.equipmentItem12 = new System.Windows.Forms.Button();
            this.equipmentItem11 = new System.Windows.Forms.Button();
            this.equipmentItem10 = new System.Windows.Forms.Button();
            this.dyeItem2 = new System.Windows.Forms.Button();
            this.dyeItem1 = new System.Windows.Forms.Button();
            this.armorLbl = new System.Windows.Forms.Label();
            this.socialsLbl = new System.Windows.Forms.Label();
            this.dyeLbl = new System.Windows.Forms.Label();
            this.equipmentFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxEquipName = new System.Windows.Forms.TextBox();
            this.labelSearchForEquip = new System.Windows.Forms.Label();
            this.listBoxEquips = new System.Windows.Forms.ListBox();
            this.dyeItem0 = new System.Windows.Forms.Button();
            this.buffsTab = new System.Windows.Forms.TabPage();
            this.groupBoxBuffControls = new System.Windows.Forms.GroupBox();
            this.buttonDeleteBuff = new System.Windows.Forms.Button();
            this.textBoxBuffName = new System.Windows.Forms.TextBox();
            this.buttonMaxAllBuffs = new System.Windows.Forms.Button();
            this.buttonMaxBuff = new System.Windows.Forms.Button();
            this.buttonDeleteAllBuffs = new System.Windows.Forms.Button();
            this.listBoxBuffs = new System.Windows.Forms.ListBox();
            this.groupBoxActiveBuffs = new System.Windows.Forms.GroupBox();
            this.gridViewBuffs = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.ammoLbl = new System.Windows.Forms.Label();
            this.coinsLbl = new System.Windows.Forms.Label();
            this.inventoryItem57 = new System.Windows.Forms.Button();
            this.inventoryItem56 = new System.Windows.Forms.Button();
            this.inventoryItem55 = new System.Windows.Forms.Button();
            this.inventoryItem54 = new System.Windows.Forms.Button();
            this.inventoryItem53 = new System.Windows.Forms.Button();
            this.inventoryItem52 = new System.Windows.Forms.Button();
            this.inventoryItem51 = new System.Windows.Forms.Button();
            this.inventoryItem50 = new System.Windows.Forms.Button();
            this.groupBoxItemProperties = new System.Windows.Forms.GroupBox();
            this.buttonDeleteAllItems = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonMaxAllStacks = new System.Windows.Forms.Button();
            this.buttonMaxStack = new System.Windows.Forms.Button();
            this.upDownStackSize = new System.Windows.Forms.NumericUpDown();
            this.stackSizeLbl = new System.Windows.Forms.Label();
            this.comboBoxItemPrefix = new System.Windows.Forms.ComboBox();
            this.itemPrefixLbl = new System.Windows.Forms.Label();
            this.inventoryFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.itemFilterInventory = new TerrariaInventoryEditor.Framework.ItemFilterControl();
            this.inventoryItem49 = new System.Windows.Forms.Button();
            this.inventoryItem48 = new System.Windows.Forms.Button();
            this.inventoryItem47 = new System.Windows.Forms.Button();
            this.inventoryItem46 = new System.Windows.Forms.Button();
            this.inventoryItem45 = new System.Windows.Forms.Button();
            this.inventoryItem44 = new System.Windows.Forms.Button();
            this.inventoryItem43 = new System.Windows.Forms.Button();
            this.inventoryItem42 = new System.Windows.Forms.Button();
            this.inventoryItem41 = new System.Windows.Forms.Button();
            this.inventoryItem40 = new System.Windows.Forms.Button();
            this.inventoryItem39 = new System.Windows.Forms.Button();
            this.inventoryItem38 = new System.Windows.Forms.Button();
            this.inventoryItem37 = new System.Windows.Forms.Button();
            this.inventoryItem36 = new System.Windows.Forms.Button();
            this.inventoryItem35 = new System.Windows.Forms.Button();
            this.inventoryItem34 = new System.Windows.Forms.Button();
            this.inventoryItem33 = new System.Windows.Forms.Button();
            this.inventoryItem32 = new System.Windows.Forms.Button();
            this.inventoryItem31 = new System.Windows.Forms.Button();
            this.inventoryItem30 = new System.Windows.Forms.Button();
            this.inventoryItem29 = new System.Windows.Forms.Button();
            this.inventoryItem28 = new System.Windows.Forms.Button();
            this.inventoryItem27 = new System.Windows.Forms.Button();
            this.inventoryItem26 = new System.Windows.Forms.Button();
            this.inventoryItem25 = new System.Windows.Forms.Button();
            this.inventoryItem24 = new System.Windows.Forms.Button();
            this.inventoryItem23 = new System.Windows.Forms.Button();
            this.inventoryItem22 = new System.Windows.Forms.Button();
            this.inventoryItem21 = new System.Windows.Forms.Button();
            this.inventoryItem20 = new System.Windows.Forms.Button();
            this.inventoryItem19 = new System.Windows.Forms.Button();
            this.inventoryItem18 = new System.Windows.Forms.Button();
            this.inventoryItem17 = new System.Windows.Forms.Button();
            this.inventoryItem16 = new System.Windows.Forms.Button();
            this.inventoryItem15 = new System.Windows.Forms.Button();
            this.inventoryItem14 = new System.Windows.Forms.Button();
            this.inventoryItem13 = new System.Windows.Forms.Button();
            this.inventoryItem12 = new System.Windows.Forms.Button();
            this.inventoryItem11 = new System.Windows.Forms.Button();
            this.inventoryItem10 = new System.Windows.Forms.Button();
            this.inventoryItem9 = new System.Windows.Forms.Button();
            this.inventoryItem8 = new System.Windows.Forms.Button();
            this.inventoryItem7 = new System.Windows.Forms.Button();
            this.inventoryItem6 = new System.Windows.Forms.Button();
            this.inventoryItem5 = new System.Windows.Forms.Button();
            this.inventoryItem4 = new System.Windows.Forms.Button();
            this.inventoryItem3 = new System.Windows.Forms.Button();
            this.inventoryItem2 = new System.Windows.Forms.Button();
            this.inventoryItem1 = new System.Windows.Forms.Button();
            this.inventoryItem0 = new System.Windows.Forms.Button();
            this.tabPageStorage = new System.Windows.Forms.TabPage();
            this.buttonDeleteAllStorageItems = new System.Windows.Forms.Button();
            this.buttonDeleteStorageItem = new System.Windows.Forms.Button();
            this.groupBoxForge = new System.Windows.Forms.GroupBox();
            this.storageItem119 = new System.Windows.Forms.Button();
            this.storageItem118 = new System.Windows.Forms.Button();
            this.storageItem117 = new System.Windows.Forms.Button();
            this.storageItem116 = new System.Windows.Forms.Button();
            this.storageItem115 = new System.Windows.Forms.Button();
            this.storageItem114 = new System.Windows.Forms.Button();
            this.storageItem113 = new System.Windows.Forms.Button();
            this.storageItem112 = new System.Windows.Forms.Button();
            this.storageItem111 = new System.Windows.Forms.Button();
            this.storageItem110 = new System.Windows.Forms.Button();
            this.storageItem109 = new System.Windows.Forms.Button();
            this.storageItem108 = new System.Windows.Forms.Button();
            this.storageItem107 = new System.Windows.Forms.Button();
            this.storageItem106 = new System.Windows.Forms.Button();
            this.storageItem105 = new System.Windows.Forms.Button();
            this.storageItem104 = new System.Windows.Forms.Button();
            this.storageItem103 = new System.Windows.Forms.Button();
            this.storageItem102 = new System.Windows.Forms.Button();
            this.storageItem101 = new System.Windows.Forms.Button();
            this.storageItem100 = new System.Windows.Forms.Button();
            this.storageItem99 = new System.Windows.Forms.Button();
            this.storageItem98 = new System.Windows.Forms.Button();
            this.storageItem97 = new System.Windows.Forms.Button();
            this.storageItem96 = new System.Windows.Forms.Button();
            this.storageItem95 = new System.Windows.Forms.Button();
            this.storageItem94 = new System.Windows.Forms.Button();
            this.storageItem93 = new System.Windows.Forms.Button();
            this.storageItem92 = new System.Windows.Forms.Button();
            this.storageItem91 = new System.Windows.Forms.Button();
            this.storageItem90 = new System.Windows.Forms.Button();
            this.storageItem89 = new System.Windows.Forms.Button();
            this.storageItem88 = new System.Windows.Forms.Button();
            this.storageItem87 = new System.Windows.Forms.Button();
            this.storageItem86 = new System.Windows.Forms.Button();
            this.storageItem85 = new System.Windows.Forms.Button();
            this.storageItem84 = new System.Windows.Forms.Button();
            this.storageItem83 = new System.Windows.Forms.Button();
            this.storageItem82 = new System.Windows.Forms.Button();
            this.storageItem81 = new System.Windows.Forms.Button();
            this.storageItem80 = new System.Windows.Forms.Button();
            this.groupBoxSafe = new System.Windows.Forms.GroupBox();
            this.storageItem79 = new System.Windows.Forms.Button();
            this.storageItem78 = new System.Windows.Forms.Button();
            this.storageItem77 = new System.Windows.Forms.Button();
            this.storageItem76 = new System.Windows.Forms.Button();
            this.storageItem75 = new System.Windows.Forms.Button();
            this.storageItem74 = new System.Windows.Forms.Button();
            this.storageItem73 = new System.Windows.Forms.Button();
            this.storageItem72 = new System.Windows.Forms.Button();
            this.storageItem71 = new System.Windows.Forms.Button();
            this.storageItem70 = new System.Windows.Forms.Button();
            this.storageItem69 = new System.Windows.Forms.Button();
            this.storageItem68 = new System.Windows.Forms.Button();
            this.storageItem67 = new System.Windows.Forms.Button();
            this.storageItem66 = new System.Windows.Forms.Button();
            this.storageItem65 = new System.Windows.Forms.Button();
            this.storageItem64 = new System.Windows.Forms.Button();
            this.storageItem63 = new System.Windows.Forms.Button();
            this.storageItem62 = new System.Windows.Forms.Button();
            this.storageItem61 = new System.Windows.Forms.Button();
            this.storageItem60 = new System.Windows.Forms.Button();
            this.storageItem59 = new System.Windows.Forms.Button();
            this.storageItem58 = new System.Windows.Forms.Button();
            this.storageItem57 = new System.Windows.Forms.Button();
            this.storageItem56 = new System.Windows.Forms.Button();
            this.storageItem55 = new System.Windows.Forms.Button();
            this.storageItem54 = new System.Windows.Forms.Button();
            this.storageItem53 = new System.Windows.Forms.Button();
            this.storageItem52 = new System.Windows.Forms.Button();
            this.storageItem51 = new System.Windows.Forms.Button();
            this.storageItem50 = new System.Windows.Forms.Button();
            this.storageItem49 = new System.Windows.Forms.Button();
            this.storageItem48 = new System.Windows.Forms.Button();
            this.storageItem47 = new System.Windows.Forms.Button();
            this.storageItem46 = new System.Windows.Forms.Button();
            this.storageItem45 = new System.Windows.Forms.Button();
            this.storageItem44 = new System.Windows.Forms.Button();
            this.storageItem43 = new System.Windows.Forms.Button();
            this.storageItem42 = new System.Windows.Forms.Button();
            this.storageItem41 = new System.Windows.Forms.Button();
            this.storageItem40 = new System.Windows.Forms.Button();
            this.groupBoxPiggyItems = new System.Windows.Forms.GroupBox();
            this.storageItem39 = new System.Windows.Forms.Button();
            this.storageItem38 = new System.Windows.Forms.Button();
            this.storageItem37 = new System.Windows.Forms.Button();
            this.storageItem36 = new System.Windows.Forms.Button();
            this.storageItem35 = new System.Windows.Forms.Button();
            this.storageItem34 = new System.Windows.Forms.Button();
            this.storageItem33 = new System.Windows.Forms.Button();
            this.storageItem32 = new System.Windows.Forms.Button();
            this.storageItem31 = new System.Windows.Forms.Button();
            this.storageItem30 = new System.Windows.Forms.Button();
            this.storageItem29 = new System.Windows.Forms.Button();
            this.storageItem28 = new System.Windows.Forms.Button();
            this.storageItem27 = new System.Windows.Forms.Button();
            this.storageItem26 = new System.Windows.Forms.Button();
            this.storageItem25 = new System.Windows.Forms.Button();
            this.storageItem24 = new System.Windows.Forms.Button();
            this.storageItem23 = new System.Windows.Forms.Button();
            this.storageItem22 = new System.Windows.Forms.Button();
            this.storageItem21 = new System.Windows.Forms.Button();
            this.storageItem20 = new System.Windows.Forms.Button();
            this.storageItem19 = new System.Windows.Forms.Button();
            this.storageItem18 = new System.Windows.Forms.Button();
            this.storageItem17 = new System.Windows.Forms.Button();
            this.storageItem16 = new System.Windows.Forms.Button();
            this.storageItem15 = new System.Windows.Forms.Button();
            this.storageItem14 = new System.Windows.Forms.Button();
            this.storageItem13 = new System.Windows.Forms.Button();
            this.storageItem12 = new System.Windows.Forms.Button();
            this.storageItem11 = new System.Windows.Forms.Button();
            this.storageItem10 = new System.Windows.Forms.Button();
            this.storageItem9 = new System.Windows.Forms.Button();
            this.storageItem8 = new System.Windows.Forms.Button();
            this.storageItem7 = new System.Windows.Forms.Button();
            this.storageItem6 = new System.Windows.Forms.Button();
            this.storageItem5 = new System.Windows.Forms.Button();
            this.storageItem4 = new System.Windows.Forms.Button();
            this.storageItem3 = new System.Windows.Forms.Button();
            this.storageItem2 = new System.Windows.Forms.Button();
            this.storageItem1 = new System.Windows.Forms.Button();
            this.storageItem0 = new System.Windows.Forms.Button();
            this.itemFilterStorage = new TerrariaInventoryEditor.Framework.ItemFilterControl();
            this.hairClrPictureBox = new System.Windows.Forms.PictureBox();
            this.hairColorLbl = new System.Windows.Forms.Label();
            this.eyeClrPictureBox = new System.Windows.Forms.PictureBox();
            this.randomizeColorsBtn = new System.Windows.Forms.Button();
            this.eyeColorLbl = new System.Windows.Forms.Label();
            this.randomizeHairBtn = new System.Windows.Forms.Button();
            this.skinClrPictureBox = new System.Windows.Forms.PictureBox();
            this.hairDesignerBtn = new System.Windows.Forms.Button();
            this.skinColorLbl = new System.Windows.Forms.Label();
            this.shoeColorLbl = new System.Windows.Forms.Label();
            this.shirtClrPictureBox = new System.Windows.Forms.PictureBox();
            this.pantsColorLbl = new System.Windows.Forms.Label();
            this.undershirtClrPictureBox = new System.Windows.Forms.PictureBox();
            this.undershirtColorLbl = new System.Windows.Forms.Label();
            this.pantsClrPictureBox = new System.Windows.Forms.PictureBox();
            this.shirtColorLbl = new System.Windows.Forms.Label();
            this.shoeClrPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.statsTab.SuspendLayout();
            this.healthManaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.playerBindingSource)).BeginInit();
            this.playerInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.upDownAnglerQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.upDownSkinVariant)).BeginInit();
            this.appearanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShoeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPantsColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxUndershirtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShirtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxEyeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxSkinColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxHairColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.playerPictureBox)).BeginInit();
            this.appearanceTab.SuspendLayout();
            this.equipmentFilterGroupBox.SuspendLayout();
            this.buffsTab.SuspendLayout();
            this.groupBoxBuffControls.SuspendLayout();
            this.groupBoxActiveBuffs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.gridViewBuffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.buffsBindingSource)).BeginInit();
            this.inventoryTab.SuspendLayout();
            this.groupBoxItemProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.upDownStackSize)).BeginInit();
            this.inventoryFilterGroupBox.SuspendLayout();
            this.tabPageStorage.SuspendLayout();
            this.groupBoxForge.SuspendLayout();
            this.groupBoxSafe.SuspendLayout();
            this.groupBoxPiggyItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.hairClrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.eyeClrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.skinClrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.shirtClrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.undershirtClrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pantsClrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.shoeClrPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1232, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolstripMenuItemNew, this.toolstripMenuItemOpen, this.toolstripMenuItemSave,
                this.toolstripMenuItemSaveAs, this.toolstripMenuItemExit
            });
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolstripMenuItemNew
            // 
            this.toolstripMenuItemNew.Name = "toolstripMenuItemNew";
            this.toolstripMenuItemNew.Size = new System.Drawing.Size(123, 22);
            this.toolstripMenuItemNew.Text = "New";
            this.toolstripMenuItemNew.Click += new System.EventHandler(this.toolstripMenuItemNew_Click);
            // 
            // toolstripMenuItemOpen
            // 
            this.toolstripMenuItemOpen.Name = "toolstripMenuItemOpen";
            this.toolstripMenuItemOpen.Size = new System.Drawing.Size(123, 22);
            this.toolstripMenuItemOpen.Text = "Open...";
            this.toolstripMenuItemOpen.Click += new System.EventHandler(this.toolstripMenuItemOpen_Click);
            // 
            // toolstripMenuItemSave
            // 
            this.toolstripMenuItemSave.Name = "toolstripMenuItemSave";
            this.toolstripMenuItemSave.Size = new System.Drawing.Size(123, 22);
            this.toolstripMenuItemSave.Text = "Save";
            this.toolstripMenuItemSave.Click += new System.EventHandler(this.toolstripMenuItemSave_Click);
            // 
            // toolstripMenuItemSaveAs
            // 
            this.toolstripMenuItemSaveAs.Name = "toolstripMenuItemSaveAs";
            this.toolstripMenuItemSaveAs.Size = new System.Drawing.Size(123, 22);
            this.toolstripMenuItemSaveAs.Text = "Save As...";
            this.toolstripMenuItemSaveAs.Click += new System.EventHandler(this.toolstripMenuItemSaveAs_Click);
            // 
            // toolstripMenuItemExit
            // 
            this.toolstripMenuItemExit.Name = "toolstripMenuItemExit";
            this.toolstripMenuItemExit.Size = new System.Drawing.Size(123, 22);
            this.toolstripMenuItemExit.Text = "Exit";
            this.toolstripMenuItemExit.Click += new System.EventHandler(this.toolstripMenuItemExit_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.statsTab);
            this.tabControl.Controls.Add(this.appearanceTab);
            this.tabControl.Controls.Add(this.buffsTab);
            this.tabControl.Controls.Add(this.inventoryTab);
            this.tabControl.Controls.Add(this.tabPageStorage);
            this.tabControl.ItemSize = new System.Drawing.Size(48, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1232, 624);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_TabSelected);
            // 
            // statsTab
            // 
            this.statsTab.Controls.Add(this.healthManaGroupBox);
            this.statsTab.Controls.Add(this.playerInfoGroupBox);
            this.statsTab.Controls.Add(this.appearanceGroupBox);
            this.statsTab.Location = new System.Drawing.Point(4, 24);
            this.statsTab.Name = "statsTab";
            this.statsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statsTab.Size = new System.Drawing.Size(1224, 596);
            this.statsTab.TabIndex = 0;
            this.statsTab.Text = "Stats";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // healthManaGroupBox
            // 
            this.healthManaGroupBox.Controls.Add(this.buttonMaxOut);
            this.healthManaGroupBox.Controls.Add(this.buttonResetDefaults);
            this.healthManaGroupBox.Controls.Add(this.manaBar);
            this.healthManaGroupBox.Controls.Add(this.textBoxMaxMana);
            this.healthManaGroupBox.Controls.Add(this.textBoxCurrentMana);
            this.healthManaGroupBox.Controls.Add(this.manaLabel);
            this.healthManaGroupBox.Controls.Add(this.textBoxMaxHealth);
            this.healthManaGroupBox.Controls.Add(this.healthBar);
            this.healthManaGroupBox.Controls.Add(this.textBoxCurrentHealth);
            this.healthManaGroupBox.Controls.Add(this.healthLabel);
            this.healthManaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.healthManaGroupBox.Location = new System.Drawing.Point(400, 8);
            this.healthManaGroupBox.Name = "healthManaGroupBox";
            this.healthManaGroupBox.Size = new System.Drawing.Size(356, 224);
            this.healthManaGroupBox.TabIndex = 14;
            this.healthManaGroupBox.TabStop = false;
            this.healthManaGroupBox.Text = "Health and Mana";
            // 
            // buttonMaxOut
            // 
            this.buttonMaxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonMaxOut.Location = new System.Drawing.Point(194, 179);
            this.buttonMaxOut.Name = "buttonMaxOut";
            this.buttonMaxOut.Size = new System.Drawing.Size(128, 27);
            this.buttonMaxOut.TabIndex = 9;
            this.buttonMaxOut.Text = "Max Out";
            this.buttonMaxOut.UseVisualStyleBackColor = true;
            this.buttonMaxOut.Click += new System.EventHandler(this.buttonMaxOut_Click);
            // 
            // buttonResetDefaults
            // 
            this.buttonResetDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonResetDefaults.Location = new System.Drawing.Point(12, 179);
            this.buttonResetDefaults.Name = "buttonResetDefaults";
            this.buttonResetDefaults.Size = new System.Drawing.Size(128, 27);
            this.buttonResetDefaults.TabIndex = 8;
            this.buttonResetDefaults.Text = "Restore Defaults";
            this.buttonResetDefaults.UseVisualStyleBackColor = true;
            this.buttonResetDefaults.Click += new System.EventHandler(this.buttonResetDefaults_Click);
            // 
            // manaBar
            // 
            this.manaBar.BackColor = System.Drawing.SystemColors.Control;
            this.manaBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource, "Mana",
                true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.manaBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.playerBindingSource,
                "MaxMana", true));
            this.manaBar.Location = new System.Drawing.Point(12, 113);
            this.manaBar.Maximum = 20;
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(310, 27);
            this.manaBar.TabIndex = 7;
            this.manaBar.Value = 20;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(TerrariaInventoryEditor.TerrariaLib.Player);
            // 
            // textBoxMaxMana
            // 
            this.textBoxMaxMana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource,
                "MaxMana", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxMaxMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxMaxMana.Location = new System.Drawing.Point(205, 83);
            this.textBoxMaxMana.Name = "textBoxMaxMana";
            this.textBoxMaxMana.Size = new System.Drawing.Size(116, 20);
            this.textBoxMaxMana.TabIndex = 6;
            // 
            // textBoxCurrentMana
            // 
            this.textBoxCurrentMana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource,
                "Mana", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCurrentMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxCurrentMana.Location = new System.Drawing.Point(82, 83);
            this.textBoxCurrentMana.Name = "textBoxCurrentMana";
            this.textBoxCurrentMana.Size = new System.Drawing.Size(116, 20);
            this.textBoxCurrentMana.TabIndex = 5;
            // 
            // manaLabel
            // 
            this.manaLabel.AutoSize = true;
            this.manaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.manaLabel.Location = new System.Drawing.Point(16, 85);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(50, 16);
            this.manaLabel.TabIndex = 4;
            this.manaLabel.Text = "Mana:";
            // 
            // textBoxMaxHealth
            // 
            this.textBoxMaxHealth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource,
                "MaxHealth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxMaxHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxMaxHealth.Location = new System.Drawing.Point(205, 20);
            this.textBoxMaxHealth.Name = "textBoxMaxHealth";
            this.textBoxMaxHealth.Size = new System.Drawing.Size(116, 20);
            this.textBoxMaxHealth.TabIndex = 3;
            // 
            // healthBar
            // 
            this.healthBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource,
                "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.healthBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.playerBindingSource,
                "MaxHealth", true));
            this.healthBar.Location = new System.Drawing.Point(12, 50);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(310, 27);
            this.healthBar.TabIndex = 2;
            this.healthBar.Value = 100;
            // 
            // textBoxCurrentHealth
            // 
            this.textBoxCurrentHealth.DataBindings.Add(new System.Windows.Forms.Binding("Text",
                this.playerBindingSource, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCurrentHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxCurrentHealth.Location = new System.Drawing.Point(82, 20);
            this.textBoxCurrentHealth.Name = "textBoxCurrentHealth";
            this.textBoxCurrentHealth.Size = new System.Drawing.Size(116, 20);
            this.textBoxCurrentHealth.TabIndex = 1;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.healthLabel.Location = new System.Drawing.Point(8, 23);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(57, 16);
            this.healthLabel.TabIndex = 0;
            this.healthLabel.Text = "Health:";
            // 
            // playerInfoGroupBox
            // 
            this.playerInfoGroupBox.Controls.Add(this.checkBoxHotbarLocked);
            this.playerInfoGroupBox.Controls.Add(this.textBoxTaxMoney);
            this.playerInfoGroupBox.Controls.Add(this.taxMoneyLbl);
            this.playerInfoGroupBox.Controls.Add(this.checkBoxExtraAccessory);
            this.playerInfoGroupBox.Controls.Add(this.textBoxPlayTime);
            this.playerInfoGroupBox.Controls.Add(this.playTimeLbl);
            this.playerInfoGroupBox.Controls.Add(this.upDownAnglerQuests);
            this.playerInfoGroupBox.Controls.Add(this.upDownSkinVariant);
            this.playerInfoGroupBox.Controls.Add(this.anglerLbl);
            this.playerInfoGroupBox.Controls.Add(this.skinVariantLbl);
            this.playerInfoGroupBox.Controls.Add(this.comboBoxDifficulty);
            this.playerInfoGroupBox.Controls.Add(this.difficultyLbl);
            this.playerInfoGroupBox.Controls.Add(this.textBoxPlayerName);
            this.playerInfoGroupBox.Controls.Add(this.playerNameLbl);
            this.playerInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.playerInfoGroupBox.Location = new System.Drawing.Point(7, 8);
            this.playerInfoGroupBox.Name = "playerInfoGroupBox";
            this.playerInfoGroupBox.Size = new System.Drawing.Size(386, 224);
            this.playerInfoGroupBox.TabIndex = 13;
            this.playerInfoGroupBox.TabStop = false;
            this.playerInfoGroupBox.Text = "Player Information";
            // 
            // checkBoxHotbarLocked
            // 
            this.checkBoxHotbarLocked.AutoSize = true;
            this.checkBoxHotbarLocked.DataBindings.Add(new System.Windows.Forms.Binding("CheckState",
                this.playerBindingSource, "IsHotbarLocked", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxHotbarLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxHotbarLocked.Location = new System.Drawing.Point(246, 157);
            this.checkBoxHotbarLocked.Name = "checkBoxHotbarLocked";
            this.checkBoxHotbarLocked.Size = new System.Drawing.Size(97, 17);
            this.checkBoxHotbarLocked.TabIndex = 37;
            this.checkBoxHotbarLocked.Text = "Hotbar Locked";
            this.checkBoxHotbarLocked.UseVisualStyleBackColor = true;
            // 
            // textBoxTaxMoney
            // 
            this.textBoxTaxMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource,
                "TaxMoney", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxTaxMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxTaxMoney.Location = new System.Drawing.Point(147, 187);
            this.textBoxTaxMoney.Name = "textBoxTaxMoney";
            this.textBoxTaxMoney.Size = new System.Drawing.Size(209, 20);
            this.textBoxTaxMoney.TabIndex = 36;
            // 
            // taxMoneyLbl
            // 
            this.taxMoneyLbl.AutoSize = true;
            this.taxMoneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.taxMoneyLbl.Location = new System.Drawing.Point(40, 188);
            this.taxMoneyLbl.Name = "taxMoneyLbl";
            this.taxMoneyLbl.Size = new System.Drawing.Size(88, 16);
            this.taxMoneyLbl.TabIndex = 35;
            this.taxMoneyLbl.Text = "Tax Money:";
            // 
            // checkBoxExtraAccessory
            // 
            this.checkBoxExtraAccessory.AutoSize = true;
            this.checkBoxExtraAccessory.DataBindings.Add(new System.Windows.Forms.Binding("CheckState",
                this.playerBindingSource, "ExtraAccessory", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxExtraAccessory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxExtraAccessory.Location = new System.Drawing.Point(246, 127);
            this.checkBoxExtraAccessory.Name = "checkBoxExtraAccessory";
            this.checkBoxExtraAccessory.Size = new System.Drawing.Size(102, 17);
            this.checkBoxExtraAccessory.TabIndex = 34;
            this.checkBoxExtraAccessory.Text = "Extra Accessory";
            this.checkBoxExtraAccessory.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayTime
            // 
            this.textBoxPlayTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource,
                "PlayTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxPlayTime.Location = new System.Drawing.Point(148, 88);
            this.textBoxPlayTime.Name = "textBoxPlayTime";
            this.textBoxPlayTime.Size = new System.Drawing.Size(208, 20);
            this.textBoxPlayTime.TabIndex = 33;
            // 
            // playTimeLbl
            // 
            this.playTimeLbl.AutoSize = true;
            this.playTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.playTimeLbl.Location = new System.Drawing.Point(49, 89);
            this.playTimeLbl.Name = "playTimeLbl";
            this.playTimeLbl.Size = new System.Drawing.Size(82, 16);
            this.playTimeLbl.TabIndex = 32;
            this.playTimeLbl.Text = "Play Time:";
            // 
            // upDownAnglerQuests
            // 
            this.upDownAnglerQuests.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource,
                "AnglerQuestsFinished", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.upDownAnglerQuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.upDownAnglerQuests.Location = new System.Drawing.Point(147, 156);
            this.upDownAnglerQuests.Maximum = new decimal(new int[] {2147483647, 0, 0, 0});
            this.upDownAnglerQuests.Name = "upDownAnglerQuests";
            this.upDownAnglerQuests.Size = new System.Drawing.Size(92, 20);
            this.upDownAnglerQuests.TabIndex = 31;
            // 
            // upDownSkinVariant
            // 
            this.upDownSkinVariant.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource,
                "SkinVariant", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.upDownSkinVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.upDownSkinVariant.Location = new System.Drawing.Point(147, 126);
            this.upDownSkinVariant.Maximum = new decimal(new int[] {9, 0, 0, 0});
            this.upDownSkinVariant.Name = "upDownSkinVariant";
            this.upDownSkinVariant.Size = new System.Drawing.Size(92, 20);
            this.upDownSkinVariant.TabIndex = 30;
            // 
            // anglerLbl
            // 
            this.anglerLbl.AutoSize = true;
            this.anglerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.anglerLbl.Location = new System.Drawing.Point(15, 156);
            this.anglerLbl.Name = "anglerLbl";
            this.anglerLbl.Size = new System.Drawing.Size(109, 16);
            this.anglerLbl.TabIndex = 28;
            this.anglerLbl.Text = "Angler Quests:";
            // 
            // skinVariantLbl
            // 
            this.skinVariantLbl.AutoSize = true;
            this.skinVariantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.skinVariantLbl.Location = new System.Drawing.Point(31, 126);
            this.skinVariantLbl.Name = "skinVariantLbl";
            this.skinVariantLbl.Size = new System.Drawing.Size(95, 16);
            this.skinVariantLbl.TabIndex = 24;
            this.skinVariantLbl.Text = "Skin Variant:";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource,
                "Difficulty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {"Softcore", "Mediumcore", "Hardcore"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(148, 53);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(208, 21);
            this.comboBoxDifficulty.TabIndex = 23;
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.AutoSize = true;
            this.difficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.difficultyLbl.Location = new System.Drawing.Point(57, 54);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(75, 16);
            this.difficultyLbl.TabIndex = 22;
            this.difficultyLbl.Text = "Difficulty: ";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource,
                "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(148, 23);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(208, 20);
            this.textBoxPlayerName.TabIndex = 21;
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.playerNameLbl.Location = new System.Drawing.Point(21, 23);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(106, 16);
            this.playerNameLbl.TabIndex = 20;
            this.playerNameLbl.Text = "Player Name: ";
            // 
            // appearanceGroupBox
            // 
            this.appearanceGroupBox.Controls.Add(this.btnLoadAppearance);
            this.appearanceGroupBox.Controls.Add(this.btnSaveAppearance);
            this.appearanceGroupBox.Controls.Add(this.buttonRandomColors);
            this.appearanceGroupBox.Controls.Add(this.buttonRandomHair);
            this.appearanceGroupBox.Controls.Add(this.buttonEditHair);
            this.appearanceGroupBox.Controls.Add(this.pictureBoxShoeColor);
            this.appearanceGroupBox.Controls.Add(this.labelShoeColor);
            this.appearanceGroupBox.Controls.Add(this.pictureBoxPantsColor);
            this.appearanceGroupBox.Controls.Add(this.labelPantsColor);
            this.appearanceGroupBox.Controls.Add(this.pictureBoxUndershirtColor);
            this.appearanceGroupBox.Controls.Add(this.labelUndershirtColor);
            this.appearanceGroupBox.Controls.Add(this.pictureBoxShirtColor);
            this.appearanceGroupBox.Controls.Add(this.labelShirtColor);
            this.appearanceGroupBox.Controls.Add(this.pictureBoxEyeColor);
            this.appearanceGroupBox.Controls.Add(this.labelEyeColor);
            this.appearanceGroupBox.Controls.Add(this.pictureBoxSkinColor);
            this.appearanceGroupBox.Controls.Add(this.labelSkinColor);
            this.appearanceGroupBox.Controls.Add(this.pictureBoxHairColor);
            this.appearanceGroupBox.Controls.Add(this.labelHairColor);
            this.appearanceGroupBox.Controls.Add(this.playerPictureBox);
            this.appearanceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.appearanceGroupBox.Location = new System.Drawing.Point(7, 238);
            this.appearanceGroupBox.Name = "appearanceGroupBox";
            this.appearanceGroupBox.Size = new System.Drawing.Size(749, 331);
            this.appearanceGroupBox.TabIndex = 22;
            this.appearanceGroupBox.TabStop = false;
            this.appearanceGroupBox.Text = "Appearance";
            // 
            // btnLoadAppearance
            // 
            this.btnLoadAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLoadAppearance.Location = new System.Drawing.Point(21, 240);
            this.btnLoadAppearance.Name = "btnLoadAppearance";
            this.btnLoadAppearance.Size = new System.Drawing.Size(136, 25);
            this.btnLoadAppearance.TabIndex = 20;
            this.btnLoadAppearance.Text = "Load Appearance";
            this.btnLoadAppearance.UseVisualStyleBackColor = true;
            // 
            // btnSaveAppearance
            // 
            this.btnSaveAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSaveAppearance.Location = new System.Drawing.Point(21, 271);
            this.btnSaveAppearance.Name = "btnSaveAppearance";
            this.btnSaveAppearance.Size = new System.Drawing.Size(136, 25);
            this.btnSaveAppearance.TabIndex = 19;
            this.btnSaveAppearance.Text = "Save Appearance";
            this.btnSaveAppearance.UseVisualStyleBackColor = true;
            // 
            // buttonRandomColors
            // 
            this.buttonRandomColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonRandomColors.Location = new System.Drawing.Point(21, 28);
            this.buttonRandomColors.Name = "buttonRandomColors";
            this.buttonRandomColors.Size = new System.Drawing.Size(136, 25);
            this.buttonRandomColors.TabIndex = 18;
            this.buttonRandomColors.Text = "Randomize Colors";
            this.buttonRandomColors.UseVisualStyleBackColor = true;
            this.buttonRandomColors.Click += new System.EventHandler(this.buttonRandomColors_Click);
            // 
            // buttonRandomHair
            // 
            this.buttonRandomHair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonRandomHair.Location = new System.Drawing.Point(21, 59);
            this.buttonRandomHair.Name = "buttonRandomHair";
            this.buttonRandomHair.Size = new System.Drawing.Size(136, 25);
            this.buttonRandomHair.TabIndex = 17;
            this.buttonRandomHair.Text = "Randomize Hair";
            this.buttonRandomHair.UseVisualStyleBackColor = true;
            this.buttonRandomHair.Click += new System.EventHandler(this.buttonRandomHair_Click);
            // 
            // buttonEditHair
            // 
            this.buttonEditHair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonEditHair.Location = new System.Drawing.Point(21, 209);
            this.buttonEditHair.Name = "buttonEditHair";
            this.buttonEditHair.Size = new System.Drawing.Size(136, 25);
            this.buttonEditHair.TabIndex = 16;
            this.buttonEditHair.Text = "Hair Designer";
            this.buttonEditHair.UseVisualStyleBackColor = true;
            this.buttonEditHair.Click += new System.EventHandler(this.buttonEditHair_Click);
            // 
            // pictureBoxShoeColor
            // 
            this.pictureBoxShoeColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor",
                this.playerBindingSource, "ShoeColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBoxShoeColor.Location = new System.Drawing.Point(625, 226);
            this.pictureBoxShoeColor.Name = "pictureBoxShoeColor";
            this.pictureBoxShoeColor.Size = new System.Drawing.Size(90, 25);
            this.pictureBoxShoeColor.TabIndex = 15;
            this.pictureBoxShoeColor.TabStop = false;
            this.pictureBoxShoeColor.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelShoeColor
            // 
            this.labelShoeColor.AutoSize = true;
            this.labelShoeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelShoeColor.Location = new System.Drawing.Point(521, 226);
            this.labelShoeColor.Name = "labelShoeColor";
            this.labelShoeColor.Size = new System.Drawing.Size(82, 15);
            this.labelShoeColor.TabIndex = 14;
            this.labelShoeColor.Text = "Shoe Color:";
            // 
            // pictureBoxPantsColor
            // 
            this.pictureBoxPantsColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor",
                this.playerBindingSource, "PantsColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBoxPantsColor.Location = new System.Drawing.Point(625, 193);
            this.pictureBoxPantsColor.Name = "pictureBoxPantsColor";
            this.pictureBoxPantsColor.Size = new System.Drawing.Size(90, 25);
            this.pictureBoxPantsColor.TabIndex = 13;
            this.pictureBoxPantsColor.TabStop = false;
            this.pictureBoxPantsColor.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelPantsColor
            // 
            this.labelPantsColor.AutoSize = true;
            this.labelPantsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPantsColor.Location = new System.Drawing.Point(518, 193);
            this.labelPantsColor.Name = "labelPantsColor";
            this.labelPantsColor.Size = new System.Drawing.Size(85, 15);
            this.labelPantsColor.TabIndex = 12;
            this.labelPantsColor.Text = "Pants Color:";
            // 
            // pictureBoxUndershirtColor
            // 
            this.pictureBoxUndershirtColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor",
                this.playerBindingSource, "UndershirtColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBoxUndershirtColor.Location = new System.Drawing.Point(625, 162);
            this.pictureBoxUndershirtColor.Name = "pictureBoxUndershirtColor";
            this.pictureBoxUndershirtColor.Size = new System.Drawing.Size(90, 25);
            this.pictureBoxUndershirtColor.TabIndex = 11;
            this.pictureBoxUndershirtColor.TabStop = false;
            this.pictureBoxUndershirtColor.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelUndershirtColor
            // 
            this.labelUndershirtColor.AutoSize = true;
            this.labelUndershirtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelUndershirtColor.Location = new System.Drawing.Point(486, 162);
            this.labelUndershirtColor.Name = "labelUndershirtColor";
            this.labelUndershirtColor.Size = new System.Drawing.Size(116, 15);
            this.labelUndershirtColor.TabIndex = 10;
            this.labelUndershirtColor.Text = "Undershirt Color:";
            // 
            // pictureBoxShirtColor
            // 
            this.pictureBoxShirtColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor",
                this.playerBindingSource, "ShirtColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBoxShirtColor.Location = new System.Drawing.Point(625, 129);
            this.pictureBoxShirtColor.Name = "pictureBoxShirtColor";
            this.pictureBoxShirtColor.Size = new System.Drawing.Size(90, 25);
            this.pictureBoxShirtColor.TabIndex = 9;
            this.pictureBoxShirtColor.TabStop = false;
            this.pictureBoxShirtColor.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelShirtColor
            // 
            this.labelShirtColor.AutoSize = true;
            this.labelShirtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelShirtColor.Location = new System.Drawing.Point(524, 129);
            this.labelShirtColor.Name = "labelShirtColor";
            this.labelShirtColor.Size = new System.Drawing.Size(79, 15);
            this.labelShirtColor.TabIndex = 8;
            this.labelShirtColor.Text = "Shirt Color:";
            // 
            // pictureBoxEyeColor
            // 
            this.pictureBoxEyeColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor",
                this.playerBindingSource, "EyeColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBoxEyeColor.Location = new System.Drawing.Point(625, 97);
            this.pictureBoxEyeColor.Name = "pictureBoxEyeColor";
            this.pictureBoxEyeColor.Size = new System.Drawing.Size(90, 25);
            this.pictureBoxEyeColor.TabIndex = 7;
            this.pictureBoxEyeColor.TabStop = false;
            this.pictureBoxEyeColor.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelEyeColor
            // 
            this.labelEyeColor.AutoSize = true;
            this.labelEyeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelEyeColor.Location = new System.Drawing.Point(531, 97);
            this.labelEyeColor.Name = "labelEyeColor";
            this.labelEyeColor.Size = new System.Drawing.Size(72, 15);
            this.labelEyeColor.TabIndex = 6;
            this.labelEyeColor.Text = "Eye Color:";
            // 
            // pictureBoxSkinColor
            // 
            this.pictureBoxSkinColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor",
                this.playerBindingSource, "SkinColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBoxSkinColor.Location = new System.Drawing.Point(625, 65);
            this.pictureBoxSkinColor.Name = "pictureBoxSkinColor";
            this.pictureBoxSkinColor.Size = new System.Drawing.Size(90, 25);
            this.pictureBoxSkinColor.TabIndex = 5;
            this.pictureBoxSkinColor.TabStop = false;
            this.pictureBoxSkinColor.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelSkinColor
            // 
            this.labelSkinColor.AutoSize = true;
            this.labelSkinColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSkinColor.Location = new System.Drawing.Point(526, 65);
            this.labelSkinColor.Name = "labelSkinColor";
            this.labelSkinColor.Size = new System.Drawing.Size(77, 15);
            this.labelSkinColor.TabIndex = 4;
            this.labelSkinColor.Text = "Skin Color:";
            // 
            // pictureBoxHairColor
            // 
            this.pictureBoxHairColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor",
                this.playerBindingSource, "HairColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBoxHairColor.Location = new System.Drawing.Point(625, 28);
            this.pictureBoxHairColor.Name = "pictureBoxHairColor";
            this.pictureBoxHairColor.Size = new System.Drawing.Size(90, 25);
            this.pictureBoxHairColor.TabIndex = 3;
            this.pictureBoxHairColor.TabStop = false;
            this.pictureBoxHairColor.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelHairColor
            // 
            this.labelHairColor.AutoSize = true;
            this.labelHairColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelHairColor.Location = new System.Drawing.Point(527, 33);
            this.labelHairColor.Name = "labelHairColor";
            this.labelHairColor.Size = new System.Drawing.Size(76, 15);
            this.labelHairColor.TabIndex = 1;
            this.labelHairColor.Text = "Hair Color:";
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("EyeColor",
                this.playerBindingSource, "EyeColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("HairColor",
                this.playerBindingSource, "HairColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("HairId", this.playerBindingSource,
                "Hair", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("PantsColor",
                this.playerBindingSource, "PantsColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ShirtColor",
                this.playerBindingSource, "ShirtColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ShoeColor",
                this.playerBindingSource, "ShoeColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("SkinVariant",
                this.playerBindingSource, "SkinVariant", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("UndershirtColor",
                this.playerBindingSource, "UndershirtColor", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerPictureBox.EyeColor = System.Drawing.Color.FromArgb(((int) (((byte) (105)))),
                ((int) (((byte) (90)))), ((int) (((byte) (75)))));
            this.playerPictureBox.HairColor = System.Drawing.Color.FromArgb(((int) (((byte) (215)))),
                ((int) (((byte) (90)))), ((int) (((byte) (55)))));
            this.playerPictureBox.HairId = 0;
            this.playerPictureBox.HairTextureFile = "Data\\HairTextures\\Player_Hair_1.png";
            this.playerPictureBox.Location = new System.Drawing.Point(301, 18);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.PantsColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (230)))), ((int) (((byte) (175)))));
            this.playerPictureBox.ShirtColor = System.Drawing.Color.FromArgb(((int) (((byte) (175)))),
                ((int) (((byte) (165)))), ((int) (((byte) (140)))));
            this.playerPictureBox.ShoeColor = System.Drawing.Color.FromArgb(((int) (((byte) (160)))),
                ((int) (((byte) (105)))), ((int) (((byte) (60)))));
            this.playerPictureBox.Size = new System.Drawing.Size(157, 246);
            this.playerPictureBox.SkinColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (125)))), ((int) (((byte) (90)))));
            this.playerPictureBox.SkinVariant = 0;
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            this.playerPictureBox.UndershirtColor = System.Drawing.Color.FromArgb(((int) (((byte) (160)))),
                ((int) (((byte) (180)))), ((int) (((byte) (215)))));
            // 
            // appearanceTab
            // 
            this.appearanceTab.Controls.Add(this.label2);
            this.appearanceTab.Controls.Add(this.label1);
            this.appearanceTab.Controls.Add(this.dyeItem8);
            this.appearanceTab.Controls.Add(this.dyeItem7);
            this.appearanceTab.Controls.Add(this.dyeItem6);
            this.appearanceTab.Controls.Add(this.dyeItem5);
            this.appearanceTab.Controls.Add(this.dyeItem4);
            this.appearanceTab.Controls.Add(this.dyeItem3);
            this.appearanceTab.Controls.Add(this.equipmentItem18);
            this.appearanceTab.Controls.Add(this.equipmentItem8);
            this.appearanceTab.Controls.Add(this.equipmentItem7);
            this.appearanceTab.Controls.Add(this.equipmentItem6);
            this.appearanceTab.Controls.Add(this.equipmentItem5);
            this.appearanceTab.Controls.Add(this.equipmentItem4);
            this.appearanceTab.Controls.Add(this.equipmentItem3);
            this.appearanceTab.Controls.Add(this.equipmentItem2);
            this.appearanceTab.Controls.Add(this.equipmentItem1);
            this.appearanceTab.Controls.Add(this.equipmentItem0);
            this.appearanceTab.Controls.Add(this.equipmentItem17);
            this.appearanceTab.Controls.Add(this.equipmentItem16);
            this.appearanceTab.Controls.Add(this.equipmentItem15);
            this.appearanceTab.Controls.Add(this.equipmentItem14);
            this.appearanceTab.Controls.Add(this.equipmentItem13);
            this.appearanceTab.Controls.Add(this.equipmentItem12);
            this.appearanceTab.Controls.Add(this.equipmentItem11);
            this.appearanceTab.Controls.Add(this.equipmentItem10);
            this.appearanceTab.Controls.Add(this.dyeItem2);
            this.appearanceTab.Controls.Add(this.dyeItem1);
            this.appearanceTab.Controls.Add(this.armorLbl);
            this.appearanceTab.Controls.Add(this.socialsLbl);
            this.appearanceTab.Controls.Add(this.dyeLbl);
            this.appearanceTab.Controls.Add(this.equipmentFilterGroupBox);
            this.appearanceTab.Controls.Add(this.dyeItem0);
            this.appearanceTab.Location = new System.Drawing.Point(4, 24);
            this.appearanceTab.Name = "appearanceTab";
            this.appearanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.appearanceTab.Size = new System.Drawing.Size(1224, 596);
            this.appearanceTab.TabIndex = 1;
            this.appearanceTab.Text = "Appearance & Equipment";
            this.appearanceTab.UseVisualStyleBackColor = true;
            // 
            // dyeItem8
            // 
            this.dyeItem8.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem8.ForeColor = System.Drawing.Color.White;
            this.dyeItem8.Location = new System.Drawing.Point(362, 501);
            this.dyeItem8.Name = "dyeItem8";
            this.dyeItem8.Size = new System.Drawing.Size(52, 52);
            this.dyeItem8.TabIndex = 51;
            this.dyeItem8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem8.UseVisualStyleBackColor = false;
            this.dyeItem8.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // dyeItem7
            // 
            this.dyeItem7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem7.ForeColor = System.Drawing.Color.White;
            this.dyeItem7.Location = new System.Drawing.Point(362, 442);
            this.dyeItem7.Name = "dyeItem7";
            this.dyeItem7.Size = new System.Drawing.Size(52, 52);
            this.dyeItem7.TabIndex = 50;
            this.dyeItem7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem7.UseVisualStyleBackColor = false;
            this.dyeItem7.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // dyeItem6
            // 
            this.dyeItem6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem6.ForeColor = System.Drawing.Color.White;
            this.dyeItem6.Location = new System.Drawing.Point(362, 384);
            this.dyeItem6.Name = "dyeItem6";
            this.dyeItem6.Size = new System.Drawing.Size(52, 52);
            this.dyeItem6.TabIndex = 49;
            this.dyeItem6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem6.UseVisualStyleBackColor = false;
            this.dyeItem6.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // dyeItem5
            // 
            this.dyeItem5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem5.ForeColor = System.Drawing.Color.White;
            this.dyeItem5.Location = new System.Drawing.Point(362, 325);
            this.dyeItem5.Name = "dyeItem5";
            this.dyeItem5.Size = new System.Drawing.Size(52, 52);
            this.dyeItem5.TabIndex = 48;
            this.dyeItem5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem5.UseVisualStyleBackColor = false;
            this.dyeItem5.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // dyeItem4
            // 
            this.dyeItem4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem4.ForeColor = System.Drawing.Color.White;
            this.dyeItem4.Location = new System.Drawing.Point(362, 267);
            this.dyeItem4.Name = "dyeItem4";
            this.dyeItem4.Size = new System.Drawing.Size(52, 52);
            this.dyeItem4.TabIndex = 47;
            this.dyeItem4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem4.UseVisualStyleBackColor = false;
            this.dyeItem4.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // dyeItem3
            // 
            this.dyeItem3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem3.ForeColor = System.Drawing.Color.White;
            this.dyeItem3.Location = new System.Drawing.Point(362, 207);
            this.dyeItem3.Name = "dyeItem3";
            this.dyeItem3.Size = new System.Drawing.Size(52, 52);
            this.dyeItem3.TabIndex = 46;
            this.dyeItem3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem3.UseVisualStyleBackColor = false;
            this.dyeItem3.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem18
            // 
            this.equipmentItem18.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem18.ForeColor = System.Drawing.Color.White;
            this.equipmentItem18.Location = new System.Drawing.Point(436, 501);
            this.equipmentItem18.Name = "equipmentItem18";
            this.equipmentItem18.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem18.TabIndex = 45;
            this.equipmentItem18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem18.UseVisualStyleBackColor = false;
            this.equipmentItem18.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem8
            // 
            this.equipmentItem8.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem8.ForeColor = System.Drawing.Color.White;
            this.equipmentItem8.Location = new System.Drawing.Point(524, 501);
            this.equipmentItem8.Name = "equipmentItem8";
            this.equipmentItem8.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem8.TabIndex = 44;
            this.equipmentItem8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem8.UseVisualStyleBackColor = false;
            this.equipmentItem8.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem7
            // 
            this.equipmentItem7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem7.ForeColor = System.Drawing.Color.White;
            this.equipmentItem7.Location = new System.Drawing.Point(524, 442);
            this.equipmentItem7.Name = "equipmentItem7";
            this.equipmentItem7.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem7.TabIndex = 43;
            this.equipmentItem7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem7.UseVisualStyleBackColor = false;
            this.equipmentItem7.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem6
            // 
            this.equipmentItem6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem6.ForeColor = System.Drawing.Color.White;
            this.equipmentItem6.Location = new System.Drawing.Point(524, 384);
            this.equipmentItem6.Name = "equipmentItem6";
            this.equipmentItem6.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem6.TabIndex = 42;
            this.equipmentItem6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem6.UseVisualStyleBackColor = false;
            this.equipmentItem6.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem5
            // 
            this.equipmentItem5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem5.ForeColor = System.Drawing.Color.White;
            this.equipmentItem5.Location = new System.Drawing.Point(524, 326);
            this.equipmentItem5.Name = "equipmentItem5";
            this.equipmentItem5.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem5.TabIndex = 41;
            this.equipmentItem5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem5.UseVisualStyleBackColor = false;
            this.equipmentItem5.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem4
            // 
            this.equipmentItem4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem4.ForeColor = System.Drawing.Color.White;
            this.equipmentItem4.Location = new System.Drawing.Point(524, 267);
            this.equipmentItem4.Name = "equipmentItem4";
            this.equipmentItem4.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem4.TabIndex = 40;
            this.equipmentItem4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem4.UseVisualStyleBackColor = false;
            this.equipmentItem4.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem3
            // 
            this.equipmentItem3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem3.ForeColor = System.Drawing.Color.White;
            this.equipmentItem3.Location = new System.Drawing.Point(524, 207);
            this.equipmentItem3.Name = "equipmentItem3";
            this.equipmentItem3.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem3.TabIndex = 39;
            this.equipmentItem3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem3.UseVisualStyleBackColor = false;
            this.equipmentItem3.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem2
            // 
            this.equipmentItem2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem2.ForeColor = System.Drawing.Color.White;
            this.equipmentItem2.Location = new System.Drawing.Point(286, 147);
            this.equipmentItem2.Name = "equipmentItem2";
            this.equipmentItem2.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem2.TabIndex = 38;
            this.equipmentItem2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem2.UseVisualStyleBackColor = false;
            this.equipmentItem2.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem1
            // 
            this.equipmentItem1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem1.ForeColor = System.Drawing.Color.White;
            this.equipmentItem1.Location = new System.Drawing.Point(286, 89);
            this.equipmentItem1.Name = "equipmentItem1";
            this.equipmentItem1.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem1.TabIndex = 37;
            this.equipmentItem1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem1.UseVisualStyleBackColor = false;
            this.equipmentItem1.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem0
            // 
            this.equipmentItem0.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem0.ForeColor = System.Drawing.Color.White;
            this.equipmentItem0.Location = new System.Drawing.Point(286, 31);
            this.equipmentItem0.Name = "equipmentItem0";
            this.equipmentItem0.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem0.TabIndex = 36;
            this.equipmentItem0.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem0.UseVisualStyleBackColor = false;
            this.equipmentItem0.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem17
            // 
            this.equipmentItem17.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem17.ForeColor = System.Drawing.Color.White;
            this.equipmentItem17.Location = new System.Drawing.Point(436, 442);
            this.equipmentItem17.Name = "equipmentItem17";
            this.equipmentItem17.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem17.TabIndex = 35;
            this.equipmentItem17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem17.UseVisualStyleBackColor = false;
            this.equipmentItem17.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem16
            // 
            this.equipmentItem16.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem16.ForeColor = System.Drawing.Color.White;
            this.equipmentItem16.Location = new System.Drawing.Point(436, 383);
            this.equipmentItem16.Name = "equipmentItem16";
            this.equipmentItem16.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem16.TabIndex = 34;
            this.equipmentItem16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem16.UseVisualStyleBackColor = false;
            this.equipmentItem16.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem15
            // 
            this.equipmentItem15.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem15.ForeColor = System.Drawing.Color.White;
            this.equipmentItem15.Location = new System.Drawing.Point(436, 325);
            this.equipmentItem15.Name = "equipmentItem15";
            this.equipmentItem15.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem15.TabIndex = 33;
            this.equipmentItem15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem15.UseVisualStyleBackColor = false;
            this.equipmentItem15.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem14
            // 
            this.equipmentItem14.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem14.ForeColor = System.Drawing.Color.White;
            this.equipmentItem14.Location = new System.Drawing.Point(436, 267);
            this.equipmentItem14.Name = "equipmentItem14";
            this.equipmentItem14.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem14.TabIndex = 32;
            this.equipmentItem14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem14.UseVisualStyleBackColor = false;
            this.equipmentItem14.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem13
            // 
            this.equipmentItem13.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem13.ForeColor = System.Drawing.Color.White;
            this.equipmentItem13.Location = new System.Drawing.Point(436, 207);
            this.equipmentItem13.Name = "equipmentItem13";
            this.equipmentItem13.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem13.TabIndex = 31;
            this.equipmentItem13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem13.UseVisualStyleBackColor = false;
            this.equipmentItem13.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem12
            // 
            this.equipmentItem12.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem12.ForeColor = System.Drawing.Color.White;
            this.equipmentItem12.Location = new System.Drawing.Point(212, 147);
            this.equipmentItem12.Name = "equipmentItem12";
            this.equipmentItem12.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem12.TabIndex = 30;
            this.equipmentItem12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem12.UseVisualStyleBackColor = false;
            this.equipmentItem12.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem11
            // 
            this.equipmentItem11.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem11.ForeColor = System.Drawing.Color.White;
            this.equipmentItem11.Location = new System.Drawing.Point(212, 89);
            this.equipmentItem11.Name = "equipmentItem11";
            this.equipmentItem11.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem11.TabIndex = 29;
            this.equipmentItem11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem11.UseVisualStyleBackColor = false;
            this.equipmentItem11.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // equipmentItem10
            // 
            this.equipmentItem10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.equipmentItem10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentItem10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentItem10.ForeColor = System.Drawing.Color.White;
            this.equipmentItem10.Location = new System.Drawing.Point(212, 31);
            this.equipmentItem10.Name = "equipmentItem10";
            this.equipmentItem10.Size = new System.Drawing.Size(52, 52);
            this.equipmentItem10.TabIndex = 28;
            this.equipmentItem10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.equipmentItem10.UseVisualStyleBackColor = false;
            this.equipmentItem10.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.equipmentItem10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // dyeItem2
            // 
            this.dyeItem2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem2.ForeColor = System.Drawing.Color.White;
            this.dyeItem2.Location = new System.Drawing.Point(362, 148);
            this.dyeItem2.Name = "dyeItem2";
            this.dyeItem2.Size = new System.Drawing.Size(52, 52);
            this.dyeItem2.TabIndex = 27;
            this.dyeItem2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem2.UseVisualStyleBackColor = false;
            this.dyeItem2.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // dyeItem1
            // 
            this.dyeItem1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem1.ForeColor = System.Drawing.Color.White;
            this.dyeItem1.Location = new System.Drawing.Point(362, 89);
            this.dyeItem1.Name = "dyeItem1";
            this.dyeItem1.Size = new System.Drawing.Size(52, 52);
            this.dyeItem1.TabIndex = 26;
            this.dyeItem1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem1.UseVisualStyleBackColor = false;
            this.dyeItem1.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // armorLbl
            // 
            this.armorLbl.AutoSize = true;
            this.armorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.armorLbl.Location = new System.Drawing.Point(293, 12);
            this.armorLbl.Name = "armorLbl";
            this.armorLbl.Size = new System.Drawing.Size(39, 13);
            this.armorLbl.TabIndex = 25;
            this.armorLbl.Text = "Armor";
            // 
            // socialsLbl
            // 
            this.socialsLbl.AutoSize = true;
            this.socialsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.socialsLbl.Location = new System.Drawing.Point(216, 12);
            this.socialsLbl.Name = "socialsLbl";
            this.socialsLbl.Size = new System.Drawing.Size(42, 13);
            this.socialsLbl.TabIndex = 24;
            this.socialsLbl.Text = "Social";
            // 
            // dyeLbl
            // 
            this.dyeLbl.AutoSize = true;
            this.dyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeLbl.Location = new System.Drawing.Point(371, 12);
            this.dyeLbl.Name = "dyeLbl";
            this.dyeLbl.Size = new System.Drawing.Size(29, 13);
            this.dyeLbl.TabIndex = 23;
            this.dyeLbl.Text = "Dye";
            // 
            // equipmentFilterGroupBox
            // 
            this.equipmentFilterGroupBox.Controls.Add(this.textBoxEquipName);
            this.equipmentFilterGroupBox.Controls.Add(this.labelSearchForEquip);
            this.equipmentFilterGroupBox.Controls.Add(this.listBoxEquips);
            this.equipmentFilterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equipmentFilterGroupBox.Location = new System.Drawing.Point(8, 8);
            this.equipmentFilterGroupBox.Name = "equipmentFilterGroupBox";
            this.equipmentFilterGroupBox.Size = new System.Drawing.Size(198, 331);
            this.equipmentFilterGroupBox.TabIndex = 21;
            this.equipmentFilterGroupBox.TabStop = false;
            this.equipmentFilterGroupBox.Text = "Item Filtering";
            // 
            // textBoxEquipName
            // 
            this.textBoxEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxEquipName.Location = new System.Drawing.Point(7, 47);
            this.textBoxEquipName.Name = "textBoxEquipName";
            this.textBoxEquipName.Size = new System.Drawing.Size(184, 20);
            this.textBoxEquipName.TabIndex = 56;
            this.textBoxEquipName.TextChanged += new System.EventHandler(this.textBoxEquipName_TextChanged);
            // 
            // labelSearchForEquip
            // 
            this.labelSearchForEquip.AutoSize = true;
            this.labelSearchForEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSearchForEquip.Location = new System.Drawing.Point(3, 23);
            this.labelSearchForEquip.Name = "labelSearchForEquip";
            this.labelSearchForEquip.Size = new System.Drawing.Size(96, 13);
            this.labelSearchForEquip.TabIndex = 55;
            this.labelSearchForEquip.Text = "Search for an item:";
            // 
            // listBoxEquips
            // 
            this.listBoxEquips.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listBoxEquips.FormattingEnabled = true;
            this.listBoxEquips.Location = new System.Drawing.Point(7, 77);
            this.listBoxEquips.Name = "listBoxEquips";
            this.listBoxEquips.Size = new System.Drawing.Size(184, 238);
            this.listBoxEquips.TabIndex = 54;
            this.listBoxEquips.SelectedIndexChanged += new System.EventHandler(this.listBoxEquips_SelectedIndexChanged);
            // 
            // dyeItem0
            // 
            this.dyeItem0.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (90)))),
                ((int) (((byte) (180)))));
            this.dyeItem0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dyeItem0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dyeItem0.ForeColor = System.Drawing.Color.White;
            this.dyeItem0.Location = new System.Drawing.Point(362, 31);
            this.dyeItem0.Name = "dyeItem0";
            this.dyeItem0.Size = new System.Drawing.Size(52, 52);
            this.dyeItem0.TabIndex = 20;
            this.dyeItem0.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dyeItem0.UseVisualStyleBackColor = false;
            this.dyeItem0.Enter += new System.EventHandler(this.equipmentItem_GotFocus);
            this.dyeItem0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.equipmentItem_MouseUp);
            // 
            // buffsTab
            // 
            this.buffsTab.Controls.Add(this.groupBoxBuffControls);
            this.buffsTab.Controls.Add(this.groupBoxActiveBuffs);
            this.buffsTab.Location = new System.Drawing.Point(4, 24);
            this.buffsTab.Name = "buffsTab";
            this.buffsTab.Padding = new System.Windows.Forms.Padding(3);
            this.buffsTab.Size = new System.Drawing.Size(1224, 596);
            this.buffsTab.TabIndex = 2;
            this.buffsTab.Text = "Buffs";
            this.buffsTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxBuffControls
            // 
            this.groupBoxBuffControls.Controls.Add(this.buttonDeleteBuff);
            this.groupBoxBuffControls.Controls.Add(this.textBoxBuffName);
            this.groupBoxBuffControls.Controls.Add(this.buttonMaxAllBuffs);
            this.groupBoxBuffControls.Controls.Add(this.buttonMaxBuff);
            this.groupBoxBuffControls.Controls.Add(this.buttonDeleteAllBuffs);
            this.groupBoxBuffControls.Controls.Add(this.listBoxBuffs);
            this.groupBoxBuffControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBoxBuffControls.Location = new System.Drawing.Point(664, 8);
            this.groupBoxBuffControls.Name = "groupBoxBuffControls";
            this.groupBoxBuffControls.Size = new System.Drawing.Size(222, 468);
            this.groupBoxBuffControls.TabIndex = 1;
            this.groupBoxBuffControls.TabStop = false;
            this.groupBoxBuffControls.Text = "Controls";
            // 
            // buttonDeleteBuff
            // 
            this.buttonDeleteBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonDeleteBuff.Location = new System.Drawing.Point(0, 391);
            this.buttonDeleteBuff.Name = "buttonDeleteBuff";
            this.buttonDeleteBuff.Size = new System.Drawing.Size(93, 27);
            this.buttonDeleteBuff.TabIndex = 6;
            this.buttonDeleteBuff.Text = "Delete";
            this.buttonDeleteBuff.UseVisualStyleBackColor = true;
            this.buttonDeleteBuff.Click += new System.EventHandler(this.buttonDeleteBuff_Click);
            // 
            // textBoxBuffName
            // 
            this.textBoxBuffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxBuffName.Location = new System.Drawing.Point(7, 27);
            this.textBoxBuffName.Name = "textBoxBuffName";
            this.textBoxBuffName.Size = new System.Drawing.Size(207, 20);
            this.textBoxBuffName.TabIndex = 5;
            this.textBoxBuffName.TextChanged += new System.EventHandler(this.textBoxBuffName_TextChanged);
            // 
            // buttonMaxAllBuffs
            // 
            this.buttonMaxAllBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonMaxAllBuffs.Location = new System.Drawing.Point(121, 435);
            this.buttonMaxAllBuffs.Name = "buttonMaxAllBuffs";
            this.buttonMaxAllBuffs.Size = new System.Drawing.Size(93, 27);
            this.buttonMaxAllBuffs.TabIndex = 4;
            this.buttonMaxAllBuffs.Text = "Max All ";
            this.buttonMaxAllBuffs.UseVisualStyleBackColor = true;
            this.buttonMaxAllBuffs.Click += new System.EventHandler(this.buttonMaxAllBuffs_Click);
            // 
            // buttonMaxBuff
            // 
            this.buttonMaxBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonMaxBuff.Location = new System.Drawing.Point(0, 435);
            this.buttonMaxBuff.Name = "buttonMaxBuff";
            this.buttonMaxBuff.Size = new System.Drawing.Size(93, 27);
            this.buttonMaxBuff.TabIndex = 3;
            this.buttonMaxBuff.Text = "Max Duration";
            this.buttonMaxBuff.UseVisualStyleBackColor = true;
            this.buttonMaxBuff.Click += new System.EventHandler(this.buttonMaxBuff_Click);
            // 
            // buttonDeleteAllBuffs
            // 
            this.buttonDeleteAllBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonDeleteAllBuffs.Location = new System.Drawing.Point(121, 391);
            this.buttonDeleteAllBuffs.Name = "buttonDeleteAllBuffs";
            this.buttonDeleteAllBuffs.Size = new System.Drawing.Size(93, 27);
            this.buttonDeleteAllBuffs.TabIndex = 2;
            this.buttonDeleteAllBuffs.Text = "Delete All";
            this.buttonDeleteAllBuffs.UseVisualStyleBackColor = true;
            this.buttonDeleteAllBuffs.Click += new System.EventHandler(this.buttonDeleteAllBuffs_Click);
            // 
            // listBoxBuffs
            // 
            this.listBoxBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listBoxBuffs.FormattingEnabled = true;
            this.listBoxBuffs.Location = new System.Drawing.Point(7, 57);
            this.listBoxBuffs.Name = "listBoxBuffs";
            this.listBoxBuffs.Size = new System.Drawing.Size(207, 316);
            this.listBoxBuffs.TabIndex = 0;
            this.listBoxBuffs.SelectedIndexChanged += new System.EventHandler(this.listBoxBuffs_SelectedIndexChanged);
            // 
            // groupBoxActiveBuffs
            // 
            this.groupBoxActiveBuffs.Controls.Add(this.gridViewBuffs);
            this.groupBoxActiveBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBoxActiveBuffs.Location = new System.Drawing.Point(8, 8);
            this.groupBoxActiveBuffs.Name = "groupBoxActiveBuffs";
            this.groupBoxActiveBuffs.Size = new System.Drawing.Size(649, 468);
            this.groupBoxActiveBuffs.TabIndex = 0;
            this.groupBoxActiveBuffs.TabStop = false;
            this.groupBoxActiveBuffs.Text = "Active Buffs";
            // 
            // gridViewBuffs
            // 
            this.gridViewBuffs.AllowUserToAddRows = false;
            this.gridViewBuffs.AllowUserToDeleteRows = false;
            this.gridViewBuffs.AutoGenerateColumns = false;
            this.gridViewBuffs.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBuffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.Image, this.nameDataGridViewTextBoxColumn, this.descriptionDataGridViewTextBoxColumn,
                this.timeDataGridViewTextBoxColumn
            });
            this.gridViewBuffs.DataSource = this.buffsBindingSource;
            this.gridViewBuffs.Location = new System.Drawing.Point(8, 23);
            this.gridViewBuffs.Name = "gridViewBuffs";
            this.gridViewBuffs.ReadOnly = true;
            this.gridViewBuffs.RowHeadersVisible = false;
            this.gridViewBuffs.RowTemplate.Height = 30;
            this.gridViewBuffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewBuffs.Size = new System.Drawing.Size(626, 428);
            this.gridViewBuffs.TabIndex = 0;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 33;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // buffsBindingSource
            // 
            this.buffsBindingSource.DataMember = "Buffs";
            this.buffsBindingSource.DataSource = this.playerBindingSource;
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.ammoLbl);
            this.inventoryTab.Controls.Add(this.coinsLbl);
            this.inventoryTab.Controls.Add(this.inventoryItem57);
            this.inventoryTab.Controls.Add(this.inventoryItem56);
            this.inventoryTab.Controls.Add(this.inventoryItem55);
            this.inventoryTab.Controls.Add(this.inventoryItem54);
            this.inventoryTab.Controls.Add(this.inventoryItem53);
            this.inventoryTab.Controls.Add(this.inventoryItem52);
            this.inventoryTab.Controls.Add(this.inventoryItem51);
            this.inventoryTab.Controls.Add(this.inventoryItem50);
            this.inventoryTab.Controls.Add(this.groupBoxItemProperties);
            this.inventoryTab.Controls.Add(this.inventoryFilterGroupBox);
            this.inventoryTab.Controls.Add(this.inventoryItem49);
            this.inventoryTab.Controls.Add(this.inventoryItem48);
            this.inventoryTab.Controls.Add(this.inventoryItem47);
            this.inventoryTab.Controls.Add(this.inventoryItem46);
            this.inventoryTab.Controls.Add(this.inventoryItem45);
            this.inventoryTab.Controls.Add(this.inventoryItem44);
            this.inventoryTab.Controls.Add(this.inventoryItem43);
            this.inventoryTab.Controls.Add(this.inventoryItem42);
            this.inventoryTab.Controls.Add(this.inventoryItem41);
            this.inventoryTab.Controls.Add(this.inventoryItem40);
            this.inventoryTab.Controls.Add(this.inventoryItem39);
            this.inventoryTab.Controls.Add(this.inventoryItem38);
            this.inventoryTab.Controls.Add(this.inventoryItem37);
            this.inventoryTab.Controls.Add(this.inventoryItem36);
            this.inventoryTab.Controls.Add(this.inventoryItem35);
            this.inventoryTab.Controls.Add(this.inventoryItem34);
            this.inventoryTab.Controls.Add(this.inventoryItem33);
            this.inventoryTab.Controls.Add(this.inventoryItem32);
            this.inventoryTab.Controls.Add(this.inventoryItem31);
            this.inventoryTab.Controls.Add(this.inventoryItem30);
            this.inventoryTab.Controls.Add(this.inventoryItem29);
            this.inventoryTab.Controls.Add(this.inventoryItem28);
            this.inventoryTab.Controls.Add(this.inventoryItem27);
            this.inventoryTab.Controls.Add(this.inventoryItem26);
            this.inventoryTab.Controls.Add(this.inventoryItem25);
            this.inventoryTab.Controls.Add(this.inventoryItem24);
            this.inventoryTab.Controls.Add(this.inventoryItem23);
            this.inventoryTab.Controls.Add(this.inventoryItem22);
            this.inventoryTab.Controls.Add(this.inventoryItem21);
            this.inventoryTab.Controls.Add(this.inventoryItem20);
            this.inventoryTab.Controls.Add(this.inventoryItem19);
            this.inventoryTab.Controls.Add(this.inventoryItem18);
            this.inventoryTab.Controls.Add(this.inventoryItem17);
            this.inventoryTab.Controls.Add(this.inventoryItem16);
            this.inventoryTab.Controls.Add(this.inventoryItem15);
            this.inventoryTab.Controls.Add(this.inventoryItem14);
            this.inventoryTab.Controls.Add(this.inventoryItem13);
            this.inventoryTab.Controls.Add(this.inventoryItem12);
            this.inventoryTab.Controls.Add(this.inventoryItem11);
            this.inventoryTab.Controls.Add(this.inventoryItem10);
            this.inventoryTab.Controls.Add(this.inventoryItem9);
            this.inventoryTab.Controls.Add(this.inventoryItem8);
            this.inventoryTab.Controls.Add(this.inventoryItem7);
            this.inventoryTab.Controls.Add(this.inventoryItem6);
            this.inventoryTab.Controls.Add(this.inventoryItem5);
            this.inventoryTab.Controls.Add(this.inventoryItem4);
            this.inventoryTab.Controls.Add(this.inventoryItem3);
            this.inventoryTab.Controls.Add(this.inventoryItem2);
            this.inventoryTab.Controls.Add(this.inventoryItem1);
            this.inventoryTab.Controls.Add(this.inventoryItem0);
            this.inventoryTab.Location = new System.Drawing.Point(4, 24);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryTab.Size = new System.Drawing.Size(1224, 596);
            this.inventoryTab.TabIndex = 3;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // ammoLbl
            // 
            this.ammoLbl.AutoSize = true;
            this.ammoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ammoLbl.Location = new System.Drawing.Point(925, 60);
            this.ammoLbl.Name = "ammoLbl";
            this.ammoLbl.Size = new System.Drawing.Size(40, 13);
            this.ammoLbl.TabIndex = 62;
            this.ammoLbl.Text = "Ammo";
            // 
            // coinsLbl
            // 
            this.coinsLbl.AutoSize = true;
            this.coinsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.coinsLbl.Location = new System.Drawing.Point(871, 60);
            this.coinsLbl.Name = "coinsLbl";
            this.coinsLbl.Size = new System.Drawing.Size(38, 13);
            this.coinsLbl.TabIndex = 61;
            this.coinsLbl.Text = "Coins";
            // 
            // inventoryItem57
            // 
            this.inventoryItem57.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem57.ForeColor = System.Drawing.Color.White;
            this.inventoryItem57.Location = new System.Drawing.Point(925, 238);
            this.inventoryItem57.Name = "inventoryItem57";
            this.inventoryItem57.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem57.TabIndex = 60;
            this.inventoryItem57.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem57.UseVisualStyleBackColor = false;
            this.inventoryItem57.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem56
            // 
            this.inventoryItem56.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem56.ForeColor = System.Drawing.Color.White;
            this.inventoryItem56.Location = new System.Drawing.Point(925, 185);
            this.inventoryItem56.Name = "inventoryItem56";
            this.inventoryItem56.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem56.TabIndex = 59;
            this.inventoryItem56.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem56.UseVisualStyleBackColor = false;
            this.inventoryItem56.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem55
            // 
            this.inventoryItem55.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem55.ForeColor = System.Drawing.Color.White;
            this.inventoryItem55.Location = new System.Drawing.Point(925, 132);
            this.inventoryItem55.Name = "inventoryItem55";
            this.inventoryItem55.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem55.TabIndex = 58;
            this.inventoryItem55.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem55.UseVisualStyleBackColor = false;
            this.inventoryItem55.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem54
            // 
            this.inventoryItem54.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem54.ForeColor = System.Drawing.Color.White;
            this.inventoryItem54.Location = new System.Drawing.Point(925, 78);
            this.inventoryItem54.Name = "inventoryItem54";
            this.inventoryItem54.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem54.TabIndex = 57;
            this.inventoryItem54.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem54.UseVisualStyleBackColor = false;
            this.inventoryItem54.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem53
            // 
            this.inventoryItem53.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem53.ForeColor = System.Drawing.Color.White;
            this.inventoryItem53.Location = new System.Drawing.Point(871, 238);
            this.inventoryItem53.Name = "inventoryItem53";
            this.inventoryItem53.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem53.TabIndex = 56;
            this.inventoryItem53.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem53.UseVisualStyleBackColor = false;
            this.inventoryItem53.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem52
            // 
            this.inventoryItem52.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem52.ForeColor = System.Drawing.Color.White;
            this.inventoryItem52.Location = new System.Drawing.Point(871, 185);
            this.inventoryItem52.Name = "inventoryItem52";
            this.inventoryItem52.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem52.TabIndex = 55;
            this.inventoryItem52.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem52.UseVisualStyleBackColor = false;
            this.inventoryItem52.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem51
            // 
            this.inventoryItem51.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem51.ForeColor = System.Drawing.Color.White;
            this.inventoryItem51.Location = new System.Drawing.Point(871, 132);
            this.inventoryItem51.Name = "inventoryItem51";
            this.inventoryItem51.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem51.TabIndex = 54;
            this.inventoryItem51.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem51.UseVisualStyleBackColor = false;
            this.inventoryItem51.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem50
            // 
            this.inventoryItem50.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem50.ForeColor = System.Drawing.Color.White;
            this.inventoryItem50.Location = new System.Drawing.Point(871, 78);
            this.inventoryItem50.Name = "inventoryItem50";
            this.inventoryItem50.Size = new System.Drawing.Size(47, 46);
            this.inventoryItem50.TabIndex = 53;
            this.inventoryItem50.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem50.UseVisualStyleBackColor = false;
            this.inventoryItem50.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // groupBoxItemProperties
            // 
            this.groupBoxItemProperties.Controls.Add(this.buttonDeleteAllItems);
            this.groupBoxItemProperties.Controls.Add(this.buttonDeleteItem);
            this.groupBoxItemProperties.Controls.Add(this.buttonMaxAllStacks);
            this.groupBoxItemProperties.Controls.Add(this.buttonMaxStack);
            this.groupBoxItemProperties.Controls.Add(this.upDownStackSize);
            this.groupBoxItemProperties.Controls.Add(this.stackSizeLbl);
            this.groupBoxItemProperties.Controls.Add(this.comboBoxItemPrefix);
            this.groupBoxItemProperties.Controls.Add(this.itemPrefixLbl);
            this.groupBoxItemProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBoxItemProperties.Location = new System.Drawing.Point(253, 314);
            this.groupBoxItemProperties.Name = "groupBoxItemProperties";
            this.groupBoxItemProperties.Size = new System.Drawing.Size(611, 181);
            this.groupBoxItemProperties.TabIndex = 52;
            this.groupBoxItemProperties.TabStop = false;
            this.groupBoxItemProperties.Text = "Properties";
            // 
            // buttonDeleteAllItems
            // 
            this.buttonDeleteAllItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonDeleteAllItems.Location = new System.Drawing.Point(496, 54);
            this.buttonDeleteAllItems.Name = "buttonDeleteAllItems";
            this.buttonDeleteAllItems.Size = new System.Drawing.Size(108, 27);
            this.buttonDeleteAllItems.TabIndex = 7;
            this.buttonDeleteAllItems.Text = "Delete All Items";
            this.buttonDeleteAllItems.UseVisualStyleBackColor = true;
            this.buttonDeleteAllItems.Click += new System.EventHandler(this.buttonDeleteAllItems_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(400, 55);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(87, 27);
            this.buttonDeleteItem.TabIndex = 6;
            this.buttonDeleteItem.Text = "Delete";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonMaxAllStacks
            // 
            this.buttonMaxAllStacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonMaxAllStacks.Location = new System.Drawing.Point(495, 20);
            this.buttonMaxAllStacks.Name = "buttonMaxAllStacks";
            this.buttonMaxAllStacks.Size = new System.Drawing.Size(110, 27);
            this.buttonMaxAllStacks.TabIndex = 5;
            this.buttonMaxAllStacks.Text = "Max All Stacks";
            this.buttonMaxAllStacks.UseVisualStyleBackColor = true;
            this.buttonMaxAllStacks.Click += new System.EventHandler(this.buttonMaxAllStacks_Click);
            // 
            // buttonMaxStack
            // 
            this.buttonMaxStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonMaxStack.Location = new System.Drawing.Point(400, 20);
            this.buttonMaxStack.Name = "buttonMaxStack";
            this.buttonMaxStack.Size = new System.Drawing.Size(87, 27);
            this.buttonMaxStack.TabIndex = 4;
            this.buttonMaxStack.Text = "Max Stack";
            this.buttonMaxStack.UseVisualStyleBackColor = true;
            this.buttonMaxStack.Click += new System.EventHandler(this.buttonMaxStack_Click);
            // 
            // upDownStackSize
            // 
            this.upDownStackSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.upDownStackSize.Location = new System.Drawing.Point(114, 55);
            this.upDownStackSize.Maximum = new decimal(new int[] {999, 0, 0, 0});
            this.upDownStackSize.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.upDownStackSize.Name = "upDownStackSize";
            this.upDownStackSize.Size = new System.Drawing.Size(141, 20);
            this.upDownStackSize.TabIndex = 3;
            this.upDownStackSize.Value = new decimal(new int[] {1, 0, 0, 0});
            this.upDownStackSize.ValueChanged += new System.EventHandler(this.upDownStackSize_ValueChanged);
            // 
            // stackSizeLbl
            // 
            this.stackSizeLbl.AutoSize = true;
            this.stackSizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.stackSizeLbl.Location = new System.Drawing.Point(8, 55);
            this.stackSizeLbl.Name = "stackSizeLbl";
            this.stackSizeLbl.Size = new System.Drawing.Size(85, 16);
            this.stackSizeLbl.TabIndex = 2;
            this.stackSizeLbl.Text = "Stack Size:";
            // 
            // comboBoxItemPrefix
            // 
            this.comboBoxItemPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBoxItemPrefix.FormattingEnabled = true;
            this.comboBoxItemPrefix.Location = new System.Drawing.Point(114, 23);
            this.comboBoxItemPrefix.Name = "comboBoxItemPrefix";
            this.comboBoxItemPrefix.Size = new System.Drawing.Size(140, 21);
            this.comboBoxItemPrefix.TabIndex = 1;
            this.comboBoxItemPrefix.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxItemPrefix_SelectedIndexChanged);
            // 
            // itemPrefixLbl
            // 
            this.itemPrefixLbl.AutoSize = true;
            this.itemPrefixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.itemPrefixLbl.Location = new System.Drawing.Point(8, 23);
            this.itemPrefixLbl.Name = "itemPrefixLbl";
            this.itemPrefixLbl.Size = new System.Drawing.Size(84, 16);
            this.itemPrefixLbl.TabIndex = 0;
            this.itemPrefixLbl.Text = "Item Prefix:";
            // 
            // inventoryFilterGroupBox
            // 
            this.inventoryFilterGroupBox.Controls.Add(this.itemFilterInventory);
            this.inventoryFilterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryFilterGroupBox.Location = new System.Drawing.Point(8, 12);
            this.inventoryFilterGroupBox.Name = "inventoryFilterGroupBox";
            this.inventoryFilterGroupBox.Size = new System.Drawing.Size(238, 483);
            this.inventoryFilterGroupBox.TabIndex = 51;
            this.inventoryFilterGroupBox.TabStop = false;
            this.inventoryFilterGroupBox.Text = "Item Filtering";
            // 
            // itemFilterInventory
            // 
            this.itemFilterInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.itemFilterInventory.Location = new System.Drawing.Point(8, 23);
            this.itemFilterInventory.Name = "itemFilterInventory";
            this.itemFilterInventory.Size = new System.Drawing.Size(225, 435);
            this.itemFilterInventory.TabIndex = 0;
            // 
            // inventoryItem49
            // 
            this.inventoryItem49.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem49.ForeColor = System.Drawing.Color.White;
            this.inventoryItem49.Location = new System.Drawing.Point(810, 253);
            this.inventoryItem49.Name = "inventoryItem49";
            this.inventoryItem49.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem49.TabIndex = 49;
            this.inventoryItem49.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem49.UseVisualStyleBackColor = false;
            this.inventoryItem49.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem48
            // 
            this.inventoryItem48.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem48.ForeColor = System.Drawing.Color.White;
            this.inventoryItem48.Location = new System.Drawing.Point(748, 254);
            this.inventoryItem48.Name = "inventoryItem48";
            this.inventoryItem48.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem48.TabIndex = 48;
            this.inventoryItem48.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem48.UseVisualStyleBackColor = false;
            this.inventoryItem48.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem47
            // 
            this.inventoryItem47.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem47.ForeColor = System.Drawing.Color.White;
            this.inventoryItem47.Location = new System.Drawing.Point(686, 254);
            this.inventoryItem47.Name = "inventoryItem47";
            this.inventoryItem47.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem47.TabIndex = 47;
            this.inventoryItem47.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem47.UseVisualStyleBackColor = false;
            this.inventoryItem47.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem46
            // 
            this.inventoryItem46.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem46.ForeColor = System.Drawing.Color.White;
            this.inventoryItem46.Location = new System.Drawing.Point(624, 254);
            this.inventoryItem46.Name = "inventoryItem46";
            this.inventoryItem46.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem46.TabIndex = 46;
            this.inventoryItem46.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem46.UseVisualStyleBackColor = false;
            this.inventoryItem46.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem45
            // 
            this.inventoryItem45.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem45.ForeColor = System.Drawing.Color.White;
            this.inventoryItem45.Location = new System.Drawing.Point(562, 254);
            this.inventoryItem45.Name = "inventoryItem45";
            this.inventoryItem45.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem45.TabIndex = 45;
            this.inventoryItem45.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem45.UseVisualStyleBackColor = false;
            this.inventoryItem45.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem44
            // 
            this.inventoryItem44.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem44.ForeColor = System.Drawing.Color.White;
            this.inventoryItem44.Location = new System.Drawing.Point(500, 254);
            this.inventoryItem44.Name = "inventoryItem44";
            this.inventoryItem44.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem44.TabIndex = 44;
            this.inventoryItem44.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem44.UseVisualStyleBackColor = false;
            this.inventoryItem44.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem43
            // 
            this.inventoryItem43.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem43.ForeColor = System.Drawing.Color.White;
            this.inventoryItem43.Location = new System.Drawing.Point(439, 254);
            this.inventoryItem43.Name = "inventoryItem43";
            this.inventoryItem43.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem43.TabIndex = 43;
            this.inventoryItem43.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem43.UseVisualStyleBackColor = false;
            this.inventoryItem43.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem42
            // 
            this.inventoryItem42.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem42.ForeColor = System.Drawing.Color.White;
            this.inventoryItem42.Location = new System.Drawing.Point(377, 254);
            this.inventoryItem42.Name = "inventoryItem42";
            this.inventoryItem42.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem42.TabIndex = 42;
            this.inventoryItem42.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem42.UseVisualStyleBackColor = false;
            this.inventoryItem42.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem41
            // 
            this.inventoryItem41.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem41.ForeColor = System.Drawing.Color.White;
            this.inventoryItem41.Location = new System.Drawing.Point(315, 254);
            this.inventoryItem41.Name = "inventoryItem41";
            this.inventoryItem41.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem41.TabIndex = 41;
            this.inventoryItem41.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem41.UseVisualStyleBackColor = false;
            this.inventoryItem41.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem40
            // 
            this.inventoryItem40.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem40.ForeColor = System.Drawing.Color.White;
            this.inventoryItem40.Location = new System.Drawing.Point(253, 254);
            this.inventoryItem40.Name = "inventoryItem40";
            this.inventoryItem40.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem40.TabIndex = 40;
            this.inventoryItem40.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem40.UseVisualStyleBackColor = false;
            this.inventoryItem40.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem39
            // 
            this.inventoryItem39.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem39.ForeColor = System.Drawing.Color.White;
            this.inventoryItem39.Location = new System.Drawing.Point(810, 192);
            this.inventoryItem39.Name = "inventoryItem39";
            this.inventoryItem39.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem39.TabIndex = 39;
            this.inventoryItem39.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem39.UseVisualStyleBackColor = false;
            this.inventoryItem39.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem38
            // 
            this.inventoryItem38.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem38.ForeColor = System.Drawing.Color.White;
            this.inventoryItem38.Location = new System.Drawing.Point(748, 193);
            this.inventoryItem38.Name = "inventoryItem38";
            this.inventoryItem38.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem38.TabIndex = 38;
            this.inventoryItem38.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem38.UseVisualStyleBackColor = false;
            this.inventoryItem38.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem37
            // 
            this.inventoryItem37.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem37.ForeColor = System.Drawing.Color.White;
            this.inventoryItem37.Location = new System.Drawing.Point(686, 193);
            this.inventoryItem37.Name = "inventoryItem37";
            this.inventoryItem37.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem37.TabIndex = 37;
            this.inventoryItem37.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem37.UseVisualStyleBackColor = false;
            this.inventoryItem37.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem36
            // 
            this.inventoryItem36.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem36.ForeColor = System.Drawing.Color.White;
            this.inventoryItem36.Location = new System.Drawing.Point(624, 193);
            this.inventoryItem36.Name = "inventoryItem36";
            this.inventoryItem36.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem36.TabIndex = 36;
            this.inventoryItem36.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem36.UseVisualStyleBackColor = false;
            this.inventoryItem36.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem35
            // 
            this.inventoryItem35.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem35.ForeColor = System.Drawing.Color.White;
            this.inventoryItem35.Location = new System.Drawing.Point(562, 193);
            this.inventoryItem35.Name = "inventoryItem35";
            this.inventoryItem35.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem35.TabIndex = 35;
            this.inventoryItem35.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem35.UseVisualStyleBackColor = false;
            this.inventoryItem35.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem34
            // 
            this.inventoryItem34.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem34.ForeColor = System.Drawing.Color.White;
            this.inventoryItem34.Location = new System.Drawing.Point(500, 193);
            this.inventoryItem34.Name = "inventoryItem34";
            this.inventoryItem34.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem34.TabIndex = 34;
            this.inventoryItem34.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem34.UseVisualStyleBackColor = false;
            this.inventoryItem34.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem33
            // 
            this.inventoryItem33.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem33.ForeColor = System.Drawing.Color.White;
            this.inventoryItem33.Location = new System.Drawing.Point(439, 193);
            this.inventoryItem33.Name = "inventoryItem33";
            this.inventoryItem33.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem33.TabIndex = 33;
            this.inventoryItem33.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem33.UseVisualStyleBackColor = false;
            this.inventoryItem33.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem32
            // 
            this.inventoryItem32.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem32.ForeColor = System.Drawing.Color.White;
            this.inventoryItem32.Location = new System.Drawing.Point(377, 193);
            this.inventoryItem32.Name = "inventoryItem32";
            this.inventoryItem32.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem32.TabIndex = 32;
            this.inventoryItem32.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem32.UseVisualStyleBackColor = false;
            this.inventoryItem32.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem31
            // 
            this.inventoryItem31.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem31.ForeColor = System.Drawing.Color.White;
            this.inventoryItem31.Location = new System.Drawing.Point(315, 193);
            this.inventoryItem31.Name = "inventoryItem31";
            this.inventoryItem31.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem31.TabIndex = 31;
            this.inventoryItem31.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem31.UseVisualStyleBackColor = false;
            this.inventoryItem31.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem30
            // 
            this.inventoryItem30.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem30.ForeColor = System.Drawing.Color.White;
            this.inventoryItem30.Location = new System.Drawing.Point(253, 193);
            this.inventoryItem30.Name = "inventoryItem30";
            this.inventoryItem30.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem30.TabIndex = 30;
            this.inventoryItem30.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem30.UseVisualStyleBackColor = false;
            this.inventoryItem30.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem29
            // 
            this.inventoryItem29.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem29.ForeColor = System.Drawing.Color.White;
            this.inventoryItem29.Location = new System.Drawing.Point(810, 130);
            this.inventoryItem29.Name = "inventoryItem29";
            this.inventoryItem29.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem29.TabIndex = 29;
            this.inventoryItem29.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem29.UseVisualStyleBackColor = false;
            this.inventoryItem29.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem28
            // 
            this.inventoryItem28.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem28.ForeColor = System.Drawing.Color.White;
            this.inventoryItem28.Location = new System.Drawing.Point(748, 132);
            this.inventoryItem28.Name = "inventoryItem28";
            this.inventoryItem28.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem28.TabIndex = 28;
            this.inventoryItem28.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem28.UseVisualStyleBackColor = false;
            this.inventoryItem28.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem27
            // 
            this.inventoryItem27.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem27.ForeColor = System.Drawing.Color.White;
            this.inventoryItem27.Location = new System.Drawing.Point(686, 132);
            this.inventoryItem27.Name = "inventoryItem27";
            this.inventoryItem27.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem27.TabIndex = 27;
            this.inventoryItem27.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem27.UseVisualStyleBackColor = false;
            this.inventoryItem27.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem26
            // 
            this.inventoryItem26.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem26.ForeColor = System.Drawing.Color.White;
            this.inventoryItem26.Location = new System.Drawing.Point(624, 132);
            this.inventoryItem26.Name = "inventoryItem26";
            this.inventoryItem26.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem26.TabIndex = 26;
            this.inventoryItem26.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem26.UseVisualStyleBackColor = false;
            this.inventoryItem26.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem25
            // 
            this.inventoryItem25.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem25.ForeColor = System.Drawing.Color.White;
            this.inventoryItem25.Location = new System.Drawing.Point(562, 132);
            this.inventoryItem25.Name = "inventoryItem25";
            this.inventoryItem25.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem25.TabIndex = 25;
            this.inventoryItem25.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem25.UseVisualStyleBackColor = false;
            this.inventoryItem25.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem24
            // 
            this.inventoryItem24.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem24.ForeColor = System.Drawing.Color.White;
            this.inventoryItem24.Location = new System.Drawing.Point(500, 132);
            this.inventoryItem24.Name = "inventoryItem24";
            this.inventoryItem24.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem24.TabIndex = 24;
            this.inventoryItem24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem24.UseVisualStyleBackColor = false;
            this.inventoryItem24.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem23
            // 
            this.inventoryItem23.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem23.ForeColor = System.Drawing.Color.White;
            this.inventoryItem23.Location = new System.Drawing.Point(439, 132);
            this.inventoryItem23.Name = "inventoryItem23";
            this.inventoryItem23.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem23.TabIndex = 23;
            this.inventoryItem23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem23.UseVisualStyleBackColor = false;
            this.inventoryItem23.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem22
            // 
            this.inventoryItem22.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem22.ForeColor = System.Drawing.Color.White;
            this.inventoryItem22.Location = new System.Drawing.Point(377, 132);
            this.inventoryItem22.Name = "inventoryItem22";
            this.inventoryItem22.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem22.TabIndex = 22;
            this.inventoryItem22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem22.UseVisualStyleBackColor = false;
            this.inventoryItem22.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem21
            // 
            this.inventoryItem21.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem21.ForeColor = System.Drawing.Color.White;
            this.inventoryItem21.Location = new System.Drawing.Point(315, 132);
            this.inventoryItem21.Name = "inventoryItem21";
            this.inventoryItem21.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem21.TabIndex = 21;
            this.inventoryItem21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem21.UseVisualStyleBackColor = false;
            this.inventoryItem21.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem20
            // 
            this.inventoryItem20.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem20.ForeColor = System.Drawing.Color.White;
            this.inventoryItem20.Location = new System.Drawing.Point(253, 132);
            this.inventoryItem20.Name = "inventoryItem20";
            this.inventoryItem20.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem20.TabIndex = 20;
            this.inventoryItem20.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem20.UseVisualStyleBackColor = false;
            this.inventoryItem20.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem19
            // 
            this.inventoryItem19.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem19.ForeColor = System.Drawing.Color.White;
            this.inventoryItem19.Location = new System.Drawing.Point(810, 69);
            this.inventoryItem19.Name = "inventoryItem19";
            this.inventoryItem19.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem19.TabIndex = 19;
            this.inventoryItem19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem19.UseVisualStyleBackColor = false;
            this.inventoryItem19.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem18
            // 
            this.inventoryItem18.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem18.ForeColor = System.Drawing.Color.White;
            this.inventoryItem18.Location = new System.Drawing.Point(748, 70);
            this.inventoryItem18.Name = "inventoryItem18";
            this.inventoryItem18.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem18.TabIndex = 18;
            this.inventoryItem18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem18.UseVisualStyleBackColor = false;
            this.inventoryItem18.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem17
            // 
            this.inventoryItem17.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem17.ForeColor = System.Drawing.Color.White;
            this.inventoryItem17.Location = new System.Drawing.Point(686, 70);
            this.inventoryItem17.Name = "inventoryItem17";
            this.inventoryItem17.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem17.TabIndex = 17;
            this.inventoryItem17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem17.UseVisualStyleBackColor = false;
            this.inventoryItem17.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem16
            // 
            this.inventoryItem16.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem16.ForeColor = System.Drawing.Color.White;
            this.inventoryItem16.Location = new System.Drawing.Point(624, 70);
            this.inventoryItem16.Name = "inventoryItem16";
            this.inventoryItem16.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem16.TabIndex = 16;
            this.inventoryItem16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem16.UseVisualStyleBackColor = false;
            this.inventoryItem16.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem15
            // 
            this.inventoryItem15.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem15.ForeColor = System.Drawing.Color.White;
            this.inventoryItem15.Location = new System.Drawing.Point(562, 70);
            this.inventoryItem15.Name = "inventoryItem15";
            this.inventoryItem15.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem15.TabIndex = 15;
            this.inventoryItem15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem15.UseVisualStyleBackColor = false;
            this.inventoryItem15.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem14
            // 
            this.inventoryItem14.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem14.ForeColor = System.Drawing.Color.White;
            this.inventoryItem14.Location = new System.Drawing.Point(500, 70);
            this.inventoryItem14.Name = "inventoryItem14";
            this.inventoryItem14.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem14.TabIndex = 14;
            this.inventoryItem14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem14.UseVisualStyleBackColor = false;
            this.inventoryItem14.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem13
            // 
            this.inventoryItem13.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem13.ForeColor = System.Drawing.Color.White;
            this.inventoryItem13.Location = new System.Drawing.Point(439, 70);
            this.inventoryItem13.Name = "inventoryItem13";
            this.inventoryItem13.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem13.TabIndex = 13;
            this.inventoryItem13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem13.UseVisualStyleBackColor = false;
            this.inventoryItem13.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem12
            // 
            this.inventoryItem12.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem12.ForeColor = System.Drawing.Color.White;
            this.inventoryItem12.Location = new System.Drawing.Point(377, 70);
            this.inventoryItem12.Name = "inventoryItem12";
            this.inventoryItem12.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem12.TabIndex = 12;
            this.inventoryItem12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem12.UseVisualStyleBackColor = false;
            this.inventoryItem12.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem11
            // 
            this.inventoryItem11.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem11.ForeColor = System.Drawing.Color.White;
            this.inventoryItem11.Location = new System.Drawing.Point(315, 70);
            this.inventoryItem11.Name = "inventoryItem11";
            this.inventoryItem11.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem11.TabIndex = 11;
            this.inventoryItem11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem11.UseVisualStyleBackColor = false;
            this.inventoryItem11.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem10
            // 
            this.inventoryItem10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem10.ForeColor = System.Drawing.Color.White;
            this.inventoryItem10.Location = new System.Drawing.Point(253, 70);
            this.inventoryItem10.Name = "inventoryItem10";
            this.inventoryItem10.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem10.TabIndex = 10;
            this.inventoryItem10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem10.UseVisualStyleBackColor = false;
            this.inventoryItem10.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem9
            // 
            this.inventoryItem9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem9.ForeColor = System.Drawing.Color.White;
            this.inventoryItem9.Location = new System.Drawing.Point(810, 8);
            this.inventoryItem9.Name = "inventoryItem9";
            this.inventoryItem9.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem9.TabIndex = 9;
            this.inventoryItem9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem9.UseVisualStyleBackColor = false;
            this.inventoryItem9.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem8
            // 
            this.inventoryItem8.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem8.ForeColor = System.Drawing.Color.White;
            this.inventoryItem8.Location = new System.Drawing.Point(748, 9);
            this.inventoryItem8.Name = "inventoryItem8";
            this.inventoryItem8.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem8.TabIndex = 8;
            this.inventoryItem8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem8.UseVisualStyleBackColor = false;
            this.inventoryItem8.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem7
            // 
            this.inventoryItem7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem7.ForeColor = System.Drawing.Color.White;
            this.inventoryItem7.Location = new System.Drawing.Point(686, 9);
            this.inventoryItem7.Name = "inventoryItem7";
            this.inventoryItem7.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem7.TabIndex = 7;
            this.inventoryItem7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem7.UseVisualStyleBackColor = false;
            this.inventoryItem7.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem6
            // 
            this.inventoryItem6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem6.ForeColor = System.Drawing.Color.White;
            this.inventoryItem6.Location = new System.Drawing.Point(624, 9);
            this.inventoryItem6.Name = "inventoryItem6";
            this.inventoryItem6.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem6.TabIndex = 6;
            this.inventoryItem6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem6.UseVisualStyleBackColor = false;
            this.inventoryItem6.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem5
            // 
            this.inventoryItem5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem5.ForeColor = System.Drawing.Color.White;
            this.inventoryItem5.Location = new System.Drawing.Point(562, 9);
            this.inventoryItem5.Name = "inventoryItem5";
            this.inventoryItem5.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem5.TabIndex = 5;
            this.inventoryItem5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem5.UseVisualStyleBackColor = false;
            this.inventoryItem5.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem4
            // 
            this.inventoryItem4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem4.ForeColor = System.Drawing.Color.White;
            this.inventoryItem4.Location = new System.Drawing.Point(500, 9);
            this.inventoryItem4.Name = "inventoryItem4";
            this.inventoryItem4.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem4.TabIndex = 4;
            this.inventoryItem4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem4.UseVisualStyleBackColor = false;
            this.inventoryItem4.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem3
            // 
            this.inventoryItem3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem3.ForeColor = System.Drawing.Color.White;
            this.inventoryItem3.Location = new System.Drawing.Point(439, 9);
            this.inventoryItem3.Name = "inventoryItem3";
            this.inventoryItem3.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem3.TabIndex = 3;
            this.inventoryItem3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem3.UseVisualStyleBackColor = false;
            this.inventoryItem3.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem2
            // 
            this.inventoryItem2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem2.ForeColor = System.Drawing.Color.White;
            this.inventoryItem2.Location = new System.Drawing.Point(377, 9);
            this.inventoryItem2.Name = "inventoryItem2";
            this.inventoryItem2.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem2.TabIndex = 2;
            this.inventoryItem2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem2.UseVisualStyleBackColor = false;
            this.inventoryItem2.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem1
            // 
            this.inventoryItem1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem1.ForeColor = System.Drawing.Color.White;
            this.inventoryItem1.Location = new System.Drawing.Point(315, 9);
            this.inventoryItem1.Name = "inventoryItem1";
            this.inventoryItem1.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem1.TabIndex = 1;
            this.inventoryItem1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem1.UseVisualStyleBackColor = false;
            this.inventoryItem1.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // inventoryItem0
            // 
            this.inventoryItem0.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.inventoryItem0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryItem0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inventoryItem0.ForeColor = System.Drawing.Color.White;
            this.inventoryItem0.Location = new System.Drawing.Point(253, 12);
            this.inventoryItem0.Name = "inventoryItem0";
            this.inventoryItem0.Size = new System.Drawing.Size(55, 54);
            this.inventoryItem0.TabIndex = 0;
            this.inventoryItem0.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inventoryItem0.UseVisualStyleBackColor = false;
            this.inventoryItem0.Enter += new System.EventHandler(this.inventoryItem_GotFocus);
            // 
            // tabPageStorage
            // 
            this.tabPageStorage.Controls.Add(this.buttonDeleteAllStorageItems);
            this.tabPageStorage.Controls.Add(this.buttonDeleteStorageItem);
            this.tabPageStorage.Controls.Add(this.groupBoxForge);
            this.tabPageStorage.Controls.Add(this.groupBoxSafe);
            this.tabPageStorage.Controls.Add(this.groupBoxPiggyItems);
            this.tabPageStorage.Controls.Add(this.itemFilterStorage);
            this.tabPageStorage.Location = new System.Drawing.Point(4, 24);
            this.tabPageStorage.Name = "tabPageStorage";
            this.tabPageStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStorage.Size = new System.Drawing.Size(1224, 596);
            this.tabPageStorage.TabIndex = 4;
            this.tabPageStorage.Text = "Storage";
            this.tabPageStorage.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAllStorageItems
            // 
            this.buttonDeleteAllStorageItems.Location = new System.Drawing.Point(127, 546);
            this.buttonDeleteAllStorageItems.Name = "buttonDeleteAllStorageItems";
            this.buttonDeleteAllStorageItems.Size = new System.Drawing.Size(105, 27);
            this.buttonDeleteAllStorageItems.TabIndex = 54;
            this.buttonDeleteAllStorageItems.Text = "Delete All Items";
            this.buttonDeleteAllStorageItems.UseVisualStyleBackColor = true;
            this.buttonDeleteAllStorageItems.Click += new System.EventHandler(this.buttonDeleteAllStorageItems_Click);
            // 
            // buttonDeleteStorageItem
            // 
            this.buttonDeleteStorageItem.Location = new System.Drawing.Point(8, 546);
            this.buttonDeleteStorageItem.Name = "buttonDeleteStorageItem";
            this.buttonDeleteStorageItem.Size = new System.Drawing.Size(105, 27);
            this.buttonDeleteStorageItem.TabIndex = 53;
            this.buttonDeleteStorageItem.Text = "Delete Item";
            this.buttonDeleteStorageItem.UseVisualStyleBackColor = true;
            this.buttonDeleteStorageItem.Click += new System.EventHandler(this.buttonDeleteStorageItem_Click);
            // 
            // groupBoxForge
            // 
            this.groupBoxForge.Controls.Add(this.storageItem119);
            this.groupBoxForge.Controls.Add(this.storageItem118);
            this.groupBoxForge.Controls.Add(this.storageItem117);
            this.groupBoxForge.Controls.Add(this.storageItem116);
            this.groupBoxForge.Controls.Add(this.storageItem115);
            this.groupBoxForge.Controls.Add(this.storageItem114);
            this.groupBoxForge.Controls.Add(this.storageItem113);
            this.groupBoxForge.Controls.Add(this.storageItem112);
            this.groupBoxForge.Controls.Add(this.storageItem111);
            this.groupBoxForge.Controls.Add(this.storageItem110);
            this.groupBoxForge.Controls.Add(this.storageItem109);
            this.groupBoxForge.Controls.Add(this.storageItem108);
            this.groupBoxForge.Controls.Add(this.storageItem107);
            this.groupBoxForge.Controls.Add(this.storageItem106);
            this.groupBoxForge.Controls.Add(this.storageItem105);
            this.groupBoxForge.Controls.Add(this.storageItem104);
            this.groupBoxForge.Controls.Add(this.storageItem103);
            this.groupBoxForge.Controls.Add(this.storageItem102);
            this.groupBoxForge.Controls.Add(this.storageItem101);
            this.groupBoxForge.Controls.Add(this.storageItem100);
            this.groupBoxForge.Controls.Add(this.storageItem99);
            this.groupBoxForge.Controls.Add(this.storageItem98);
            this.groupBoxForge.Controls.Add(this.storageItem97);
            this.groupBoxForge.Controls.Add(this.storageItem96);
            this.groupBoxForge.Controls.Add(this.storageItem95);
            this.groupBoxForge.Controls.Add(this.storageItem94);
            this.groupBoxForge.Controls.Add(this.storageItem93);
            this.groupBoxForge.Controls.Add(this.storageItem92);
            this.groupBoxForge.Controls.Add(this.storageItem91);
            this.groupBoxForge.Controls.Add(this.storageItem90);
            this.groupBoxForge.Controls.Add(this.storageItem89);
            this.groupBoxForge.Controls.Add(this.storageItem88);
            this.groupBoxForge.Controls.Add(this.storageItem87);
            this.groupBoxForge.Controls.Add(this.storageItem86);
            this.groupBoxForge.Controls.Add(this.storageItem85);
            this.groupBoxForge.Controls.Add(this.storageItem84);
            this.groupBoxForge.Controls.Add(this.storageItem83);
            this.groupBoxForge.Controls.Add(this.storageItem82);
            this.groupBoxForge.Controls.Add(this.storageItem81);
            this.groupBoxForge.Controls.Add(this.storageItem80);
            this.groupBoxForge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBoxForge.Location = new System.Drawing.Point(873, 31);
            this.groupBoxForge.Name = "groupBoxForge";
            this.groupBoxForge.Size = new System.Drawing.Size(322, 554);
            this.groupBoxForge.TabIndex = 52;
            this.groupBoxForge.TabStop = false;
            this.groupBoxForge.Text = "Sorcerer\'s Forge";
            // 
            // storageItem119
            // 
            this.storageItem119.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem119.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem119.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem119.ForeColor = System.Drawing.Color.White;
            this.storageItem119.Location = new System.Drawing.Point(254, 488);
            this.storageItem119.Name = "storageItem119";
            this.storageItem119.Size = new System.Drawing.Size(55, 54);
            this.storageItem119.TabIndex = 51;
            this.storageItem119.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem119.UseVisualStyleBackColor = false;
            this.storageItem119.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem118
            // 
            this.storageItem118.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem118.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem118.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem118.ForeColor = System.Drawing.Color.White;
            this.storageItem118.Location = new System.Drawing.Point(192, 488);
            this.storageItem118.Name = "storageItem118";
            this.storageItem118.Size = new System.Drawing.Size(55, 54);
            this.storageItem118.TabIndex = 50;
            this.storageItem118.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem118.UseVisualStyleBackColor = false;
            this.storageItem118.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem117
            // 
            this.storageItem117.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem117.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem117.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem117.ForeColor = System.Drawing.Color.White;
            this.storageItem117.Location = new System.Drawing.Point(131, 488);
            this.storageItem117.Name = "storageItem117";
            this.storageItem117.Size = new System.Drawing.Size(55, 54);
            this.storageItem117.TabIndex = 49;
            this.storageItem117.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem117.UseVisualStyleBackColor = false;
            this.storageItem117.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem116
            // 
            this.storageItem116.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem116.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem116.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem116.ForeColor = System.Drawing.Color.White;
            this.storageItem116.Location = new System.Drawing.Point(69, 488);
            this.storageItem116.Name = "storageItem116";
            this.storageItem116.Size = new System.Drawing.Size(55, 54);
            this.storageItem116.TabIndex = 48;
            this.storageItem116.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem116.UseVisualStyleBackColor = false;
            this.storageItem116.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem115
            // 
            this.storageItem115.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem115.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem115.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem115.ForeColor = System.Drawing.Color.White;
            this.storageItem115.Location = new System.Drawing.Point(7, 488);
            this.storageItem115.Name = "storageItem115";
            this.storageItem115.Size = new System.Drawing.Size(55, 54);
            this.storageItem115.TabIndex = 47;
            this.storageItem115.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem115.UseVisualStyleBackColor = false;
            this.storageItem115.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem114
            // 
            this.storageItem114.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem114.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem114.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem114.ForeColor = System.Drawing.Color.White;
            this.storageItem114.Location = new System.Drawing.Point(254, 425);
            this.storageItem114.Name = "storageItem114";
            this.storageItem114.Size = new System.Drawing.Size(55, 54);
            this.storageItem114.TabIndex = 46;
            this.storageItem114.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem114.UseVisualStyleBackColor = false;
            this.storageItem114.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem113
            // 
            this.storageItem113.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem113.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem113.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem113.ForeColor = System.Drawing.Color.White;
            this.storageItem113.Location = new System.Drawing.Point(192, 425);
            this.storageItem113.Name = "storageItem113";
            this.storageItem113.Size = new System.Drawing.Size(55, 54);
            this.storageItem113.TabIndex = 45;
            this.storageItem113.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem113.UseVisualStyleBackColor = false;
            this.storageItem113.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem112
            // 
            this.storageItem112.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem112.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem112.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem112.ForeColor = System.Drawing.Color.White;
            this.storageItem112.Location = new System.Drawing.Point(131, 425);
            this.storageItem112.Name = "storageItem112";
            this.storageItem112.Size = new System.Drawing.Size(55, 54);
            this.storageItem112.TabIndex = 44;
            this.storageItem112.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem112.UseVisualStyleBackColor = false;
            this.storageItem112.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem111
            // 
            this.storageItem111.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem111.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem111.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem111.ForeColor = System.Drawing.Color.White;
            this.storageItem111.Location = new System.Drawing.Point(69, 425);
            this.storageItem111.Name = "storageItem111";
            this.storageItem111.Size = new System.Drawing.Size(55, 54);
            this.storageItem111.TabIndex = 43;
            this.storageItem111.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem111.UseVisualStyleBackColor = false;
            this.storageItem111.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem110
            // 
            this.storageItem110.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem110.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem110.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem110.ForeColor = System.Drawing.Color.White;
            this.storageItem110.Location = new System.Drawing.Point(7, 425);
            this.storageItem110.Name = "storageItem110";
            this.storageItem110.Size = new System.Drawing.Size(55, 54);
            this.storageItem110.TabIndex = 42;
            this.storageItem110.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem110.UseVisualStyleBackColor = false;
            this.storageItem110.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem109
            // 
            this.storageItem109.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem109.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem109.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem109.ForeColor = System.Drawing.Color.White;
            this.storageItem109.Location = new System.Drawing.Point(254, 363);
            this.storageItem109.Name = "storageItem109";
            this.storageItem109.Size = new System.Drawing.Size(55, 54);
            this.storageItem109.TabIndex = 41;
            this.storageItem109.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem109.UseVisualStyleBackColor = false;
            this.storageItem109.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem108
            // 
            this.storageItem108.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem108.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem108.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem108.ForeColor = System.Drawing.Color.White;
            this.storageItem108.Location = new System.Drawing.Point(192, 363);
            this.storageItem108.Name = "storageItem108";
            this.storageItem108.Size = new System.Drawing.Size(55, 54);
            this.storageItem108.TabIndex = 40;
            this.storageItem108.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem108.UseVisualStyleBackColor = false;
            this.storageItem108.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem107
            // 
            this.storageItem107.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem107.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem107.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem107.ForeColor = System.Drawing.Color.White;
            this.storageItem107.Location = new System.Drawing.Point(131, 363);
            this.storageItem107.Name = "storageItem107";
            this.storageItem107.Size = new System.Drawing.Size(55, 54);
            this.storageItem107.TabIndex = 39;
            this.storageItem107.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem107.UseVisualStyleBackColor = false;
            this.storageItem107.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem106
            // 
            this.storageItem106.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem106.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem106.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem106.ForeColor = System.Drawing.Color.White;
            this.storageItem106.Location = new System.Drawing.Point(69, 363);
            this.storageItem106.Name = "storageItem106";
            this.storageItem106.Size = new System.Drawing.Size(55, 54);
            this.storageItem106.TabIndex = 38;
            this.storageItem106.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem106.UseVisualStyleBackColor = false;
            this.storageItem106.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem105
            // 
            this.storageItem105.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem105.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem105.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem105.ForeColor = System.Drawing.Color.White;
            this.storageItem105.Location = new System.Drawing.Point(7, 363);
            this.storageItem105.Name = "storageItem105";
            this.storageItem105.Size = new System.Drawing.Size(55, 54);
            this.storageItem105.TabIndex = 37;
            this.storageItem105.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem105.UseVisualStyleBackColor = false;
            this.storageItem105.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem104
            // 
            this.storageItem104.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem104.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem104.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem104.ForeColor = System.Drawing.Color.White;
            this.storageItem104.Location = new System.Drawing.Point(254, 302);
            this.storageItem104.Name = "storageItem104";
            this.storageItem104.Size = new System.Drawing.Size(55, 54);
            this.storageItem104.TabIndex = 36;
            this.storageItem104.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem104.UseVisualStyleBackColor = false;
            this.storageItem104.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem103
            // 
            this.storageItem103.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem103.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem103.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem103.ForeColor = System.Drawing.Color.White;
            this.storageItem103.Location = new System.Drawing.Point(192, 302);
            this.storageItem103.Name = "storageItem103";
            this.storageItem103.Size = new System.Drawing.Size(55, 54);
            this.storageItem103.TabIndex = 35;
            this.storageItem103.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem103.UseVisualStyleBackColor = false;
            this.storageItem103.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem102
            // 
            this.storageItem102.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem102.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem102.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem102.ForeColor = System.Drawing.Color.White;
            this.storageItem102.Location = new System.Drawing.Point(131, 302);
            this.storageItem102.Name = "storageItem102";
            this.storageItem102.Size = new System.Drawing.Size(55, 54);
            this.storageItem102.TabIndex = 34;
            this.storageItem102.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem102.UseVisualStyleBackColor = false;
            this.storageItem102.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem101
            // 
            this.storageItem101.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem101.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem101.ForeColor = System.Drawing.Color.White;
            this.storageItem101.Location = new System.Drawing.Point(69, 302);
            this.storageItem101.Name = "storageItem101";
            this.storageItem101.Size = new System.Drawing.Size(55, 54);
            this.storageItem101.TabIndex = 33;
            this.storageItem101.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem101.UseVisualStyleBackColor = false;
            this.storageItem101.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem100
            // 
            this.storageItem100.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem100.ForeColor = System.Drawing.Color.White;
            this.storageItem100.Location = new System.Drawing.Point(7, 302);
            this.storageItem100.Name = "storageItem100";
            this.storageItem100.Size = new System.Drawing.Size(55, 54);
            this.storageItem100.TabIndex = 32;
            this.storageItem100.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem100.UseVisualStyleBackColor = false;
            this.storageItem100.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem99
            // 
            this.storageItem99.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem99.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem99.ForeColor = System.Drawing.Color.White;
            this.storageItem99.Location = new System.Drawing.Point(254, 205);
            this.storageItem99.Name = "storageItem99";
            this.storageItem99.Size = new System.Drawing.Size(55, 54);
            this.storageItem99.TabIndex = 31;
            this.storageItem99.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem99.UseVisualStyleBackColor = false;
            this.storageItem99.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem98
            // 
            this.storageItem98.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem98.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem98.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem98.ForeColor = System.Drawing.Color.White;
            this.storageItem98.Location = new System.Drawing.Point(192, 205);
            this.storageItem98.Name = "storageItem98";
            this.storageItem98.Size = new System.Drawing.Size(55, 54);
            this.storageItem98.TabIndex = 30;
            this.storageItem98.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem98.UseVisualStyleBackColor = false;
            this.storageItem98.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem97
            // 
            this.storageItem97.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem97.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem97.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem97.ForeColor = System.Drawing.Color.White;
            this.storageItem97.Location = new System.Drawing.Point(131, 205);
            this.storageItem97.Name = "storageItem97";
            this.storageItem97.Size = new System.Drawing.Size(55, 54);
            this.storageItem97.TabIndex = 29;
            this.storageItem97.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem97.UseVisualStyleBackColor = false;
            this.storageItem97.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem96
            // 
            this.storageItem96.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem96.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem96.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem96.ForeColor = System.Drawing.Color.White;
            this.storageItem96.Location = new System.Drawing.Point(69, 205);
            this.storageItem96.Name = "storageItem96";
            this.storageItem96.Size = new System.Drawing.Size(55, 54);
            this.storageItem96.TabIndex = 28;
            this.storageItem96.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem96.UseVisualStyleBackColor = false;
            this.storageItem96.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem95
            // 
            this.storageItem95.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem95.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem95.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem95.ForeColor = System.Drawing.Color.White;
            this.storageItem95.Location = new System.Drawing.Point(7, 205);
            this.storageItem95.Name = "storageItem95";
            this.storageItem95.Size = new System.Drawing.Size(55, 54);
            this.storageItem95.TabIndex = 27;
            this.storageItem95.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem95.UseVisualStyleBackColor = false;
            this.storageItem95.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem94
            // 
            this.storageItem94.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem94.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem94.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem94.ForeColor = System.Drawing.Color.White;
            this.storageItem94.Location = new System.Drawing.Point(254, 144);
            this.storageItem94.Name = "storageItem94";
            this.storageItem94.Size = new System.Drawing.Size(55, 54);
            this.storageItem94.TabIndex = 26;
            this.storageItem94.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem94.UseVisualStyleBackColor = false;
            this.storageItem94.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem93
            // 
            this.storageItem93.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem93.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem93.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem93.ForeColor = System.Drawing.Color.White;
            this.storageItem93.Location = new System.Drawing.Point(192, 144);
            this.storageItem93.Name = "storageItem93";
            this.storageItem93.Size = new System.Drawing.Size(55, 54);
            this.storageItem93.TabIndex = 25;
            this.storageItem93.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem93.UseVisualStyleBackColor = false;
            this.storageItem93.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem92
            // 
            this.storageItem92.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem92.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem92.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem92.ForeColor = System.Drawing.Color.White;
            this.storageItem92.Location = new System.Drawing.Point(131, 144);
            this.storageItem92.Name = "storageItem92";
            this.storageItem92.Size = new System.Drawing.Size(55, 54);
            this.storageItem92.TabIndex = 24;
            this.storageItem92.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem92.UseVisualStyleBackColor = false;
            this.storageItem92.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem91
            // 
            this.storageItem91.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem91.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem91.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem91.ForeColor = System.Drawing.Color.White;
            this.storageItem91.Location = new System.Drawing.Point(69, 144);
            this.storageItem91.Name = "storageItem91";
            this.storageItem91.Size = new System.Drawing.Size(55, 54);
            this.storageItem91.TabIndex = 23;
            this.storageItem91.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem91.UseVisualStyleBackColor = false;
            this.storageItem91.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem90
            // 
            this.storageItem90.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem90.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem90.ForeColor = System.Drawing.Color.White;
            this.storageItem90.Location = new System.Drawing.Point(7, 144);
            this.storageItem90.Name = "storageItem90";
            this.storageItem90.Size = new System.Drawing.Size(55, 54);
            this.storageItem90.TabIndex = 22;
            this.storageItem90.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem90.UseVisualStyleBackColor = false;
            this.storageItem90.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem89
            // 
            this.storageItem89.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem89.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem89.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem89.ForeColor = System.Drawing.Color.White;
            this.storageItem89.Location = new System.Drawing.Point(254, 83);
            this.storageItem89.Name = "storageItem89";
            this.storageItem89.Size = new System.Drawing.Size(55, 54);
            this.storageItem89.TabIndex = 21;
            this.storageItem89.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem89.UseVisualStyleBackColor = false;
            this.storageItem89.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem88
            // 
            this.storageItem88.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem88.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem88.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem88.ForeColor = System.Drawing.Color.White;
            this.storageItem88.Location = new System.Drawing.Point(192, 83);
            this.storageItem88.Name = "storageItem88";
            this.storageItem88.Size = new System.Drawing.Size(55, 54);
            this.storageItem88.TabIndex = 20;
            this.storageItem88.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem88.UseVisualStyleBackColor = false;
            this.storageItem88.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem87
            // 
            this.storageItem87.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem87.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem87.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem87.ForeColor = System.Drawing.Color.White;
            this.storageItem87.Location = new System.Drawing.Point(131, 83);
            this.storageItem87.Name = "storageItem87";
            this.storageItem87.Size = new System.Drawing.Size(55, 54);
            this.storageItem87.TabIndex = 19;
            this.storageItem87.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem87.UseVisualStyleBackColor = false;
            this.storageItem87.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem86
            // 
            this.storageItem86.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem86.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem86.ForeColor = System.Drawing.Color.White;
            this.storageItem86.Location = new System.Drawing.Point(69, 83);
            this.storageItem86.Name = "storageItem86";
            this.storageItem86.Size = new System.Drawing.Size(55, 54);
            this.storageItem86.TabIndex = 18;
            this.storageItem86.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem86.UseVisualStyleBackColor = false;
            this.storageItem86.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem85
            // 
            this.storageItem85.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem85.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem85.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem85.ForeColor = System.Drawing.Color.White;
            this.storageItem85.Location = new System.Drawing.Point(7, 83);
            this.storageItem85.Name = "storageItem85";
            this.storageItem85.Size = new System.Drawing.Size(55, 54);
            this.storageItem85.TabIndex = 17;
            this.storageItem85.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem85.UseVisualStyleBackColor = false;
            this.storageItem85.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem84
            // 
            this.storageItem84.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem84.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem84.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem84.ForeColor = System.Drawing.Color.White;
            this.storageItem84.Location = new System.Drawing.Point(254, 22);
            this.storageItem84.Name = "storageItem84";
            this.storageItem84.Size = new System.Drawing.Size(55, 54);
            this.storageItem84.TabIndex = 16;
            this.storageItem84.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem84.UseVisualStyleBackColor = false;
            this.storageItem84.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem83
            // 
            this.storageItem83.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem83.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem83.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem83.ForeColor = System.Drawing.Color.White;
            this.storageItem83.Location = new System.Drawing.Point(192, 22);
            this.storageItem83.Name = "storageItem83";
            this.storageItem83.Size = new System.Drawing.Size(55, 54);
            this.storageItem83.TabIndex = 15;
            this.storageItem83.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem83.UseVisualStyleBackColor = false;
            this.storageItem83.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem82
            // 
            this.storageItem82.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem82.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem82.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem82.ForeColor = System.Drawing.Color.White;
            this.storageItem82.Location = new System.Drawing.Point(131, 22);
            this.storageItem82.Name = "storageItem82";
            this.storageItem82.Size = new System.Drawing.Size(55, 54);
            this.storageItem82.TabIndex = 14;
            this.storageItem82.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem82.UseVisualStyleBackColor = false;
            this.storageItem82.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem81
            // 
            this.storageItem81.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem81.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem81.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem81.ForeColor = System.Drawing.Color.White;
            this.storageItem81.Location = new System.Drawing.Point(69, 22);
            this.storageItem81.Name = "storageItem81";
            this.storageItem81.Size = new System.Drawing.Size(55, 54);
            this.storageItem81.TabIndex = 13;
            this.storageItem81.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem81.UseVisualStyleBackColor = false;
            this.storageItem81.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem80
            // 
            this.storageItem80.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem80.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem80.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem80.ForeColor = System.Drawing.Color.White;
            this.storageItem80.Location = new System.Drawing.Point(7, 22);
            this.storageItem80.Name = "storageItem80";
            this.storageItem80.Size = new System.Drawing.Size(55, 54);
            this.storageItem80.TabIndex = 12;
            this.storageItem80.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem80.UseVisualStyleBackColor = false;
            this.storageItem80.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // groupBoxSafe
            // 
            this.groupBoxSafe.Controls.Add(this.storageItem79);
            this.groupBoxSafe.Controls.Add(this.storageItem78);
            this.groupBoxSafe.Controls.Add(this.storageItem77);
            this.groupBoxSafe.Controls.Add(this.storageItem76);
            this.groupBoxSafe.Controls.Add(this.storageItem75);
            this.groupBoxSafe.Controls.Add(this.storageItem74);
            this.groupBoxSafe.Controls.Add(this.storageItem73);
            this.groupBoxSafe.Controls.Add(this.storageItem72);
            this.groupBoxSafe.Controls.Add(this.storageItem71);
            this.groupBoxSafe.Controls.Add(this.storageItem70);
            this.groupBoxSafe.Controls.Add(this.storageItem69);
            this.groupBoxSafe.Controls.Add(this.storageItem68);
            this.groupBoxSafe.Controls.Add(this.storageItem67);
            this.groupBoxSafe.Controls.Add(this.storageItem66);
            this.groupBoxSafe.Controls.Add(this.storageItem65);
            this.groupBoxSafe.Controls.Add(this.storageItem64);
            this.groupBoxSafe.Controls.Add(this.storageItem63);
            this.groupBoxSafe.Controls.Add(this.storageItem62);
            this.groupBoxSafe.Controls.Add(this.storageItem61);
            this.groupBoxSafe.Controls.Add(this.storageItem60);
            this.groupBoxSafe.Controls.Add(this.storageItem59);
            this.groupBoxSafe.Controls.Add(this.storageItem58);
            this.groupBoxSafe.Controls.Add(this.storageItem57);
            this.groupBoxSafe.Controls.Add(this.storageItem56);
            this.groupBoxSafe.Controls.Add(this.storageItem55);
            this.groupBoxSafe.Controls.Add(this.storageItem54);
            this.groupBoxSafe.Controls.Add(this.storageItem53);
            this.groupBoxSafe.Controls.Add(this.storageItem52);
            this.groupBoxSafe.Controls.Add(this.storageItem51);
            this.groupBoxSafe.Controls.Add(this.storageItem50);
            this.groupBoxSafe.Controls.Add(this.storageItem49);
            this.groupBoxSafe.Controls.Add(this.storageItem48);
            this.groupBoxSafe.Controls.Add(this.storageItem47);
            this.groupBoxSafe.Controls.Add(this.storageItem46);
            this.groupBoxSafe.Controls.Add(this.storageItem45);
            this.groupBoxSafe.Controls.Add(this.storageItem44);
            this.groupBoxSafe.Controls.Add(this.storageItem43);
            this.groupBoxSafe.Controls.Add(this.storageItem42);
            this.groupBoxSafe.Controls.Add(this.storageItem41);
            this.groupBoxSafe.Controls.Add(this.storageItem40);
            this.groupBoxSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBoxSafe.Location = new System.Drawing.Point(239, 312);
            this.groupBoxSafe.Name = "groupBoxSafe";
            this.groupBoxSafe.Size = new System.Drawing.Size(625, 273);
            this.groupBoxSafe.TabIndex = 51;
            this.groupBoxSafe.TabStop = false;
            this.groupBoxSafe.Text = "Safe";
            // 
            // storageItem79
            // 
            this.storageItem79.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem79.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem79.ForeColor = System.Drawing.Color.White;
            this.storageItem79.Location = new System.Drawing.Point(563, 208);
            this.storageItem79.Name = "storageItem79";
            this.storageItem79.Size = new System.Drawing.Size(55, 54);
            this.storageItem79.TabIndex = 50;
            this.storageItem79.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem79.UseVisualStyleBackColor = false;
            this.storageItem79.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem78
            // 
            this.storageItem78.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem78.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem78.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem78.ForeColor = System.Drawing.Color.White;
            this.storageItem78.Location = new System.Drawing.Point(502, 208);
            this.storageItem78.Name = "storageItem78";
            this.storageItem78.Size = new System.Drawing.Size(55, 54);
            this.storageItem78.TabIndex = 49;
            this.storageItem78.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem78.UseVisualStyleBackColor = false;
            this.storageItem78.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem77
            // 
            this.storageItem77.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem77.ForeColor = System.Drawing.Color.White;
            this.storageItem77.Location = new System.Drawing.Point(440, 208);
            this.storageItem77.Name = "storageItem77";
            this.storageItem77.Size = new System.Drawing.Size(55, 54);
            this.storageItem77.TabIndex = 48;
            this.storageItem77.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem77.UseVisualStyleBackColor = false;
            this.storageItem77.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem76
            // 
            this.storageItem76.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem76.ForeColor = System.Drawing.Color.White;
            this.storageItem76.Location = new System.Drawing.Point(378, 208);
            this.storageItem76.Name = "storageItem76";
            this.storageItem76.Size = new System.Drawing.Size(55, 54);
            this.storageItem76.TabIndex = 47;
            this.storageItem76.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem76.UseVisualStyleBackColor = false;
            this.storageItem76.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem75
            // 
            this.storageItem75.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem75.ForeColor = System.Drawing.Color.White;
            this.storageItem75.Location = new System.Drawing.Point(316, 208);
            this.storageItem75.Name = "storageItem75";
            this.storageItem75.Size = new System.Drawing.Size(55, 54);
            this.storageItem75.TabIndex = 46;
            this.storageItem75.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem75.UseVisualStyleBackColor = false;
            this.storageItem75.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem74
            // 
            this.storageItem74.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem74.ForeColor = System.Drawing.Color.White;
            this.storageItem74.Location = new System.Drawing.Point(254, 208);
            this.storageItem74.Name = "storageItem74";
            this.storageItem74.Size = new System.Drawing.Size(55, 54);
            this.storageItem74.TabIndex = 45;
            this.storageItem74.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem74.UseVisualStyleBackColor = false;
            this.storageItem74.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem73
            // 
            this.storageItem73.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem73.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem73.ForeColor = System.Drawing.Color.White;
            this.storageItem73.Location = new System.Drawing.Point(192, 208);
            this.storageItem73.Name = "storageItem73";
            this.storageItem73.Size = new System.Drawing.Size(55, 54);
            this.storageItem73.TabIndex = 44;
            this.storageItem73.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem73.UseVisualStyleBackColor = false;
            this.storageItem73.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem72
            // 
            this.storageItem72.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem72.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem72.ForeColor = System.Drawing.Color.White;
            this.storageItem72.Location = new System.Drawing.Point(131, 208);
            this.storageItem72.Name = "storageItem72";
            this.storageItem72.Size = new System.Drawing.Size(55, 54);
            this.storageItem72.TabIndex = 43;
            this.storageItem72.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem72.UseVisualStyleBackColor = false;
            this.storageItem72.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem71
            // 
            this.storageItem71.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem71.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem71.ForeColor = System.Drawing.Color.White;
            this.storageItem71.Location = new System.Drawing.Point(69, 208);
            this.storageItem71.Name = "storageItem71";
            this.storageItem71.Size = new System.Drawing.Size(55, 54);
            this.storageItem71.TabIndex = 42;
            this.storageItem71.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem71.UseVisualStyleBackColor = false;
            this.storageItem71.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem70
            // 
            this.storageItem70.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem70.ForeColor = System.Drawing.Color.White;
            this.storageItem70.Location = new System.Drawing.Point(7, 208);
            this.storageItem70.Name = "storageItem70";
            this.storageItem70.Size = new System.Drawing.Size(55, 54);
            this.storageItem70.TabIndex = 41;
            this.storageItem70.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem70.UseVisualStyleBackColor = false;
            this.storageItem70.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem69
            // 
            this.storageItem69.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem69.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem69.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem69.ForeColor = System.Drawing.Color.White;
            this.storageItem69.Location = new System.Drawing.Point(563, 147);
            this.storageItem69.Name = "storageItem69";
            this.storageItem69.Size = new System.Drawing.Size(55, 54);
            this.storageItem69.TabIndex = 40;
            this.storageItem69.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem69.UseVisualStyleBackColor = false;
            this.storageItem69.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem68
            // 
            this.storageItem68.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem68.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem68.ForeColor = System.Drawing.Color.White;
            this.storageItem68.Location = new System.Drawing.Point(502, 147);
            this.storageItem68.Name = "storageItem68";
            this.storageItem68.Size = new System.Drawing.Size(55, 54);
            this.storageItem68.TabIndex = 39;
            this.storageItem68.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem68.UseVisualStyleBackColor = false;
            this.storageItem68.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem67
            // 
            this.storageItem67.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem67.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem67.ForeColor = System.Drawing.Color.White;
            this.storageItem67.Location = new System.Drawing.Point(440, 147);
            this.storageItem67.Name = "storageItem67";
            this.storageItem67.Size = new System.Drawing.Size(55, 54);
            this.storageItem67.TabIndex = 38;
            this.storageItem67.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem67.UseVisualStyleBackColor = false;
            this.storageItem67.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem66
            // 
            this.storageItem66.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem66.ForeColor = System.Drawing.Color.White;
            this.storageItem66.Location = new System.Drawing.Point(378, 147);
            this.storageItem66.Name = "storageItem66";
            this.storageItem66.Size = new System.Drawing.Size(55, 54);
            this.storageItem66.TabIndex = 37;
            this.storageItem66.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem66.UseVisualStyleBackColor = false;
            this.storageItem66.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem65
            // 
            this.storageItem65.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem65.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem65.ForeColor = System.Drawing.Color.White;
            this.storageItem65.Location = new System.Drawing.Point(316, 147);
            this.storageItem65.Name = "storageItem65";
            this.storageItem65.Size = new System.Drawing.Size(55, 54);
            this.storageItem65.TabIndex = 36;
            this.storageItem65.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem65.UseVisualStyleBackColor = false;
            this.storageItem65.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem64
            // 
            this.storageItem64.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem64.ForeColor = System.Drawing.Color.White;
            this.storageItem64.Location = new System.Drawing.Point(254, 147);
            this.storageItem64.Name = "storageItem64";
            this.storageItem64.Size = new System.Drawing.Size(55, 54);
            this.storageItem64.TabIndex = 35;
            this.storageItem64.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem64.UseVisualStyleBackColor = false;
            this.storageItem64.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem63
            // 
            this.storageItem63.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem63.ForeColor = System.Drawing.Color.White;
            this.storageItem63.Location = new System.Drawing.Point(192, 147);
            this.storageItem63.Name = "storageItem63";
            this.storageItem63.Size = new System.Drawing.Size(55, 54);
            this.storageItem63.TabIndex = 34;
            this.storageItem63.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem63.UseVisualStyleBackColor = false;
            this.storageItem63.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem62
            // 
            this.storageItem62.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem62.ForeColor = System.Drawing.Color.White;
            this.storageItem62.Location = new System.Drawing.Point(131, 147);
            this.storageItem62.Name = "storageItem62";
            this.storageItem62.Size = new System.Drawing.Size(55, 54);
            this.storageItem62.TabIndex = 33;
            this.storageItem62.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem62.UseVisualStyleBackColor = false;
            this.storageItem62.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem61
            // 
            this.storageItem61.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem61.ForeColor = System.Drawing.Color.White;
            this.storageItem61.Location = new System.Drawing.Point(69, 147);
            this.storageItem61.Name = "storageItem61";
            this.storageItem61.Size = new System.Drawing.Size(55, 54);
            this.storageItem61.TabIndex = 32;
            this.storageItem61.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem61.UseVisualStyleBackColor = false;
            this.storageItem61.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem60
            // 
            this.storageItem60.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem60.ForeColor = System.Drawing.Color.White;
            this.storageItem60.Location = new System.Drawing.Point(7, 147);
            this.storageItem60.Name = "storageItem60";
            this.storageItem60.Size = new System.Drawing.Size(55, 54);
            this.storageItem60.TabIndex = 31;
            this.storageItem60.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem60.UseVisualStyleBackColor = false;
            this.storageItem60.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem59
            // 
            this.storageItem59.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem59.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem59.ForeColor = System.Drawing.Color.White;
            this.storageItem59.Location = new System.Drawing.Point(563, 85);
            this.storageItem59.Name = "storageItem59";
            this.storageItem59.Size = new System.Drawing.Size(55, 54);
            this.storageItem59.TabIndex = 30;
            this.storageItem59.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem59.UseVisualStyleBackColor = false;
            this.storageItem59.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem58
            // 
            this.storageItem58.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem58.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem58.ForeColor = System.Drawing.Color.White;
            this.storageItem58.Location = new System.Drawing.Point(502, 85);
            this.storageItem58.Name = "storageItem58";
            this.storageItem58.Size = new System.Drawing.Size(55, 54);
            this.storageItem58.TabIndex = 29;
            this.storageItem58.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem58.UseVisualStyleBackColor = false;
            this.storageItem58.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem57
            // 
            this.storageItem57.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem57.ForeColor = System.Drawing.Color.White;
            this.storageItem57.Location = new System.Drawing.Point(440, 85);
            this.storageItem57.Name = "storageItem57";
            this.storageItem57.Size = new System.Drawing.Size(55, 54);
            this.storageItem57.TabIndex = 28;
            this.storageItem57.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem57.UseVisualStyleBackColor = false;
            this.storageItem57.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem56
            // 
            this.storageItem56.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem56.ForeColor = System.Drawing.Color.White;
            this.storageItem56.Location = new System.Drawing.Point(378, 85);
            this.storageItem56.Name = "storageItem56";
            this.storageItem56.Size = new System.Drawing.Size(55, 54);
            this.storageItem56.TabIndex = 27;
            this.storageItem56.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem56.UseVisualStyleBackColor = false;
            this.storageItem56.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem55
            // 
            this.storageItem55.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem55.ForeColor = System.Drawing.Color.White;
            this.storageItem55.Location = new System.Drawing.Point(316, 85);
            this.storageItem55.Name = "storageItem55";
            this.storageItem55.Size = new System.Drawing.Size(55, 54);
            this.storageItem55.TabIndex = 26;
            this.storageItem55.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem55.UseVisualStyleBackColor = false;
            this.storageItem55.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem54
            // 
            this.storageItem54.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem54.ForeColor = System.Drawing.Color.White;
            this.storageItem54.Location = new System.Drawing.Point(254, 85);
            this.storageItem54.Name = "storageItem54";
            this.storageItem54.Size = new System.Drawing.Size(55, 54);
            this.storageItem54.TabIndex = 25;
            this.storageItem54.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem54.UseVisualStyleBackColor = false;
            this.storageItem54.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem53
            // 
            this.storageItem53.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem53.ForeColor = System.Drawing.Color.White;
            this.storageItem53.Location = new System.Drawing.Point(192, 85);
            this.storageItem53.Name = "storageItem53";
            this.storageItem53.Size = new System.Drawing.Size(55, 54);
            this.storageItem53.TabIndex = 24;
            this.storageItem53.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem53.UseVisualStyleBackColor = false;
            this.storageItem53.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem52
            // 
            this.storageItem52.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem52.ForeColor = System.Drawing.Color.White;
            this.storageItem52.Location = new System.Drawing.Point(131, 85);
            this.storageItem52.Name = "storageItem52";
            this.storageItem52.Size = new System.Drawing.Size(55, 54);
            this.storageItem52.TabIndex = 23;
            this.storageItem52.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem52.UseVisualStyleBackColor = false;
            this.storageItem52.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem51
            // 
            this.storageItem51.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem51.ForeColor = System.Drawing.Color.White;
            this.storageItem51.Location = new System.Drawing.Point(69, 85);
            this.storageItem51.Name = "storageItem51";
            this.storageItem51.Size = new System.Drawing.Size(55, 54);
            this.storageItem51.TabIndex = 22;
            this.storageItem51.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem51.UseVisualStyleBackColor = false;
            this.storageItem51.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem50
            // 
            this.storageItem50.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem50.ForeColor = System.Drawing.Color.White;
            this.storageItem50.Location = new System.Drawing.Point(7, 85);
            this.storageItem50.Name = "storageItem50";
            this.storageItem50.Size = new System.Drawing.Size(55, 54);
            this.storageItem50.TabIndex = 21;
            this.storageItem50.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem50.UseVisualStyleBackColor = false;
            this.storageItem50.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem49
            // 
            this.storageItem49.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem49.ForeColor = System.Drawing.Color.White;
            this.storageItem49.Location = new System.Drawing.Point(563, 22);
            this.storageItem49.Name = "storageItem49";
            this.storageItem49.Size = new System.Drawing.Size(55, 54);
            this.storageItem49.TabIndex = 20;
            this.storageItem49.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem49.UseVisualStyleBackColor = false;
            this.storageItem49.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem48
            // 
            this.storageItem48.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem48.ForeColor = System.Drawing.Color.White;
            this.storageItem48.Location = new System.Drawing.Point(502, 22);
            this.storageItem48.Name = "storageItem48";
            this.storageItem48.Size = new System.Drawing.Size(55, 54);
            this.storageItem48.TabIndex = 19;
            this.storageItem48.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem48.UseVisualStyleBackColor = false;
            this.storageItem48.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem47
            // 
            this.storageItem47.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem47.ForeColor = System.Drawing.Color.White;
            this.storageItem47.Location = new System.Drawing.Point(440, 22);
            this.storageItem47.Name = "storageItem47";
            this.storageItem47.Size = new System.Drawing.Size(55, 54);
            this.storageItem47.TabIndex = 18;
            this.storageItem47.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem47.UseVisualStyleBackColor = false;
            this.storageItem47.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem46
            // 
            this.storageItem46.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem46.ForeColor = System.Drawing.Color.White;
            this.storageItem46.Location = new System.Drawing.Point(378, 22);
            this.storageItem46.Name = "storageItem46";
            this.storageItem46.Size = new System.Drawing.Size(55, 54);
            this.storageItem46.TabIndex = 17;
            this.storageItem46.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem46.UseVisualStyleBackColor = false;
            this.storageItem46.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem45
            // 
            this.storageItem45.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem45.ForeColor = System.Drawing.Color.White;
            this.storageItem45.Location = new System.Drawing.Point(316, 22);
            this.storageItem45.Name = "storageItem45";
            this.storageItem45.Size = new System.Drawing.Size(55, 54);
            this.storageItem45.TabIndex = 16;
            this.storageItem45.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem45.UseVisualStyleBackColor = false;
            this.storageItem45.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem44
            // 
            this.storageItem44.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem44.ForeColor = System.Drawing.Color.White;
            this.storageItem44.Location = new System.Drawing.Point(254, 22);
            this.storageItem44.Name = "storageItem44";
            this.storageItem44.Size = new System.Drawing.Size(55, 54);
            this.storageItem44.TabIndex = 15;
            this.storageItem44.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem44.UseVisualStyleBackColor = false;
            this.storageItem44.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem43
            // 
            this.storageItem43.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem43.ForeColor = System.Drawing.Color.White;
            this.storageItem43.Location = new System.Drawing.Point(192, 22);
            this.storageItem43.Name = "storageItem43";
            this.storageItem43.Size = new System.Drawing.Size(55, 54);
            this.storageItem43.TabIndex = 14;
            this.storageItem43.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem43.UseVisualStyleBackColor = false;
            this.storageItem43.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem42
            // 
            this.storageItem42.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem42.ForeColor = System.Drawing.Color.White;
            this.storageItem42.Location = new System.Drawing.Point(131, 22);
            this.storageItem42.Name = "storageItem42";
            this.storageItem42.Size = new System.Drawing.Size(55, 54);
            this.storageItem42.TabIndex = 13;
            this.storageItem42.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem42.UseVisualStyleBackColor = false;
            this.storageItem42.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem41
            // 
            this.storageItem41.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem41.ForeColor = System.Drawing.Color.White;
            this.storageItem41.Location = new System.Drawing.Point(69, 22);
            this.storageItem41.Name = "storageItem41";
            this.storageItem41.Size = new System.Drawing.Size(55, 54);
            this.storageItem41.TabIndex = 12;
            this.storageItem41.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem41.UseVisualStyleBackColor = false;
            this.storageItem41.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem40
            // 
            this.storageItem40.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem40.ForeColor = System.Drawing.Color.White;
            this.storageItem40.Location = new System.Drawing.Point(7, 22);
            this.storageItem40.Name = "storageItem40";
            this.storageItem40.Size = new System.Drawing.Size(55, 54);
            this.storageItem40.TabIndex = 11;
            this.storageItem40.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem40.UseVisualStyleBackColor = false;
            this.storageItem40.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // groupBoxPiggyItems
            // 
            this.groupBoxPiggyItems.Controls.Add(this.storageItem39);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem38);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem37);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem36);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem35);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem34);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem33);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem32);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem31);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem30);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem29);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem28);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem27);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem26);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem25);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem24);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem23);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem22);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem21);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem20);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem19);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem18);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem17);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem16);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem15);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem14);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem13);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem12);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem11);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem10);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem9);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem8);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem7);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem6);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem5);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem4);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem3);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem2);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem1);
            this.groupBoxPiggyItems.Controls.Add(this.storageItem0);
            this.groupBoxPiggyItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBoxPiggyItems.Location = new System.Drawing.Point(239, 31);
            this.groupBoxPiggyItems.Name = "groupBoxPiggyItems";
            this.groupBoxPiggyItems.Size = new System.Drawing.Size(625, 273);
            this.groupBoxPiggyItems.TabIndex = 11;
            this.groupBoxPiggyItems.TabStop = false;
            this.groupBoxPiggyItems.Text = "Piggy Bank";
            // 
            // storageItem39
            // 
            this.storageItem39.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem39.ForeColor = System.Drawing.Color.White;
            this.storageItem39.Location = new System.Drawing.Point(563, 208);
            this.storageItem39.Name = "storageItem39";
            this.storageItem39.Size = new System.Drawing.Size(55, 54);
            this.storageItem39.TabIndex = 50;
            this.storageItem39.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem39.UseVisualStyleBackColor = false;
            this.storageItem39.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem38
            // 
            this.storageItem38.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem38.ForeColor = System.Drawing.Color.White;
            this.storageItem38.Location = new System.Drawing.Point(502, 208);
            this.storageItem38.Name = "storageItem38";
            this.storageItem38.Size = new System.Drawing.Size(55, 54);
            this.storageItem38.TabIndex = 49;
            this.storageItem38.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem38.UseVisualStyleBackColor = false;
            this.storageItem38.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem37
            // 
            this.storageItem37.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem37.ForeColor = System.Drawing.Color.White;
            this.storageItem37.Location = new System.Drawing.Point(440, 208);
            this.storageItem37.Name = "storageItem37";
            this.storageItem37.Size = new System.Drawing.Size(55, 54);
            this.storageItem37.TabIndex = 48;
            this.storageItem37.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem37.UseVisualStyleBackColor = false;
            this.storageItem37.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem36
            // 
            this.storageItem36.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem36.ForeColor = System.Drawing.Color.White;
            this.storageItem36.Location = new System.Drawing.Point(378, 208);
            this.storageItem36.Name = "storageItem36";
            this.storageItem36.Size = new System.Drawing.Size(55, 54);
            this.storageItem36.TabIndex = 47;
            this.storageItem36.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem36.UseVisualStyleBackColor = false;
            this.storageItem36.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem35
            // 
            this.storageItem35.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem35.ForeColor = System.Drawing.Color.White;
            this.storageItem35.Location = new System.Drawing.Point(316, 208);
            this.storageItem35.Name = "storageItem35";
            this.storageItem35.Size = new System.Drawing.Size(55, 54);
            this.storageItem35.TabIndex = 46;
            this.storageItem35.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem35.UseVisualStyleBackColor = false;
            this.storageItem35.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem34
            // 
            this.storageItem34.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem34.ForeColor = System.Drawing.Color.White;
            this.storageItem34.Location = new System.Drawing.Point(254, 208);
            this.storageItem34.Name = "storageItem34";
            this.storageItem34.Size = new System.Drawing.Size(55, 54);
            this.storageItem34.TabIndex = 45;
            this.storageItem34.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem34.UseVisualStyleBackColor = false;
            this.storageItem34.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem33
            // 
            this.storageItem33.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem33.ForeColor = System.Drawing.Color.White;
            this.storageItem33.Location = new System.Drawing.Point(192, 208);
            this.storageItem33.Name = "storageItem33";
            this.storageItem33.Size = new System.Drawing.Size(55, 54);
            this.storageItem33.TabIndex = 44;
            this.storageItem33.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem33.UseVisualStyleBackColor = false;
            this.storageItem33.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem32
            // 
            this.storageItem32.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem32.ForeColor = System.Drawing.Color.White;
            this.storageItem32.Location = new System.Drawing.Point(131, 208);
            this.storageItem32.Name = "storageItem32";
            this.storageItem32.Size = new System.Drawing.Size(55, 54);
            this.storageItem32.TabIndex = 43;
            this.storageItem32.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem32.UseVisualStyleBackColor = false;
            this.storageItem32.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem31
            // 
            this.storageItem31.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem31.ForeColor = System.Drawing.Color.White;
            this.storageItem31.Location = new System.Drawing.Point(69, 208);
            this.storageItem31.Name = "storageItem31";
            this.storageItem31.Size = new System.Drawing.Size(55, 54);
            this.storageItem31.TabIndex = 42;
            this.storageItem31.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem31.UseVisualStyleBackColor = false;
            this.storageItem31.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem30
            // 
            this.storageItem30.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem30.ForeColor = System.Drawing.Color.White;
            this.storageItem30.Location = new System.Drawing.Point(7, 208);
            this.storageItem30.Name = "storageItem30";
            this.storageItem30.Size = new System.Drawing.Size(55, 54);
            this.storageItem30.TabIndex = 41;
            this.storageItem30.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem30.UseVisualStyleBackColor = false;
            this.storageItem30.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem29
            // 
            this.storageItem29.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem29.ForeColor = System.Drawing.Color.White;
            this.storageItem29.Location = new System.Drawing.Point(563, 147);
            this.storageItem29.Name = "storageItem29";
            this.storageItem29.Size = new System.Drawing.Size(55, 54);
            this.storageItem29.TabIndex = 40;
            this.storageItem29.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem29.UseVisualStyleBackColor = false;
            this.storageItem29.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem28
            // 
            this.storageItem28.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem28.ForeColor = System.Drawing.Color.White;
            this.storageItem28.Location = new System.Drawing.Point(502, 147);
            this.storageItem28.Name = "storageItem28";
            this.storageItem28.Size = new System.Drawing.Size(55, 54);
            this.storageItem28.TabIndex = 39;
            this.storageItem28.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem28.UseVisualStyleBackColor = false;
            this.storageItem28.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem27
            // 
            this.storageItem27.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem27.ForeColor = System.Drawing.Color.White;
            this.storageItem27.Location = new System.Drawing.Point(440, 147);
            this.storageItem27.Name = "storageItem27";
            this.storageItem27.Size = new System.Drawing.Size(55, 54);
            this.storageItem27.TabIndex = 38;
            this.storageItem27.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem27.UseVisualStyleBackColor = false;
            this.storageItem27.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem26
            // 
            this.storageItem26.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem26.ForeColor = System.Drawing.Color.White;
            this.storageItem26.Location = new System.Drawing.Point(378, 147);
            this.storageItem26.Name = "storageItem26";
            this.storageItem26.Size = new System.Drawing.Size(55, 54);
            this.storageItem26.TabIndex = 37;
            this.storageItem26.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem26.UseVisualStyleBackColor = false;
            this.storageItem26.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem25
            // 
            this.storageItem25.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem25.ForeColor = System.Drawing.Color.White;
            this.storageItem25.Location = new System.Drawing.Point(316, 147);
            this.storageItem25.Name = "storageItem25";
            this.storageItem25.Size = new System.Drawing.Size(55, 54);
            this.storageItem25.TabIndex = 36;
            this.storageItem25.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem25.UseVisualStyleBackColor = false;
            this.storageItem25.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem24
            // 
            this.storageItem24.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem24.ForeColor = System.Drawing.Color.White;
            this.storageItem24.Location = new System.Drawing.Point(254, 147);
            this.storageItem24.Name = "storageItem24";
            this.storageItem24.Size = new System.Drawing.Size(55, 54);
            this.storageItem24.TabIndex = 35;
            this.storageItem24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem24.UseVisualStyleBackColor = false;
            this.storageItem24.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem23
            // 
            this.storageItem23.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem23.ForeColor = System.Drawing.Color.White;
            this.storageItem23.Location = new System.Drawing.Point(192, 147);
            this.storageItem23.Name = "storageItem23";
            this.storageItem23.Size = new System.Drawing.Size(55, 54);
            this.storageItem23.TabIndex = 34;
            this.storageItem23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem23.UseVisualStyleBackColor = false;
            this.storageItem23.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem22
            // 
            this.storageItem22.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem22.ForeColor = System.Drawing.Color.White;
            this.storageItem22.Location = new System.Drawing.Point(131, 147);
            this.storageItem22.Name = "storageItem22";
            this.storageItem22.Size = new System.Drawing.Size(55, 54);
            this.storageItem22.TabIndex = 33;
            this.storageItem22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem22.UseVisualStyleBackColor = false;
            this.storageItem22.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem21
            // 
            this.storageItem21.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem21.ForeColor = System.Drawing.Color.White;
            this.storageItem21.Location = new System.Drawing.Point(69, 147);
            this.storageItem21.Name = "storageItem21";
            this.storageItem21.Size = new System.Drawing.Size(55, 54);
            this.storageItem21.TabIndex = 32;
            this.storageItem21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem21.UseVisualStyleBackColor = false;
            this.storageItem21.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem20
            // 
            this.storageItem20.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem20.ForeColor = System.Drawing.Color.White;
            this.storageItem20.Location = new System.Drawing.Point(7, 147);
            this.storageItem20.Name = "storageItem20";
            this.storageItem20.Size = new System.Drawing.Size(55, 54);
            this.storageItem20.TabIndex = 31;
            this.storageItem20.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem20.UseVisualStyleBackColor = false;
            this.storageItem20.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem19
            // 
            this.storageItem19.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem19.ForeColor = System.Drawing.Color.White;
            this.storageItem19.Location = new System.Drawing.Point(563, 85);
            this.storageItem19.Name = "storageItem19";
            this.storageItem19.Size = new System.Drawing.Size(55, 54);
            this.storageItem19.TabIndex = 30;
            this.storageItem19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem19.UseVisualStyleBackColor = false;
            this.storageItem19.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem18
            // 
            this.storageItem18.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem18.ForeColor = System.Drawing.Color.White;
            this.storageItem18.Location = new System.Drawing.Point(502, 85);
            this.storageItem18.Name = "storageItem18";
            this.storageItem18.Size = new System.Drawing.Size(55, 54);
            this.storageItem18.TabIndex = 29;
            this.storageItem18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem18.UseVisualStyleBackColor = false;
            this.storageItem18.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem17
            // 
            this.storageItem17.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem17.ForeColor = System.Drawing.Color.White;
            this.storageItem17.Location = new System.Drawing.Point(440, 85);
            this.storageItem17.Name = "storageItem17";
            this.storageItem17.Size = new System.Drawing.Size(55, 54);
            this.storageItem17.TabIndex = 28;
            this.storageItem17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem17.UseVisualStyleBackColor = false;
            this.storageItem17.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem16
            // 
            this.storageItem16.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem16.ForeColor = System.Drawing.Color.White;
            this.storageItem16.Location = new System.Drawing.Point(378, 85);
            this.storageItem16.Name = "storageItem16";
            this.storageItem16.Size = new System.Drawing.Size(55, 54);
            this.storageItem16.TabIndex = 27;
            this.storageItem16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem16.UseVisualStyleBackColor = false;
            this.storageItem16.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem15
            // 
            this.storageItem15.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem15.ForeColor = System.Drawing.Color.White;
            this.storageItem15.Location = new System.Drawing.Point(316, 85);
            this.storageItem15.Name = "storageItem15";
            this.storageItem15.Size = new System.Drawing.Size(55, 54);
            this.storageItem15.TabIndex = 26;
            this.storageItem15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem15.UseVisualStyleBackColor = false;
            this.storageItem15.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem14
            // 
            this.storageItem14.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem14.ForeColor = System.Drawing.Color.White;
            this.storageItem14.Location = new System.Drawing.Point(254, 85);
            this.storageItem14.Name = "storageItem14";
            this.storageItem14.Size = new System.Drawing.Size(55, 54);
            this.storageItem14.TabIndex = 25;
            this.storageItem14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem14.UseVisualStyleBackColor = false;
            this.storageItem14.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem13
            // 
            this.storageItem13.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem13.ForeColor = System.Drawing.Color.White;
            this.storageItem13.Location = new System.Drawing.Point(192, 85);
            this.storageItem13.Name = "storageItem13";
            this.storageItem13.Size = new System.Drawing.Size(55, 54);
            this.storageItem13.TabIndex = 24;
            this.storageItem13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem13.UseVisualStyleBackColor = false;
            this.storageItem13.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem12
            // 
            this.storageItem12.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem12.ForeColor = System.Drawing.Color.White;
            this.storageItem12.Location = new System.Drawing.Point(131, 85);
            this.storageItem12.Name = "storageItem12";
            this.storageItem12.Size = new System.Drawing.Size(55, 54);
            this.storageItem12.TabIndex = 23;
            this.storageItem12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem12.UseVisualStyleBackColor = false;
            this.storageItem12.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem11
            // 
            this.storageItem11.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem11.ForeColor = System.Drawing.Color.White;
            this.storageItem11.Location = new System.Drawing.Point(69, 85);
            this.storageItem11.Name = "storageItem11";
            this.storageItem11.Size = new System.Drawing.Size(55, 54);
            this.storageItem11.TabIndex = 22;
            this.storageItem11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem11.UseVisualStyleBackColor = false;
            this.storageItem11.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem10
            // 
            this.storageItem10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem10.ForeColor = System.Drawing.Color.White;
            this.storageItem10.Location = new System.Drawing.Point(7, 85);
            this.storageItem10.Name = "storageItem10";
            this.storageItem10.Size = new System.Drawing.Size(55, 54);
            this.storageItem10.TabIndex = 21;
            this.storageItem10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem10.UseVisualStyleBackColor = false;
            this.storageItem10.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem9
            // 
            this.storageItem9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem9.ForeColor = System.Drawing.Color.White;
            this.storageItem9.Location = new System.Drawing.Point(563, 22);
            this.storageItem9.Name = "storageItem9";
            this.storageItem9.Size = new System.Drawing.Size(55, 54);
            this.storageItem9.TabIndex = 20;
            this.storageItem9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem9.UseVisualStyleBackColor = false;
            this.storageItem9.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem8
            // 
            this.storageItem8.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem8.ForeColor = System.Drawing.Color.White;
            this.storageItem8.Location = new System.Drawing.Point(502, 22);
            this.storageItem8.Name = "storageItem8";
            this.storageItem8.Size = new System.Drawing.Size(55, 54);
            this.storageItem8.TabIndex = 19;
            this.storageItem8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem8.UseVisualStyleBackColor = false;
            this.storageItem8.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem7
            // 
            this.storageItem7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem7.ForeColor = System.Drawing.Color.White;
            this.storageItem7.Location = new System.Drawing.Point(440, 22);
            this.storageItem7.Name = "storageItem7";
            this.storageItem7.Size = new System.Drawing.Size(55, 54);
            this.storageItem7.TabIndex = 18;
            this.storageItem7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem7.UseVisualStyleBackColor = false;
            this.storageItem7.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem6
            // 
            this.storageItem6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem6.ForeColor = System.Drawing.Color.White;
            this.storageItem6.Location = new System.Drawing.Point(378, 22);
            this.storageItem6.Name = "storageItem6";
            this.storageItem6.Size = new System.Drawing.Size(55, 54);
            this.storageItem6.TabIndex = 17;
            this.storageItem6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem6.UseVisualStyleBackColor = false;
            this.storageItem6.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem5
            // 
            this.storageItem5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem5.ForeColor = System.Drawing.Color.White;
            this.storageItem5.Location = new System.Drawing.Point(316, 22);
            this.storageItem5.Name = "storageItem5";
            this.storageItem5.Size = new System.Drawing.Size(55, 54);
            this.storageItem5.TabIndex = 16;
            this.storageItem5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem5.UseVisualStyleBackColor = false;
            this.storageItem5.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem4
            // 
            this.storageItem4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem4.ForeColor = System.Drawing.Color.White;
            this.storageItem4.Location = new System.Drawing.Point(254, 22);
            this.storageItem4.Name = "storageItem4";
            this.storageItem4.Size = new System.Drawing.Size(55, 54);
            this.storageItem4.TabIndex = 15;
            this.storageItem4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem4.UseVisualStyleBackColor = false;
            this.storageItem4.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem3
            // 
            this.storageItem3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem3.ForeColor = System.Drawing.Color.White;
            this.storageItem3.Location = new System.Drawing.Point(192, 22);
            this.storageItem3.Name = "storageItem3";
            this.storageItem3.Size = new System.Drawing.Size(55, 54);
            this.storageItem3.TabIndex = 14;
            this.storageItem3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem3.UseVisualStyleBackColor = false;
            this.storageItem3.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem2
            // 
            this.storageItem2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem2.ForeColor = System.Drawing.Color.White;
            this.storageItem2.Location = new System.Drawing.Point(131, 22);
            this.storageItem2.Name = "storageItem2";
            this.storageItem2.Size = new System.Drawing.Size(55, 54);
            this.storageItem2.TabIndex = 13;
            this.storageItem2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem2.UseVisualStyleBackColor = false;
            this.storageItem2.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem1
            // 
            this.storageItem1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem1.ForeColor = System.Drawing.Color.White;
            this.storageItem1.Location = new System.Drawing.Point(69, 22);
            this.storageItem1.Name = "storageItem1";
            this.storageItem1.Size = new System.Drawing.Size(55, 54);
            this.storageItem1.TabIndex = 12;
            this.storageItem1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem1.UseVisualStyleBackColor = false;
            this.storageItem1.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // storageItem0
            // 
            this.storageItem0.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))),
                ((int) (((byte) (90)))), ((int) (((byte) (180)))));
            this.storageItem0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageItem0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.storageItem0.ForeColor = System.Drawing.Color.White;
            this.storageItem0.Location = new System.Drawing.Point(7, 22);
            this.storageItem0.Name = "storageItem0";
            this.storageItem0.Size = new System.Drawing.Size(55, 54);
            this.storageItem0.TabIndex = 11;
            this.storageItem0.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.storageItem0.UseVisualStyleBackColor = false;
            this.storageItem0.Enter += new System.EventHandler(this.storageItem_GotFocus);
            // 
            // itemFilterStorage
            // 
            this.itemFilterStorage.Location = new System.Drawing.Point(7, 7);
            this.itemFilterStorage.Name = "itemFilterStorage";
            this.itemFilterStorage.Size = new System.Drawing.Size(225, 435);
            this.itemFilterStorage.TabIndex = 0;
            // 
            // hairClrPictureBox
            // 
            this.hairClrPictureBox.Location = new System.Drawing.Point(0, 0);
            this.hairClrPictureBox.Name = "hairClrPictureBox";
            this.hairClrPictureBox.Size = new System.Drawing.Size(100, 50);
            this.hairClrPictureBox.TabIndex = 0;
            this.hairClrPictureBox.TabStop = false;
            // 
            // hairColorLbl
            // 
            this.hairColorLbl.Location = new System.Drawing.Point(0, 0);
            this.hairColorLbl.Name = "hairColorLbl";
            this.hairColorLbl.Size = new System.Drawing.Size(100, 23);
            this.hairColorLbl.TabIndex = 0;
            // 
            // eyeClrPictureBox
            // 
            this.eyeClrPictureBox.Location = new System.Drawing.Point(0, 0);
            this.eyeClrPictureBox.Name = "eyeClrPictureBox";
            this.eyeClrPictureBox.Size = new System.Drawing.Size(100, 50);
            this.eyeClrPictureBox.TabIndex = 0;
            this.eyeClrPictureBox.TabStop = false;
            // 
            // randomizeColorsBtn
            // 
            this.randomizeColorsBtn.Location = new System.Drawing.Point(0, 0);
            this.randomizeColorsBtn.Name = "randomizeColorsBtn";
            this.randomizeColorsBtn.Size = new System.Drawing.Size(75, 23);
            this.randomizeColorsBtn.TabIndex = 0;
            // 
            // eyeColorLbl
            // 
            this.eyeColorLbl.Location = new System.Drawing.Point(0, 0);
            this.eyeColorLbl.Name = "eyeColorLbl";
            this.eyeColorLbl.Size = new System.Drawing.Size(100, 23);
            this.eyeColorLbl.TabIndex = 0;
            // 
            // randomizeHairBtn
            // 
            this.randomizeHairBtn.Location = new System.Drawing.Point(0, 0);
            this.randomizeHairBtn.Name = "randomizeHairBtn";
            this.randomizeHairBtn.Size = new System.Drawing.Size(75, 23);
            this.randomizeHairBtn.TabIndex = 0;
            // 
            // skinClrPictureBox
            // 
            this.skinClrPictureBox.Location = new System.Drawing.Point(0, 0);
            this.skinClrPictureBox.Name = "skinClrPictureBox";
            this.skinClrPictureBox.Size = new System.Drawing.Size(100, 50);
            this.skinClrPictureBox.TabIndex = 0;
            this.skinClrPictureBox.TabStop = false;
            // 
            // hairDesignerBtn
            // 
            this.hairDesignerBtn.Location = new System.Drawing.Point(0, 0);
            this.hairDesignerBtn.Name = "hairDesignerBtn";
            this.hairDesignerBtn.Size = new System.Drawing.Size(75, 23);
            this.hairDesignerBtn.TabIndex = 0;
            // 
            // skinColorLbl
            // 
            this.skinColorLbl.Location = new System.Drawing.Point(0, 0);
            this.skinColorLbl.Name = "skinColorLbl";
            this.skinColorLbl.Size = new System.Drawing.Size(100, 23);
            this.skinColorLbl.TabIndex = 0;
            // 
            // shoeColorLbl
            // 
            this.shoeColorLbl.Location = new System.Drawing.Point(0, 0);
            this.shoeColorLbl.Name = "shoeColorLbl";
            this.shoeColorLbl.Size = new System.Drawing.Size(100, 23);
            this.shoeColorLbl.TabIndex = 0;
            // 
            // shirtClrPictureBox
            // 
            this.shirtClrPictureBox.Location = new System.Drawing.Point(0, 0);
            this.shirtClrPictureBox.Name = "shirtClrPictureBox";
            this.shirtClrPictureBox.Size = new System.Drawing.Size(100, 50);
            this.shirtClrPictureBox.TabIndex = 0;
            this.shirtClrPictureBox.TabStop = false;
            // 
            // pantsColorLbl
            // 
            this.pantsColorLbl.Location = new System.Drawing.Point(0, 0);
            this.pantsColorLbl.Name = "pantsColorLbl";
            this.pantsColorLbl.Size = new System.Drawing.Size(100, 23);
            this.pantsColorLbl.TabIndex = 0;
            // 
            // undershirtClrPictureBox
            // 
            this.undershirtClrPictureBox.Location = new System.Drawing.Point(0, 0);
            this.undershirtClrPictureBox.Name = "undershirtClrPictureBox";
            this.undershirtClrPictureBox.Size = new System.Drawing.Size(100, 50);
            this.undershirtClrPictureBox.TabIndex = 0;
            this.undershirtClrPictureBox.TabStop = false;
            // 
            // undershirtColorLbl
            // 
            this.undershirtColorLbl.Location = new System.Drawing.Point(0, 0);
            this.undershirtColorLbl.Name = "undershirtColorLbl";
            this.undershirtColorLbl.Size = new System.Drawing.Size(100, 23);
            this.undershirtColorLbl.TabIndex = 0;
            // 
            // pantsClrPictureBox
            // 
            this.pantsClrPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pantsClrPictureBox.Name = "pantsClrPictureBox";
            this.pantsClrPictureBox.Size = new System.Drawing.Size(100, 50);
            this.pantsClrPictureBox.TabIndex = 0;
            this.pantsClrPictureBox.TabStop = false;
            // 
            // shirtColorLbl
            // 
            this.shirtColorLbl.Location = new System.Drawing.Point(0, 0);
            this.shirtColorLbl.Name = "shirtColorLbl";
            this.shirtColorLbl.Size = new System.Drawing.Size(100, 23);
            this.shirtColorLbl.TabIndex = 0;
            // 
            // shoeClrPictureBox
            // 
            this.shoeClrPictureBox.Location = new System.Drawing.Point(0, 0);
            this.shoeClrPictureBox.Name = "shoeClrPictureBox";
            this.shoeClrPictureBox.Size = new System.Drawing.Size(100, 50);
            this.shoeClrPictureBox.TabIndex = 0;
            this.shoeClrPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(436, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Social Acc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(524, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Accessories";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 663);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Terraria Inventory Editor - v1.0.0.0";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.statsTab.ResumeLayout(false);
            this.healthManaGroupBox.ResumeLayout(false);
            this.healthManaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.playerBindingSource)).EndInit();
            this.playerInfoGroupBox.ResumeLayout(false);
            this.playerInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.upDownAnglerQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.upDownSkinVariant)).EndInit();
            this.appearanceGroupBox.ResumeLayout(false);
            this.appearanceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShoeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPantsColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxUndershirtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShirtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxEyeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxSkinColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxHairColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.playerPictureBox)).EndInit();
            this.appearanceTab.ResumeLayout(false);
            this.appearanceTab.PerformLayout();
            this.equipmentFilterGroupBox.ResumeLayout(false);
            this.equipmentFilterGroupBox.PerformLayout();
            this.buffsTab.ResumeLayout(false);
            this.groupBoxBuffControls.ResumeLayout(false);
            this.groupBoxBuffControls.PerformLayout();
            this.groupBoxActiveBuffs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.gridViewBuffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.buffsBindingSource)).EndInit();
            this.inventoryTab.ResumeLayout(false);
            this.inventoryTab.PerformLayout();
            this.groupBoxItemProperties.ResumeLayout(false);
            this.groupBoxItemProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.upDownStackSize)).EndInit();
            this.inventoryFilterGroupBox.ResumeLayout(false);
            this.tabPageStorage.ResumeLayout(false);
            this.groupBoxForge.ResumeLayout(false);
            this.groupBoxSafe.ResumeLayout(false);
            this.groupBoxPiggyItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.hairClrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.eyeClrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.skinClrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.shirtClrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.undershirtClrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pantsClrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.shoeClrPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolstripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolstripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolstripMenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolstripMenuItemExit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.TabPage appearanceTab;
        private System.Windows.Forms.GroupBox healthManaGroupBox;
        private System.Windows.Forms.Button buttonMaxOut;
        private System.Windows.Forms.Button buttonResetDefaults;
        private System.Windows.Forms.ProgressBar manaBar;
        private System.Windows.Forms.TextBox textBoxMaxMana;
        private System.Windows.Forms.TextBox textBoxCurrentMana;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.TextBox textBoxMaxHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.TextBox textBoxCurrentHealth;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.GroupBox playerInfoGroupBox;
        private System.Windows.Forms.Label anglerLbl;
        private System.Windows.Forms.Label skinVariantLbl;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Label difficultyLbl;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.NumericUpDown upDownSkinVariant;
        private System.Windows.Forms.NumericUpDown upDownAnglerQuests;
        private System.Windows.Forms.TextBox textBoxPlayTime;
        private System.Windows.Forms.Label playTimeLbl;
        private System.Windows.Forms.Label taxMoneyLbl;
        private System.Windows.Forms.CheckBox checkBoxExtraAccessory;
        private System.Windows.Forms.TextBox textBoxTaxMoney;
        private System.Windows.Forms.CheckBox checkBoxHotbarLocked;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.ToolStripMenuItem toolstripMenuItemNew;
        private System.Windows.Forms.PictureBox hairClrPictureBox;
        private System.Windows.Forms.Label hairColorLbl;
        private System.Windows.Forms.PictureBox shoeClrPictureBox;
        private System.Windows.Forms.PictureBox pantsClrPictureBox;
        private System.Windows.Forms.PictureBox undershirtClrPictureBox;
        private System.Windows.Forms.PictureBox shirtClrPictureBox;
        private System.Windows.Forms.Label skinColorLbl;
        private System.Windows.Forms.PictureBox skinClrPictureBox;
        private System.Windows.Forms.Label eyeColorLbl;
        private System.Windows.Forms.PictureBox eyeClrPictureBox;
        private System.Windows.Forms.Label shoeColorLbl;
        private System.Windows.Forms.Label pantsColorLbl;
        private System.Windows.Forms.Label undershirtColorLbl;
        private System.Windows.Forms.Label shirtColorLbl;
        private System.Windows.Forms.Button hairDesignerBtn;
        private System.Windows.Forms.Button randomizeColorsBtn;
        private System.Windows.Forms.Button randomizeHairBtn;
        private System.Windows.Forms.TabPage buffsTab;
        private System.Windows.Forms.GroupBox groupBoxActiveBuffs;
        private System.Windows.Forms.DataGridView gridViewBuffs;
        private System.Windows.Forms.BindingSource buffsBindingSource;
        private System.Windows.Forms.GroupBox groupBoxBuffControls;
        private System.Windows.Forms.Button buttonMaxAllBuffs;
        private System.Windows.Forms.Button buttonMaxBuff;
        private System.Windows.Forms.Button buttonDeleteAllBuffs;
        private System.Windows.Forms.ListBox listBoxBuffs;
        private System.Windows.Forms.TextBox textBoxBuffName;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button inventoryItem49;
        private System.Windows.Forms.Button inventoryItem48;
        private System.Windows.Forms.Button inventoryItem47;
        private System.Windows.Forms.Button inventoryItem46;
        private System.Windows.Forms.Button inventoryItem45;
        private System.Windows.Forms.Button inventoryItem44;
        private System.Windows.Forms.Button inventoryItem43;
        private System.Windows.Forms.Button inventoryItem42;
        private System.Windows.Forms.Button inventoryItem41;
        private System.Windows.Forms.Button inventoryItem40;
        private System.Windows.Forms.Button inventoryItem39;
        private System.Windows.Forms.Button inventoryItem38;
        private System.Windows.Forms.Button inventoryItem37;
        private System.Windows.Forms.Button inventoryItem36;
        private System.Windows.Forms.Button inventoryItem35;
        private System.Windows.Forms.Button inventoryItem34;
        private System.Windows.Forms.Button inventoryItem33;
        private System.Windows.Forms.Button inventoryItem32;
        private System.Windows.Forms.Button inventoryItem31;
        private System.Windows.Forms.Button inventoryItem30;
        private System.Windows.Forms.Button inventoryItem29;
        private System.Windows.Forms.Button inventoryItem28;
        private System.Windows.Forms.Button inventoryItem27;
        private System.Windows.Forms.Button inventoryItem26;
        private System.Windows.Forms.Button inventoryItem25;
        private System.Windows.Forms.Button inventoryItem24;
        private System.Windows.Forms.Button inventoryItem23;
        private System.Windows.Forms.Button inventoryItem22;
        private System.Windows.Forms.Button inventoryItem21;
        private System.Windows.Forms.Button inventoryItem20;
        private System.Windows.Forms.Button inventoryItem19;
        private System.Windows.Forms.Button inventoryItem18;
        private System.Windows.Forms.Button inventoryItem17;
        private System.Windows.Forms.Button inventoryItem16;
        private System.Windows.Forms.Button inventoryItem15;
        private System.Windows.Forms.Button inventoryItem14;
        private System.Windows.Forms.Button inventoryItem13;
        private System.Windows.Forms.Button inventoryItem12;
        private System.Windows.Forms.Button inventoryItem11;
        private System.Windows.Forms.Button inventoryItem10;
        private System.Windows.Forms.Button inventoryItem9;
        private System.Windows.Forms.Button inventoryItem8;
        private System.Windows.Forms.Button inventoryItem7;
        private System.Windows.Forms.Button inventoryItem6;
        private System.Windows.Forms.Button inventoryItem5;
        private System.Windows.Forms.Button inventoryItem4;
        private System.Windows.Forms.Button inventoryItem3;
        private System.Windows.Forms.Button inventoryItem2;
        private System.Windows.Forms.Button inventoryItem1;
        private System.Windows.Forms.Button inventoryItem0;
        private System.Windows.Forms.GroupBox groupBoxItemProperties;
        private System.Windows.Forms.Button buttonDeleteAllItems;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonMaxAllStacks;
        private System.Windows.Forms.Button buttonMaxStack;
        private System.Windows.Forms.NumericUpDown upDownStackSize;
        private System.Windows.Forms.Label stackSizeLbl;
        private System.Windows.Forms.ComboBox comboBoxItemPrefix;
        private System.Windows.Forms.Label itemPrefixLbl;
        private System.Windows.Forms.Button inventoryItem53;
        private System.Windows.Forms.Button inventoryItem52;
        private System.Windows.Forms.Button inventoryItem51;
        private System.Windows.Forms.Button inventoryItem50;
        private System.Windows.Forms.Button inventoryItem57;
        private System.Windows.Forms.Button inventoryItem56;
        private System.Windows.Forms.Button inventoryItem55;
        private System.Windows.Forms.Button inventoryItem54;
        private System.Windows.Forms.Label ammoLbl;
        private System.Windows.Forms.Label coinsLbl;
        private System.Windows.Forms.Button buttonDeleteBuff;
        private System.Windows.Forms.GroupBox equipmentFilterGroupBox;
        private System.Windows.Forms.Button dyeItem0;
        private System.Windows.Forms.TextBox textBoxEquipName;
        private System.Windows.Forms.Label labelSearchForEquip;
        private System.Windows.Forms.ListBox listBoxEquips;
        private System.Windows.Forms.GroupBox appearanceGroupBox;
        private System.Windows.Forms.Label dyeLbl;
        private System.Windows.Forms.Button dyeItem2;
        private System.Windows.Forms.Button dyeItem1;
        private System.Windows.Forms.Label armorLbl;
        private System.Windows.Forms.Label socialsLbl;
        private System.Windows.Forms.Button equipmentItem10;
        private System.Windows.Forms.Button equipmentItem7;
        private System.Windows.Forms.Button equipmentItem6;
        private System.Windows.Forms.Button equipmentItem5;
        private System.Windows.Forms.Button equipmentItem4;
        private System.Windows.Forms.Button equipmentItem3;
        private System.Windows.Forms.Button equipmentItem2;
        private System.Windows.Forms.Button equipmentItem1;
        private System.Windows.Forms.Button equipmentItem0;
        private System.Windows.Forms.Button equipmentItem17;
        private System.Windows.Forms.Button equipmentItem16;
        private System.Windows.Forms.Button equipmentItem15;
        private System.Windows.Forms.Button equipmentItem14;
        private System.Windows.Forms.Button equipmentItem13;
        private System.Windows.Forms.Button equipmentItem12;
        private System.Windows.Forms.Button equipmentItem11;
        private System.Windows.Forms.Button equipmentItem18;
        private System.Windows.Forms.Button equipmentItem8;
        private System.Windows.Forms.Button dyeItem8;
        private System.Windows.Forms.Button dyeItem7;
        private System.Windows.Forms.Button dyeItem6;
        private System.Windows.Forms.Button dyeItem5;
        private System.Windows.Forms.Button dyeItem4;
        private System.Windows.Forms.Button dyeItem3;
        private System.Windows.Forms.PictureBox pictureBoxUndershirtColor;
        private System.Windows.Forms.Label labelUndershirtColor;
        private System.Windows.Forms.PictureBox pictureBoxShirtColor;
        private System.Windows.Forms.Label labelShirtColor;
        private System.Windows.Forms.PictureBox pictureBoxEyeColor;
        private System.Windows.Forms.Label labelEyeColor;
        private System.Windows.Forms.PictureBox pictureBoxSkinColor;
        private System.Windows.Forms.Label labelSkinColor;
        private System.Windows.Forms.PictureBox pictureBoxHairColor;
        private System.Windows.Forms.Label labelHairColor;
        private System.Windows.Forms.PictureBox pictureBoxShoeColor;
        private System.Windows.Forms.Label labelShoeColor;
        private System.Windows.Forms.PictureBox pictureBoxPantsColor;
        private System.Windows.Forms.Label labelPantsColor;
        private System.Windows.Forms.Button buttonRandomColors;
        private System.Windows.Forms.Button buttonRandomHair;
        private System.Windows.Forms.Button buttonEditHair;
        private System.Windows.Forms.TabPage tabPageStorage;
        private System.Windows.Forms.GroupBox inventoryFilterGroupBox;
        private System.Windows.Forms.GroupBox groupBoxForge;
        private System.Windows.Forms.Button storageItem119;
        private System.Windows.Forms.Button storageItem118;
        private System.Windows.Forms.Button storageItem117;
        private System.Windows.Forms.Button storageItem116;
        private System.Windows.Forms.Button storageItem115;
        private System.Windows.Forms.Button storageItem114;
        private System.Windows.Forms.Button storageItem113;
        private System.Windows.Forms.Button storageItem112;
        private System.Windows.Forms.Button storageItem111;
        private System.Windows.Forms.Button storageItem110;
        private System.Windows.Forms.Button storageItem109;
        private System.Windows.Forms.Button storageItem108;
        private System.Windows.Forms.Button storageItem107;
        private System.Windows.Forms.Button storageItem106;
        private System.Windows.Forms.Button storageItem105;
        private System.Windows.Forms.Button storageItem104;
        private System.Windows.Forms.Button storageItem103;
        private System.Windows.Forms.Button storageItem102;
        private System.Windows.Forms.Button storageItem101;
        private System.Windows.Forms.Button storageItem100;
        private System.Windows.Forms.Button storageItem99;
        private System.Windows.Forms.Button storageItem98;
        private System.Windows.Forms.Button storageItem97;
        private System.Windows.Forms.Button storageItem96;
        private System.Windows.Forms.Button storageItem95;
        private System.Windows.Forms.Button storageItem94;
        private System.Windows.Forms.Button storageItem93;
        private System.Windows.Forms.Button storageItem92;
        private System.Windows.Forms.Button storageItem91;
        private System.Windows.Forms.Button storageItem90;
        private System.Windows.Forms.Button storageItem89;
        private System.Windows.Forms.Button storageItem88;
        private System.Windows.Forms.Button storageItem87;
        private System.Windows.Forms.Button storageItem86;
        private System.Windows.Forms.Button storageItem85;
        private System.Windows.Forms.Button storageItem84;
        private System.Windows.Forms.Button storageItem83;
        private System.Windows.Forms.Button storageItem82;
        private System.Windows.Forms.Button storageItem81;
        private System.Windows.Forms.Button storageItem80;
        private System.Windows.Forms.GroupBox groupBoxSafe;
        private System.Windows.Forms.Button storageItem79;
        private System.Windows.Forms.Button storageItem78;
        private System.Windows.Forms.Button storageItem77;
        private System.Windows.Forms.Button storageItem76;
        private System.Windows.Forms.Button storageItem75;
        private System.Windows.Forms.Button storageItem74;
        private System.Windows.Forms.Button storageItem73;
        private System.Windows.Forms.Button storageItem72;
        private System.Windows.Forms.Button storageItem71;
        private System.Windows.Forms.Button storageItem70;
        private System.Windows.Forms.Button storageItem69;
        private System.Windows.Forms.Button storageItem68;
        private System.Windows.Forms.Button storageItem67;
        private System.Windows.Forms.Button storageItem66;
        private System.Windows.Forms.Button storageItem65;
        private System.Windows.Forms.Button storageItem64;
        private System.Windows.Forms.Button storageItem63;
        private System.Windows.Forms.Button storageItem62;
        private System.Windows.Forms.Button storageItem61;
        private System.Windows.Forms.Button storageItem60;
        private System.Windows.Forms.Button storageItem59;
        private System.Windows.Forms.Button storageItem58;
        private System.Windows.Forms.Button storageItem57;
        private System.Windows.Forms.Button storageItem56;
        private System.Windows.Forms.Button storageItem55;
        private System.Windows.Forms.Button storageItem54;
        private System.Windows.Forms.Button storageItem53;
        private System.Windows.Forms.Button storageItem52;
        private System.Windows.Forms.Button storageItem51;
        private System.Windows.Forms.Button storageItem50;
        private System.Windows.Forms.Button storageItem49;
        private System.Windows.Forms.Button storageItem48;
        private System.Windows.Forms.Button storageItem47;
        private System.Windows.Forms.Button storageItem46;
        private System.Windows.Forms.Button storageItem45;
        private System.Windows.Forms.Button storageItem44;
        private System.Windows.Forms.Button storageItem43;
        private System.Windows.Forms.Button storageItem42;
        private System.Windows.Forms.Button storageItem41;
        private System.Windows.Forms.Button storageItem40;
        private System.Windows.Forms.GroupBox groupBoxPiggyItems;
        private System.Windows.Forms.Button storageItem39;
        private System.Windows.Forms.Button storageItem38;
        private System.Windows.Forms.Button storageItem37;
        private System.Windows.Forms.Button storageItem36;
        private System.Windows.Forms.Button storageItem35;
        private System.Windows.Forms.Button storageItem34;
        private System.Windows.Forms.Button storageItem33;
        private System.Windows.Forms.Button storageItem32;
        private System.Windows.Forms.Button storageItem31;
        private System.Windows.Forms.Button storageItem30;
        private System.Windows.Forms.Button storageItem29;
        private System.Windows.Forms.Button storageItem28;
        private System.Windows.Forms.Button storageItem27;
        private System.Windows.Forms.Button storageItem26;
        private System.Windows.Forms.Button storageItem25;
        private System.Windows.Forms.Button storageItem24;
        private System.Windows.Forms.Button storageItem23;
        private System.Windows.Forms.Button storageItem22;
        private System.Windows.Forms.Button storageItem21;
        private System.Windows.Forms.Button storageItem20;
        private System.Windows.Forms.Button storageItem19;
        private System.Windows.Forms.Button storageItem18;
        private System.Windows.Forms.Button storageItem17;
        private System.Windows.Forms.Button storageItem16;
        private System.Windows.Forms.Button storageItem15;
        private System.Windows.Forms.Button storageItem14;
        private System.Windows.Forms.Button storageItem13;
        private System.Windows.Forms.Button storageItem12;
        private System.Windows.Forms.Button storageItem11;
        private System.Windows.Forms.Button storageItem10;
        private System.Windows.Forms.Button storageItem9;
        private System.Windows.Forms.Button storageItem8;
        private System.Windows.Forms.Button storageItem7;
        private System.Windows.Forms.Button storageItem6;
        private System.Windows.Forms.Button storageItem5;
        private System.Windows.Forms.Button storageItem4;
        private System.Windows.Forms.Button storageItem3;
        private System.Windows.Forms.Button storageItem2;
        private System.Windows.Forms.Button storageItem1;
        private System.Windows.Forms.Button storageItem0;
        private System.Windows.Forms.Button buttonDeleteAllStorageItems;
        private System.Windows.Forms.Button buttonDeleteStorageItem;
        private TerrariaInventoryEditor.Framework.ItemFilterControl itemFilterInventory;
        private TerrariaInventoryEditor.Framework.ItemFilterControl itemFilterStorage;
        private TerrariaInventoryEditor.Framework.PlayerPictureBox playerPictureBox;
        private System.Windows.Forms.Button btnSaveAppearance;
        private System.Windows.Forms.Button btnLoadAppearance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

