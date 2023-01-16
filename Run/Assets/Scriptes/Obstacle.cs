using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //障害物格納用
    private GameObject obstacle1, obstacle2, obstacle3, obstacle4;

    //障害物生成時Y軸管理用
    [SerializeField]
    private float obstacle1Pos = -4, obstacle2pos = -4, obstacle3Pos = -4, obstacle4Pos = -4;

    //スポーン時の数値格納用(ランダムに障害物を発生させる)
    private float minTime = 2f, maxTime = 3.5f;

    //スポーン管理用
    [SerializeField]
    private float spawnTime;

    //障害物の種類を扱う(4種類=4)
    private int obstacleType4 = 4;

    //生成するオブジェクト
    private int obstacleSpawn;

    //カメラ格納用
    private Camera mainCamera;

    //障害物を生成するべきポジション用
    private Vector3 obstaclePos = Vector3.zero;

    //生成したゲームオブジェクト格納用
    private GameObject newObstacle;

    //生成したオブジェクト管理用リスト
    [SerializeField]
    private List<GameObject> obstacle1Pool, obstacle2Pool, obstacle3Pool, obstacle4Pool;

    //生成しておくべき数用
    [SerializeField]
    private int InstantiateObstacleSpawn =5;




    void Awake()
    {
        //メインカメラ情報取得
        mainCamera = Camera.main;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //障害物オブジェクトを作成する
    void ObstacleGenerate()
    {
        for(int i = 0; i < 3; i++)
        {

        }
    }

    //オブジェクトを表示させるべき場所へ表示させる
    void DisplayObstacle(int Obstacle)
    {

    }
}
