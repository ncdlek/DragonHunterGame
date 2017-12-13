using DragonHunterGame.Enums;

namespace DragonHunterGame.Model
{
    public class Dragon : Character
    {
        public Dragon(string n)
        {
            Name = n;
            Type = CharType.Dragon;
            Health = 500;
            Power = 10;
        }

        public override int Attack(int r)
        {
            int x = 5;
            if (r < 15)
                x = 0;
            else if (r < 19)
                x = 1;
            return Power * x;
        }
    }
}
