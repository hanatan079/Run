using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //移動スピード、ジャンプ力
    [SerializeField]
    private float moveSpeed = 7f, jumpSpeed = 5f;

    //rigidBody格納
    private Rigidbody2D rd;


    private void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    //プレイヤーの移動速度(velocity=rigidbodyの速度ベクトル)
    private void MovePlayer()
    {
        rd.velocity = new Vector2(moveSpeed, rd.velocity.y);
    }
}
