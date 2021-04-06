using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TerrariaKit.Core.Models;

namespace TerrariaKit.Services
{
    internal sealed class LocalizationService
    {
        private const string LocalizationJsonPath = "localization.json";
        private const string ItemsJsonPath = "items.json";

        private readonly IDictionary<string, string> _localizationMap = new Dictionary<string, string>();
        private readonly IDictionary<int, string> _itemIdToName = new Dictionary<int, string>();

        public LocalizationService()
        {
            var items = JsonSerializer.Deserialize<List<Item>>(File.ReadAllText(ItemsJsonPath));
            Debug.Assert(items != null, "items != null");
            
            foreach (var item in items)
            {
                _itemIdToName[item.NetId] = item.Name;
            }

            // TODO: Differ initialization until the console client is opened / a connection is established?
            _localizationMap =
                JsonSerializer.Deserialize<IDictionary<string, string>>(File.ReadAllText(LocalizationJsonPath));
        }

        public string? GetItemName(int itemId) => _itemIdToName.TryGetValue(itemId, out var name) ? name : null;

        public string? GetLocalizedText(string category) =>
            _localizationMap.TryGetValue(category, out var localizedText) ? localizedText : null;
    }
}