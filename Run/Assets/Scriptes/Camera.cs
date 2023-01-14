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



    //プレイヤーを探す
    private void FindPlayer()
    {
        playerPos = GameObject.FindWithTag("Player").transform;
    }

    //追跡する
    private void TrackingPlayer()
    {
        if(playerPos)
        {
            cameraPos = transform.position;
            cameraPos.x = playerPos.position.x - playerDistance;

            transform.position = cameraPos;
        }
    }
}
