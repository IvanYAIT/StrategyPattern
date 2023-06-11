using UnityEngine;

namespace Template
{
    public class Boss : AEnemy
    {
        private readonly int ATTACK_ANIM_HASH_CODE = Animator.StringToHash("Attack");

        public Boss(Animator animator) : base(animator)
        {
        }

        public override void Attack()
        {
            if(Input.GetKeyDown(KeyCode.Q))
                Animator.SetTrigger(ATTACK_ANIM_HASH_CODE);
        }
    }
}