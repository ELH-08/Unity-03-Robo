using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour
{

    //private GUITexture _thisObjBtn;
    //private Image _thisObjBtn;



    public GameObject _target;                  //��ǥ : �÷��̾�
    public string methodName = "ReGame";    //_functionName ������ ReGame(���� ����� �Լ�) �Լ����� ����



    void Start()
    {

        //_thisObjBtn = gameObject.GetComponentInChildren<Image>();

    }



    public void BtnReGame() //��ư ����� �Լ�
    {
        if (_target != null)                                                         //��ǥ ������ ������
            _target.SendMessage(methodName, SendMessageOptions.DontRequireReceiver); //�÷��̾�� �޼���������(���� ����� �Լ��� ã�ƶ�)

    }


    /*    // Update is called once per frame
        void Update()
        {

            if( Input.GetMouseButtonDown(0))
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
