using UnityEngine;
using System.Collections;       //library 들여오기
using UnityEngine.UI;           //library 들여오기

public class ButtonClicked : MonoBehaviour
{

    //private GUITexture _thisObjBtn;
    //private Image _thisObjBtn;

    public GameObject _target;                  //목표물(플레이어)
    public string methodName = "ReGame";        //ReGame 함수명을 저장 (PlayerScript - ReGame() 함수)


    void Start()
    {

        //_thisObjBtn = gameObject.GetComponentInChildren<Image>();

    }



    public void BtnReGame() //재시작 함수
    {
        if (_target != null)                                                         //목표물(플레이어)가 있으면
            _target.SendMessage(methodName, SendMessageOptions.DontRequireReceiver); //플레이어 객체에게 메세지 전송(함수명 ReGame에 해당하는 함수를 찾아라)
                                                                                     //SendMessage : 리플렉션을 사용하여 대상 함수를 동적으로 찾고 호출, 직접 함수 호출에 비해 성능 오버헤드가 발생)

    }


    /*     
        void Update()
        {

            if( Input.GetMouseButtonDown(0))    //마우스 왼쪽 클릭시
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
