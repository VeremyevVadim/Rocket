using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Spawners
{
    class CoinSpawner : Spawner
    {
        public override void LevelUp()
        {
            spawnerLevel++;
        }
    }
}
