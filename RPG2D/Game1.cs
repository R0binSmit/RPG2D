using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG2D_Windows
{
    internal class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
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
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
