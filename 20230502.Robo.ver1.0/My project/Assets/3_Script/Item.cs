using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    #region Variables

    /*public int restoreHp = 50;      // �� �������� ��� ������ ü�� ��ġ
    public int restoreSp = 50;
    public int atkUp = 10;
    public int money = 1000;*/


    public int addValue = 50;       // ������ ������ ��ġ ��
    #endregion Variables


    #region Unity Method




    private void OnTriggerEnter(Collider other) //�浹 �Լ�, Ʈ���� �̺�Ʈ
    {
        // �÷��̾�� �浹�ߴ��� Ȯ��
        if (other.tag == "Player")
        {
            //Debug.Log("�÷��̾ " + gameObject.name + " ������ ȹ����.");

            // ������ �Ծ��� ��� �÷��̾� ü�� ����
            //if (gameObject.tag == "Item_Heal")
            //{
            //    other.GetComponent<PlayerHealth>().RestoreHealth(addValue);
            //}
            /*else if(gameObject.tag == "Money")
            {
                GameSceneUIManager.Instance.money += money;
            }
            else if(gameObject.tag == "Item_SP")
            {
                other.GetComponent<PlayerHealth>().RestoreSp(restoreSp);
                Debug.Log(restoreSp + "��ŭ SP����");
            }
            else if(gameObject.tag == "AttackUp")
            {
                FindObjectOfType<PlayerAttack>().attack += atkUp;
            }*/

            // ��ġ�� �Ծ��� ��� �÷��̾� ���ݷ� ����
            //else if (gameObject.tag == "Item_Power")
            //{
                // FindObjectOfType : ������ �ش� ������Ʈ�� ã�Ƽ� �Ҵ�
            //    PlayerAttack playerAttack = FindObjectOfType<PlayerAttack>();
            //    playerAttack.attack += addValue;
            //    GameSceneUIManager.Instance.ChangeAttackValue(playerAttack.attack);
            //}
            // �������� �Ծ��� ��� �÷��̾� �� ����
            //else if (gameObject.tag == "Item_Defence")
            //{
                // �÷��̾� �ǰ� ���� Ŭ���� ��������
            //    PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
                // �÷��̾� ������ �ʰ�
            //    playerHealth.IncreaseDef(addValue);
                // �÷��̾� ������ UI ����
            //    GameSceneUIManager.Instance.ChangeDefenceValue(playerHealth.defence);
            //}

            // �÷��̾ �������� ȹ���ϸ� �������� �ٷ� �����ǵ��� ����
            Destroy(gameObject);
        }
    }

    #endregion Unity Method


    #region Method


    #endregion Method
}