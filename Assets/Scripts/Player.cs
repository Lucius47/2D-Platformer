using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LivingEntity
{
    public float playerHealth = 200f;
    public float damageInflictedByPlayer = 20f;
    public float bulletSpeed = 20f;
    public float bulletLifeInSeconds = 10f;
    public Weapon weapon;

    void Start()
    {
        _health = playerHealth;
        _damageInflicted = damageInflictedByPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if(_health <= 0)
		{
            Die();
		}
		if (Input.GetButtonDown("Fire1"))
		{
            weapon.Shoot(_damageInflicted, bulletSpeed, bulletLifeInSeconds);
        }
    }
}
