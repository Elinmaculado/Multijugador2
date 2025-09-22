using System;
using UnityEngine;
using Fusion;

public class TrafficLight : NetworkBehaviour
{
    private MeshRenderer _mr;
    public int index = 0;
    public Color[] colors = { Color.green, Color.yellow, Color.red };

    private void Start()
    {
        gameObject.TryGetComponent(out _mr);
    }

    public void ChangeColor()
    {
        index = (index + 1) % colors.Length;
        _mr.material.color = colors[index];
    }
    
    
}
