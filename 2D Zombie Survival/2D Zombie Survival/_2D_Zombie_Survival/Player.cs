using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace _2D_Zombie_Survival
{
    class Player
    {
        Texture2D playerTex;
        Rectangle playerRec;

        float moveSpeed = 5f;

        KeyboardState keyState, oldKeyState;

        public Player()
        {

        }

        public void LoadContent(ContentManager Content)
        {
            playerTex = Content.Load<Texture2D>("player");
            playerRec = new Rectangle(20, 20, 32, 32);
        }

        public void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();

            // Player movement
            if (keyState.IsKeyDown(Keys.W))
                playerRec.Y -= (int)moveSpeed;
            if (keyState.IsKeyDown(Keys.S))
                playerRec.Y += (int)moveSpeed;
            if (keyState.IsKeyDown(Keys.A))
                playerRec.X -= (int)moveSpeed;
            if (keyState.IsKeyDown(Keys.D))
                playerRec.X += (int)moveSpeed;

            oldKeyState = keyState;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(playerTex, playerRec, Color.White);
        }
    }
}
