using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject logPrefab;    //통나무 프리팹


    private void OnCollisionEnter(Collision collision) //충돌함수
    {
        if (collision.gameObject.CompareTag("player"))  //충돌한 객체가 플레이어 태그를 달고 있으면
        {
            DropItem();                                 //DropItem() 호출
            Destroy(gameObject);
        }
    }

    private void DropItem()
    {

        Instantiate(logPrefab, transform.position + Vector3.up, Quaternion.identity);         //통나무 복제
    }
}
