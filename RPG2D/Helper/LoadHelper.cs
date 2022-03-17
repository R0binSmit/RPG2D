using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG2D_Windows.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2D_Windows.Helper
{
    internal static class LoadHelper
    {
        public static Player LoadPlayer(int maxGameWidth, int maxGameHeight, Texture2D playerTexture )
        {
            Vector2 playerPosition = new Vector2(maxGameWidth / 2, maxGameHeight / 2);
            float playerSpeed = 2;
            return new Player(playerTexture, playerPosition, playerSpeed);
        }
    }
}
