using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class TrueColor : MonoBehaviour
{
    [SerializeField]ColorPixel colorPixel;
    void Start()
    {
        for (int i = 0; i < 500; i++)
        {


            float xRand = Random.Range(-8f, 8f);
            float yRand = Random.Range(-4f, 4f);
            Vector3 pos = new Vector3(xRand, yRand, 0);
            Instantiate(colorPixel, pos, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }

    
}
