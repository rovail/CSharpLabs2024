using System;

namespace GameMagic
{
    public class Mage : Character, IAttack
    {
        private ISpell _spell;

        public Spell Spell
        {
            get => (Spell)_spell;
            set => _spell = value;
        }

        public Mage(int hp, ISpell spell, string name) : base(name)
        {
            Hp = hp;
            _spell = spell;
        }

        public void Attack(IDamagebl damagebl)
        {
            if (damagebl.GetHashCode() == this.GetHashCode())
                return;
            Spell.CauseDamage(damagebl);
            Mage mage = (Mage)damagebl;
            Console.WriteLine($"[{Name} надамажив {mage.Name}]");
        }
    }
}
