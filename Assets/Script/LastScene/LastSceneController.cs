using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LastSceneController : MonoBehaviour
{
    public AudioSource audioSource;
    public Text last;

    private void Start()
    {
        last.text = "score:" + ScoreController.score_num;
    }

    public void OnClick()
    {
        StartCoroutine("Last");
        audioSource.Play();
    }

    IEnumerator Last()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("TitleScene");
    }


}
