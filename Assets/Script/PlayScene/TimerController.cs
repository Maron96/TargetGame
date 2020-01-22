using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public static float countTime = 30.0f;
    float max = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime;
        countTime = Mathf.Max(countTime, 0);
        GetComponent<Text>().text = countTime.ToString();

        if (countTime == 0)
        {
            SceneManager.LoadScene("LastScene");
        }
    }
}
