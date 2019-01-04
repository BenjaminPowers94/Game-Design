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
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace AllInOneMono
{
    public class StartScene : GameScene
    {
        public MenuComponent Menu { get; set; }
        private Texture2D homeScreenImg;
        SoundEffect jumpSound;

        private SpriteBatch spriteBatch;
        string[] menuItems = {"Begin Game",
                                "How to Play",
                                "Help",
                                "Credit",
                                "Quit"};
        public StartScene(Game game): base(game)
        {
            Game1 g = (Game1)game;

            this.spriteBatch = g.spriteBatch;
            SpriteFont regularFont = g.Content.Load<SpriteFont>("Fonts/regularFont");
            SpriteFont highlightFont = game.Content.Load<SpriteFont>("Fonts/hilightFont");

            homeScreenImg = g.Content.Load<Texture2D>("Images/homePageScreenImage");

            jumpSound = game.Content.Load<SoundEffect>("jump");

            Menu = new MenuComponent(game, spriteBatch,regularFont,highlightFont, menuItems);
            game.Components.Add(Menu);
        }

        public override void Update(GameTime gameTime)
        {

            KeyboardState keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Up) || keyState.IsKeyDown(Keys.Down))
            {
                jumpSound.Play();
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(homeScreenImg, new Rectangle(500, 0, 500, 696), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
