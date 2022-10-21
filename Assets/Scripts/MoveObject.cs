using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 Direction;

    private Vector3 DirectionForTranslate()
    {
        return new Vector3(Direction.x * Time.deltaTime * _speed, Direction.y, Direction.z);
    }
    private void Move()
    {
        this.gameObject.transform.Translate(DirectionForTranslate());
    }
    void Update()
    {
        Move();
    }
}
