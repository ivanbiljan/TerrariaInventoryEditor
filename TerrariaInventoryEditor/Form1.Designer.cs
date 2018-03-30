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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.maxManaBox = new System.Windows.Forms.TextBox();
            this.currentManaBox = new System.Windows.Forms.TextBox();
            this.manaLabel = new System.Windows.Forms.Label();
            this.maxHealthBox = new System.Windows.Forms.TextBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.currentHealthBox = new System.Windows.Forms.TextBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anglerTxtBox = new System.Windows.Forms.TextBox();
            this.anglerLbl = new System.Windows.Forms.Label();
            this.extraAccCmbBox = new System.Windows.Forms.ComboBox();
            this.extraAccLbl = new System.Windows.Forms.Label();
            this.skinVariantLbl = new System.Windows.Forms.Label();
            this.difficultyCmbBox = new System.Windows.Forms.ComboBox();
            this.difficultyLbl = new System.Windows.Forms.Label();
            this.playerNameTxtBox = new System.Windows.Forms.TextBox();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.skinVariantUpDown = new System.Windows.Forms.NumericUpDown();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
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
            this.tabControl1.Size = new System.Drawing.Size(596, 332);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 306);
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
            this.groupBox2.Location = new System.Drawing.Point(264, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 167);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Health and Mana";
            // 
            // maxOutBtn
            // 
            this.maxOutBtn.Location = new System.Drawing.Point(166, 138);
            this.maxOutBtn.Name = "maxOutBtn";
            this.maxOutBtn.Size = new System.Drawing.Size(110, 23);
            this.maxOutBtn.TabIndex = 9;
            this.maxOutBtn.Text = "Max Out";
            this.maxOutBtn.UseVisualStyleBackColor = true;
            // 
            // resetHealthBtn
            // 
            this.resetHealthBtn.Location = new System.Drawing.Point(10, 138);
            this.resetHealthBtn.Name = "resetHealthBtn";
            this.resetHealthBtn.Size = new System.Drawing.Size(110, 23);
            this.resetHealthBtn.TabIndex = 8;
            this.resetHealthBtn.Text = "Restore Defaults";
            this.resetHealthBtn.UseVisualStyleBackColor = true;
            // 
            // manaBar
            // 
            this.manaBar.Location = new System.Drawing.Point(10, 98);
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(266, 23);
            this.manaBar.TabIndex = 7;
            // 
            // maxManaBox
            // 
            this.maxManaBox.Location = new System.Drawing.Point(176, 72);
            this.maxManaBox.Name = "maxManaBox";
            this.maxManaBox.Size = new System.Drawing.Size(100, 20);
            this.maxManaBox.TabIndex = 6;
            // 
            // currentManaBox
            // 
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
            this.maxHealthBox.Location = new System.Drawing.Point(176, 17);
            this.maxHealthBox.Name = "maxHealthBox";
            this.maxHealthBox.Size = new System.Drawing.Size(100, 20);
            this.maxHealthBox.TabIndex = 3;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(10, 43);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(266, 23);
            this.healthBar.TabIndex = 2;
            // 
            // currentHealthBox
            // 
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
            this.groupBox1.Controls.Add(this.skinVariantUpDown);
            this.groupBox1.Controls.Add(this.anglerTxtBox);
            this.groupBox1.Controls.Add(this.anglerLbl);
            this.groupBox1.Controls.Add(this.extraAccCmbBox);
            this.groupBox1.Controls.Add(this.extraAccLbl);
            this.groupBox1.Controls.Add(this.skinVariantLbl);
            this.groupBox1.Controls.Add(this.difficultyCmbBox);
            this.groupBox1.Controls.Add(this.difficultyLbl);
            this.groupBox1.Controls.Add(this.playerNameTxtBox);
            this.groupBox1.Controls.Add(this.playerNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 167);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Information";
            // 
            // anglerTxtBox
            // 
            this.anglerTxtBox.Location = new System.Drawing.Point(127, 127);
            this.anglerTxtBox.Name = "anglerTxtBox";
            this.anglerTxtBox.Size = new System.Drawing.Size(119, 20);
            this.anglerTxtBox.TabIndex = 29;
            // 
            // anglerLbl
            // 
            this.anglerLbl.AutoSize = true;
            this.anglerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anglerLbl.Location = new System.Drawing.Point(15, 128);
            this.anglerLbl.Name = "anglerLbl";
            this.anglerLbl.Size = new System.Drawing.Size(109, 16);
            this.anglerLbl.TabIndex = 28;
            this.anglerLbl.Text = "Angler Quests:";
            // 
            // extraAccCmbBox
            // 
            this.extraAccCmbBox.FormattingEnabled = true;
            this.extraAccCmbBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.extraAccCmbBox.Location = new System.Drawing.Point(127, 100);
            this.extraAccCmbBox.Name = "extraAccCmbBox";
            this.extraAccCmbBox.Size = new System.Drawing.Size(119, 21);
            this.extraAccCmbBox.TabIndex = 27;
            // 
            // extraAccLbl
            // 
            this.extraAccLbl.AutoSize = true;
            this.extraAccLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraAccLbl.Location = new System.Drawing.Point(0, 101);
            this.extraAccLbl.Name = "extraAccLbl";
            this.extraAccLbl.Size = new System.Drawing.Size(124, 16);
            this.extraAccLbl.TabIndex = 26;
            this.extraAccLbl.Text = "Extra Accessory:";
            // 
            // skinVariantLbl
            // 
            this.skinVariantLbl.AutoSize = true;
            this.skinVariantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinVariantLbl.Location = new System.Drawing.Point(27, 76);
            this.skinVariantLbl.Name = "skinVariantLbl";
            this.skinVariantLbl.Size = new System.Drawing.Size(95, 16);
            this.skinVariantLbl.TabIndex = 24;
            this.skinVariantLbl.Text = "Skin Variant:";
            // 
            // difficultyCmbBox
            // 
            this.difficultyCmbBox.FormattingEnabled = true;
            this.difficultyCmbBox.Items.AddRange(new object[] {
            "Softcore",
            "Mediumcore",
            "Hardcore"});
            this.difficultyCmbBox.Location = new System.Drawing.Point(127, 46);
            this.difficultyCmbBox.Name = "difficultyCmbBox";
            this.difficultyCmbBox.Size = new System.Drawing.Size(119, 21);
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
            this.playerNameTxtBox.Location = new System.Drawing.Point(127, 20);
            this.playerNameTxtBox.Name = "playerNameTxtBox";
            this.playerNameTxtBox.Size = new System.Drawing.Size(119, 20);
            this.playerNameTxtBox.TabIndex = 21;
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
            this.tabPage2.Size = new System.Drawing.Size(588, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appearance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // skinVariantUpDown
            // 
            this.skinVariantUpDown.Location = new System.Drawing.Point(128, 74);
            this.skinVariantUpDown.Name = "skinVariantUpDown";
            this.skinVariantUpDown.Size = new System.Drawing.Size(118, 20);
            this.skinVariantUpDown.TabIndex = 30;
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
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::TerrariaInventoryEditor.Properties.Resources.save_as;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 372);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox anglerTxtBox;
        private System.Windows.Forms.Label anglerLbl;
        private System.Windows.Forms.ComboBox extraAccCmbBox;
        private System.Windows.Forms.Label extraAccLbl;
        private System.Windows.Forms.Label skinVariantLbl;
        private System.Windows.Forms.ComboBox difficultyCmbBox;
        private System.Windows.Forms.Label difficultyLbl;
        private System.Windows.Forms.TextBox playerNameTxtBox;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.NumericUpDown skinVariantUpDown;
    }
}

