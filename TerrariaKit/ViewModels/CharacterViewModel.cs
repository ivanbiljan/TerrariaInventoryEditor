using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaKit.ViewModels
{
    internal sealed class CharacterViewModel : ViewModelBase<CharacterViewModel>
    {
        public string Name
        {
            get => Model.Name;
            set => Model.Name = value;
        }
    }
}
