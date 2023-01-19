using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSE : MonoBehaviour
{

    //シングルトン化
    public static SoundSE single;

    //SE格納
    public SE[] se;




    //SE再生
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

}
