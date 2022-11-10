using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewColorOnObjects : MonoBehaviour
{
    [SerializeField] Color32 _color;

    [Header("RandomColor")]
    [SerializeField] bool _randomColor;
    private void OnValidate()
    {
        var renderer = this.GetComponent<MeshRenderer>();
        var tempMaterial = new Material(renderer.sharedMaterial);
        tempMaterial.color = _color;
        renderer.material = tempMaterial;
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
}
