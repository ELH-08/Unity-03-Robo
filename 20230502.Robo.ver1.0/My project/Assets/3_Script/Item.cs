using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    #region Variables

    /*public int restoreHp = 50;      // 힐 아이템일 경우 증가할 체력 수치
    public int restoreSp = 50;
    public int atkUp = 10;
    public int money = 1000;*/


    public int addValue = 50;       // 변경할 데이터 수치 값
    #endregion Variables


    #region Unity Method




    private void OnTriggerEnter(Collider other) //충돌 함수, 트리거 이벤트
    {
        // 플레이어와 충돌했는지 확인
        if (other.tag == "Player")
        {
            //Debug.Log("플레이어가 " + gameObject.name + " 아이템 획득함.");

            // 힐팩을 먹었을 경우 플레이어 체력 증가
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
                Debug.Log(restoreSp + "만큼 SP증가");
            }
            else if(gameObject.tag == "AttackUp")
            {
                FindObjectOfType<PlayerAttack>().attack += atkUp;
            }*/

            // 망치를 먹었을 경우 플레이어 공격력 증가
            //else if (gameObject.tag == "Item_Power")
            //{
                // FindObjectOfType : 씬에서 해당 컴포넌트를 찾아서 할당
            //    PlayerAttack playerAttack = FindObjectOfType<PlayerAttack>();
            //    playerAttack.attack += addValue;
            //    GameSceneUIManager.Instance.ChangeAttackValue(playerAttack.attack);
            //}
            // 돈가방을 먹었을 경우 플레이어 돈 증가
            //else if (gameObject.tag == "Item_Defence")
            //{
                // 플레이어 건강 관리 클래스 가져오기
            //    PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
                // 플레이어 소지금 초가
            //    playerHealth.IncreaseDef(addValue);
                // 플레이어 소지금 UI 갱신
            //    GameSceneUIManager.Instance.ChangeDefenceValue(playerHealth.defence);
            //}

            // 플레이어가 아이템을 획득하면 아이템이 바로 삭제되도록 설정
            Destroy(gameObject);
        }
    }

    #endregion Unity Method


    #region Method


    #endregion Method
}