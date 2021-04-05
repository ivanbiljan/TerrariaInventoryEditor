using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaKit.Core.Models
{
    public sealed class SpawnInfo
    {
        public SpawnInfo(int worldId, string worldName, int spawnX, int spawnY)
        {
            WorldId = worldId;
            WorldName = worldName;
            SpawnX = spawnX;
            SpawnY = spawnY;
        }

        public int WorldId { get; }
        public string WorldName { get; }
        public int SpawnX { get; }
        public int SpawnY { get; }
    }
}
