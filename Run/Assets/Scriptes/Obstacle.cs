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
    private int obstacleType = 4;

    //生成するオブジェクト
    private int obstacleSpawn;

    //カメラ格納用
    private Camera camera;

    //障害物を生成するべきポジション用
    private Vector3 obstaclePos = Vector3.zero;

    //生成したゲームオブジェクト格納用
    private GameObject newObstacle;

    //生成したゲームオブジェクト格納用
    [SerializeField]
    private List<GameObject> obstacle1Pool, obstacle2Pool, obstacle3Pool, obstacle4Pool;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
