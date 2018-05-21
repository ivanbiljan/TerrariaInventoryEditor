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
        private Bitmap _armHandTexture;
        private Bitmap _armShirtTexture;
        private Bitmap _armSkinTexture;
        private Bitmap _armUndershirtTexture;
        private Bitmap _extrasTexture;
        private Bitmap _eyeTexture;
        private Bitmap _eyeWhitesTexture;
        private Bitmap _hairTexture;
        private Bitmap _handsTexture;
        private Bitmap _headTexture;
        private Bitmap _legsTexture;
        private Bitmap _pantsTexture;
        private Bitmap _shirtTexture;
        private Bitmap _shoeTexture;
        private Bitmap _torsoTexture;
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
        ///     Gets or set sthe character's hair ID.
        /// </summary>
        public int HairId { get; set; }

        /// <summary>
        ///     Gets or sets the character's hair texture file path.
        /// </summary>
        public string HairTextureFile { get; set; } = "Data\\HairTextures\\Player_Hair_1.png";

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

        private static Bitmap GetColoredImage(Bitmap image, Color color)
        {
            for (var x = 0; x < image.Width; ++x)
            {
                for (var y = 0; y < image.Height; ++y)
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
            // Colorize texture files using appropriate colors
            _hairTexture = GetColoredImage(new Bitmap($"Data\\HairTextures\\Player_Hair_{HairId + 1}.png"), HairColor);
            _headTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Head),
                SkinColor);
            _eyeTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Eyes),
                EyeColor);
            _eyeWhitesTexture = GetColoredImage(
                TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.EyeWhites), EyeWhitesColor);
            _torsoTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Torso),
                SkinColor);
            _undershirtTexture = GetColoredImage(
                TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Undershirt),
                UndershirtColor);
            _handsTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Hands),
                SkinColor);
            _shirtTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Shirt),
                ShirtColor);
            _armSkinTexture =
                GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.ArmSkin), SkinColor);
            _armUndershirtTexture =
                GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.ArmUndershirt),
                    UndershirtColor);
            _armHandTexture =
                GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.ArmHand), SkinColor);
            _legsTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.LegSkin),
                SkinColor);
            _pantsTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Pants),
                PantsColor);
            _shoeTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Shoes),
                ShoeColor);
            _armShirtTexture =
                GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.ArmShirt), ShirtColor);

            // Draw the character
            var characterImage = new Bitmap(Width, Height);
            using (var gfx = Graphics.FromImage(characterImage))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;

                if (SkinVariant > 3 && SkinVariant != 8)
                {
                    gfx.DrawImage(_legsTexture, 0, 0, _legsTexture.Width * 4, _legsTexture.Height * 4);
                }

                gfx.DrawImage(_headTexture, 0, 0, _headTexture.Width * 4, _headTexture.Height * 4);
                gfx.DrawImage(_hairTexture, 0, 0, _hairTexture.Width * 4, _hairTexture.Height * 4);
                gfx.DrawImage(_eyeWhitesTexture, 0, 0, _eyeWhitesTexture.Width * 4,
                    _eyeWhitesTexture.Height * 4);
                gfx.DrawImage(_eyeTexture, 0, 0, _eyeTexture.Width * 4, _eyeTexture.Height * 4);
                gfx.DrawImage(_torsoTexture, 0, 0, _torsoTexture.Width * 4, _torsoTexture.Height * 4);
                gfx.DrawImage(_undershirtTexture, 0, 0, _undershirtTexture.Width * 4,
                    _undershirtTexture.Height * 4);
                gfx.DrawImage(_handsTexture, 0, 0, _handsTexture.Width * 4, _handsTexture.Height * 4);
                gfx.DrawImage(_shirtTexture, 0, 0, _shirtTexture.Width * 4, _shirtTexture.Height * 4);
                gfx.DrawImage(_armSkinTexture, 0, 0, _armSkinTexture.Width * 4, _armSkinTexture.Height * 4);
                gfx.DrawImage(_armUndershirtTexture, 0, 0, _armUndershirtTexture.Width * 4,
                    _armUndershirtTexture.Height * 4);
                gfx.DrawImage(_armHandTexture, 0, 0, _armHandTexture.Width * 4, _armHandTexture.Height * 4);
                gfx.DrawImage(_legsTexture, 0, 0, _legsTexture.Width * 4, _legsTexture.Height * 4);
                gfx.DrawImage(_pantsTexture, 0, 0, _pantsTexture.Width * 4, _pantsTexture.Height * 4);
                gfx.DrawImage(_shoeTexture, 0, 0, _shoeTexture.Width * 4, _shoeTexture.Height * 4);
                gfx.DrawImage(_armShirtTexture, 0, 0, _armShirtTexture.Width * 4, _armShirtTexture.Height * 4);

                if (TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Extras) != null)
                {
                    _extrasTexture = GetColoredImage(
                        TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Extras),
                        ShirtColor);
                    gfx.DrawImage(_extrasTexture, 0, 0, _extrasTexture.Width * 4, _extrasTexture.Height * 4);
                }
            }

            Image = characterImage;
        }
    }
}