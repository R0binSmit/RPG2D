using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG2D.Interface;

namespace RPG2D.Entities
{
    internal class BaseEntitie : Interface.IDrawable
    {
        internal readonly Texture2D texture;
        internal Vector2 position;
        internal readonly float rotaion;
        internal readonly float layerDepth;

        internal BaseEntitie(Texture2D texture, Vector2 position, float rotaion = 0, float layerDepth = 0) 
        {
            this.texture = texture;
            this.position = position;
            this.rotaion = rotaion;
            this.layerDepth = layerDepth;
        }

        /// <summary>
        /// Draw the enitie object by the given texture and position.
        /// </summary>
        /// <param name="spriteBatch">SpriteBatch from the base game class.</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                position,
                null,
                Color.White,
                rotaion,
                new Vector2(texture.Width / 2, texture.Height / 2),
                Vector2.One,
                SpriteEffects.None,
                layerDepth
            );
        }

        /// <summary>
        /// Return the current postion from the entrie.
        /// </summary>
        /// <returns>Position as Vecotr2</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Vector2 GetVector()
        {
            throw new NotImplementedException();
        }
    }
}