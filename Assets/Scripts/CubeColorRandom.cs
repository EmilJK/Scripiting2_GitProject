using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorRandom : MonoBehaviour
{
    public void OnBecameInvisible()
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}
