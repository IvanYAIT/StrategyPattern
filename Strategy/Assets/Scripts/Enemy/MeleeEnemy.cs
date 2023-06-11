using UnityEngine;

namespace Template
{
    public class MeleeEnemy : AEnemy
    {
        private readonly int ATTACK_ANIM_HASH_CODE = Animator.StringToHash("Attack");

        private bool isAttacked;

        public MeleeEnemy(Animator animator) : base(animator)
        {
            isAttacked = false;
        }

        public override void Attack()
        {
            if (!isAttacked)
            {
                Animator.SetTrigger(ATTACK_ANIM_HASH_CODE);
                isAttacked = true;
            }
        }
    }
}