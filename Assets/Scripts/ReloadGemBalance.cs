using UnityEngine;
using ConvertsDigits;
using TMPro;

public class ReloadGemBalance : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gemBalance;
    void Start()
    {
        PlayerSettings.instance.Gem.ValueChanged += UpdateBalanceTMP;
        UpdateBalanceTMP();
    }

    private void UpdateBalanceTMP()
    {
        _gemBalance.text = Converter.FormatNum(PlayerSettings.instance.Gem.Value);
    }

}
