using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero:Character
    {

        public int currentExp;
        private int gold;

        public override void Attack(GameEntity target)
        {

        }
        public void CollectGold(int amount) //เพิ่มพิ่ ค่าค่ amount ให้กัห้บกั gold
        {
            gold = amount;
        }
        protected override void LevelUp(GameEntity target) //เรียกรี implementation จาก base class และรีเรีซ็ตซ็ currentExp = 0
        {
            currentExp = 0;
        } 

    }
}
