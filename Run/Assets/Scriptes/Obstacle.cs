using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //障害物格納用
    private GameObject Obstacle1, Obstacle2, Obstacle3, Obstacle4;

    //障害物生成時Y軸管理用
    [SerializeField]
    private float Obstacle1Pos = -4, Obstacle2pos = -4, Obstacle3Pos = -4, Obstacle4Pos = -4;

    //スポーン時の数値格納用(ランダムに障害物を発生させる)
    private float minTime = 2f, maxTime = 3.5f;

    //スポーン管理用
    [SerializeField]
    private float spawnTime;

    //障害物の種類を扱う(4種類=4)
    private int ObstacleType = 4;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
