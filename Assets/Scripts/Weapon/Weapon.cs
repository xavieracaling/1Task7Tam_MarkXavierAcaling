using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class Weapon : MonoBehaviour
{
    public abstract void Shoot();
    public GameObject bulletPrefab;
    public Transform firePoint;
}

public class Pistol : Weapon
{
    public override void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Destroy(bullet, 0.5f);
    }
}

public class Shotgun : Weapon
{
    public int bulletCount = 5;
    public float spreadAngle = 30f;
    public override void Shoot()
    {
        for (int i = 0; i < bulletCount; i++)
        {
            float angle = spreadAngle * (i - (bulletCount - 1) / 2f) / (bulletCount - 1);
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation * Quaternion.Euler(0, 0, angle));
            Destroy(bullet, 0.5f);
        }
    }
}