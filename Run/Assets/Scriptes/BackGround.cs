using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    //地面格納用
    [SerializeField]
    private GameObject floorPrefab;

    //地面を呼び出す時に用意されている数
    [SerializeField]
    private float floorSpawn = 10;

    //生成したオブジェクトを管理
    private List<GameObject> floorPool = new List<GameObject>();

    //生成する位置の調整用
    [SerializeField]
    private float floorPos = 0f;

    //生成する幅の調整用
    [SerializeField]
    private float floorWidth = 18f;

    //表示するポジション格納用
    private float floorDisplay;

    //秒数ごとの表示を管理する用
    [SerializeField]
    private float DisplayManagement = 12f;

    //待ち時間
    private float floorWaitTime;




    // Start is called before the first frame update
    void Start()
    {
        FloorGenerate();

        //プレイ時間＋待ち時間、DisplayManagementの秒数が経過したら新しいオブジェクトが表示
        floorWaitTime = Time.time + DisplayManagement;

    }

    // Update is called once per frame
    void Update()
    {
        NextGround();
    }


    //床オブジェクトの生成
    void FloorGenerate()
    {
        //床生成位置を格納用(0,0,0)
        Vector3 newFloorPos = Vector3.zero;

        //生成された床格納用
        GameObject newFloor;

        //初期に用意されている数分繰り返す
        for(int i = 0; i < floorSpawn; i++)
        {
            //生成するポジションを格納
            newFloorPos = new Vector3(floorDisplay, -4.7f, 0f);

            //新しい場所へインスタンス(地面)を生成
            newFloor = Instantiate(floorPrefab, newFloorPos, Quaternion.identity);

            //親オブジェクトを変更する
            newFloor.transform.SetParent(transform);

            //新たに生成した床をリストへ追加
            floorPool.Add(newFloor);

            //次に生成するポジションの更新
            floorDisplay += floorWidth;
        }
    }

    //次に生成するまでの時間設定
    void  NextGround()
    {
        if(Time.time > floorWaitTime)
        {
            RedisplayGround();

            //プレイ時間＋待ち時間、DisplayManagementの秒数が経過したら新しいオブジェクトが表示
            floorWaitTime = Time.time + DisplayManagement;
        }
    }

    //地面オブジェクトを再利用(再表示)する
    void RedisplayGround()
    {
        //生成するべきポジションを格納する変数作成
        Vector3 newFloorPos = Vector3.zero;

        //リストの中の非表示の床を設定するべきポジションへ表示する
        foreach (GameObject obj in floorPool)
        {
            //オブジェクトが非表示なら
            if(!obj.activeInHierarchy)
            {
                //表示するべき場所へ表示する
                newFloorPos = new Vector3(floorDisplay, floorPos, 0f);

                //リストが次に表示されるべき場所へ移動する
                obj.transform.position = newFloorPos;

                //表示する
                obj.SetActive(true);

                //次に生成するポジションの更新
                floorDisplay += floorWidth;
            }
        }
    }


}
