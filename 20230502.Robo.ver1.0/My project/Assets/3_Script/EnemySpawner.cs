using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    #region Variables

    public GameObject[] enemys;                      // 랜덤 생성할 적 
    private int randEnemy;                           // 랜덤 생성될 적 번호

    public Transform[] EnemySpawnPoints;             // 적 생성 위치 
    private int randPos;                             // 랜덤 생성 위치 번호

    public float radius = 3f;                        // 적 위치에서 랜덤 생성될 반지름 길이

    #endregion Variables


    #region Unity Method


    // 초기화
    void Start()
    {
        // 5초에 한번씩 아이템 생성 메서드 실행
        InvokeRepeating("SpawnEnemy", 5, 1);
    }

    #endregion Unity Method


    #region Method

    /// <summary>
    /// 아이템 생성 함수
    /// </summary>
    private void SpawnEnemy()
    {
        // 아이템 생성 위치 개수 만큼 반복
        for (int i = 0; i < EnemySpawnPoints.Length; i++)
        {
            // 랜덤 아이템 지정
            randEnemy = Random.Range(0, enemys.Length);

            // 랜덤 x좌표 지정
            float radomX = Random.Range(-radius, radius);

            // 랜덤 z좌표 지정
            float radomZ = Random.Range(-radius, radius);

            // 랜덤으로 생성될 아이템의 위치 지정
            Vector3 enemyPos = EnemySpawnPoints[i].position + new Vector3(radomX, 0, radomZ);

            // 랜덤 아이템 객체 생성
            // Instantiate(생성할 오브젝트, 생성할 위치, 회전 값)
            GameObject enemy = Instantiate(enemys[randEnemy], enemyPos, Quaternion.identity);
        }
    }

    #endregion Method
}
