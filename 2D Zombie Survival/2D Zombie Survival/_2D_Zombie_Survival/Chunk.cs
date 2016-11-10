using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_Zombie_Survival
{
    class Chunk
    {
        /// <summary>
        /// Chunk position in world
        /// </summary>
        public Vector2 cPosition { get; set; }
        public Tile[,] Tiles;

        public Chunk(Vector2 cPosition)
        {
            this.cPosition = cPosition;
        }

        public void Render(ContentManager Content)
        {

        }

        private void Create()
        {
            Tiles = new Tile[16,16];

            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    Tiles[x, y] = new Tile();
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
