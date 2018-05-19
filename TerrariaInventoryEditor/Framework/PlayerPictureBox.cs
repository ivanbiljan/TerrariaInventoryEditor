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

        private bool _canDraw;
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
        ///     Re-allows drawing to the control.
        /// </summary>
        public void AllowUpdates()
        {
            _canDraw = true;
            Draw();
        }

        /// <summary>
        ///     Draws the current character onto the control.
        /// </summary>
        public void Draw()
        {
            if (!_canDraw)
            {
                return;
            }

            // Colorize texture files using appropriate colors
            _hairTexture = GetColoredImage(new Bitmap($"Data\\HairTextures\\Player_Hair_{HairId + 1}.png"), HairColor);
            _headTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Head),
                SkinColor);
            _eyeWhitesTexture = GetColoredImage(
                TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.EyeWhites),
                EyeWhitesColor);
            _eyeTexture = GetColoredImage(TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Eyes),
                EyeColor);
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
                    gfx.DrawImage(_legsTexture, 0, 0, _legsTexture.Width * 3.75F, _legsTexture.Height * 3.75F);
                }

                gfx.DrawImage(_headTexture, 0, 0, _headTexture.Width * 3.75F, _headTexture.Height * 3.75F);
                gfx.DrawImage(_hairTexture, 0, 0, _hairTexture.Width * 3.75F, _hairTexture.Height * 3.75F);
                gfx.DrawImage(_eyeWhitesTexture, 0, 0, _eyeWhitesTexture.Width * 3.75F,
                    _eyeWhitesTexture.Height * 3.75F);
                gfx.DrawImage(_eyeTexture, 0, 0, _eyeTexture.Width * 3.75F, -_eyeTexture.Height * 3.75F);
                gfx.DrawImage(_torsoTexture, 0, 0, _torsoTexture.Width * 3.75F, _torsoTexture.Height * 3.75F);
                gfx.DrawImage(_undershirtTexture, 0, 0, _undershirtTexture.Width * 3.75F,
                    _undershirtTexture.Height * 3.75F);
                gfx.DrawImage(_handsTexture, 0, 0, _handsTexture.Width * 3.75F, _handsTexture.Height * 3.75F);
                gfx.DrawImage(_shirtTexture, 0, 0, _shirtTexture.Width * 3.75F, _shirtTexture.Height * 3.75F);
                gfx.DrawImage(_armSkinTexture, 0, 0, _armSkinTexture.Width * 3.75F, _armSkinTexture.Height * 3.75F);
                gfx.DrawImage(_armUndershirtTexture, 0, 0, _armUndershirtTexture.Width * 3.75F,
                    _armUndershirtTexture.Height * 3.75F);
                gfx.DrawImage(_armHandTexture, 0, 0, _armHandTexture.Width * 3.75F, _armHandTexture.Height * 3.75F);
                gfx.DrawImage(_legsTexture, 0, 0, _legsTexture.Width * 3.75F, _legsTexture.Height * 3.75F);
                gfx.DrawImage(_pantsTexture, 0, 0, _pantsTexture.Width * 3.75F, _pantsTexture.Height * 3.75F);
                gfx.DrawImage(_shoeTexture, 0, 0, _shoeTexture.Width * 3.75F, _shoeTexture.Height * 3.75F);
                gfx.DrawImage(_armShirtTexture, 0, 0, _armShirtTexture.Width * 3.75F, _armShirtTexture.Height * 3.75F);

                if (TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Extras) != null)
                {
                    _extrasTexture = GetColoredImage(
                        TextureManager.Instance.GetTexture(SkinVariant, PlayerTexture.Extras),
                        ShirtColor);
                    gfx.DrawImage(_extrasTexture, 0, 0, _extrasTexture.Width * 3.75F, _extrasTexture.Height * 3.75F);
                }
            }

            Image = characterImage;
        }

        /// <summary>
        ///     Prevents drawing to the control.
        /// </summary>
        public void PreventUpdates()
        {
            _canDraw = false;
        }
    }
}