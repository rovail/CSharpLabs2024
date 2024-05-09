using System;
namespace GameMagic
{
    public abstract class Character : IDamagebl
    {
        private int _hp;
        private string _name;

        protected Character(string name)
        {
            _name = name;
        }

        public int Hp
        {
            get => _hp;
            set
            {
                _hp = value;
                Console.WriteLine($"[ Поточне здоров'я {Name}, становить [{Hp}] ]");
            }
        }
        public string Name
        {
            get => _name;
            protected set => _name = value;
        }
        public void TakeDamage(int damage)
        {
            Hp -= damage;
            Console.WriteLine($"{Name} отримав урон");
        }

    }
}
