using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    //キャンバス
    private static Canvas gameOverCanvas;



    void Awake()
    {
        gameOverCanvas = GetComponent<Canvas>();
    }

    //リスタート
    public static void RePlay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameOverScene");

    }
}
