using UnityEngine;
using System.Collections;

public class ShotEnemy : MonoBehaviour {
    public GameEnd game;
    public GUIText gameover;
    public Player ship;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        
        if(other.tag == "Player")
        {
            gameover.text = "GAME OVER!";
            Player.Destroy(ship);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
        game.EnemyUpdate();
    }
}
