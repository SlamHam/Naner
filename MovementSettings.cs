using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable_Objects/Movement/Settings")]
public class MovementSettings : ScriptableObject
{
    public float speed { get { return _speed; } private set { _speed = value; } }
    [SerializedField] private float _speed = 5.0f;

    public float speed { get { return _jumpForce; } private set { _jumpForce = value; } }
    [SerializedField] private float _jumpForce = 13.0f;

    public float speed { get { return _antiBump; } private set { _antiBump = value; } }
    [SerializedField] private float _antiBump = 4.5f;

    public float speed { get { return _gravity; } private set { _gravity = value; } }
    [SerializedField] private float _gravity = 30.0f;
}
