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
        if (collision.gameObject.tag == "target")
        {
            audioSource.Play();
            Destroy(collision.gameObject);
            ScoreController.score_num += 10;
            Destroy(this.gameObject, 1.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
