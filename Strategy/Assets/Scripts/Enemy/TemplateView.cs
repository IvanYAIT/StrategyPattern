using UnityEngine;
using UnityEngine.UI;

namespace Template
{
    public class TemplateView : MonoBehaviour
    {
        [SerializeField] private Button meleeBtn;
        [SerializeField] private Button rangeBtn;
        [SerializeField] private Button bossBtn;

        public Button MeleeBtn => meleeBtn;
        public Button RangeBtn => rangeBtn;
        public Button BossBtn => bossBtn;
    }
}