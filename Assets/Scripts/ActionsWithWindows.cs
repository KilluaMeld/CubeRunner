using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsWithWindows : MonoBehaviour
{
    [SerializeField] GameObject[] _windowsForClose;
    [SerializeField] GameObject[] _windowsForOpen;

    public void Action()
    {
        Debug.Log("click");
        foreach (var item in _windowsForClose)
        {
            item.SetActive(false);
        }
        foreach (var item in _windowsForOpen)
        {
            item.SetActive(true);
        }
    }
}
