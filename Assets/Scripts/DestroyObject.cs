using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] float _timeToDestroy;
    void Start()
    {
        StartCoroutine(DestroyObjectWithDelay());
    }
        
    IEnumerator DestroyObjectWithDelay()
    {
        yield return new WaitForSecondsRealtime(_timeToDestroy);
        Destroy(this.gameObject);
    }
}

