using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TerrariaInventoryEditor.Annotations;

namespace TerrariaInventoryEditor.Framework
{
    /// <summary>
    ///     The base class for data source objects which automatically invokes the PropertyChanged event.
    /// </summary>
    public abstract class DataSourceObject : INotifyPropertyChanged
    {
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        /// <summary>
        ///     Occurs when a property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <typeparam name="T">The property's type.</typeparam>
        /// <param name="propertyName">The property's name, which defaults to the caller.</param>
        /// <returns>The property's value.</returns>
        public T Get<T>([CallerMemberName] string propertyName = null)
        {
            Debug.Assert(propertyName != null, "Property name must not be null.");

            return _properties.TryGetValue(propertyName, out var returnValue) ? (T) returnValue : default(T);
        }

        /// <summary>
        ///     Sets the value of the specified property and invokes the PropertyChanged event.
        /// </summary>
        /// <typeparam name="T">The property's type.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="propertyName">The property's name, which defaults to the caller.</param>
        public void Set<T>(T value, [CallerMemberName] string propertyName = null)
        {
            Debug.Assert(propertyName != null, "Property name must not be null.");

            if (EqualityComparer<T>.Default.Equals(value, Get<T>(propertyName)))
            {
                return;
            }

            _properties[propertyName] = value;
            OnPropertyChanged(propertyName);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}