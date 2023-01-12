using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    //地面格納用
    [SerializeField]
    private void groundPrefab;

    //地面を呼び出す時に用意されている数
    [SerializeField]
    private float groundSpawn = 10

    //生成したオブジェクトを管理
    private List<GameObject> groundPool = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
