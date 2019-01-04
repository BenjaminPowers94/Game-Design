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
using PROG2370CollisionLibrary;
using AllInOneMono;
using Microsoft.Xna.Framework.Audio;

namespace BensFinalGameAssignment
{
    class Player : DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        Texture2D playerTexture;
        Background background;

        int health;

        public Texture2D texture, bulletTexture; // added for bullet
        public Vector2 location; // added for bullet
        public bool Collision; // added for bullet
        public List<Bullet> bulletList; // added for bullet

        const int STANDFRAMEWIDTH = 66;     //all values from spritesheet.txt
        const int STANDFRAMEHEIGHT = 92;
        const int WALKFRAMEWIDTH = 72;
        const int WALKFRAMEHEIGHT = 97;
        const int JUMPFRAMEWIDTH = 67;
        const int JUMPFRAMEHEIGHT = 94;
        const float SCALE = 0.70f;

        const int STANDFRAME = 0;
        const int FIRSTWALKFRAME = 1;
        const int WALKFRAMES = 11;
        const int JUMPFRAME = 12;
        bool isPlayerFacingRight = false; //direct player is facing, used to determine which direction bullet shoots

        private int currentFrame = STANDFRAME;      //our initial frame (when game starts)
        List<Rectangle> playerFrames;
        SpriteEffects spriteDirection;  //determines what direction the texture is pointing

        const int FRAMEDELAYMAXCOUNT = 3;  //key change every 3 frames
        int currentFrameDelayCount = 0;          // increments every frame, resets every FRAMEDELAYMAXCOUNT


        const float GRAVITY = 0.02f;        //some constant that adds a force downward.

        bool isShooting = false; //is the pink shooting?
        bool isJumping = false;
        bool isGrounded = false;
        int currentJumpPower = 0;
        const int JUMPPOWER = -12;   //negative because of inverted co-oridinates (change to suit your max jump height)
        const float JUMPSTEP = 1.3f;  // the amount of movement per frame (gravity reduces this)

        const float SPEED = 2.3f;
        Vector2 velocity;
        int bulletDelay = 500; //time since last bullet fired
        const int bulletDelayTime = 500; //1000 ms 

        SoundEffect gunSound;
        SoundEffect jumpSound;

        Rectangle _rectangle;
        //Rectangle enemyRectangle;

        public Rectangle Rectangle
        {
            get { return _rectangle; }
            set { _rectangle = value; }
        }

        public Player(Game game, SpriteBatch spriteBatch, Texture2D playerTexture, Background background) : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.playerTexture = playerTexture;
            this.background = background;

            playerFrames = new List<Rectangle>();

            bulletList = new List<Bullet>(); // added for bullets
            //bulletDelay = 10; // added for bullets
            bulletTexture = game.Content.Load<Texture2D>("bullet");

            //add the stand frame
            playerFrames.Add(new Rectangle(67, 196, STANDFRAMEWIDTH, STANDFRAMEHEIGHT));

            //add the soundEffect
            gunSound = game.Content.Load<SoundEffect>("gunShot");

            //adding the jumping sound 
            jumpSound = game.Content.Load<SoundEffect>("jump");

            //the walk frames
            playerFrames.Add(new Rectangle(0, 0, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(73, 0, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(146, 0, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(0, 98, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(73, 98, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(146, 98, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(219, 0, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(292, 0, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(219, 98, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(365, 0, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));
            playerFrames.Add(new Rectangle(292, 98, WALKFRAMEWIDTH, WALKFRAMEHEIGHT));

            //the jump frame
            playerFrames.Add(new Rectangle(438, 93, JUMPFRAMEWIDTH, JUMPFRAMEHEIGHT));

            Start();
        }

        public void Start()
        {
            _rectangle = new Rectangle(30, 0, (int)(SCALE * STANDFRAMEWIDTH), (int)(SCALE * STANDFRAMEHEIGHT));

            velocity = new Vector2(0);
            spriteDirection = SpriteEffects.None;
            isPlayerFacingRight = true;

            health = 5; // number of bullets able to be taken before gameover 
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(playerTexture,
                _rectangle,                                             // containing rectangle
                playerFrames.ElementAt<Rectangle>(currentFrame),     // our current key frame
                Color.White,
                0f,             //rotation
                new Vector2(0),    //origin 
                spriteDirection, // for animation only: the direction to face the texture
                0f      //layerdept
                );
            //spriteBatch.DrawRectangle(player, Color.Yellow);

            foreach (Bullet bullet in bulletList)
            {
                spriteBatch.Draw(bulletTexture, new Rectangle((int)bullet.position.X, (int)bullet.position.Y, 10, 10), Color.White);
                bullet.position.X += bullet.velocity;
                bullet.Bounds = new Rectangle((int)bullet.position.X, (int)bullet.position.Y, 10, 10);
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            velocity.X = 0;
            velocity.Y += GRAVITY * deltaTime;

            //get input
            KeyboardState keyState = Keyboard.GetState();

            //add SPEED to velocity (as required)
            if (keyState.IsKeyDown(Keys.D))
            {
                velocity.X = SPEED;
                isPlayerFacingRight = true;
            }
            if (keyState.IsKeyDown(Keys.A))
            {
                velocity.X = -SPEED;
                isPlayerFacingRight = false;
            }
            if (keyState.IsKeyDown(Keys.W))
            {
                if (!isJumping && isGrounded)  // ready to jump
                {
                    jumpSound.Play();
                    isJumping = true;
                    isGrounded = false;
                    currentJumpPower = JUMPPOWER;  // this is maximum "thrust" at the very beginning of jump
                }
            }

            if (bulletDelay <= bulletDelayTime)
            {
                bulletDelay += gameTime.ElapsedGameTime.Milliseconds;
            }

            if (keyState.IsKeyDown(Keys.Space)) //for shooting for pink player
            {

                if (bulletDelay >= bulletDelayTime)
                {
                    gunSound.Play();
                    bulletList.Add(new Bullet(new Vector2(_rectangle.X + 20, _rectangle.Y + 20), isPlayerFacingRight));
                    bulletDelay = 0; //resetting time since last bullet fired to 0
                }
            }

            if (isJumping)
            {
                if (currentJumpPower < 0)  // we still have upward thrust 
                {
                    velocity.Y -= JUMPSTEP;
                    currentJumpPower++;
                }
                else
                {
                    isJumping = false;   //now we are falling
                }
            }

            // our new location becomes the "proposed" location
            Rectangle proposedLocation = new Rectangle(_rectangle.X + (int)velocity.X,
                                                    _rectangle.Y + (int)velocity.Y,
                                                    _rectangle.Width,
                                                    _rectangle.Height);
            // check if move is ok
            Sides collisionSides = proposedLocation.CheckCollisions(background.RigidBodyList);

            if ((collisionSides & Sides.RIGHT) == Sides.RIGHT)
                if (velocity.X > 0)
                    velocity.X = 0;

            if ((collisionSides & Sides.LEFT) == Sides.LEFT)
                if (velocity.X < 0)
                    velocity.X = 0;

            if ((collisionSides & Sides.TOP) == Sides.TOP)
            {
                isJumping = false;
                velocity.Y = SPEED;
            }

            foreach (Bullet bullet in bulletList)
            {
                Enemy enemy = Game.Components.OfType<Enemy>().First();

                if (enemy != null && bullet.Bounds.Intersects(enemy.Rectangle))
                {
                    health--;

                    if (health <= 0)
                    {
                        enemy.Enabled = false;
                        enemy.Visible = false;

                        ActionScene scene = Game.Components.OfType<ActionScene>().First();
                        scene.Restart();
                    }

                    bulletList.Remove(bullet);
                    break;
                }
            }

            if ((collisionSides & Sides.BOTTOM) == Sides.BOTTOM && (currentJumpPower != JUMPPOWER))
            {
                velocity.Y = 0;
                isGrounded = true;
            }

            //absolutely ok, update location to "proposed"
            //anim
            if (velocity.X < 0)
                spriteDirection = SpriteEffects.FlipHorizontally;
            else if (velocity.X > 0)
                spriteDirection = SpriteEffects.None;

            // when jumping
            if (isJumping)
            {
                currentFrame = JUMPFRAME;
                //player.Width = JUMPFRAMEWIDTH, JUMPFRAMEHEIGHT)
            }
            else
            {
                //STANDFRAMEWIDTH, STANDFRAMEHEIGHT
            }

            //when standing
            // equivalent to  if(isGrounded == TRUE)
            if (isGrounded)
            {
                //and standing
                if (nearlyZero(velocity.X))
                {
                    //STANDFRAMEWIDTH, STANDFRAMEHEIGHT
                    currentFrame = STANDFRAME;
                }
                // or walking
                else
                {
                    //WALKFRAMEWIDTH, WALKFRAMEHEIGHT
                    currentFrameDelayCount++;
                    if (currentFrameDelayCount > FRAMEDELAYMAXCOUNT)
                    {
                        currentFrameDelayCount = 0;
                        currentFrame++;  //advance to the next frame
                    }
                    if (currentFrame > WALKFRAMES)
                        currentFrame = FIRSTWALKFRAME;
                }
            }

            _rectangle.X = _rectangle.X + (int)velocity.X;
            _rectangle.Y = _rectangle.Y + (int)velocity.Y;

            base.Update(gameTime);
        }

        private bool nearlyZero(float f1)
        {
            // sometimes 0 is not 0 when its a float or double
            // float.Epsilon is the variance around zero
            return (Math.Abs(f1) < float.Epsilon);
        }
        private bool nearlyEqual(float f1, float f2)
        {
            // sometimes 0 is not 0 when its a float or double
            // float.Epsilon is the variance around zero
            return nearlyZero(f1 - f2);
        }
    }
}

