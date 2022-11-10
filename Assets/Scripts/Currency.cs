using UnityEngine;
using TMPro;
using ConvertsDigits;

public class Currency : MonoBehaviour
{
    public double Value;
    public delegate void ValueChange();
    public ValueChange ValueChanged;
    public void AddValue(double value)
    {
        Value += value;
        ValueChanged?.Invoke();
    }
    public void MinusValue(double value)
    {
        if (Value >= value)
        {
            Value -= value;
            ValueChanged?.Invoke();
        }
        else
        {
            Debug.Log("No currency");
        }
    }

    public void ChangeCost(double value)
    {
        ValueChanged?.Invoke();
    }
}
