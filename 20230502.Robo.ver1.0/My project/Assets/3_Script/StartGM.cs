using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGM : MonoBehaviour
{

 
	void Start () {
	
	}
	
 
	void Update () {
	
	}


    void LoadScene() //장면 불러오기 함수
    {
        //Debug.Log("test");	
        SceneManager.LoadScene("1_Play");	//Main 화면 불러오기
    }
}
