using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG2D_Windows.Entities;
using RPG2D_Windows.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2D_Windows.Helper
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
        public static Player LoadPlayer(int maxGameWidth, int maxGameHeight, Texture2D playerTexture )
        {
            Vector2 playerPosition = new Vector2(maxGameWidth / 2, maxGameHeight / 2);
            float playerSpeed = 2;
            return new Player(playerTexture, playerPosition, playerSpeed);
        }

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
