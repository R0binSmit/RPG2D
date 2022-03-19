using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG2D_Windows.Helper;
using RPG2D_Windows.Interface;

namespace RPG2D_Windows.Entities
{
    internal class Player : BaseEntitie,  IMovable
    {
        private float speed;

        public Player(Texture2D texture, Vector2 position, float speed2D) : base(texture, position)
        {
            speed = speed2D;
        }

        /// <summary>
        /// Basic player movement.
        /// </summary>
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

            if (PositionHelper.InSquare(Game1.BasePoint, new Point(1920, 1080), newPosition)) 
            {
                position.Y = newPosition.Y;
                position.X = newPosition.X;
            }
        }
    }
}
