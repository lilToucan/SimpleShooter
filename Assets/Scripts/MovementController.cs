using UnityEngine;

public class MovementController 
{
    public virtual Vector3 GetMoveVector(float _speed, Vector3 _direction) => _speed * Time.deltaTime * _direction;
}
