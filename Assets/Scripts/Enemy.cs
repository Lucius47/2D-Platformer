using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : LivingEntity
{
    public float enemyHealth = 100f;
    public float damageInflictedByEnemy = 20f;
    public float bulletSpeed = 20f;
    public float bulletLifeInSeconds = 5f;
    public float timeBetweenShots = 1f;
    float xyz = 0;

    public Weapon weapon;
    void Start()
    {
        _health = enemyHealth;
        _damageInflicted = damageInflictedByEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        if(_health <= 0)
		{
            Die();
		}

        xyz += Time.time;
        if(Mathf.Abs(xyz - timeBetweenShots) <= 0.1)
		{
            if (weapon != null)
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, 10f);
                if (hitInfo)
                {
                    weapon.Shoot(_damageInflicted, bulletSpeed, bulletLifeInSeconds);
                }
            }
            timeBetweenShots += Time.time;
        }
    }
}
