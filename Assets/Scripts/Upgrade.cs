using UnityEngine;
using TMPro;
using ConvertsDigits;

public class Upgrade : MonoBehaviour
{
    public double Value;
    public double Cost;

    public delegate void ValueChange();
    public ValueChange ValueChanged;
    public void AddValue(double value)
    {
        Value += value;
        ValueChanged?.Invoke();
    }
    public void MinusValue(double value)
    {
        Value -= value;
        ValueChanged?.Invoke();
    }

    public void ChangeCost(double value)
    {
        Cost = value;
        ValueChanged?.Invoke();
    }
}
