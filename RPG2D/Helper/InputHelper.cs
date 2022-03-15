using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RPG2D_Windows.Helper
{
    internal static class InputHelper
    {
        public static bool IsKeyRightPressed() 
        {
            return Keyboard.GetState().IsKeyDown(Keys.D)
                || Keyboard.GetState().IsKeyDown(Keys.Right)
                || GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed;
        }

        public static bool IsKeyDownPressed()
        {
            return (Keyboard.GetState().IsKeyDown(Keys.S))
                || Keyboard.GetState().IsKeyDown(Keys.Down)
                || GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed;
        }

        public static bool IsKeyLeftPressed() 
        {
            return (Keyboard.GetState().IsKeyDown(Keys.A))
                || Keyboard.GetState().IsKeyDown(Keys.Left)
                || GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed;
        }

        public static bool IsKeyUpPressed() 
        {
            return (Keyboard.GetState().IsKeyDown(Keys.W))
                || Keyboard.GetState().IsKeyDown(Keys.Up)
                || GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed;
        }
    }
}
