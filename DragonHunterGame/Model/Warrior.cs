using DragonHunterGame.Enums;

namespace DragonHunterGame.Model
{
    public class Warrior : Character
    {
        public Warrior()
        {
            Type = CharType.Warrior;
            Health = 100;
            Power = 50;
        }
    }
}
