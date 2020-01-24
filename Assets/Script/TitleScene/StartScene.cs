using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public AudioClip menu;
    public AudioClip button;
    public AudioSource audioSource;


    public void OnClick()
    {
        audioSource = GetComponent<AudioSource>(); 
        ScoreController.score_num = 0;
        TimerController.countTime = 30.0f;
        HumanController.result = true;
        audioSource.PlayOneShot(button);
        StartCoroutine("Stco");
    }

    public void SpecificationButonClick()
    {
        audioSource.PlayOneShot(menu);
        StartCoroutine("Specification");
    }

    public void TitleButtonClick()
    {
        audioSource.PlayOneShot(button);
        StartCoroutine("Title");
    }

    IEnumerator Stco()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("PlayScene");
    }

    IEnumerator Specification()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("DescriptionScene");
    }

    IEnumerator Title()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("TitleScene");
    }

}
