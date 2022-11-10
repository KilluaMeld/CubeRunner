using UnityEngine;
using ConvertsDigits;
using TMPro;

public class BulletDamageUpgrade : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _dmgCost;
    [SerializeField] private TextMeshProUGUI _description;
    void Start()
    {
        PlayerSettings.instance.Damage.ValueChanged += UpdateCostTMP;
        UpdateCostTMP();
    }

    private void UpdateCostTMP()
    {
        _dmgCost.text = Converter.FormatNum(PlayerSettings.instance.Damage.Cost);
        _description.text = $"Damage: {Converter.FormatNum(PlayerSettings.instance.Damage.Value)}";
    }
    public void BuyUpggrade()
    {
        PlayerSettings.instance.Gem.MinusValue(PlayerSettings.instance.Damage.Cost);
        PlayerSettings.instance.Damage.AddValue(1);
    }
}
