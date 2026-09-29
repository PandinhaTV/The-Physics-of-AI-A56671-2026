using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;
    private float speed = 0;
    float yspeed = 0f;
    private float mass = 10;
    private float force = 1;
    private float acceleration;
    private float drag = 1;
    float gravity = -9.81f;
    private float gAccel;
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        acceleration = force / mass;
        speed += acceleration * 1;
        gAccel += gravity/mass;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        speed*=(1-Time.deltaTime*drag);
        yspeed += gAccel*Time.deltaTime;
        this.transform.Translate(0,yspeed,speed );
    }
}
