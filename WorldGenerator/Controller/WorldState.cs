using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorldGenerator.Controller
{
    internal class WorldState
    {
        public enum AreaType : byte
        {
            WATER = 0,
            SAND = 1,
            VALLEY = 2,
            HILL = 3,
            MOUNTAIN = 4,
        }

        public byte[,] MapGrid { get; set; }

        public WorldState()
        {
            MapGrid = new byte[8912, 8192];
        }

        public void generateMap(string key)
        {
            GenerateIslands(MapGrid, key);
        }

        private static void IterateMapGrid(byte[,] mapGrid,Func<int, int,byte> funcToOperate)
        {
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    mapGrid[i, j] = funcToOperate(i,j);
                }
            }
        }

        private static void GenerateIslands(byte[,] mapGrid, string key)
        {
            int sum = 0;
            foreach(char c in key)
            {
                sum += c % Int32.MaxValue;
            }

            FastNoiseLite noise = new FastNoiseLite();
            noise.SetSeed(sum);
            noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);
            noise.SetFrequency(0.01f);
            noise.SetFractalLacunarity(10f);
            noise.SetFractalGain(0.25f);
            noise.SetFractalType(FastNoiseLite.FractalType.DomainWarpProgressive);

            IterateMapGrid(mapGrid, (x,y) =>
            {
                float value = noise.GetNoise(x, y);
                
                if ( 0.25f <= value && 0.35f > value)
                {
                    return (byte)AreaType.SAND;
                }
                else if (0.35f <= value && 0.6f > value)
                {
                    return (byte)AreaType.VALLEY;
                }
                else if (0.6f <= value && 0.65f > value)
                {
                    return (byte)AreaType.HILL;
                }
                else if (0.65f <= value && 1.0f > value)
                {
                    return (byte)AreaType.MOUNTAIN;
                }
                else
                {
                    return (byte)AreaType.WATER;
                }
            });
        }
    }
}
