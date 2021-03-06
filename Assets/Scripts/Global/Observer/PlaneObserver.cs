using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlaneObserver : MonoBehaviour
{
    ServiceEvents e = new ServiceEvents();
    public static int Score = 0;
    public static int lives = 3;
    public TMP_Text life;
    public TMP_Text score;
    public Image gameOver;

    private void Start()
    {
        e.OnGroundHit += OnCollisionEnter;
        gameOver.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Apples")
        {
            lives--;
            Destroy(collision.gameObject);
            e.OnGroundHit -= OnCollisionEnter;
        }
        else
        {
            Destroy(collision.gameObject);
            e.OnGroundHit -= OnCollisionEnter;
        }
        
    }

    private void Update()
    {
        life.SetText(lives.ToString());
        score.SetText(Score.ToString());
        if(lives <= 0)
        {
            gameOver.enabled = true;
        }
    }
}
