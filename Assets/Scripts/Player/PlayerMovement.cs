using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private ChildRotation _childRotation;
    private CharacterController _characterController;
    private Vector3 _currentPosition;
    private Vector3 _hitPoint;

    void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _childRotation = GetComponentInChildren<ChildRotation>();
    }

    void Update()
    {
        if (_currentPosition != _hitPoint)
        {
            Move(_hitPoint);
        }
    }

    public void Move(Vector3 hitPoint)
    {
        _currentPosition = this.gameObject.transform.position;
        _hitPoint = hitPoint;
        var _direction = (_hitPoint - _currentPosition).normalized;
        _childRotation.LookAtDirection(_direction);
        _characterController.Move(_direction * speed  * Time.deltaTime);
    }

    public void Roll()
    {
        print("Roll");
    }

    public void StopMoving()
    {
        _hitPoint = _currentPosition;
    }
}