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

        public World()
        {
            this.cBounds = new Vector2(1f, 1f);
        }

        public void Render(ContentManager Content)
        {

        }

        /// <summary>
        /// New world
        /// </summary>
        /// <param name="cBounds"> Bounds in chunks (1 Chunk is 16x16) </param>
        public World(Vector2 cBounds)
        {
            this.cBounds = cBounds;
        }
    }
}
