using UnityEngine;
using TMPro;
using ConvertsDigits;

public class Upgrade : MonoBehaviour
{
    public double Value;
    public TextMeshProUGUI[] ValueTMP;

    public double Cost;
    public TextMeshProUGUI CostTMP;

    public delegate void ValueChange();
    public ValueChange ValueChanged;
    private void Start()
    {
        ValueChanged = UpdateAllValueTexts;
    }
    public void AddValue(double value)
    {
        Value += value;
        ValueChanged();
    }
    public void MinusValue(double value)
    {
        Value -= value;
        ValueChanged();
    }

    public void ChangeCost(double value)
    {
        Cost = value;
        ValueChanged();
    }

    private void UpdateAllValueTexts()
    {
        foreach (var tmp in ValueTMP)
        {
            tmp.text = Converter.FormatNum(Value);
        }
        CostTMP.text = Converter.FormatNum(Cost); 
    }
}
