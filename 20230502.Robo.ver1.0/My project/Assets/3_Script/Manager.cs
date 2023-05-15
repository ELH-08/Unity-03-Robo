/*
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    // public Manager Instance;

    [SerializeField] string currentSceneName;           // 현재 씬 이름
    [SerializeField] string stageNum;                   // 현재 스테이지
    [SerializeField] string nextSceneName;              // 다음 씬 이름

    [SerializeField] GameObject[] playerHPimage;        // 플레이어 체력 이미지
    [SerializeField] int carrot;                        // 획득 당근 수
    [SerializeField] Text carrotText;                   // 획득 당근을 출력할 텍스트 오브젝트

    [SerializeField] PlayerScript playerHP;             // 플레이어 체력 정보를 받아올 스크립트
    [SerializeField] GameObject clearPanel;             // 스테이지 클리어 패널
    [SerializeField] Text clearText;                    // 스테이지 클리어 텍스트
    [SerializeField] GameObject failPanel;              // 스테이지 실패 패널
    [SerializeField] Text failText;                     // 스테이지 실패 텍스트
    [SerializeField] Text stageStart;                   // 스테이지 스타트 텍스트

    [SerializeField] Text stageQuest;                   // 스테이지 목표 텍스트

    // Start is called before the first frame update
    /*void Awake()
    {
        if(Instance != null)
        {
            DestroyImmediate(this.gameObject);
        }

        Instance = this;
    }

    private void Awake()
    {
        // 스테이지 스타트 텍스트가 null값이 아니라면
        if (stageStart.gameObject)
        {
            stageStart.DOText(stageNum, 2f);        // 스테이지 텍스트 출력
            Invoke("StartGirlVoice", 2f);   // 스테이지 보이스
            Destroy(stageStart.gameObject, 3f);         // 스테이지 텍스트 삭제
        }

        // 초기화
        stageStart.text = "";
        clearText.text = "";
        failText.text = "";
        carrot = 0;
        clearPanel.SetActive(false);
        failPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHPStatus();
        StageClearCheck();
        PlayeDieCheck();

        // 스테이지 3 만 스테이지 목적이 다름
        if (stageNum != "STAGE 3")
            QuestUpdate();
    }

    // 스테이지 별 목적
    void QuestUpdate()
    {
        stageQuest.text = "  " + carrot + " / 5 개를 찾아줘!";
    }

    void StartGirlVoice()
    {
        SoundManager.instance.PlaySoundEffect("Start");
    }
    void MouseCursorOFF()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void MouseCursorON()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // 체력 상황 업데이트
    public void UpdateHPStatus()
    {
        /*for (int i = 0; i < playerHPimage.Length; i++)
        {
            if (i < playerHP._hp)
            {
                playerHPimage[i].gameObject.SetActive(true);
            }
            else
                playerHPimage[i].gameObject.SetActive(false);
        }
        // 라이더의 기능 => 코드 간결
        for (int i = 0; i < playerHPimage.Length; i++)
        {
            playerHPimage[i].gameObject.SetActive(i < playerHP._hp);
        }
    }

    // 캐릭 획득 업데이트
    public void UpdateCarrot(int _carrot)
    {
        carrot += _carrot;
        carrotText.text = carrot.ToString();
    }

    // 보스 클리어 패널
    public void BossClear()
    {
        if (!playerHP._playerLive)
            return;
        clearPanel.SetActive(true);
        clearText.text = "ALL STAGE CLEAR";
        Initiate.Fade(nextSceneName, Color.black, 2f);
    }

    // 스테이지 클리어
    void StageClearCheck()
    {
        if (carrot < 5 || !playerHP._playerLive)
            return;

        /*Tweener clear = clearText.DOText("STAGE CLEAR!!", 10f);
        clear.OnComplete(()=> clearText.gameObject.SetActive(true));
        clearPanel.SetActive(true);
        clearText.text = "STAGE CLEAR";
        Initiate.Fade(nextSceneName, Color.black, 2f);
    }

    // 스테이지 실패 체크
    void PlayeDieCheck()
    {
        if (playerHP._hp <= 0)
        {
            MouseCursorON();
            playerHP._hp = 0;
            failText.text = "STAGE FAIL";
            failPanel.SetActive(true);
        }
    }

    // 스테이지 재시작 버튼
    public void StageRestartBtn()
    {
        Initiate.Fade(currentSceneName, Color.black, 1f);
    }

    // 메인 메뉴로 가는 버튼
    public void GoMainMenuBtn()
    {
        Initiate.Fade("01_MainMenu_Scene", Color.black, 2f);
    }
}

*/