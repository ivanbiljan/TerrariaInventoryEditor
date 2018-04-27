using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TerrariaInventoryEditor.Framework
{
    /// <summary>
    ///     Represents a textbox control which supports placeholder values.
    /// </summary>
    public sealed class PlaceholderTextBox : TextBox
    {
        private string _placeholder;

        public PlaceholderTextBox()
        {
            GotFocus += PlaceholderTextBox_GotFocus;
            LostFocus += PlaceholderTextBox_LostFocus;

            ForeColor = Color.Gray;
        }

        /// <summary>
        ///     Gets or sets the placeholder.
        /// </summary>
        [Category("Appearance")]
        [Description("The placeholder value associated with this control.")]
        public string Placeholder
        {
            get => _placeholder;
            set
            {
                _placeholder = value;
                if (string.IsNullOrWhiteSpace(Text))
                {
                    Text = value;
                }
            }
        }

        private void PlaceholderTextBox_GotFocus(object sender, EventArgs e)
        {
            ForeColor = SystemColors.ControlText;
            Text = string.Empty;
        }

        private void PlaceholderTextBox_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Text))
            {
                return;
            }

            ForeColor = Color.Gray;
            Text = Placeholder;
        }
    }
}