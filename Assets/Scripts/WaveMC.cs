using UnityEngine;

public class WaveMC : MovementController
{
    public override Vector3 GetMoveVector(float _speed, Vector3 _direction)
    {
        return base.GetMoveVector(_speed, _direction);
    }
}