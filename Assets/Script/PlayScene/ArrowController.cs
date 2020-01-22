using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // Content Size Fitterを入れるべき
    // Pivot 中心点を設定するもの
    // 左下が0,0、右上が1,1

    Rigidbody rd;
    AudioSource audioSource;
    public GameObject bom;

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
        Debug.Log(collision.gameObject.name);
        GameObject pare;
        pare = collision.gameObject.transform.parent.gameObject;

        if (collision.gameObject.tag == "ten")
        {
            audioSource.Play();
            Destroy(pare);
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            if (collision.gameObject)
            ScoreController.score_num += 10;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "twenty")
        {
            audioSource.Play();
            Destroy(pare);
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            if (collision.gameObject)
            ScoreController.score_num += 20;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "thirty")
        {
            audioSource.Play();
            Destroy(pare);
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            if (collision.gameObject)
            ScoreController.score_num += 30;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "forty")
        {
            audioSource.Play();
            Destroy(pare);
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            if (collision.gameObject)
            ScoreController.score_num += 40;
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "sixty")
        {
            audioSource.Play();
            Destroy(pare);
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            if (collision.gameObject)
            ScoreController.score_num += 60;
            Debug.Break();
            Destroy(this.gameObject, 0.2f);
        }
        else if (collision.gameObject.tag == "ufo")
        {
            audioSource.Play();
            Destroy(collision.gameObject);
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            ScoreController.score_num += 100;
            Destroy(this.gameObject, 0.2f);
        }
        /* if (collision.gameObject.tag == "target")
        {
            audioSource.Play();
            Destroy(collision.gameObject);
            GameObject obj;
            obj = Instantiate(bom, transform.position, transform.rotation);
            Destroy(obj, 1.0f);
            if (collision.gameObject)
            ScoreController.score_num += 10;
            Destroy(this.gameObject, 0.2f);
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
