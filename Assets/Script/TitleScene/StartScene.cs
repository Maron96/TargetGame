using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void OnClick()
    {
        ScoreController.score_num = 0;
        TimerController.countTime = 30.0f;
        HumanController.result = true;
        SceneManager.LoadScene("PlayScene");
    }
}
