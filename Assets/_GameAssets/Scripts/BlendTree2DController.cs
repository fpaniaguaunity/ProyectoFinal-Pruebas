using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree2DController : MonoBehaviour
{
    float h;
    float v;
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("Horizontal",h);
        GetComponent<Animator>().SetFloat("Vertical",v);
    }
}
