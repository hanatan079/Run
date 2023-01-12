using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    //地面格納用
    [SerializeField]
    private GameObject groundPrefab;

    //地面を呼び出す時に用意されている数
    [SerializeField]
    private float groundSpawn = 10;

    //生成したオブジェクトを管理
    private List<GameObject> groundPool = new List<GameObject>();

    //生成する位置の調整用
    [SerializeField]
    private float groundPos = 0f;

    //生成する幅の調整用
    [SerializeField]
    private float groundWidth = 18f;

    //表示するポジション格納用
    private float groundDisplay;

    //秒数ごとの表示を管理する用
    [SerializeField]
    private float DisplayManagement = 10f;

    //待ち時間
    private float groundWaitTime;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //グラウンドオブジェクトの生成
    void GroundGenerate()
    {
        //地面生成位置を格納用(0,0,0)
        Vector3 newGroundPos = Vector3.zero;

        //生成された床格納用
        GameObject newGround;

        //初期に用意されている数分繰り返す
        for(int i = 0; i < groundSpawn; i++)
        {
            //生成するポジションを格納
            newGroundPos = new Vector3(groundDisplay, groundPos, 0f);

            //新しい場所へインスタンス(地面)を生成
            newGround = Instantiate(groundPrefab, newGroundPos, Quaternion.identity);

            //親オブジェクトを変更する
            newGround.transform.SetParent(transform);

            //新たに生成した床をリストへ追加
            groundPool.Add(newGround);

            //次に生成するポジションの更新
            groundDisplay += groundPos;
            
        }

    }
}
