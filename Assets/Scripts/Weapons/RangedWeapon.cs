using UnityEngine;

public class RangedWeapon : Weapon
{
    public RangedWeaponSO weaponSO;
    private int currentMag;

    private void Start()
    {
        Reload();
    }

    public override void Use(GameObject weapon)
    {
        Shoot(weapon);
    }

    public override void SecondaryUse()
    {
        Reload();
    }

    private void Shoot(GameObject weapon)
    {
        // weapon.transform.forward
        int bulletsPerShoot = weaponSO.BulletsPerShot;

        currentMag -= bulletsPerShoot;
       
        {
            bulletsPerShoot -= currentMag;
        }

        for (int i = 0; i < weaponSO.BulletsPerShot; i++)
        {
            currentMag--;
            if (currentMag <= 0)
                break;

            // activate bullets from the pooler 
        }

    }

    private void Reload()
    {
        currentMag = weaponSO.MagSize;
    }
}