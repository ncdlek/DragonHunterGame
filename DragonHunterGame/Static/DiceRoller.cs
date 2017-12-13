using System;

namespace DragonHunterGame.Static
{
    public static class DiceRoller
    {
        private static Random rand = new Random();
        private static int r;
        
        public static int Roll()
        {
            r = rand.Next(0, 20);
            return r;
        }
    }
}
