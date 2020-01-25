using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    // Content Size Fitterを入れるべき
    // Pivot 中心点を設定するもの
    // 左下が0,0、右上が1,1

    Rigidbody rd;
    AudioSource audioSource;
    public GameObject bom;
    Collision coll;
    public GameObject arrowWord;
    public Text[] myText;
    string[] word = {"ぐさっ！", "ぽすっ", "ぴょん", "ぐわー" };
    string[] ufoWord = { "どっかーん！！！", "どんどん！", "あわわっ！！！" };

    // Start is called before the first frame update
    void Start()
    {

        rd = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject pare;
        pare = collision.gameObject.transform.parent.gameObject;
        coll = collision;

        if (collision.gameObject.tag == "ten")
        {
            OnArrow(pare, coll);
            if (collision.gameObject)
            ScoreController.score_num += 10;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "twenty")
        {
            OnArrow(pare, coll);
            if (collision.gameObject)
            ScoreController.score_num += 20;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "thirty")
        {
            OnArrow(pare, coll);
            if (collision.gameObject)
            ScoreController.score_num += 30;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "forty")
        {
            OnArrow(pare, coll);
            if (collision.gameObject)
            ScoreController.score_num += 40;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "sixty")
        {
            OnArrow(pare, coll);
            if (collision.gameObject)
            ScoreController.score_num += 60;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "ufo")
        {
            arrowWord.gameObject.SetActive(true);
            UfoWord();
            audioSource.Play();
            Destroy(pare);
            BgmController.ufoBgm = false;
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            ScoreController.score_num += 100;
            Destroy(this.gameObject, 0.2f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    public void OnArrow(GameObject pare, Collision coll)
    {
        arrowWord.gameObject.SetActive(true);
        Word();
        audioSource.Play();
        Destroy(pare);
        GameObject obj;
        obj = Instantiate(bom, transform.position, transform.rotation);
        Destroy(obj, 1.5f);
        
    }

    public void Word()
    {
        myText[Random.Range(0, myText.Length)].text = word[Random.Range(0, word.Length)];
    }

    public void UfoWord()
    {
        myText[Random.Range(0, myText.Length)].text = ufoWord[Random.Range(0, ufoWord.Length)];
    }
}
