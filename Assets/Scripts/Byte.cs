using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;
    void Start()
    {
    }

    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        value = 0;
    }
}
