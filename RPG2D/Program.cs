namespace RPG2D_Windows
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using (Game1 game = new Game1()) 
            {
                game.Run();
            }
        }
    }
}