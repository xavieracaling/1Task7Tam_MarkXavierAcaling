using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "WeaponConfig", menuName = "Config/WeaponConfig")]
public class WeaponConfig : ScriptableObject
{
    public Sprite WeaponSprite;
    public string weaponName;
    public float fireRate;
    public float damage;
    public float range;
    public BulletConfig bulletConfig;
    public GameObject bulletPrefab;
}