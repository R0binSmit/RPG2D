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

        public void Draw() 
        {
            if(SpriteBatch != null)
            {
                SpriteBatch.Begin();
                SpriteBatch.Draw(Texture2D, Vector2.Zero, Color.Black);
                SpriteBatch.End();
            }
        }
    }
}
