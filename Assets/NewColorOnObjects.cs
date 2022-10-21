using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewColorOnObjects : MonoBehaviour
{
    [SerializeField] Color32 _color;
    private void OnValidate()
    {
        var renderer = this.GetComponent<Renderer>();
        var tempMaterial = new Material(renderer.sharedMaterial);
        tempMaterial.color = _color;
        renderer.sharedMaterial = tempMaterial;
    }
}
