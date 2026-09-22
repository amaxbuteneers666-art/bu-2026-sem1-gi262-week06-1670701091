using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster:Character
    {
        public int baseDamage;
        protected int aggroRange;

        public override void Attack(GameEntity target)//: ÊÑè ÊÑè§target.TakeDamage(baseDamage) 
        {
            if (baseDamage == 0) 
            { 
                target.TakeDamage(baseDamage);
            }
        }
        protected virtual void Roar()
        {

        }
    }
}
