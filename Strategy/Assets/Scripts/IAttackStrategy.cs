using UnityEngine;

namespace Strategy
{
    public interface IAttackStrategy
    {
        Animator Animator { get; }

        void Attack();
    }
}