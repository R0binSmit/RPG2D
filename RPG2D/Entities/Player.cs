using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG2D_Windows.Helper;
using RPG2D_Windows.Interface;

namespace RPG2D_Windows.Entities
{
    internal class Player : IMovable, Interface.IDrawable
    {
        private float speed;
        private Vector2 position;
        private Texture2D texture;


        public Player(Texture2D texture2D, Vector2 position2D, float speed2D)
        {
            position = position2D;
            texture = texture2D;
            speed = speed2D;
        }

        public void Move()
        {
            Point newPosition = new Point((int)position.X, (int)position.Y);

            if (InputHelper.IsKeyRightPressed())
                newPosition.X = (int)(newPosition.X + 1 * speed);

            if (InputHelper.IsKeyLeftPressed())
                newPosition.X = (int)(newPosition.X - 1 * speed);

            if (InputHelper.IsKeyUpPressed())
                newPosition.Y = (int)(newPosition.Y - 1 * speed);

            if (InputHelper.IsKeyDownPressed())
                newPosition.Y = (int)(position.Y + 1 * speed);

            if (PositionHelper.InRange(Game1.BasePoint, new Point(1920, 1080), newPosition)) 
            {
                position.Y = newPosition.Y;
                position.X = newPosition.X;
            }
        }


        public void SetTexture(Texture2D texture2D)
        {
            texture = texture2D;
        }

        public Texture2D GetTexture()
        {
            return texture;
        }

        public Vector2 GetVector() 
        {
            return position;
        }
    }
}
