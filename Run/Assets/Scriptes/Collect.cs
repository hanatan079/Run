using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    //床へぶつかったら非表示にする
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Floor") || collision.CompareTag("obstacle") )
        {
            collision.gameObject.SetActive(false);
        }
    }

}
