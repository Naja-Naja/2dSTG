using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmoveenemy : MonoBehaviour
{
    [SerializeField] float speed=1;
    void Update()
    {
        transform.localPosition += new Vector3(speed*Time.deltaTime, 0, 0);
        config.bulletdestroy(transform.localPosition,this.gameObject);
    }
}
