using DragonHunterGame.Enums;

namespace DragonHunterGame.Model
{
    public delegate void HealthHandler();

    public abstract class Character
    {
        public string Name { get; set; }
        public CharType Type;
        public int Power { get; set; }
        private int _health;
        public int Health
        {
            get { return _health; }
            set
            {
                _health = value;
                if (_health <= 0)
                    OnDeath();
            }
        }
        public event HealthHandler OnDeath;
        public virtual int Attack(int r)
        {
            int x = 2;
            if (r < 8)
                x = 0;
            else if (r < 17)
                x = 1;
            return Power * x;
        }

        public virtual void HealthDecrease (int hit)
        {
            this.Health -= hit;
        }
    }
}
