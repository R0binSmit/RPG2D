using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG2D.Entities;
using RPG2D.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2D.Helper
{
    /// <summary>
    /// This class helps out loading all objects for the game.
    /// </summary>
    internal static class LoadHelper
    {
        /// <summary>
        /// Initialize the player object with its core properties. With that it returns the constructed player object
        /// back to the Game1 LoadContent() method.
        /// </summary>
        /// <param name="maxGameWidth">The width of the window</param>
        /// <param name="maxGameHeight">The height of the window</param>
        /// <param name="playerTexture">The texture of the Player</param>
        /// <returns>Player</returns>
        public static Player Player(Game game)
        {
            return new Player(game.Content.Load<Texture2D>(
                ContentPathHelper.Player),
                new Vector2(game.graphics.PreferredBackBufferWidth / 2, game.graphics.PreferredBackBufferHeight / 2),
                2);
        }

        /// <summary>
        /// Initialize a ring object with its core propereties.
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public static BaseItem Ring(Game game) 
        {
            return new BaseItem(
                game.Content.Load<Texture2D>(ContentPathHelper.Ring),
                new Vector2(50, 50),
                "Ring",
                "Nice yellow Ring",
                true
            );
        }
    }
}
