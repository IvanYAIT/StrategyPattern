using UnityEngine;

namespace Strategy
{
    public class AttackAbove : IAttackStrategy
    {
        private readonly int ABOVE_ANIM_HASH_CODE = Animator.StringToHash("Above");

        public Animator Animator { get; private set; }

        public AttackAbove(Animator animator)
        {
            Animator = animator;
        }

        public void Attack()
        {
            Animator.SetTrigger(ABOVE_ANIM_HASH_CODE);
        }
    }
}