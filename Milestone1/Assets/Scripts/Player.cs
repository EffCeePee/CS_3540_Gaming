using System;
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float speed;

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    public float rotationSpeed = 100.0F;


    public GameObject shot;
    public Transform shootingOrigin;
    private float fireRate = 0.25f;

    private float nextFire;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shootingOrigin.position, shootingOrigin.rotation);
        }
    }


	void FixedUpdate ()
	{
	    float moveHorizontal = Input.GetAxis("Horizontal");
	    float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        rigidbody.velocity = movement * speed;
        
        float Rotation = Input.GetAxis("Rotate") * rotationSpeed;
	    
            Rotation *= Time.deltaTime;
	    

        transform.Rotate(0, 0, Rotation);

        rigidbody.position = new Vector3
        (
            Mathf.Clamp(rigidbody.position.x, xMin, xMax), //x
            10.0f, //y
            Mathf.Clamp(rigidbody.position.z, zMin, zMax) //z

        );

    }
}

