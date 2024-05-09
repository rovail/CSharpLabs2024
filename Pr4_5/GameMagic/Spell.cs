
namespace GameMagic
{
    public abstract class Spell : ISpell
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            internal set => _damage = value;
        }

        public void CauseDamage(IDamagebl damagebl)
        {
            damagebl.TakeDamage(_damage);
        }
    }
}
