using UnityEngine;

namespace Strategy
{
    public class AttackBelow : IAttackStrategy
    {
        private readonly int BELOW_ANIM_HASH_CODE = Animator.StringToHash("Below");

        public Animator Animator { get; private set; }

        public AttackBelow(Animator animator)
        {
            Animator = animator;
        }

        public void Attack()
        {
            Animator.SetTrigger(BELOW_ANIM_HASH_CODE);
        }
    }
}