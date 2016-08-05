using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_Zombie_Survival
{
    class Tile
    {
        public Vector2 pBounds { get { return new Vector2(16f, 16f); } }
        public Vector2 cPosition { get; set; }
        public Vector2 tPosition { get; set; }
        public Vector2 pPosition { get { return new Vector2(cPosition.X + tPosition.X * 16, cPosition.Y + tPosition.Y * 16); } }
        private Rectangle Drawable { get { return new Rectangle((int)pPosition.X, (int)pPosition.Y, (int)pBounds.X, (int)pBounds.Y); } }
        private Texture2D Texture { get; set; }
        public bool Passable { get; set; }

        public Tile()
        {

        }

        public Tile(Texture2D Texture, Vector2 cPosition, Vector2 tPosition)
        {
            this.Texture = Texture;
            this.cPosition = cPosition;
            this.tPosition = tPosition;
            this.Passable = true;
        }

        public Tile(Texture2D Texture, Vector2 cPosition, Vector2 tPosition, bool Passable)
        {
            this.Texture = Texture;
            this.cPosition = cPosition;
            this.tPosition = tPosition;
            this.Passable = Passable;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Drawable, Color.White);
        }
    }
}
