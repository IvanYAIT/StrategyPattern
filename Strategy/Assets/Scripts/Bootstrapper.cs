using Strategy;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private AttackPerformer attackPerformer;
        [SerializeField] private StrategyView strategyView;
        [SerializeField] private Animator playerAnimator;

        void Start()
        {
            PlayerController playerController = new PlayerController();
            attackPerformer.Construct(playerController);
            StrategyController strategyController = new StrategyController(strategyView, playerController, playerAnimator);
        }
    }
}