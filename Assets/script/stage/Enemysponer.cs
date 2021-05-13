using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemysponer : MonoBehaviour
{
    float timer = 0;
    float wavecounter = 0;
    float zouka = 0.3f;
    float T = 15;
    [SerializeField]GameObject enemy=null;
    Transform enemypooltransform = null;
    void Start()
    {
        enemypooltransform = GameObject.Find("enemypool").transform;
        //Debug.Log(Random.value);
        StartCoroutine("counter");
        StartCoroutine("timercoroutine");
        StartCoroutine("sponer");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timer);
    }
    //波を作る
    IEnumerator counter()
    {
        while (true)
        {
            timer = -3*Mathf.Cos(2 * Mathf.PI * 1/T * Time.time) +1+wavecounter;
            yield return null;
        }
    }
    //徐々に増加
    IEnumerator timercoroutine()
    {
        while (true)
        {
            wavecounter = wavecounter + zouka;
            yield return new WaitForSeconds(T);
        }
    }
    //スポーン関数を呼ぶ
    IEnumerator sponer()
    {
        while (true)
        {
            //float i = timer;
            for(float i = timer; i >= 0; i--)
            {
                Instbullet(transform.position, transform.rotation);
                /*
                GameObject tmp = Instantiate(enemy, this.gameObject.transform.position, transform.localRotation);
                Enemysetter(tmp);
                */
            }
            yield return new WaitForSeconds(3f);
        }
    }
    void Instbullet(Vector3 pos, Quaternion rotation)
    {
        //アクティブでないオブジェクトをbulletsの中から探索
        foreach (Transform t in enemypooltransform)
        {
            if (!t.gameObject.activeSelf)
            {
                //アクティブにする
                t.gameObject.SetActive(true);
                //Enemysetter(t.gameObject);
                return;
            }
        }
        //非アクティブなオブジェクトがない場合新規生成

        //生成時にbulletsの子オブジェクトにする
        GameObject tmp = Instantiate(enemy, pos, rotation, enemypooltransform);
        //Enemysetter(tmp);
    }

    void Enemysetter(GameObject enemy)
    {
        //enemy.GetComponent<enemymove>().initialize();
    }
}
