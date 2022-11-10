using UnityEngine;
using ConvertsDigits;
using TMPro;

public class BulletSizeUpgrade : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _cost;
    [SerializeField] private TextMeshProUGUI _description;
    void Start()
    {
        PlayerSettings.instance.BulletSize.ValueChanged += UpdateCostTMP;
        UpdateCostTMP();
    }

    private void UpdateCostTMP()
    {
        _cost.text = Converter.FormatNum(PlayerSettings.instance.BulletSize.Cost);
        _description.text = $"Size: {PlayerSettings.instance.BulletSize.Value}";
    }
    public void BuyUpggrade()
    {
        PlayerSettings.instance.Gem.MinusValue(PlayerSettings.instance.BulletSize.Cost);
        PlayerSettings.instance.BulletSize.AddValue(0.1d);
    }
}
