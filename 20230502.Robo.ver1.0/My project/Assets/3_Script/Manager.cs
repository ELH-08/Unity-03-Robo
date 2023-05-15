/*
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    // public Manager Instance;

    [SerializeField] string currentSceneName;           // ���� �� �̸�
    [SerializeField] string stageNum;                   // ���� ��������
    [SerializeField] string nextSceneName;              // ���� �� �̸�

    [SerializeField] GameObject[] playerHPimage;        // �÷��̾� ü�� �̹���
    [SerializeField] int carrot;                        // ȹ�� ��� ��
    [SerializeField] Text carrotText;                   // ȹ�� ����� ����� �ؽ�Ʈ ������Ʈ

    [SerializeField] PlayerScript playerHP;             // �÷��̾� ü�� ������ �޾ƿ� ��ũ��Ʈ
    [SerializeField] GameObject clearPanel;             // �������� Ŭ���� �г�
    [SerializeField] Text clearText;                    // �������� Ŭ���� �ؽ�Ʈ
    [SerializeField] GameObject failPanel;              // �������� ���� �г�
    [SerializeField] Text failText;                     // �������� ���� �ؽ�Ʈ
    [SerializeField] Text stageStart;                   // �������� ��ŸƮ �ؽ�Ʈ

    [SerializeField] Text stageQuest;                   // �������� ��ǥ �ؽ�Ʈ

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
        // �������� ��ŸƮ �ؽ�Ʈ�� null���� �ƴ϶��
        if (stageStart.gameObject)
        {
            stageStart.DOText(stageNum, 2f);        // �������� �ؽ�Ʈ ���
            Invoke("StartGirlVoice", 2f);   // �������� ���̽�
            Destroy(stageStart.gameObject, 3f);         // �������� �ؽ�Ʈ ����
        }

        // �ʱ�ȭ
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

        // �������� 3 �� �������� ������ �ٸ�
        if (stageNum != "STAGE 3")
            QuestUpdate();
    }

    // �������� �� ����
    void QuestUpdate()
    {
        stageQuest.text = "  " + carrot + " / 5 ���� ã����!";
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

    // ü�� ��Ȳ ������Ʈ
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
        // ���̴��� ��� => �ڵ� ����
        for (int i = 0; i < playerHPimage.Length; i++)
        {
            playerHPimage[i].gameObject.SetActive(i < playerHP._hp);
        }
    }

    // ĳ�� ȹ�� ������Ʈ
    public void UpdateCarrot(int _carrot)
    {
        carrot += _carrot;
        carrotText.text = carrot.ToString();
    }

    // ���� Ŭ���� �г�
    public void BossClear()
    {
        if (!playerHP._playerLive)
            return;
        clearPanel.SetActive(true);
        clearText.text = "ALL STAGE CLEAR";
        Initiate.Fade(nextSceneName, Color.black, 2f);
    }

    // �������� Ŭ����
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

    // �������� ���� üũ
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

    // �������� ����� ��ư
    public void StageRestartBtn()
    {
        Initiate.Fade(currentSceneName, Color.black, 1f);
    }

    // ���� �޴��� ���� ��ư
    public void GoMainMenuBtn()
    {
        Initiate.Fade("01_MainMenu_Scene", Color.black, 2f);
    }
}

*/