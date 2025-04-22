using System.Collections.Generic;
using UnityEngine;

public class WeaponController
{
    public List<Weapon> WeaponList;
    private int listIndex;
    public Weapon CurrentWeapon => WeaponList[listIndex];

    public WeaponController(Weapon _weapon)
    {
        listIndex = 0;
        this.WeaponList = new List<Weapon>();
        WeaponList.Add(_weapon);
    }

    public WeaponController(List<Weapon> _WeaponList)
    {
        this.WeaponList = _WeaponList;
    }

    public void ChangeWeapon(int input)
    {
        listIndex += input;

        if (listIndex >= WeaponList.Count)
            listIndex = 0;

        else if (listIndex <= 0)
            listIndex = WeaponList.Count - 1;

    }

    public void PrimaryUse(GameObject weapon)
    {
        CurrentWeapon.Use(weapon);
    }

    public void SecondaryUse()
    {
        CurrentWeapon.SecondaryUse();
    }

}
