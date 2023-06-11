using UnityEngine;

namespace Template
{
    public abstract class AEnemy
    {
        public Animator Animator { get; }

        protected AEnemy(Animator animator)
        {
            Animator = animator;
        }

        public void PerformAttack()
        {
            Attack();
        }

        public abstract void Attack();
    }
}