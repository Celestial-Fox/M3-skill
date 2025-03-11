using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Bitmap : MonoBehaviour
{
    [SerializeField] Byte[] bytes = new Byte[8];
    [SerializeField] int[] values = new int[8];


    private void Start()
    {
        for (int i = 0; i < bytes.Length; i++)
        {
            values[i] = Random.Range(0, 255);
            bytes[i].SetValue(values[i]);
        }
        
    }
    void Update()
    {
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i].SetValue(values[i]);
        }
    }
}
