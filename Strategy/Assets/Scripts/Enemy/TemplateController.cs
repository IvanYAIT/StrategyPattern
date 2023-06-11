using System.Collections;
using System.Collections.Generic;

namespace Template
{
    public class TemplateController
    {
        private TemplateView _templateView;
        private EnemySettings _enemySettings;

        private AEnemy _currentEnemy;

        public TemplateController(TemplateView templateView, EnemySettings enemySettings)
        {
            _enemySettings = enemySettings;
            _templateView = templateView;

            _templateView.MeleeBtn.onClick.AddListener(SetMeleeEnemy);
            _templateView.RangeBtn.onClick.AddListener(SetRangeEnemy);
            _templateView.BossBtn.onClick.AddListener(SetBoss);

            SetMeleeEnemy();
        }

        public void Update() =>
            _currentEnemy.PerformAttack();

        private void SetMeleeEnemy()
        {
            _enemySettings.MeleeEnemy.SetActive(true);
            _enemySettings.RangeEnemy.SetActive(false);
            _enemySettings.Boss.SetActive(false);
            _currentEnemy = new MeleeEnemy(_enemySettings.MeleeEnemyAnim);
        }

        private void SetRangeEnemy()
        {
            _enemySettings.MeleeEnemy.SetActive(false);
            _enemySettings.RangeEnemy.SetActive(true);
            _enemySettings.Boss.SetActive(false);
            _currentEnemy = new RangeEnemy(_enemySettings.RangeEnemyAnim);
        }

        private void SetBoss()
        {
            _enemySettings.MeleeEnemy.SetActive(false);
            _enemySettings.RangeEnemy.SetActive(false);
            _enemySettings.Boss.SetActive(true);
            _currentEnemy = new Boss(_enemySettings.BossAnim);
        }
    }
}