using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject logPrefab;    //�볪�� ������


    private void OnCollisionEnter(Collision collision) //�浹�Լ�
    {
        if (collision.gameObject.CompareTag("player"))  //�浹�� ��ü�� �÷��̾� �±׸� �ް� ������
        {
            DropItem();                                 //DropItem() ȣ��
            Destroy(gameObject);
        }
    }

    private void DropItem()
    {

        Instantiate(logPrefab, transform.position + Vector3.up, Quaternion.identity);         //�볪�� ����
    }
}
