using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AllInOneMono
{
    public abstract class GameScene : DrawableGameComponent
    {
        public virtual void show()
        {
            this.Enabled = true;
            this.Visible = true;
        }

        public virtual void hide()
        {
            this.Enabled = false;
            this.Visible = false;
        }

        public GameScene(Game game) : base(game)
        {
            hide();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
