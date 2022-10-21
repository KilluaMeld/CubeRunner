using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSettings : MonoBehaviour
{
    [SerializeField] private double _damage;
    [SerializeField] private double _size;
    private void Start()
    {
        _damage = PlayerSettings.instance.Damage.Value;
        _size = PlayerSettings.instance.BulletSize.Value;
        this.transform.localScale = new Vector3((float)_size, (float)_size, (float)_size);
    }
    public double GetDamage()
    {
        return _damage;
    }
}
