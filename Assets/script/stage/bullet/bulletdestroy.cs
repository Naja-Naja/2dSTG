using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
    [SerializeField]float deathtime=10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("deathtimecounter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator deathtimecounter()
    {
        yield return new WaitForSeconds(deathtime);
        Destroy(this.gameObject);
    }
}
