using Microsoft.Xna.Framework;

namespace RPG2D_Windows.Helper
{
    internal static class PositionHelper
    {
        public static bool InRange(Point minPosition, Point maxPosition, Point entitiePosition) 
        {
            return entitiePosition.X <= maxPosition.X
                && entitiePosition.Y <= maxPosition.Y
                && entitiePosition.X >= minPosition.X
                && entitiePosition.Y >= minPosition.Y;
        }
    }
}
