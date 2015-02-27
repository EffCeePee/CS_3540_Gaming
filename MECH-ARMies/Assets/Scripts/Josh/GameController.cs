using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	private bool gameOverPlayer1;
	private bool gameOverPlayer2;
    public GameObject Ship;
    private Vector3 location = new Vector3(105,34.5f,105);

	// Use this for initialization
	void Start () {
		gameOverPlayer1 = false;
		gameOverPlayer2 = false;
	    Ship = (GameObject) Instantiate(Ship, location,Ship.transform.rotation);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
