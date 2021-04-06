using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaKit.Core.Models
{
    //public record Item(int NetId, string Name, byte Prefix, int StackSize, bool IsFavorite);
    public sealed class Item
    {
        public Item(int netId, string name)
        {
            NetId = netId;
            Name = name;
        }

        public int NetId { get; }
        
        public string Name { get; }
        
        public byte Prefix { get; set; }
        
        public int StackSize { get; set; }
        
        public bool IsFavorite { get; set; }
    }
}