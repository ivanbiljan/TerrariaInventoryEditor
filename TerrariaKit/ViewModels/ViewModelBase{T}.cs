using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TerrariaKit.Annotations;

namespace TerrariaKit.ViewModels
{
    /// <summary>
    /// Represents the base class for a ViewModel.
    /// </summary>
    /// <typeparam name="T">The type of model this ViewModel encapsulates.</typeparam>
    internal abstract class ViewModelBase<T> : INotifyPropertyChanged where T : class, new()
    {
        private readonly IDictionary<string, object?> _propertyNameToValueMapping = new Dictionary<string, object?>();

        public event PropertyChangedEventHandler? PropertyChanged;

        public T Model { get; protected set; } = new T();

        public TProperty Get<TProperty>([CallerMemberName] string? name = null)
        {
            return (_propertyNameToValueMapping.TryGetValue(name!, out var obj) && obj != null ? (TProperty) obj : default)!;
        }

        public void Set<TProperty>(TProperty value, [CallerMemberName] string? name = null)
        {
            if (EqualityComparer<TProperty>.Default.Equals(Get<TProperty>(name), value))
            {
                return;
            }

            _propertyNameToValueMapping[name!] = value;
            OnPropertyChanged(name!);
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}