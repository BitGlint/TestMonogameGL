using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TestMonogameGL
{
    /// <summary>
    /// Main game class
    /// </summary>
    public class Game1 : Game
    {
        // Private variables
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _testImage;
        private float _posX = 0;

        #region Public methods

        /// <summary>
        /// Constructor
        /// </summary>
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        #endregion

        #region Base class overrides

        /// <summary>
        /// Initialise game module
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
        }

        /// <summary>
        /// Load content
        /// </summary>
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _testImage = Content.Load<Texture2D>("Test");
        }

        /// <summary>
        /// Main update process
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            _posX += 0.1f;

            base.Update(gameTime);
        }

        /// <summary>
        /// Main draw process
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_testImage, new Vector2(85 + (float)(Math.Sin((double)_posX) * 25), (float)(Math.Cos((double)_posX) * 15)), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        #endregion
    }
}
