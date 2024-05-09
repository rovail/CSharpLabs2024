
namespace GameMagic
{
    public interface ISpell
    {
        int Damage { get; }

        void CauseDamage(IDamagebl damagebl);
    }
}
