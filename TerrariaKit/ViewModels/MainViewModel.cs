using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
using TerrariaKit.Core.Models;
using TerrariaKit.Services;

namespace TerrariaKit.ViewModels {
    internal sealed class MainViewModel : ViewModelBase<Character>
    {
        private readonly ObservableCollection<ViewModelBase> _childViewModels;
        
        public MainViewModel()
        {
            _childViewModels = new ObservableCollection<ViewModelBase>
            {
                new CharacterViewModel(this)
            };
        }
        
        public ICommand LoadPlayerCommand => new DelegateCommand(OpenPlayerFileDialog);

        public ObservableCollection<ViewModelBase> ChildViewModels => _childViewModels;

        private void OpenPlayerFileDialog(object? obj) {
            var openFileDialog = new OpenFileDialog {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments,
                    Environment.SpecialFolderOption.None),
                Filter = "Terraria Player Files (*.plr)|*.plr"
            };

            if (openFileDialog.ShowDialog() != true) {
                return;
            }

            // TODO: set up DI
            var playerFileService = new PlayerFileService(new LocalizationService());
            var playerFile = playerFileService.Read(openFileDialog.FileName);
            Load(playerFile.Data);
            
            // Something about this approach doesn't feel right. Calling OnPropertyChanged with a null argument
            // indicates that all properties of an object have changed. This forces views
            // to refresh when a new player is loaded
            foreach (var child in ChildViewModels)
            {
                child.OnPropertyChanged(null);
            }
        }
    }
}
