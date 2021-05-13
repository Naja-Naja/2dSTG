using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershotall : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    //int coolcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("shot");
        StartCoroutine("shot2");
        StartCoroutine("shot3");
        StartCoroutine("shot4");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator shot()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                Instantiate(bullet, this.gameObject.transform.position, transform.localRotation);
                Debug.Log("a_weapon");
                yield return new WaitForSeconds(.5f);
            }
            yield return null;
        }
    }
    IEnumerator shot2()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.X))
            {
                Instantiate(bullet2, this.gameObject.transform.position, transform.localRotation);
                Debug.Log("b_weapon");
                yield return new WaitForSeconds(.7f);
            }
            yield return null;
        }
    }
    
    IEnumerator shot3()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                GameObject bulletInstance = Instantiate(bullet3, this.gameObject.transform.position, transform.localRotation);
                Debug.Log("c_weapon");
                yield return new WaitForSeconds(5f);
                Destroy(bulletInstance);
                yield return new WaitForSeconds(60f);
            }
            yield return null;
        }
    }
    IEnumerator shot4()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.V))
            {
                Instantiate(bullet4, this.gameObject.transform.position, transform.localRotation);
                Debug.Log("d_weapon");
                yield return new WaitForSeconds(5f);
                //Destroy(bulletInstance);
            }
            yield return null;
        }
    }

}
