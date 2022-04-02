using Microsoft.Xna.Framework;

namespace RPG2D.Helper
{
    internal static class PositionHelper
    {
        /// <summary>
        /// Check if entitiePosition is in a defined square (minPosition, maxPosition).
        /// </summary>
        /// <param name="minPosition">Top left corner form the square</param>
        /// <param name="maxPosition">Bottom right corner frome the square</param>
        /// <param name="entitiePosition">Position frome the entitie</param>
        /// <returns>True if the entitie is in the square.</returns>
        public static bool InSquare(Point minPosition, Point maxPosition, Point entitiePosition) 
        {
            return entitiePosition.X <= maxPosition.X
                && entitiePosition.Y <= maxPosition.Y
                && entitiePosition.X >= minPosition.X
                && entitiePosition.Y >= minPosition.Y;
        }
    }
}