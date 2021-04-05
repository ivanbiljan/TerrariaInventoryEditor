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
    internal abstract class ViewModelBase<T> : INotifyPropertyChanged where T : class
    {
        private readonly IDictionary<string, object?> _propertyNameToValueMapping = new Dictionary<string, object?>();

        public event PropertyChangedEventHandler? PropertyChanged;

        public T Get<T>([CallerMemberName] string? name = null)
        {
            return (_propertyNameToValueMapping.TryGetValue(name!, out var obj) && obj != null ? (T) obj : default)!;
        }

        public void Set<T>(T value, [CallerMemberName] string? name = null)
        {
            if (EqualityComparer<T>.Default.Equals(Get<T>(name), value))
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