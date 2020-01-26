using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LastSceneController : MonoBehaviour
{
    public AudioSource audioSource;
    public Text last;
    public Text pati;
    public Text patipati;
    string[] word = { "ぱちぱち", "がーん" };

    private void Start()
    {
        last.text = "score:" + ScoreController.score_num;
        if (ScoreController.score_num < 300)
        {
            pati.text = word[1];
            patipati.text = word[1];
        }
        else
        {
            pati.text = word[0];
            patipati.text = word[0];
        }
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
