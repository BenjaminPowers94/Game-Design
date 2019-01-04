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
using BensFinalGameAssignment;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using AllInOneMono;

namespace AllInOneMono
{
    public class ActionScene : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private Player player;
        private Enemy enemy;
        private Background background;

        public List<IGameComponent> levelGameObjects = new List<IGameComponent>();

        public ActionScene (Game game): base(game)
        {
            Game1 g = (Game1)game;
            this.spriteBatch = g.spriteBatch;

            // TODO: use this.Content to load your game content here
            Texture2D backgroundTex = g.Content.Load<Texture2D>("Helicopterbackgrounds");
            background = new Background(game, spriteBatch, backgroundTex);
            game.Components.Add(background);

            Texture2D playerTex = g.Content.Load<Texture2D>("p3_spritesheet");
            player = new Player(game, spriteBatch, playerTex, background);
            game.Components.Add(player);

            Texture2D enemyTex = g.Content.Load<Texture2D>("p2_spritesheet");
            enemy = new Enemy(game, spriteBatch, enemyTex, background);
            game.Components.Add(enemy);

            EnabledChanged += ActionScene_EnabledChanged;
        }

        private void ActionScene_EnabledChanged(object sender, EventArgs e)
        {
            if (sender is IUpdateable updateable)
            {
                player.Enabled = updateable.Enabled;
                enemy.Enabled = updateable.Enabled;
                background.Enabled = updateable.Enabled;

                player.Visible = updateable.Enabled;
                enemy.Visible = updateable.Enabled;
                background.Visible = updateable.Enabled;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        internal void Restart()
        {
            player.Enabled = true;
            enemy.Enabled = true;
            background.Enabled = true;

            player.Visible = true;
            enemy.Visible = true;
            background.Visible = true;

            player.Start();
            enemy.Start();
        }
    }
}
