using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorRandom : MonoBehaviour
{
    int i;
    public void OnBecameInvisible()
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        print(i++);
    }
}
