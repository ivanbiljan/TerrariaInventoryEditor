using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TerrariaInventoryEditor.TerrariaLib;

namespace TerrariaInventoryEditor.Framework
{
    /// <summary>
    ///     Represents a PlayerPictureBox control in charge of displaying Terraria characters.
    /// </summary>
    public sealed class PlayerPictureBox : PictureBox
    {
        private static readonly string EyeTextureFile = "Data\\Player\\eyes.png";
        private static readonly string EyeWhitesTextureFile = "Data\\Player\\eyewhites.png";
        private static readonly string HandsTextureFile = "Data\\Player\\hands.png";
        private static readonly string HeadTextureFile = "Data\\Player\\head.png";
        private static readonly string LegsTextureFile = "Data\\Player\\Female\\legs.png"; // Only drawn if character is female

        private Bitmap _eyeTexture;
        private Bitmap _eyeWhitesTexture;
        private Bitmap _hairTexture;
        private Bitmap _handsTexture;
        private Bitmap _headTexture;
        private Bitmap _legsTexture;
        private Bitmap _pantsTexture;
        private Bitmap _shirtTexture;
        private Bitmap _shoeTexture;
        private Bitmap _undershirtTexture;

        /// <summary>
        ///     Gets or sets the character's eye colour.
        /// </summary>
        public Color EyeColor { get; set; } = Color.FromArgb(105, 90, 75);

        /// <summary>
        ///     Gets or sets the character's eye whites colour.
        /// </summary>
        public Color EyeWhitesColor { get; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        ///     Gets or sets the character's hair colour.
        /// </summary>
        public Color HairColor { get; set; } = Color.FromArgb(215, 90, 55);

        /// <summary>
        /// Gets or set sthe character's hair ID.
        /// </summary>
        public int HairId { get; set; }

        /// <summary>
        ///     Gets or sets the character's hair texture file path.
        /// </summary>
        public string HairTextureFile { get; set; } = "Data\\Hair\\Player_Hair_1.png";

        /// <summary>
        ///     Gets or sets the character's pants colour.
        /// </summary>
        public Color PantsColor { get; set; } = Color.FromArgb(255, 230, 175);

        /// <summary>
        ///     Gets or sets the character's shirt colour.
        /// </summary>
        public Color ShirtColor { get; set; } = Color.FromArgb(175, 165, 140);

        /// <summary>
        ///     Gets or sets the character's shoe colour.
        /// </summary>
        public Color ShoeColor { get; set; } = Color.FromArgb(160, 105, 60);

        /// <summary>
        ///     Gets or sets the character's skin colour.
        /// </summary>
        public Color SkinColor { get; set; } = Color.FromArgb(255, 125, 90);

        /// <summary>
        ///     Gets or sets the character's skin variant.
        /// </summary>
        public int SkinVariant { get; set; }

        /// <summary>
        ///     Gets or sets the character's undershirt colour.
        /// </summary>
        public Color UndershirtColor { get; set; } = Color.FromArgb(160, 180, 215);

        private static Bitmap ColorImage(Bitmap image, Color color)
        {
            for (var x = 0; x < image.Width; ++x)
            {
                for (var y = 0; y < image.Height; y++)
                {
                    var currentPixel = image.GetPixel(x, y);
                    if (currentPixel == Color.FromArgb(0, 0, 0, 0))
                    {
                        continue;
                    }

                    if (currentPixel == Color.FromArgb(249, 249, 249))
                    {
                        image.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        image.SetPixel(x, y,
                            Color.FromArgb(currentPixel.R * color.R / 255, currentPixel.G * color.G / 255,
                                currentPixel.B * color.B / 255));
                    }
                }
            }

            return image;
        }

        /// <summary>
        ///     Draws the current character onto the control.
        /// </summary>
        public void Draw()
        {
            _eyeTexture = ColorImage(new Bitmap(EyeTextureFile), EyeColor);
            _eyeWhitesTexture = ColorImage(new Bitmap(EyeWhitesTextureFile), EyeWhitesColor);
            _hairTexture = ColorImage(new Bitmap($"Data\\Hair\\Player_Hair_{HairId + 1}.png"), HairColor);
            _handsTexture = ColorImage(new Bitmap(HandsTextureFile), SkinColor);
            _headTexture = ColorImage(new Bitmap(HeadTextureFile), SkinColor);
            _legsTexture = ColorImage(new Bitmap(LegsTextureFile), SkinColor);

            var pantsTextureFile = $"Data\\Player\\{(SkinVariant < 4 ? "pants.png" : "Female\\pants.png")}";
            _pantsTexture = ColorImage(new Bitmap(pantsTextureFile), PantsColor);

            var shirtTextureFile = $"Data\\Player\\{(SkinVariant < 4 ? "shirt.png" : "Female\\shirt.png")}";
            _shirtTexture = ColorImage(new Bitmap(shirtTextureFile), ShirtColor);

            var shoeTextureFile = $"Data\\Player\\{(SkinVariant < 4 ? "shoes.png" : "Female\\shoes.png")}";
            _shoeTexture = ColorImage(new Bitmap(shoeTextureFile), ShoeColor);

            var undershirtTextureFile =
                $"Data\\Player\\{(SkinVariant < 4 ? "undershirt.png" : "Female\\undershirt.png")}";
            _undershirtTexture = ColorImage(new Bitmap(undershirtTextureFile), UndershirtColor);

            var character = new Bitmap(Width, Height);
            using (var gfx = Graphics.FromImage(character))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;

                if (SkinVariant > 3)
                {
                    gfx.DrawImage(_legsTexture, 0, 0, _legsTexture.Width * 3.75F, _legsTexture.Height * 3.75F);
                }

                gfx.DrawImage(_pantsTexture, 0, 0, _pantsTexture.Width * 3.75F, _pantsTexture.Height * 3.75F);
                gfx.DrawImage(_shoeTexture, 0, 0, _shoeTexture.Width * 3.75F, _shoeTexture.Height * 3.75F);
                gfx.DrawImage(_shirtTexture, 0, 0, _shirtTexture.Width * 3.75F, _shirtTexture.Height * 3.75F);
                gfx.DrawImage(_undershirtTexture, 0, 0, _undershirtTexture.Width * 3.75F,
                    _undershirtTexture.Height * 3.75F);
                gfx.DrawImage(_handsTexture, 0, 0, _handsTexture.Width * 3.75F, _handsTexture.Height * 3.75F);
                gfx.DrawImage(_headTexture, 0, 0, _headTexture.Width * 3.75F, _headTexture.Height * 3.75F);
                gfx.DrawImage(_eyeTexture, 0, 0, _eyeTexture.Width * 3.75F, _eyeTexture.Height * 3.75F);
                gfx.DrawImage(_eyeWhitesTexture, 0, 0, _eyeWhitesTexture.Width * 3.75F, _eyeWhitesTexture.Height * 3.75F);
                gfx.DrawImage(_hairTexture, 0, 0, _hairTexture.Width * 3.75F, _hairTexture.Height * 3.75F);
            }

            Image = character;
        }
    }
}