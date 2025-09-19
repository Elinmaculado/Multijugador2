using UnityEngine;
using Fusion;
using UnityEngine.InputSystem;
public class ColorNetworked : NetworkBehaviour
{
    private MeshRenderer mr;
    [Networked, OnChangedRenderAttribute(nameof(ShainBrightLaikADaimond))]
    
    public Color color {  get; set; }

    private void Start()
    {
        gameObject.TryGetComponent(out mr);
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) 
        {
            color = Random.ColorHSV();
        }
    }
    private void ShainBrightLaikADaimond()
    {
        mr.material.color = color;
    }
    [Networked, OnChangedRenderAttribute(nameof(ColorChanged))]
    public Color NetworkColor {  get; set; }

    public void ColorChanged()
    {
        Debug.Log("Color Shi");
    }

}
