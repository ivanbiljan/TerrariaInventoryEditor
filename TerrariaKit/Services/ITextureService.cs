using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TerrariaKit.Services {
    public interface ITextureService
    {
        ImageSource? GetHairTexture(int hairId);

        ImageSource? GetPlayerTexture(int skinVariant, int texture);

        ImageSource GetItemTexture(int itemId);
    }
}
