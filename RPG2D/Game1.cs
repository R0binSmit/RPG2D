using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG2D_Windows
{
    internal class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Player player;
        public Game1(): base() 
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            /* Load Player */
            player = new Player();
            player.SpriteBatch = new SpriteBatch(GraphicsDevice);
            player.Texture2D = Content.Load<Texture2D>("content/player");
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
            Content.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            player.Move();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            player.Draw();

            base.Draw(gameTime);
        }
    }
}
