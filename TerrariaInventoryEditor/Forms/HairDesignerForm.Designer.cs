namespace TerrariaInventoryEditor.Forms
{
    partial class HairDesignerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HairDesignerForm));
            this.hairDisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueLabel = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.hairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.redUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.selectedHairUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hairDisplayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedHairUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // hairDisplayPictureBox
            // 
            this.hairDisplayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hairDisplayPictureBox.Location = new System.Drawing.Point(13, 13);
            this.hairDisplayPictureBox.Name = "hairDisplayPictureBox";
            this.hairDisplayPictureBox.Size = new System.Drawing.Size(164, 175);
            this.hairDisplayPictureBox.TabIndex = 0;
            this.hairDisplayPictureBox.TabStop = false;
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(234, 13);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(182, 45);
            this.redTrackBar.TabIndex = 4;
            this.redTrackBar.ValueChanged += new System.EventHandler(this.clrTrackBar_ValueChanged);
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(194, 20);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(33, 15);
            this.redLabel.TabIndex = 6;
            this.redLabel.Text = "Red:";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.Location = new System.Drawing.Point(183, 71);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(44, 15);
            this.greenLabel.TabIndex = 9;
            this.greenLabel.Text = "Green:";
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(234, 64);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(182, 45);
            this.greenTrackBar.TabIndex = 7;
            this.greenTrackBar.ValueChanged += new System.EventHandler(this.clrTrackBar_ValueChanged);
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Location = new System.Drawing.Point(192, 121);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(35, 15);
            this.blueLabel.TabIndex = 12;
            this.blueLabel.Text = "Blue:";
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(234, 114);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(182, 45);
            this.blueTrackBar.TabIndex = 10;
            this.blueTrackBar.ValueChanged += new System.EventHandler(this.clrTrackBar_ValueChanged);
            // 
            // redUpDown
            // 
            this.redUpDown.Location = new System.Drawing.Point(422, 20);
            this.redUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redUpDown.Name = "redUpDown";
            this.redUpDown.Size = new System.Drawing.Size(62, 20);
            this.redUpDown.TabIndex = 13;
            this.redUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clrTxtBox_KeyPress);
            // 
            // greenUpDown
            // 
            this.greenUpDown.Location = new System.Drawing.Point(422, 71);
            this.greenUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenUpDown.Name = "greenUpDown";
            this.greenUpDown.Size = new System.Drawing.Size(62, 20);
            this.greenUpDown.TabIndex = 14;
            this.greenUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clrTxtBox_KeyPress);
            // 
            // blueUpDown
            // 
            this.blueUpDown.Location = new System.Drawing.Point(422, 121);
            this.blueUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueUpDown.Name = "blueUpDown";
            this.blueUpDown.Size = new System.Drawing.Size(62, 20);
            this.blueUpDown.TabIndex = 15;
            this.blueUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clrTxtBox_KeyPress);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(408, 218);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(327, 218);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 17;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // selectedHairUpDown
            // 
            this.selectedHairUpDown.Location = new System.Drawing.Point(13, 194);
            this.selectedHairUpDown.Maximum = new decimal(new int[] {
            134,
            0,
            0,
            0});
            this.selectedHairUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedHairUpDown.Name = "selectedHairUpDown";
            this.selectedHairUpDown.Size = new System.Drawing.Size(164, 20);
            this.selectedHairUpDown.TabIndex = 18;
            this.selectedHairUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedHairUpDown.ValueChanged += new System.EventHandler(this.selectedHairUpDown_ValueChanged);
            // 
            // HairDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 253);
            this.Controls.Add(this.selectedHairUpDown);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.blueUpDown);
            this.Controls.Add(this.greenUpDown);
            this.Controls.Add(this.redUpDown);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.hairDisplayPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HairDesignerForm";
            this.Text = "Hair Designer";
            ((System.ComponentModel.ISupportInitialize)(this.hairDisplayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedHairUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hairDisplayPictureBox;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.BindingSource hairBindingSource;
        private System.Windows.Forms.NumericUpDown redUpDown;
        private System.Windows.Forms.NumericUpDown greenUpDown;
        private System.Windows.Forms.NumericUpDown blueUpDown;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.NumericUpDown selectedHairUpDown;
    }
}