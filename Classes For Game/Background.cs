//-----------------------------------
// Ben Powers
// Final Assignment
// Game Design
// December 12th, 2018
//-----------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using C3.XNA; 

namespace BensFinalGameAssignment
{
    class Background : DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        Texture2D helicopterBackground;

        List<Rectangle> rigidBodyList; // list of red rectangles
        public List<Rectangle> RigidBodyList { get => rigidBodyList; } 


        public Background(Game game, SpriteBatch spriteBatch, Texture2D helicopterBackground) : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.helicopterBackground = helicopterBackground;

            rigidBodyList = new List<Rectangle>(); // using the list of red rectangles

            // for all four sides
            rigidBodyList.Add(new Rectangle(0, 0, 1237, 55));
            rigidBodyList.Add(new Rectangle(0, 628, 1237, 65));
            rigidBodyList.Add(new Rectangle(-10, -10, 10, 1237));
            rigidBodyList.Add(new Rectangle(1237, 210, 140, 1237));

            // for ledges and objects for players to jump onto
            rigidBodyList.Add(new Rectangle(100, 470, 180, 70));
            rigidBodyList.Add(new Rectangle(900, 470, 180, 70));
            rigidBodyList.Add(new Rectangle(200, 300, 180, 70));
            rigidBodyList.Add(new Rectangle(800, 300, 180, 70));
            rigidBodyList.Add(new Rectangle(300, 160, 180, 70));
            rigidBodyList.Add(new Rectangle(700, 160, 180, 70));
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(helicopterBackground, new Rectangle(0, 0, 1237, 696), Color.White); // adding the image into the game1 form
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
