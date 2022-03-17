using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2D_Windows.Interface
{
    internal interface IDrawable
    {
        void Draw(SpriteBatch spriteBatch);
        Vector2 GetVector();
    }
}
