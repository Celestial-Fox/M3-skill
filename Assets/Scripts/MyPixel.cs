using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyPixel : MonoBehaviour
{
    public GameObject Pixel;
    private SpriteRenderer spriteRenderer;
    public Byte ByteR;
    public Byte ByteG;
    public Byte ByteB;

    void Start()
    {
        
    }

    void Update()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }

        //if (ByteR != null && ByteG != null && ByteB != null && Pixel != null)
        //{
            //colorCode = "#" + ByteR.getHex() + ByteG.getHex() + ByteB.getHex();

            //if (UnityEngine.ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            //{
            //    spriteRenderer.color = newColor;
            //}
            //else
            //{
            //   Debug.LogError("Ongeldige hex kleur: " + colorCode);
            //}
        //}
    }
}
