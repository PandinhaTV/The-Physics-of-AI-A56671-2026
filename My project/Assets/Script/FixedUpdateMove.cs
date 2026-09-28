using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour
{
    public float speed = 1;
    void FixedUpdate()
    {
        this.transform.Translate(0,0,speed*Time.deltaTime);
    }
}
