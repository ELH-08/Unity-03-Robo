using UnityEngine;
using System.Collections;

//Hammer ��ü�� �߰��� Collider �� IsTrigger�� �ߵ��Ǵ� ������, �ش��ϴ� �浹 ��ü�� ������ �޾ƿ� �±װ� ���� ��� HP�� ����

public class PlayerAttackScript : MonoBehaviour 
{
	

	public PlayerScript _PlayerSt;  //PlayerScript ����

 
    void Start () 
	{
		//�ʱ갪
		_PlayerSt = GameObject.FindWithTag("player").GetComponent<PlayerScript>();  // (�ҹ���) player�� �±׸� �� ��ü�� ��ũ��Ʈ�� ������ ����
		_PlayerSt._attackChkCol = gameObject.GetComponent<BoxCollider>(); //

		gameObject.GetComponent<BoxCollider>().enabled = false;
	
	}
	
 
	void Update () {
	
	}


    void OnTriggerEnter(Collider other) //�浹���� ��� Ʈ���� �̺�Ʈ �۵� �Լ�
    {

        if (other.tag == "enemy") //������ ��ü�� �±װ� �����̸�
        {
            Vector3 _Vec = (other.transform.position - transform.position).normalized; //_Vec�� ������ ��ü ��ġ - �� ��ġ �������� ����
            _Vec.y=0;										//_Vec�� y�� �ʱ�ȭ
            other.transform.localPosition += _Vec * 0.5f;   //������ ��ü�� ������ǥ�� _Vec * 0.5f ��ŭ ����
            other.SendMessage("Damaged",10.0f);				//
        }
        
    }
}
