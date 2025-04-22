using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] float speed;
    public Action<Vector2> OnMoveInput;
    private MovementController mController;

    private void OnEnable()
    {
        mController = new MovementController();
        OnMoveInput += MovementPressed;
    }

    private void OnDisable()
    {
        OnMoveInput -= MovementPressed;
    }

    private void MovementPressed(Vector2 input)
    {
        gameObject.transform.position += mController.GetMoveVector(speed, input);
    }
}
