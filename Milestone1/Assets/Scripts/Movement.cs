using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private float tumble = 10.0f;

    void Start ()
    {
        rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
    }
	
	
}
