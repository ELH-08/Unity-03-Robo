using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerScript : MonoBehaviour
{
	
	// Player's basic properties
	
	public float _speed;				// 이동속도

	public float _hp;					// 플레이어 hp
	public TextMesh _HpVal;				// 플레이어 HP value text
	public GameObject _hpBar;			// 플레이어 HP bar img
	
    public Animator _rabbit;			// Animator for Player's animation
	
	// For Game Result
	public bool _gameWin;				//게임 승리 
    public bool _playerLive = true;		// bool for player's live
	public GameObject _uiResult;		// Result UI 객체
	public TextMeshProUGUI _resultText;	// Result UI 아래 결과를 나타내는 Text (win or lose)
	
	public BoxCollider _attackChkCol;   // Boxcollider for on/off when player attack  
                                        //PlayerScript에서 공격이 진행되고 있지 않을 때 망치의 Collider 컴퍼넌트를 비활성화시켜 적의 HP 깎지 않기 하기 위함

    private float _damTimer;			// Timer for damage state check
	public GameObject _DamEffect;		// Effect for damage state
    public GameObject _DamText;			// Text Mesh for damage's value
	
	private float _timerForAttack;
    private float _timerForAttackSnd;
    private bool _attackChkbool;


	// Use this for initialization
	void Start () 
	{
		
		//atakState = _rabbit.StringToHash("0_idle"); 
		
		if( GetComponent<AudioSource>() != null) GetComponent<AudioSource>().Play();
        if(_rabbit != null) 
		{
			_rabbit.speed = 2.0f;
		}
		else
		{
			_rabbit = gameObject.GetComponentInChildren<Animator>();
			_rabbit.speed = 2.0f;
		}


        if(_uiResult!=null)	//Result_UI 객체가 있으면
        {
            _resultText = _uiResult.transform.Find("3_Result_Text").gameObject.GetComponent<TextMeshProUGUI>();
        }
			
	}
	
 
	void Update () {
		if(_playerLive)
		{
			
			
	        if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0))
	        {
	            float _verticalPos = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
	            float _horizonPos = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
	
	            transform.position += new Vector3(-1 * _horizonPos, 0, -1 * _verticalPos);
	            transform.forward = (new Vector3(-1 * _horizonPos, 0, -1 * _verticalPos));
	            if(_rabbit != null) _rabbit.SetBool("runChk", true);
	        }
	        else
	        {
	            if(_rabbit != null)_rabbit.SetBool("runChk", false);
	        }

			if((_rabbit != null))
			{
                if (Input.GetButtonDown("Fire1") && !_rabbit.GetCurrentAnimatorStateInfo(0).IsName("1_attack"))
                {
                    
                    _rabbit.SetBool("attackChk", true);
                    if (_attackChkCol != null)
                    {
                        _attackChkCol.enabled = true;
                    }
                    _attackChkbool = true;
                }

                else
                {
                    if (_attackChkCol != null) _attackChkCol.enabled = false;
                }

                if (_rabbit.GetBool("damageChk"))
                {
                    if (_rabbit.GetCurrentAnimatorStateInfo(0).IsName("3_damage"))
                    {
                        if (_rabbit.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.0f) _rabbit.SetBool("damageChk", false);
                    }
                }
                
		    }
        }
		

	}

    private void OnCollisionEnter(Collision collision) //충돌함수
    {
        if (collision.gameObject.CompareTag("Item"))  // 충돌한 객체의 태그가 Item이면
        {
            PickUpItem(collision.gameObject);         // PickUpItem()에 충돌한 객체의 정보를 넣기
        }

    }


    private void PickUpItem(GameObject item) //아이템 줍기 함수
    {
        // Add the item to the player's inventory or perform any other desired action
        Destroy(item);							//해당 아이템 파괴
    }



    void Damaged(float _dam) //데미지 함수
	{


		_hp -= _dam;
        if(!_rabbit.GetCurrentAnimatorStateInfo(0).IsName("3_damage")) _rabbit.SetBool("damageChk", true);
		if(_DamEffect!=null) Instantiate(_DamEffect,new Vector3(transform.position.x, 1.0f, transform.position.z),Quaternion.identity);
        if(_DamText!=null) Instantiate(_DamText, new Vector3(transform.position.x, 1.2f, transform.position.z + 0.2f), Quaternion.identity);
        
		if(_hp >0)
		{
			if(_hpBar!=null) _hpBar.transform.localScale = new Vector3 (_hp*0.01f,1,1);
			if(_HpVal!=null) _HpVal.text = _hp.ToString();
		}
		else if(_hp <= 0)
		{
			if(_hpBar!=null) _hpBar.transform.localScale = new Vector3 (0,1,1);
			_playerLive=false;
			if(_HpVal!=null) _HpVal.text = "0";
			_gameWin=false;
			GameOver();
		}
	}
	
	public void GameOver() //게임종료 함수
	{
 
        if (_gameWin)											//게임에 이겼을 경우
        {
            if(_resultText != null) _resultText.text = "WIN";  //3_Result_Text의 텍스트에 WIN 출력
        }
        else													//게임에 졌을 경우
        {
            if(_resultText != null)_resultText.text = "Your journey has come to an end..."; //3_Result_Text의 텍스트에 LOSE 출력
        }
        
        //
		Time.timeScale = 0.0f;
		if(_uiResult != null) _uiResult.SetActive(true);
		
	}

    void ReGame() //재시작 함수
    {
        Time.timeScale = 1.0f;								//게임 시간 진행 속도를 1.0f (실제 시간과 동기화)
        SceneManager.LoadScene("1_Play");                   //Scene in build 목록의 1_play 장면 불러오기 
    }






}
