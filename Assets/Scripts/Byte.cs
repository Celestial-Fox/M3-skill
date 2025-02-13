using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;
    int i = new int();
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

        for (int i = 0; i < bits.Length; i++) 
        { 
            if (bits[i].state)
            {
                value += (1 << i);
            }
        }
    }
}
