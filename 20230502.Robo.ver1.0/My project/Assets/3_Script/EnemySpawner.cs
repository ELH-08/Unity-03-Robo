using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    #region Variables

    public GameObject[] enemys;                      // ���� ������ �� 
    private int randEnemy;                           // ���� ������ �� ��ȣ

    public Transform[] EnemySpawnPoints;             // �� ���� ��ġ 
    private int randPos;                             // ���� ���� ��ġ ��ȣ

    public float radius = 3f;                        // �� ��ġ���� ���� ������ ������ ����

    #endregion Variables


    #region Unity Method


    // �ʱ�ȭ
    void Start()
    {
        // 5�ʿ� �ѹ��� ������ ���� �޼��� ����
        InvokeRepeating("SpawnEnemy", 5, 1);
    }

    #endregion Unity Method


    #region Method

    /// <summary>
    /// ������ ���� �Լ�
    /// </summary>
    private void SpawnEnemy()
    {
        // ������ ���� ��ġ ���� ��ŭ �ݺ�
        for (int i = 0; i < EnemySpawnPoints.Length; i++)
        {
            // ���� ������ ����
            randEnemy = Random.Range(0, enemys.Length);

            // ���� x��ǥ ����
            float radomX = Random.Range(-radius, radius);

            // ���� z��ǥ ����
            float radomZ = Random.Range(-radius, radius);

            // �������� ������ �������� ��ġ ����
            Vector3 enemyPos = EnemySpawnPoints[i].position + new Vector3(radomX, 0, radomZ);

            // ���� ������ ��ü ����
            // Instantiate(������ ������Ʈ, ������ ��ġ, ȸ�� ��)
            GameObject enemy = Instantiate(enemys[randEnemy], enemyPos, Quaternion.identity);
        }
    }

    #endregion Method
}
