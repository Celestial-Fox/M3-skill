using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPixel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color color;
    void Start()
    {
        change();
    }

    void Update()
    {
        spriteRenderer.color = color;
        if (Input.GetButtonDown("Jump"))
        {
            change();
        }
        change();
    }

    void change()
    {
        float R = Random.value;
        float G = Random.value;
        float B = Random.value;
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = new Color(R, G, B);
    }
}
