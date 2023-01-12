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
        GroundGenerate();

        //プレイ時間＋待ち時間、DisplayManagementの秒数が経過したら新しいオブジェクトが表示
        groundWaitTime = Time.time + DisplayManagement;

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

    //次に生成するまでの時間設定
    void  NextGround()
    {
        if(Time.time > groundWaitTime)
        {
            //地面オブジェクトを再利用(再表示)する呼ぶ

            //プレイ時間＋待ち時間、DisplayManagementの秒数が経過したら新しいオブジェクトが表示
            groundWaitTime = Time.time + DisplayManagement;
        }
    }

    //地面オブジェクトを再利用(再表示)する
    void RedisplayGround()
    {
        //生成するべきポジションを格納する変数作成
        Vector3 newGroundPos = Vector3.zero;

        //リストの中の非表示の床を設定するべきポジションへ表示する
        foreach (GameObject obj in groundPool)
        {
            //オブジェクトが非表示なら
            if(!obj.activeInHierarchy)
            {
                //表示するべき場所へ表示する
                newGroundPos = new Vector3(groundDisplay, groundPos, 0f);

                //リストが次に表示されるべき場所へ移動する
                obj.transform.position = newGroundPos;

                //表示する
                obj.SetActive(true);

                //次に生成するポジションの更新
                groundDisplay += groundWidth;
            }
        }
    }


}
