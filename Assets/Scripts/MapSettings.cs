using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using ConvertsDigits;

public class MapSettings : MonoBehaviour
{
    [SerializeField] private double _score;
    [SerializeField] private TextMeshProUGUI _scoreTMP;

    private void Start()
    {
        UpdateScoreTMP();
    }
    public void AddScore(double value)
    {
        _score += value;
        UpdateScoreTMP();
    }
    private void UpdateScoreTMP()
    {
        _scoreTMP.text = Converter.FormatNum(_score);
    }

    public void LoseLevel()
    {
        Debug.Log("Lose");
        SceneManager.LoadScene(0);
    }
    public void WinLevel()
    {
        PlayerSettings.instance.Gem.AddValue(_score / 100);
        Debug.Log("Win");
    }


}
