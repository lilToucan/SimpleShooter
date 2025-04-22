using UnityEngine;

public class MeleeWeapon : Weapon
{
    public MeleeWeaponSO weaponSO;

    public override void Use(GameObject weapon)
    {
        Swing(weapon);
    }

    public override void SecondaryUse()
    {
        Block();
    }

    private void Swing(GameObject weapon)
    {

    }
    private void Block()
    {

    }
}
