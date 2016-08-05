using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_Zombie_Survival
{
    class Chunk
    {
        public Vector2 cPosition { get; set; }
        public Tile[] Tiles;

        public Chunk(Vector2 cPosition)
        {
            this.cPosition = cPosition;
        }

        public void Render()
        {

        }

        private Tile[] MakeTiles()
        {
            Tile[] tiles = new Tile[256];

            for (int i = 0; i < 256; i++)
            {
                tiles[i] = new Tile();
            }

            return tiles;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < 256; i++)
            {
                Tiles[i].Draw(spriteBatch);
            }
        }
    }
}
