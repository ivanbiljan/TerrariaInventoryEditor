using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TerrariaInventoryEditor
{
    /// <summary>
    ///     Represesnts the hair designer form.
    /// </summary>
    public partial class HairDesignerForm : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="HairDesignerForm" /> class.
        /// </summary>
        public HairDesignerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="HairDesignerForm" /> class with the specified hair ID and colour.
        /// </summary>
        /// <param name="hairId">The hair ID.</param>
        /// <param name="hairColor">The hair colour.</param>
        public HairDesignerForm(int hairId, Color hairColor)
        {
            InitializeComponent();

            HairId = hairId + 1;
            HairColor = hairColor;

            selectedHairUpDown.DataBindings.Add(new Binding("Value", this, nameof(HairId), true,
                DataSourceUpdateMode.OnPropertyChanged));

            redTrackBar.DataBindings.Add(
                new Binding("Value", HairColor, "R", true, DataSourceUpdateMode.Never)
                {
                    ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
                });
            greenTrackBar.DataBindings.Add(
                new Binding("Value", HairColor, "G", true, DataSourceUpdateMode.Never)
                {
                    ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
                });
            blueTrackBar.DataBindings.Add(
                new Binding("Value", HairColor, "B", true, DataSourceUpdateMode.Never)
                {
                    ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
                });

            redUpDown.DataBindings.Add(new Binding("Value", redTrackBar, "Value", true,
                DataSourceUpdateMode.OnPropertyChanged));
            greenUpDown.DataBindings.Add(new Binding("Value", greenTrackBar, "Value", true,
                DataSourceUpdateMode.OnPropertyChanged));
            blueUpDown.DataBindings.Add(new Binding("Value", blueTrackBar, "Value", true,
                DataSourceUpdateMode.OnPropertyChanged));

            DrawHair();
        }

        /// <summary>
        ///     Gets or sets the currently selected hair colour.
        /// </summary>
        public Color HairColor { get; set; } = Color.FromArgb(215, 90, 55);

        /// <summary>
        ///     Gets or sets the currently selected hair's ID.
        /// </summary>
        public int HairId { get; set; }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void clrTrackBar_ValueChanged(object sender, EventArgs e)
        {
            HairColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            DrawHair();
        }

        private void clrTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char) Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void DrawHair()
        {
            var hairBitmap = new Bitmap($"Data\\HairTextures\\Player_Hair_{HairId}.png");
            for (var x = 0; x < hairBitmap.Width; ++x)
            {
                for (var y = 0; y < hairBitmap.Height; ++y)
                {
                    var pixel = hairBitmap.GetPixel(x, y);
                    if (pixel == Color.FromArgb(0, 0, 0, 0))
                    {
                        continue;
                    }

                    if (pixel == Color.FromArgb(249, 249, 249))
                    {
                        hairBitmap.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        hairBitmap.SetPixel(x, y,
                            Color.FromArgb(pixel.R * HairColor.R / 255, pixel.G * HairColor.G / 255,
                                pixel.B * HairColor.B / 255));
                    }
                }
            }

            var newBitmap = new Bitmap(hairBitmap.Width * 4, hairBitmap.Height * 4);
            using (var gfx = Graphics.FromImage(newBitmap))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                gfx.DrawImage(hairBitmap, 0, 0, newBitmap.Width, newBitmap.Height);
            }

            hairDisplayPictureBox.Image = newBitmap;
            GC.Collect();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void selectedHairUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!(sender is NumericUpDown upDownControl))
            {
                return;
            }

            HairId = (int) upDownControl.Value;
            DrawHair();
        }
    }
}