using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HumanController : MonoBehaviour
{
    public GameObject arrow;
    AudioSource audioSource;

    public float speed;
    public float adRotateY = 80;
    public float adRotateX = 50;

    float yRotate = 0.0f;
    float xRotate = 0.0f;
    public static bool result;

    bool isPlay;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
        if (TimerController.countTime == 0)
        {
            result = false;
        }
        // transform.Rotate(Vector3.up * Input.GetAxis("Horizontal"));
        if (result && Input.GetKey(KeyCode.D))
        {
            // 1秒間辺りに100度回転させる処理。
            yRotate = Mathf.Clamp(yRotate + adRotateY * Time.deltaTime, -70, 50);
            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }
        if (result && Input.GetKey(KeyCode.A))
        {
            yRotate = Mathf.Clamp(yRotate - adRotateY * Time.deltaTime, -70, 50);
            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }
        if (result && Input.GetKey(KeyCode.S))
        {
            xRotate = Mathf.Clamp(xRotate + adRotateX * Time.deltaTime, -30, 0);
            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }
        if (result && Input.GetKey(KeyCode.W))
        {
            xRotate = Mathf.Clamp(xRotate - adRotateX * Time.deltaTime, -30, 0);
            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }
        if (result && SceneManager.GetActiveScene().name == "PlayScene" && Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            GameObject obj = Instantiate(arrow, new Vector3(0f, 3.5f, 3f), Quaternion.LookRotation(transform.forward));
            obj.GetComponent<Rigidbody>().velocity = (obj.transform.forward) * 50.0f;
        }
    }
}
