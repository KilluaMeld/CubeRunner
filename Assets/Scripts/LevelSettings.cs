using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSettings : MonoBehaviour
{
    [SerializeField] private int _level;
    [SerializeField] private GameObject _checkMark;
    [SerializeField] private GameObject _lockPanel;
    void Start()
    {
        UpdateViewAboutLevel();
    }
    public void SetLevel()
    {
        if (_level <= GameSettings.instance.CurrentLevel)
        {
            GameSettings.instance.ChooseLevel = _level;
        }
    }
    public void UpdateViewAboutLevel()
    {
        if(GameSettings.instance.CurrentLevel == _level)
        {
            _lockPanel.SetActive(false);
            _checkMark.SetActive(false);
            return;
        }


        if (GameSettings.instance.CurrentLevel<_level)
        {
            _checkMark.SetActive(false);
            _lockPanel.SetActive(true);
        }
        else
        {
            _checkMark.SetActive(true);
            _lockPanel.SetActive(false);
        }
    }
}
