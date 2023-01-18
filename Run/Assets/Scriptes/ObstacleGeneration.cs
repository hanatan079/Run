using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
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

        RepeatObstacle();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //障害物を複数回生成する
    void RepeatObstacle()
    {
        for(int i = 0; i < 4; i++)
        {
            GeneratObstacle(i);
        }
    }

    //障害物を生成する
    void GeneratObstacle(int obstaclelAmount)
    {
        switch(obstaclelAmount)
        {
            case 0:
            for(int i = 0; i < InstantiateObstacleSpawn; i++)
            {
                newObstacle = Instantiate(obstacle1);

                newObstacle.transform.SetParent(transform);

                obstacle1Pool.Add(newObstacle);

                newObstacle.SetActive(false);
            }

            break;

            case 1:
            for(int i = 0; i < InstantiateObstacleSpawn; i++)
            {
                newObstacle = Instantiate(obstacle2);

                newObstacle.transform.SetParent(transform);

                obstacle2Pool.Add(newObstacle);

                newObstacle.SetActive(false);
            }
            
            break;

            case 2:
            for(int i = 0; i < InstantiateObstacleSpawn; i++)
            {
                newObstacle = Instantiate(obstacle3);

                newObstacle.transform.SetParent(transform);

                obstacle3Pool.Add(newObstacle);

                newObstacle.SetActive(false);
            }

            break;

            case 3:
            for(int i = 0; i < InstantiateObstacleSpawn; i++)
            {
                newObstacle = Instantiate(obstacle4);

                newObstacle.transform.SetParent(transform);

                obstacle4Pool.Add(newObstacle);

                newObstacle.SetActive(false);
            }

            break;
        }
    }

    //表示したい場所へ表示させる
    void DisplayObstacle()
    {
        if(Time.time > spawnTime)
        {
            spawnTime = Time.time + Random.Range(minTime, maxTime);
        }
    }

    //表示したい場所へ表示させる(ポジ指定)
    void DisplayPosObstacle()
    {
        obstacleSpawn = Random.Range(0, obstacleType4);

        obstaclePos.x = mainCamera.transform.position.x + 20f;

        switch(obstacleSpawn)
        {
            case 0:
            for(int i = 0; i < obstacle1Pool.Count; i++)
            {
                if(!obstacle1Pool[i].activeInHierarchy)
                {
                    obstacle1Pool[i].SetActive(true);

                    obstaclePos.y = obstacle1Pos;

                    newObstacle = obstacle1Pool[i];

                    break;
                }
            }
            break;

            case 1:
            for(int i = 0; i < obstacle2Pool.Count; i++)
            {
                if(!obstacle2Pool[i].activeInHierarchy)
                {
                    obstacle2Pool[i].SetActive(true);

                    obstaclePos.y = obstacle1Pos;

                    newObstacle = obstacle2Pool[i];

                    break;
                }
            }
            break;

            case 2:
            for(int i = 0; i < obstacle3Pool.Count; i++)
            {
                if(!obstacle3Pool[i].activeInHierarchy)
                {
                    obstacle3Pool[i].SetActive(true);

                    obstaclePos.y = obstacle3Pos;

                    newObstacle = obstacle3Pool[i];

                    break;
                }
            }
            break;

            case 3:
            for(int i = 0; i < obstacle4Pool.Count; i++)
            {
                if(!obstacle4Pool[i].activeInHierarchy)
                {
                    obstacle4Pool[i].SetActive(true);

                    obstaclePos.y = obstacle4Pos;

                    newObstacle = obstacle4Pool[i];

                    break;
                }
            }
            break;

            newObstacle.transform.position = obstaclePos;
        }

    }
}
