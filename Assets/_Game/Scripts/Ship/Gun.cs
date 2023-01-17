using System;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _laserPrefab;
        [SerializeField] private FloatVariable rechargeTime;
        private float delay;

        private void Update( )
        {
            if ( delay <= 0 )
            {
                if ( Input.GetKeyDown( KeyCode.Space ) )
                {
                    Shoot();
                    delay = rechargeTime.value;
                }
            }
            else
            {
                delay -= Time.deltaTime;
            }
        }

        private void Shoot( )
        {
            var trans = transform;
            Instantiate( _laserPrefab, trans.position, trans.rotation );
        }
    }
}