using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    private float speed = 50.0f;
    
    void Start ()
    {
        rigidbody.velocity = (transform.forward) * speed;
    }
}
