using UnityEngine;
using TMPro;
using ConvertsDigits;

public class Currency : MonoBehaviour
{
    public double Value;
    public TextMeshProUGUI[] ValueTMP;
    public delegate void ValueChange();
    public ValueChange ValueChanged;
    private void Start()
    {
        ValueChanged = UpdateValueTexts;
    }
    public void AddValue(double value)
    {
        Value += value;
        ValueChanged();
    }
    private void UpdateValueTexts()
    {
        foreach (var tmp in ValueTMP)
        {
            tmp.text = Converter.FormatNum(Value);
        }
    }
}
