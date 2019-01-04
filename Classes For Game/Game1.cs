//-----------------------------------
// Ben Powers
// Final Assignment
// Game Design
// December 12th, 2018
//-----------------------------------
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace AllInOneMono
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        
        //declare all the scenes here
        private StartScene startScene;
        private ActionScene actionScene;
        private HelpScene helpScene;
        private CreditScene creditScreen;
        private HowToPlayScene howToPlayScreen;
        // songs for game
        Song bg;
        Song helpScreenSong;
        Song howToScreenSong;
        Song creditScreenSong;
        Song homeScreenSong;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferHeight = 696; // changing the size of the height of the program
            graphics.PreferredBackBufferWidth = 1237; // changing the size of the width of the program 

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Shared.stage = new Vector2(graphics.PreferredBackBufferWidth,
                graphics.PreferredBackBufferHeight);

            //initialize other Shared class members
            this.IsMouseVisible = true;
            base.Initialize();
        }

        private void hideAllScenes()
        {
            GameScene gs = null;
            foreach (GameComponent  item in Components)
            {
                if (item is GameScene)
                {
                    gs = (GameScene)item;
                    gs.hide();
                }
            }
        }


        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            startScene = new StartScene(this);
            this.Components.Add(startScene);
            startScene.show();

            //create other scenes here and add to component list
            actionScene = new ActionScene(this);
            actionScene.Enabled = false;
            this.Components.Add(actionScene);

            helpScene = new HelpScene(this);
            this.Components.Add(helpScene);

            creditScreen = new CreditScene(this);
            this.Components.Add(creditScreen);

            howToPlayScreen = new HowToPlayScene(this);
            this.Components.Add(howToPlayScreen);

            bg = Content.Load<Song>("Song");
            helpScreenSong = Content.Load<Song>("helpscreensong");
            howToScreenSong = Content.Load<Song>("howtosong");
            creditScreenSong = Content.Load<Song>("creditsong");
            homeScreenSong = Content.Load<Song>("homescreensongz");

            MediaPlayer.Play(homeScreenSong); 
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            int selectedIndex = 0;

            KeyboardState ks = Keyboard.GetState();

            if (startScene.Enabled)
            {
                //MediaPlayer.Stop();
                selectedIndex = startScene.Menu.SelectedIndex;
                if (selectedIndex == 0 && ks.IsKeyDown(Keys.Enter))
                {
                    MediaPlayer.Stop();
                    hideAllScenes();
                    MediaPlayer.Play(bg);
                    actionScene.Enabled = true;
                }
                else if (selectedIndex == 1 && ks.IsKeyDown(Keys.Enter))
                {
                    MediaPlayer.Stop();
                    hideAllScenes();
                    MediaPlayer.Play(howToScreenSong);
                    howToPlayScreen.show();
                }
                else if (selectedIndex == 2 && ks.IsKeyDown(Keys.Enter))
                {
                    MediaPlayer.Stop();
                    hideAllScenes();
                    MediaPlayer.Play(helpScreenSong);
                    helpScene.show();
                }
                else if (selectedIndex == 3 && ks.IsKeyDown(Keys.Enter))
                {
                    MediaPlayer.Stop();
                    hideAllScenes();
                    MediaPlayer.Play(creditScreenSong);
                    creditScreen.show();
                }
                //handle other menu options
                else if (selectedIndex == 4 && ks.IsKeyDown(Keys.Enter))
                {
                    Exit();
                }
            }

            if (actionScene.Enabled || helpScene.Enabled || creditScreen.Enabled || howToPlayScreen.Enabled)
            {
                if (ks.IsKeyDown(Keys.Escape))
                {
                    MediaPlayer.Play(homeScreenSong);
                    hideAllScenes();
                    startScene.show();
                }
            }
            // TODO: Add your update logic here

            base.Update(gameTime); 
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
