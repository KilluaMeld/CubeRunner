using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 Direction;

    private Vector3 DirectionForTranslate()
    {
        return new Vector3(Direction.x, Direction.y, Direction.z);
    }
    private void Move()
    {
        this.gameObject.transform.Rotate(DirectionForTranslate(), Time.deltaTime * _speed);
    }
    void FixedUpdate()
    {
        Move();
    }
}
