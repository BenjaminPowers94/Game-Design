//-----------------------------------
// Ben Powers
// Final Assignment
// Game Design
// December 12th, 2018
//-----------------------------------
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AllInOneMono
{
    public class HelpScene : GameScene
    {
        private SpriteBatch spriteBatch;
        private Texture2D helpTex;
        public HelpScene(Game game) : base(game)
        {
            Game1 g = (Game1)game;
            this.spriteBatch = g.spriteBatch;
            helpTex = g.Content.Load<Texture2D>("Images/helpImage");
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(helpTex, new Rectangle(0, 0, 1237, 696), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
