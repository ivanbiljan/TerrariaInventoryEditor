using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using TerrariaInventoryEditor.Annotations;

namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Represents a Terraria buff.
    /// </summary>
    public sealed class Buff : INotifyPropertyChanged
    {
        private int _buffId;

        private string _description = "N/A";

        private Bitmap _image = new Bitmap("Data\\BuffTextures\\Buff_0.png");

        private string _name = "Inactive";

        private int _time = 3600;

        /// <summary>
        ///     Gets or sets the buff's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get => _description;
            set
            {
                if (value == _description)
                {
                    return;
                }

                _description = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the buff's ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get => _buffId;
            set
            {
                if (value == _buffId)
                {
                    return;
                }

                _buffId = value;
                _image = new Bitmap($"Data\\BuffTextures\\Buff_{value}.png");
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the buff's image.
        /// </summary>
        public Bitmap Image
        {
            get => _image;
            set
            {
                if (value == _image)
                {
                    return;
                }

                _image = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the buff's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => _name;
            set
            {
                if (value == _name)
                {
                    return;
                }

                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the buff's duration time.
        /// </summary>
        [JsonProperty("time")]
        public int Time
        {
            get => _time;
            set
            {
                if (value == _time)
                {
                    return;
                }

                _time = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Occurs when a property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Constructs the buff based on the specified buff ID.
        /// </summary>
        /// <param name="buffId">The buff ID.</param>
        public void SetDefaults(int buffId)
        {
            Debug.Assert(buffId >= 0, "Buff ID must not be negative.");
            Debug.Assert(buffId < Terraria.Instance.Buffs.Count,
                "Buff ID must not be greater than the size of buff collection.");

            var buff = Terraria.Instance.Buffs.SingleOrDefault(b => b.Id == buffId);
            if (buff == null)
            {
                return;
            }

            Description = buff.Description;
            Id = buff.Id;
            Name = buff.Name;
        }

        /// <summary>
        ///     Returns the string representation of this buff.
        /// </summary>
        /// <returns>The string representation of this buff.</returns>
        public override string ToString()
        {
            return Name;
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}