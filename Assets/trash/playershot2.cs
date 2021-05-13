using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershot2 : MonoBehaviour
{
    public GameObject bullet;
    //int coolcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("shot2");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Z)&&coolcount==0)
        {
            //Instantiate(bullet,this.gameObject.transform);
            //Vector3 playerposition = this.gameObject.transform.position;
            //Instantiate(bullet, playerposition, transform.localRotation);
            Instantiate(bullet, this.gameObject.transform.position,transform.localRotation);
            coolcount = 100;
            Debug.Log("pushZley");
        }
        if (coolcount > 0) { coolcount--; }
        */

    }
    IEnumerator shot2()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.X))
            {
                Instantiate(bullet, this.gameObject.transform.position, transform.localRotation);
                Debug.Log("b");
                yield return new WaitForSeconds(.5f);
            }
            yield return null;
        }
    }
}
