using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_Zombie_Survival
{
    class World
    {
        /// <summary>
        /// Size of world in chunks
        /// </summary>
        private Vector2 cBounds { get; set; }

        /// <summary>
        /// Size of world in tiles
        /// </summary>
        public Vector2 tBounds { get { return new Vector2(cBounds.X * 16, cBounds.Y * 16); } }

        /// <summary>
        /// Size of world in pixels
        /// </summary>
        public Vector2 pBounds { get { return new Vector2(cBounds.X * tBounds.X * 16, cBounds.Y * tBounds.Y * 16); } }

        /// <summary>
        /// Array of chunks present in world
        /// </summary>
        public Chunk[,] Chunks { get; set; }

        /// <summary>
        /// Creates a new instance of world
        /// </summary>
        public World()
        {
            this.cBounds = new Vector2(1f, 1f);
        }

        /// <summary>
        /// Creates a new instance of world
        /// </summary>
        /// <param name="cBounds"> Bounds in chunks (1 Chunk is 16x16) </param>
        public World(Vector2 cBounds)
        {
            this.cBounds = cBounds;
        }

        public void Create()
        {
            Chunks = new Chunk[(int)cBounds.X, (int)cBounds.Y];

            for (int x = 0; x < (int)cBounds.X; x++)
            {
                for (int y = 0; y < cBounds.Y; y++)
                {
                    Chunks[x, y] = new Chunk(new Vector2(x, y));
                }
            }
        }

        public void Render(ContentManager Content)
        {

        }
    }
}
