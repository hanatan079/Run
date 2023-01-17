using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //移動スピード、ジャンプ力
    [SerializeField]
    private float moveSpeed = 7f, jumpPower = 5f;

    //rigidBody格納
    private Rigidbody2D rd;

    //ジャンプ判定
    private Transform floorContactPos;

    //地面レイヤー
    [SerializeField]
    private LayerMask floorLayer;

    //アニメーション用
    private AnimationPlayer animationPlayer;



    private void Awake()
    {
        //rigidbodyの位置を格納(プレイヤーの位置)
        rd = GetComponent<Rigidbody2D>();

        //子オブジェクトにしたFloorContactを取得
        //floorContactPos = transform.GetChild(0).transform;

        //AnimationPlayer
        animationPlayer = GetComponent<AnimationPlayer>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        JumpPlayer();
        AnimatePlayer();
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

    //ジャンプする関数
    private void JumpPlayer()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Landing())
            {
                //力を加える
                rd.AddForce(new Vector2(0f, jumpPower),ForceMode2D.Impulse);
            }
        }
    }

    //地面に着陸しているか
    private bool Landing()
    {
        //floorContactPosを中心に半径0.1fの円が作られる
        return Physics2D.OverlapCircle(floorContactPos.position, 0.1f, floorLayer);
    }

    //ジャンプ、アニメーションを管理
    private void AnimatePlayer()
    {
        animationPlayer.JumpAnimation(rd.velocity.y);
        animationPlayer.RunAnimation(Landing());
    }
}
