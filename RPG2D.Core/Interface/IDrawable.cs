using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG2D.Interface
{
    internal interface IDrawable
    {
        void Draw(SpriteBatch spriteBatch);
        Vector2 GetVector();
    }
}
