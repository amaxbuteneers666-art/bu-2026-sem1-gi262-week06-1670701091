using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Mage:Hero
    {
        public int mana;
        private int spellPower;

        public override void Attack(GameEntity target)
        {
            mana++;
        }
        public void CastSpell(GameEntity target) //: ‚®¡µ’ target «¬‡«∑¡πµ ·≈–≈¥§Ë“mana
        {
            spellPower++;
        }
    }
}
