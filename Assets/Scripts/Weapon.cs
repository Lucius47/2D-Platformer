using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    public void Shoot(float _damageInflicted, float _speed, float _life)
    {
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation).GetComponent<Bullet>();
        bullet.SetValues(_damageInflicted, _speed, _life);
    }
}
