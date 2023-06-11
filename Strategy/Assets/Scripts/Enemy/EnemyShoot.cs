using System.Collections;
using UnityEngine;

namespace Template
{
    public class EnemyShoot : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _shootPoint;

        public void Attack()
        {
            Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.identity);

        }
    }
}