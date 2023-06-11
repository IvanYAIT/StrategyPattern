using UnityEngine;

namespace Strategy
{
    public class StrategyController
    {
        private StrategyView _strategyView;
        private PlayerController _playerController;

        private IAttackStrategy _aboveAttackStrategy;
        private IAttackStrategy _belowAttackStrategy;
        private IAttackStrategy _strongAttackStrategy;

        public StrategyController(StrategyView strategyView, PlayerController playerController, Animator playerAnimator)
        {
            _strategyView = strategyView;
            _playerController = playerController;

            _aboveAttackStrategy = new AttackAbove(playerAnimator);
            _belowAttackStrategy = new AttackBelow(playerAnimator);
            _strongAttackStrategy = new StrongAttack(playerAnimator);

            _strategyView.AboveBtn.onClick.AddListener(SetAboveStrategy);
            _strategyView.BelowBtn.onClick.AddListener(SetBelowStrategy);
            _strategyView.StrongBtn.onClick.AddListener(SetStrongStrategy);

            SetAboveStrategy();
        }

        private void SetAboveStrategy()
        {
            _playerController.SetStrategy(_aboveAttackStrategy);
            _strategyView.AboveBtnImage.color = Color.green;
            _strategyView.BelowBtnImage.color = Color.white;
            _strategyView.StrongBtnImage.color = Color.white;
        }

        private void SetBelowStrategy()
        {
            _playerController.SetStrategy(_belowAttackStrategy);
            _strategyView.AboveBtnImage.color = Color.white;
            _strategyView.BelowBtnImage.color = Color.green;
            _strategyView.StrongBtnImage.color = Color.white;
        }

        private void SetStrongStrategy()
        {
            _playerController.SetStrategy(_strongAttackStrategy);
            _strategyView.AboveBtnImage.color = Color.white;
            _strategyView.BelowBtnImage.color = Color.white;
            _strategyView.StrongBtnImage.color = Color.green;
        }
    }
}