using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSE : MonoBehaviour
{

    //シングルトン化
    public static SoundSE single;

    //SE格納
    public AudioSource[] se;


    //singleをからにする
    private void Awake()
    {
        if(single == null)
        {
            single = this;
        }
        else if(single != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    //SE再生(0.衝突音 1.ジャンプ)
    public void StartSE(int x)
    {
        se[x].Stop();
        se[x].Play();
    }
}