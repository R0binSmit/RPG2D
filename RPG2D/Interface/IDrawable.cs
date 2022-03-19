using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG2D_Windows.Interface
{
    internal interface IDrawable
    {
        void Draw(SpriteBatch spriteBatch);
        Vector2 GetVector();
    }
}
