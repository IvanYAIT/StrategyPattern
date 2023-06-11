using UnityEngine;

namespace Template
{
    public class EnemySettings : MonoBehaviour
    {
        [SerializeField] private GameObject meleeEnemy;
        [SerializeField] private GameObject rangeEnemy;
        [SerializeField] private GameObject boss;

        [SerializeField] private Animator meleeEnemyAnim;
        [SerializeField] private Animator rangeEnemyAnim;
        [SerializeField] private Animator bossAnim;

        public GameObject MeleeEnemy => meleeEnemy;
        public GameObject RangeEnemy => rangeEnemy;
        public GameObject Boss => boss;

        public Animator MeleeEnemyAnim => meleeEnemyAnim;
        public Animator RangeEnemyAnim => rangeEnemyAnim;
        public Animator BossAnim => bossAnim;

    }
}