using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrariaKit.Core.Models;

namespace TerrariaKit.ViewModels
{
    internal sealed class CharacterViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainViewModel;

        public CharacterViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public string Name
        {
            get => _mainViewModel.Model.Name;
            set
            {
                _mainViewModel.Model.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public byte Difficulty
        {
            get => (byte) _mainViewModel.Model.Difficulty;
            set
            {
                _mainViewModel.Model.Difficulty = (CharacterDifficulty) value;
                OnPropertyChanged(nameof(Difficulty));
            }
        }

        public string Playtime
        {
            get => _mainViewModel.Model.PlayTime.ToString();
            set
            {
                if (!TimeSpan.TryParse(value, out var span))
                {
                    return;
                }

                _mainViewModel.Model.PlayTime = span;
                OnPropertyChanged(nameof(Playtime));
            }
        }

        public byte SkinVariant
        {
            get => _mainViewModel.Model.SkinVariant;
            set
            {
                _mainViewModel.Model.SkinVariant = value;
                OnPropertyChanged(nameof(SkinVariant));
            }
        }

        public bool HasExtraAccessory
        {
            get => _mainViewModel.Model.HasExtraAccessoryEnabled;
            set
            {
                _mainViewModel.Model.HasExtraAccessoryEnabled = value;
                OnPropertyChanged(nameof(HasExtraAccessory));
            }
        }
    }
}