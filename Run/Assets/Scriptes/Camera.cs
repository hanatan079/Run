using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    //プレイヤーの位置格納用
    private Transform playerPos;

    //プレイヤーとの距離
    [SerializeField]
    private float playerDistance = -5f;

    //カメラ移動ポジ
    [SerializeField]
    private Vector3 cameraPos;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
