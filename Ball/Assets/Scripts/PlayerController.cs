using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVeritcal = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0,moveVeritcal);

        rigidbody.AddForce(movement * speed * Time.deltaTime);
    }

}
