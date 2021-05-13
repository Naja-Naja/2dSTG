using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshot : MonoBehaviour
{
    public GameObject enemyshotobj;
    //[SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletpoolobject;
    /*[SerializeField]*/ Transform bulletpooltransform=null;
    //int coolcount = 0;
    // Start is called before the first frame update
    void OnEnable()
    {

        bulletpooltransform = GameObject.Find("bulletpool").transform;
        StartCoroutine("shot");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (coolcount == 0)
        {
            //Instantiate(bullet,this.gameObject.transform);
            //Vector3 playerposition = this.gameObject.transform.position;
            //Instantiate(bullet, playerposition, transform.localRotation);
            Instantiate(enemyshotobj, this.gameObject.transform.position, transform.localRotation);
            coolcount = 100;
            Debug.Log("pushZley");
        }
        if (coolcount > 0) { coolcount--; }
        */
    }
    IEnumerator shot()
    {
        yield return new WaitForSeconds(4f);
        while(true)
        {
            Debug.Log("コルーチン");
            Instbullet(transform.position, transform.rotation);
            //Instantiate(enemyshotobj, this.gameObject.transform.position, transform.localRotation);
            //Debug.Log("a");
            yield return new WaitForSeconds(2f);
        }
    }
    void Instbullet(Vector3 pos, Quaternion rotation)
    {
        //アクティブでないオブジェクトをbulletsの中から探索
        foreach (Transform t in bulletpooltransform)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置と回転を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }
        //非アクティブなオブジェクトがない場合新規生成

        //生成時にbulletsの子オブジェクトにする
        Instantiate(enemyshotobj, pos, rotation, bulletpooltransform);
    }
}
