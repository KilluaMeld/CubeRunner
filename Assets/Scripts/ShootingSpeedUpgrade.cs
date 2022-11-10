using UnityEngine;
using ConvertsDigits;
using TMPro;

public class ShootingSpeedUpgrade : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _cost;
    [SerializeField] private TextMeshProUGUI _description;
    void Start()
    {
        PlayerSettings.instance.ShootingSpeed.ValueChanged += UpdateCostTMP;
        UpdateCostTMP();
    }

    private void UpdateCostTMP()
    {
        _cost.text = Converter.FormatNum(PlayerSettings.instance.ShootingSpeed.Cost);
        _description.text = $"1 shot / {PlayerSettings.instance.ShootingSpeed.Value} sec";
    }
    public void BuyUpggrade()
    {
        PlayerSettings.instance.Gem.MinusValue(PlayerSettings.instance.ShootingSpeed.Cost);
        PlayerSettings.instance.ShootingSpeed.MinusValue(0.1d);
    }
}
