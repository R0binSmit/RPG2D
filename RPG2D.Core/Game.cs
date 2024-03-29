﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPG2D.Entities;
using RPG2D.Entities.Items;
using RPG2D.Helper;
using RPG2D.Interface;

namespace RPG2D
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        public static readonly Point BasePoint = new Point(0, 0);
        internal readonly GraphicsDeviceManager graphics;
        private readonly List<IMovable> movableEntities = new List<IMovable>();
        private readonly List<Interface.IDrawable> drawableEntities = new List<Interface.IDrawable>();
        SpriteBatch spriteBatch;
        private Player player;

        public Game() : base()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            spriteBatch = new SpriteBatch(GraphicsDevice);

            /* Load Player */
            player = LoadHelper.Player(this);
            movableEntities.Add(player);
            drawableEntities.Add(player);

            BaseItem ring = LoadHelper.Ring(this);
            drawableEntities.Add(ring);
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
            Content.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (IMovable movable in movableEntities)
                movable.Move();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            foreach (Interface.IDrawable drawable in drawableEntities.OfType<Interface.IDrawable>())
                drawable.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
