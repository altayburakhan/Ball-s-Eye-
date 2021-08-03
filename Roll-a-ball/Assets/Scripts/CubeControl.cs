using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    
    void Update()
    {
        Vector3 vektor = new Vector3(15,30,45);
        transform.Rotate(vektor*0.03f);
    }
}
