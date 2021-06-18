using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour
{
    protected float _health;
    protected float _damageInflicted;


    public void TakeDamage(float _damage)
	{
        _health -= _damage;
	}
    
    protected void Die()
	{
        Destroy(this.gameObject);
	}
}
