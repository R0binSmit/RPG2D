using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG2D_Windows
{
    internal class Player
    {
        public Texture2D Texture2D { get; set; }
        public SpriteBatch SpriteBatch { get; set; }
        private Vector2 vector2D { get; set; }
        public Player()
        {
            vector2D = new Vector2(0, 0);
        }

        public void Move() 
        {
            vector2D = new Vector2(vector2D.X + 1, vector2D.Y);
        }

        public void Draw() 
        {
            if(SpriteBatch != null)
            {
                SpriteBatch.Begin();
                SpriteBatch.Draw(Texture2D, vector2D, Color.Black);
                SpriteBatch.End();
            }
        }
    }
}
