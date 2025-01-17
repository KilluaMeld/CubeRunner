using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ConvertsDigits;

public class Enemy : MonoBehaviour
{
    [SerializeField] private double _score;
    [SerializeField] private TextMeshPro[] _scoreTexts;
    [SerializeField] private MapSettings _mapSettings;
    private void Start()
    {
        _mapSettings = GameObject.FindObjectOfType<MapSettings>();
        UpdateScoreTexts();
        UpdateColor();
    }
    void TakeDamage(double dagame)
    {
        _score -= dagame;
        if (_score <= 0)
        {
            Destroy(this.gameObject);
        }
        UpdateScoreTexts();
    }
    private byte FormatColor()
    {
        var randColorByte = System.Convert.ToByte(Random.Range(0, 255));
        return randColorByte;
    }
    private void UpdateColor()
    {
        this.GetComponent<Renderer>().material.color = new Color32(FormatColor(), FormatColor(), FormatColor(), 255);
    }
    private void UpdateScoreTexts()
    {
        foreach (var score in _scoreTexts)
        {
            score.text = Converter.FormatNum(_score);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BulletSettings>())
        {
            var value = other.gameObject.GetComponent<BulletSettings>().GetDamage();
            TakeDamage(value);
            _mapSettings.AddScore(value);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            _mapSettings.LoseLevel();
        }
    }
}
