using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private WeaponConfig pistolConfig;
    [SerializeField] private WeaponConfig shotgunConfig;
    private WeaponConfig currentWeaponConfig;

    [SerializeField] private Image weaponImage;


    void Start()
    {
        currentWeaponConfig = pistolConfig;
    }

    public void Shoot()
    {
        Instantiate(currentWeaponConfig.bulletPrefab, transform.position, transform.rotation);
    }

    public void SwitchToPistol()
    {
        currentWeaponConfig = pistolConfig;
        weaponImage.sprite = currentWeaponConfig.WeaponSprite;
    }

    public void SwitchToShotgun()
    {
        currentWeaponConfig = shotgunConfig;
        weaponImage.sprite = currentWeaponConfig.WeaponSprite;
    }
}
