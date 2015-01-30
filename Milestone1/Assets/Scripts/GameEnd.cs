using System;
using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour
{


    private float time = 60.0f;
    private int seconds = 1;
    public GUIText timer;
    public GUIText enemiesLeft;
    public GUIText gameover;
    private int enemies = 6;
    public Player ship;

    void Start()
    {
        EnemyUpdate();
    }

    void Update()
    {
        if (seconds == 0)
        {
            gameover.text = "GAME OVER!";
            Player.Destroy(ship);
        }
        else if (enemies == 0 && seconds > 0)
        {
            gameover.text = "WINNNER!";
            Player.Destroy(ship);
        }
        else 
        {
            time = time - Time.deltaTime;
            seconds = Convert.ToInt32(time%60);
            timer.text = "Time Remaining: " + seconds.ToString();
        }
    }

   public void EnemyUpdate()
    {
        enemies--;
        enemiesLeft.text = "Enemies: " + enemies.ToString();
    }

}
