using Strategy;
using Template;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private AttackPerformer attackPerformer;
        [SerializeField] private StrategyView strategyView;
        [SerializeField] private TemplateView templateView;
        [SerializeField] private Animator playerAnimator;
        [SerializeField] private EnemySettings enemySettings;

        private TemplateController templateController;
        void Start()
        {
            PlayerController playerController = new PlayerController();
            attackPerformer.Construct(playerController);
            templateController = new TemplateController(templateView, enemySettings);
            StrategyController strategyController = new StrategyController(strategyView, playerController, playerAnimator);
        }

        private void Update()
        {
            templateController.Update();
        }
    }
}