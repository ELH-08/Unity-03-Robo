using UnityEngine;
using System.Collections;       //library �鿩����
using UnityEngine.UI;           //library �鿩����

public class ButtonClicked : MonoBehaviour
{

    //private GUITexture _thisObjBtn;
    //private Image _thisObjBtn;

    public GameObject _target;                  //��ǥ��(�÷��̾�)
    public string methodName = "ReGame";        //ReGame �Լ����� ���� (PlayerScript - ReGame() �Լ�)


    void Start()
    {

        //_thisObjBtn = gameObject.GetComponentInChildren<Image>();

    }



    public void BtnReGame() //����� �Լ�
    {
        if (_target != null)                                                         //��ǥ��(�÷��̾�)�� ������
            _target.SendMessage(methodName, SendMessageOptions.DontRequireReceiver); //�÷��̾� ��ü���� �޼��� ����(�Լ��� ReGame�� �ش��ϴ� �Լ��� ã�ƶ�)
                                                                                     //SendMessage : ���÷����� ����Ͽ� ��� �Լ��� �������� ã�� ȣ��, ���� �Լ� ȣ�⿡ ���� ���� ������尡 �߻�)

    }


    /*     
        void Update()
        {

            if( Input.GetMouseButtonDown(0))    //���콺 ���� Ŭ����
            {
                if (_thisObjBtn.Raycast(Input.mousePosition, Camera.main))
                {

                    if (_target != null)
                    {
                    }
                }
            }
        }*/
}
