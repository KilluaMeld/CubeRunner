using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootElement : MonoBehaviour
{
    [SerializeField] double _timeToSpawnBullet;
    [SerializeField] GameObject _bulletPrefab;

    private float miliseconds = 0;
    void Start()
    {
        _timeToSpawnBullet = PlayerSettings.instance.ShootingSpeed.Value;
        //StartCoroutine(SpawnerBullets());
    }
    private void FixedUpdate()
    {
        miliseconds += Time.fixedDeltaTime;
        if (miliseconds >= _timeToSpawnBullet)
        {
            Instantiate(_bulletPrefab, this.transform.position, Quaternion.identity);
            miliseconds = 0;
        }
    }
    IEnumerator SpawnerBullets()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime((float)_timeToSpawnBullet);
            Instantiate(_bulletPrefab, this.transform.position, Quaternion.identity);
        }
    }
}
