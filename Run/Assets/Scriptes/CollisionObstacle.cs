using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionObstacle : MonoBehaviour
{

    //衝突の検知
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Time.timeScale = 0f;

            SceneManager.LoadScene("GameOverScene");

        }
    }
}
