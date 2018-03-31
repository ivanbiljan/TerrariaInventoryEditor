namespace TerrariaInventoryEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxOutBtn = new System.Windows.Forms.Button();
            this.resetHealthBtn = new System.Windows.Forms.Button();
            this.manaBar = new System.Windows.Forms.ProgressBar();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maxManaBox = new System.Windows.Forms.TextBox();
            this.currentManaBox = new System.Windows.Forms.TextBox();
            this.manaLabel = new System.Windows.Forms.Label();
            this.maxHealthBox = new System.Windows.Forms.TextBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.currentHealthBox = new System.Windows.Forms.TextBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotbarCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.taxMoneyLbl = new System.Windows.Forms.Label();
            this.extraAccCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playTimeLbl = new System.Windows.Forms.Label();
            this.anglerQuestUpDown = new System.Windows.Forms.NumericUpDown();
            this.skinVariantUpDown = new System.Windows.Forms.NumericUpDown();
            this.anglerLbl = new System.Windows.Forms.Label();
            this.skinVariantLbl = new System.Windows.Forms.Label();
            this.difficultyCmbBox = new System.Windows.Forms.ComboBox();
            this.difficultyLbl = new System.Windows.Forms.Label();
            this.playerNameTxtBox = new System.Windows.Forms.TextBox();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anglerQuestUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinVariantUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::TerrariaInventoryEditor.Properties.Resources.open_file;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::TerrariaInventoryEditor.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::TerrariaInventoryEditor.Properties.Resources.save_as;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxOutBtn);
            this.groupBox2.Controls.Add(this.resetHealthBtn);
            this.groupBox2.Controls.Add(this.manaBar);
            this.groupBox2.Controls.Add(this.maxManaBox);
            this.groupBox2.Controls.Add(this.currentManaBox);
            this.groupBox2.Controls.Add(this.manaLabel);
            this.groupBox2.Controls.Add(this.maxHealthBox);
            this.groupBox2.Controls.Add(this.healthBar);
            this.groupBox2.Controls.Add(this.currentHealthBox);
            this.groupBox2.Controls.Add(this.healthLabel);
            this.groupBox2.Location = new System.Drawing.Point(343, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 194);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Health and Mana";
            // 
            // maxOutBtn
            // 
            this.maxOutBtn.Location = new System.Drawing.Point(166, 155);
            this.maxOutBtn.Name = "maxOutBtn";
            this.maxOutBtn.Size = new System.Drawing.Size(110, 23);
            this.maxOutBtn.TabIndex = 9;
            this.maxOutBtn.Text = "Max Out";
            this.maxOutBtn.UseVisualStyleBackColor = true;
            // 
            // resetHealthBtn
            // 
            this.resetHealthBtn.Location = new System.Drawing.Point(10, 155);
            this.resetHealthBtn.Name = "resetHealthBtn";
            this.resetHealthBtn.Size = new System.Drawing.Size(110, 23);
            this.resetHealthBtn.TabIndex = 8;
            this.resetHealthBtn.Text = "Restore Defaults";
            this.resetHealthBtn.UseVisualStyleBackColor = true;
            // 
            // manaBar
            // 
            this.manaBar.BackColor = System.Drawing.SystemColors.Control;
            this.manaBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource, "Mana", true));
            this.manaBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.playerBindingSource, "MaxMana", true));
            this.manaBar.Location = new System.Drawing.Point(10, 98);
            this.manaBar.Maximum = 20;
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(266, 23);
            this.manaBar.TabIndex = 7;
            this.manaBar.Value = 20;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(TerrariaInventoryEditor.Terraria.Player);
            // 
            // maxManaBox
            // 
            this.maxManaBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "MaxMana", true));
            this.maxManaBox.Location = new System.Drawing.Point(176, 72);
            this.maxManaBox.Name = "maxManaBox";
            this.maxManaBox.Size = new System.Drawing.Size(100, 20);
            this.maxManaBox.TabIndex = 6;
            // 
            // currentManaBox
            // 
            this.currentManaBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Mana", true));
            this.currentManaBox.Location = new System.Drawing.Point(70, 72);
            this.currentManaBox.Name = "currentManaBox";
            this.currentManaBox.Size = new System.Drawing.Size(100, 20);
            this.currentManaBox.TabIndex = 5;
            // 
            // manaLabel
            // 
            this.manaLabel.AutoSize = true;
            this.manaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaLabel.Location = new System.Drawing.Point(14, 74);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(50, 16);
            this.manaLabel.TabIndex = 4;
            this.manaLabel.Text = "Mana:";
            // 
            // maxHealthBox
            // 
            this.maxHealthBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "MaxHealth", true));
            this.maxHealthBox.Location = new System.Drawing.Point(176, 17);
            this.maxHealthBox.Name = "maxHealthBox";
            this.maxHealthBox.Size = new System.Drawing.Size(100, 20);
            this.maxHealthBox.TabIndex = 3;
            // 
            // healthBar
            // 
            this.healthBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource, "Health", true));
            this.healthBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.playerBindingSource, "MaxHealth", true));
            this.healthBar.Location = new System.Drawing.Point(10, 43);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(266, 23);
            this.healthBar.TabIndex = 2;
            this.healthBar.Value = 100;
            // 
            // currentHealthBox
            // 
            this.currentHealthBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Health", true));
            this.currentHealthBox.Location = new System.Drawing.Point(70, 17);
            this.currentHealthBox.Name = "currentHealthBox";
            this.currentHealthBox.Size = new System.Drawing.Size(100, 20);
            this.currentHealthBox.TabIndex = 1;
            this.currentHealthBox.TextChanged += new System.EventHandler(this.currentHealthBox_TextChanged);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(7, 20);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(57, 16);
            this.healthLabel.TabIndex = 0;
            this.healthLabel.Text = "Health:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotbarCheckBox);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.taxMoneyLbl);
            this.groupBox1.Controls.Add(this.extraAccCheckBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.playTimeLbl);
            this.groupBox1.Controls.Add(this.anglerQuestUpDown);
            this.groupBox1.Controls.Add(this.skinVariantUpDown);
            this.groupBox1.Controls.Add(this.anglerLbl);
            this.groupBox1.Controls.Add(this.skinVariantLbl);
            this.groupBox1.Controls.Add(this.difficultyCmbBox);
            this.groupBox1.Controls.Add(this.difficultyLbl);
            this.groupBox1.Controls.Add(this.playerNameTxtBox);
            this.groupBox1.Controls.Add(this.playerNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 194);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Information";
            // 
            // hotbarCheckBox
            // 
            this.hotbarCheckBox.AutoSize = true;
            this.hotbarCheckBox.Location = new System.Drawing.Point(211, 136);
            this.hotbarCheckBox.Name = "hotbarCheckBox";
            this.hotbarCheckBox.Size = new System.Drawing.Size(97, 17);
            this.hotbarCheckBox.TabIndex = 37;
            this.hotbarCheckBox.Text = "Hotbar Locked";
            this.hotbarCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "TaxMoney", true));
            this.textBox2.Location = new System.Drawing.Point(126, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 36;
            // 
            // taxMoneyLbl
            // 
            this.taxMoneyLbl.AutoSize = true;
            this.taxMoneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxMoneyLbl.Location = new System.Drawing.Point(34, 163);
            this.taxMoneyLbl.Name = "taxMoneyLbl";
            this.taxMoneyLbl.Size = new System.Drawing.Size(88, 16);
            this.taxMoneyLbl.TabIndex = 35;
            this.taxMoneyLbl.Text = "Tax Money:";
            // 
            // extraAccCheckBox
            // 
            this.extraAccCheckBox.AutoSize = true;
            this.extraAccCheckBox.Location = new System.Drawing.Point(211, 110);
            this.extraAccCheckBox.Name = "extraAccCheckBox";
            this.extraAccCheckBox.Size = new System.Drawing.Size(102, 17);
            this.extraAccCheckBox.TabIndex = 34;
            this.extraAccCheckBox.Text = "Extra Accessory";
            this.extraAccCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "PlayTime", true));
            this.textBox1.Location = new System.Drawing.Point(127, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 33;
            // 
            // playTimeLbl
            // 
            this.playTimeLbl.AutoSize = true;
            this.playTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playTimeLbl.Location = new System.Drawing.Point(42, 77);
            this.playTimeLbl.Name = "playTimeLbl";
            this.playTimeLbl.Size = new System.Drawing.Size(82, 16);
            this.playTimeLbl.TabIndex = 32;
            this.playTimeLbl.Text = "Play Time:";
            // 
            // anglerQuestUpDown
            // 
            this.anglerQuestUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource, "AnglerQuestsFinished", true));
            this.anglerQuestUpDown.Location = new System.Drawing.Point(126, 135);
            this.anglerQuestUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.anglerQuestUpDown.Name = "anglerQuestUpDown";
            this.anglerQuestUpDown.Size = new System.Drawing.Size(79, 20);
            this.anglerQuestUpDown.TabIndex = 31;
            // 
            // skinVariantUpDown
            // 
            this.skinVariantUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource, "SkinVariant", true));
            this.skinVariantUpDown.Location = new System.Drawing.Point(126, 109);
            this.skinVariantUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.skinVariantUpDown.Name = "skinVariantUpDown";
            this.skinVariantUpDown.Size = new System.Drawing.Size(79, 20);
            this.skinVariantUpDown.TabIndex = 30;
            // 
            // anglerLbl
            // 
            this.anglerLbl.AutoSize = true;
            this.anglerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anglerLbl.Location = new System.Drawing.Point(13, 135);
            this.anglerLbl.Name = "anglerLbl";
            this.anglerLbl.Size = new System.Drawing.Size(109, 16);
            this.anglerLbl.TabIndex = 28;
            this.anglerLbl.Text = "Angler Quests:";
            // 
            // skinVariantLbl
            // 
            this.skinVariantLbl.AutoSize = true;
            this.skinVariantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinVariantLbl.Location = new System.Drawing.Point(27, 109);
            this.skinVariantLbl.Name = "skinVariantLbl";
            this.skinVariantLbl.Size = new System.Drawing.Size(95, 16);
            this.skinVariantLbl.TabIndex = 24;
            this.skinVariantLbl.Text = "Skin Variant:";
            // 
            // difficultyCmbBox
            // 
            this.difficultyCmbBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Difficulty", true));
            this.difficultyCmbBox.FormattingEnabled = true;
            this.difficultyCmbBox.Items.AddRange(new object[] {
            "Softcore",
            "Mediumcore",
            "Hardcore"});
            this.difficultyCmbBox.Location = new System.Drawing.Point(127, 46);
            this.difficultyCmbBox.Name = "difficultyCmbBox";
            this.difficultyCmbBox.Size = new System.Drawing.Size(179, 21);
            this.difficultyCmbBox.TabIndex = 23;
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.AutoSize = true;
            this.difficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLbl.Location = new System.Drawing.Point(49, 47);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(75, 16);
            this.difficultyLbl.TabIndex = 22;
            this.difficultyLbl.Text = "Difficulty: ";
            // 
            // playerNameTxtBox
            // 
            this.playerNameTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Name", true));
            this.playerNameTxtBox.Location = new System.Drawing.Point(127, 20);
            this.playerNameTxtBox.Name = "playerNameTxtBox";
            this.playerNameTxtBox.Size = new System.Drawing.Size(179, 20);
            this.playerNameTxtBox.TabIndex = 21;
            this.playerNameTxtBox.Leave += new System.EventHandler(this.playerNameTxtBox_Leave);
            this.playerNameTxtBox.Validated += new System.EventHandler(this.playerNameTxtBox_Validated);
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLbl.Location = new System.Drawing.Point(21, 21);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(103, 16);
            this.playerNameLbl.TabIndex = 20;
            this.playerNameLbl.Text = "Player name: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appearance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 417);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Terraria Inventory Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anglerQuestUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinVariantUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button maxOutBtn;
        private System.Windows.Forms.Button resetHealthBtn;
        private System.Windows.Forms.ProgressBar manaBar;
        private System.Windows.Forms.TextBox maxManaBox;
        private System.Windows.Forms.TextBox currentManaBox;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.TextBox maxHealthBox;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.TextBox currentHealthBox;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label anglerLbl;
        private System.Windows.Forms.Label skinVariantLbl;
        private System.Windows.Forms.ComboBox difficultyCmbBox;
        private System.Windows.Forms.Label difficultyLbl;
        private System.Windows.Forms.TextBox playerNameTxtBox;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.NumericUpDown skinVariantUpDown;
        private System.Windows.Forms.NumericUpDown anglerQuestUpDown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label playTimeLbl;
        private System.Windows.Forms.Label taxMoneyLbl;
        private System.Windows.Forms.CheckBox extraAccCheckBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox hotbarCheckBox;
        private System.Windows.Forms.BindingSource playerBindingSource;
    }
}

