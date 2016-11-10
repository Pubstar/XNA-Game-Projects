using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_Zombie_Survival
{
    class Tile
    {
        /// <summary>
        /// Id of tile (Declares the what tile it is)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Position of tile in texture file
        /// </summary>
        public Rectangle fPosition 
        { 
            get
            {
                int x = Id % 8;
                int y = Id / 8;

                return new Rectangle(x * 16, y * 16, 16, 16);
            }
        }

        /// <summary>
        /// Bounds of tile in pixels
        /// </summary>
        public Vector2 pBounds { get { return new Vector2(16f, 16f); } }

        /// <summary>
        /// Position of chunk in world
        /// </summary>
        public Vector2 cPosition { get; set; }

        /// <summary>
        /// Position of tile in chunk
        /// </summary>
        public Vector2 tPosition { get; set; }

        /// <summary>
        /// Position of tile in pixels
        /// </summary>
        public Vector2 pPosition { get { return new Vector2(cPosition.X + tPosition.X * 16, cPosition.Y + tPosition.Y * 16); } }

        /// <summary>
        /// Bounds and position of drawable rectangle
        /// </summary>
        private Rectangle Drawable { get { return new Rectangle((int)pPosition.X, (int)pPosition.Y, (int)pBounds.X, (int)pBounds.Y); } }

        /// <summary>
        /// Tile's texture
        /// </summary>
        private Texture2D Texture { get; set; }

        /// <summary>
        /// Whether or not the player can pass through or walk the tile
        /// </summary>
        public bool Passable { get; set; }

        public Tile()
        {

        }

        public Tile(Vector2 cPosition, Vector2 tPosition)
        {
            this.cPosition = cPosition;
            this.tPosition = tPosition;
            this.Passable = true;
        }

        public Tile(Vector2 cPosition, Vector2 tPosition, bool Passable)
        {
            this.cPosition = cPosition;
            this.tPosition = tPosition;
            this.Passable = Passable;
        }

        public void Render(ContentManager Content)
        {
            this.Texture = Content.Load<Texture2D>("Tiles.png");
        }
    }
}
