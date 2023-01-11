using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{

    //アニメーター
    private Animator animator;



    private void Awake()
    {
        //アニメーターの取得
        animator = GetComponent<Animator>();
    }

    //アニメーション設定用
    public void JumpAnimation(float jumpY)
    {
        animator.SetFloat("Jump", jumpY);
    }

    public void RunAnimation(bool running)
    {
        animator.SetBool("Run", running);
    }
}
