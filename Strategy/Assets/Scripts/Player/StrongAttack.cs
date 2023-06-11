using UnityEngine;

namespace Strategy
{
    public class StrongAttack : IAttackStrategy
    {
        private readonly int STRONG_ANIM_HASH_CODE = Animator.StringToHash("Strong");

        public Animator Animator { get; private set; }

        public StrongAttack(Animator animator)
        {
            Animator = animator;
        }

        public void Attack()
        {
            Animator.SetTrigger(STRONG_ANIM_HASH_CODE);
        }
    }
}