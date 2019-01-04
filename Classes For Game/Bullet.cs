//-----------------------------------
// Ben Powers
// Final Assignment
// Game Design
// December 12th, 2018
//-----------------------------------
using Microsoft.Xna.Framework;

namespace AllInOneMono
{
    public class Bullet
    {
        public Vector2 position;
        public int velocity;
        private Rectangle bounds;
        bool isBulletShootingRight = false;

        public Bullet(Vector2 position, bool isBulletShootingRight)
        {
            bounds = new Rectangle((int)position.X, (int)position.Y, 10, 10);
            this.position = position;
            this.isBulletShootingRight = isBulletShootingRight;

            if (isBulletShootingRight)
            {
                velocity = 10;
            }
            else
            {
                velocity = -10;
            }
        }

        public Rectangle Bounds
        {
            get { return bounds; }
            set { bounds = value; }
        }
    }
}
