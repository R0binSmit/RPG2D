using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG2D_Windows.Entities.Items
{
    internal class BaseItem : BaseEntitie
    {
        internal string Name { get; private set; }
        internal string Description { get; private set; }
        internal bool IsVisible { get; private set; }

        /// <summary>
        /// BaseItem constructure
        /// </summary>
        /// <param name="texture">Item texure</param>
        /// <param name="position">Item position</param>
        /// <param name="name">Item name</param>
        /// <param name="description">Item description</param>
        /// <param name="isVisible">Item visibility</param>
        internal BaseItem(Texture2D texture,Vector2 position, string name, string description, bool isVisible = false) 
            : base(texture, position)
        {
            Name = name;
            Description = description;
            IsVisible = isVisible;
        }

        /// <summary>
        /// Draw BasicItem when IsVisable.
        /// </summary>
        /// <param name="spriteBatch">SpriteBatch from basic Game class.</param>
        public new void Draw(SpriteBatch spriteBatch)
        {
            if (IsVisible)
                base.Draw(spriteBatch);
        }
    }
}
