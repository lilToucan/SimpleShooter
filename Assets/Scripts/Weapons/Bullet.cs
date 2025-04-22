using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 startPos;
    Vector3 targetPos;
    Vector3 direction;
    float speed;
    MovementController mController;
    RangedWeapon weaponUsedToFire;

    public void Activate(RangedWeapon _weapon, BULLETTYPE _bulletType)
    {

        direction = (targetPos - startPos).normalized;

        switch ((int)_bulletType)
        {
            case 0:
                mController = new MovementController();
                break;

            case 1:
                mController = new WaveMC();
                break;

            case 2:
                mController = new SpeedUpMC(targetPos);
                break;

            default:
                Debug.LogError("how???");
                break;
        }
    }

    private void Update()
    {
        mController.GetMoveVector(speed,direction);
    }
}

public enum BULLETTYPE
{
    Normal = 0,
    Wave = 1,
    SpeedUp = 2,
}