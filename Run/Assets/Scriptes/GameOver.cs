using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    //キャンバス
    private static Canvas gameOverCanvas;



    void Awake()
    {
        gameOverCanvas = GetComponent<Canvas>();
    }



    //パネルを開く
    public static void GameOverOpenPanel()
    {
        Time.timeScale = 0f;
    }

}
