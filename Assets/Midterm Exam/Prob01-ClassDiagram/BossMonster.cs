using UnityEngine;

namespace MidtermExam.Prob01
{
    public class BossMonster:Monster
    {
        public int phase;
        private bool isEnraged;

        public override void Attack(GameEntity target) 
        {
            
        }
        protected override void Roar()
        {

        }
        public void TriggerPhaseTransition() //: ‡æ‘Ë æ‘Ë¡phase++·≈–ª√— √—∫isEnraged = true
        {
            isEnraged = true;
        } 

    }
}
