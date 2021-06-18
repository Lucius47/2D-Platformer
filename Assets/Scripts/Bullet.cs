using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    float bulletSpeed;
    float damageInflicted;
    float lifeInSeconds;


    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
        StartCoroutine(Life());
    }
	
    IEnumerator Life()
	{
        yield return new WaitForSeconds(lifeInSeconds);
        Destroy(this.gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
        LivingEntity livingEntity = collision.GetComponent<LivingEntity>();
        if (livingEntity != null)
        {
            livingEntity.TakeDamage(damageInflicted);
        }
		
        Destroy(this.gameObject);
    }

    public void SetValues(float _damageInflicted, float _speed, float _life)
	{
        bulletSpeed = _speed;
        damageInflicted = _damageInflicted;
        lifeInSeconds = _life;
	}
}
