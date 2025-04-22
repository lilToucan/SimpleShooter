using UnityEngine;

public class SpeedUpMC : MovementController
{
    Vector3 target;

    public SpeedUpMC(Vector3 _target)
    {
        this.target = _target;
    }

    public override Vector3 GetMoveVector(float _speed, Vector3 _direction)
    {
        return base.GetMoveVector(_speed, _direction);
    }
}