using System;
using UnityEngine;

public class PlayerWController : MonoBehaviour
{
    public Action<GameObject> OnUseInput;
    public Action OnSecondaryUseInput;
    public Action<int> OnWeaponChange;
    [SerializeField] private Weapon startingWeapon;
    WeaponController wController;

    private void OnEnable()
    {
        wController = new(startingWeapon);
        OnUseInput += wController.PrimaryUse;
        OnSecondaryUseInput += wController.SecondaryUse;
        OnWeaponChange += wController.ChangeWeapon;
    }

    private void OnDisable()
    {
        OnUseInput -= wController.PrimaryUse;
        OnSecondaryUseInput -= wController.SecondaryUse;
        OnWeaponChange -= wController.ChangeWeapon;
    }


}
