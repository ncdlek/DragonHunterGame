using DragonHunterGame.Enums;

namespace DragonHunterGame.Model
{
    public class Mage : Character
    {
        public Mage()
        {
            Type = CharType.Mage;
            Health = 80;
            Power = 70;
        }
    }
}
