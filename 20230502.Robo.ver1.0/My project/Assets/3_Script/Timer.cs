using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour 
{


    private TextMeshProUGUI _timer; //alt+enter네임스페이스 불러오기    ctrl+좌클릭 클래스 찾아보기 
    private float _timerForText;
    private int _secText;
    private int _minText;





	void Start () {
        //초깃값
        _timer = gameObject.GetComponent<TextMeshProUGUI>(); //TextMeshProUGUI 형식 저장

    }
	

	void Update () 
    {

        _timerForText += Time.deltaTime;        //_timerForText 시간 누적

        if (_timerForText > 1.0f)               //_timerForText 1 이상이면
        {
            _secText += 1;                      //_secText 1 누적
            if (_secText > 60)                  //_secText 60초를 넘기면
            {
                _minText += 1;                  //_minText 1 누적
                _secText = 0;                   //_secText 0으로 리셋
            }
            _timer.text = string.Format("{0:D2}", _minText) + ":" + string.Format("{0:D2}", _secText); //_timer의 text 영역에 문자열 형식으로 분 : 시간 형식으로 표시

            //_timer.text = string.Format("{0:D2}", _minText.ToString()) + ":" + string.Format("{0:D2}", _secText.ToString());
            _timerForText = 0;
        }

	
	}
}
