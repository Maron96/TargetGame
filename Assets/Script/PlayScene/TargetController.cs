using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameObject target;
    public GameObject ufo;
    private bool result;
    private GameObject mato;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Locate");
        StartCoroutine("Ufo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 
    private  IEnumerator Locate()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            mato = GameObject.FindGameObjectWithTag("target");
            if (mato == null)
            {
                Make();
            }
        }
        
    }

    private IEnumerator Ufo()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10.0f, 30.0f));
            Instantiate(ufo, new Vector3(24.7f, -1.3f, 35.0f), Quaternion.identity);
        }
    }

    private void Make()
    {
        // オブジェクトの座標
        float x = Random.Range(-8.0f, 8.0f);
        float y = Random.Range(3.0f, 10.0f);
        float z = 19.0f;

        if (HumanController.result)
        {
            // オブジェクトを生成
            GameObject obj = Instantiate(target, new Vector3(x, y, z), Quaternion.identity);
            Destroy(obj, 2.0f);
        } 
    }
}
