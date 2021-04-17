using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TerrariaKit {
    internal sealed class DelegateCommand : ICommand
    {
        private readonly Action<object?> _callback;
        private readonly Func<object?, bool>? _canExecute;

        public DelegateCommand(Action<object?> callback, Func<object?, bool>? executionCondition = null)
        {
            _callback = callback ?? throw new ArgumentNullException(nameof(callback));
            _canExecute = executionCondition;
        }

        /// <inheritdoc />
        public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? false;

        /// <inheritdoc />
        public void Execute(object? parameter) => _callback(parameter);

        /// <inheritdoc />
        public event EventHandler? CanExecuteChanged;
    }
}
