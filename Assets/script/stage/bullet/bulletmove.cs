using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bulletmove : MonoBehaviour
{
    [SerializeField] float speed = 1;
    void Update()
    {
        transform.localPosition += new Vector3(speed * Time.deltaTime, 0, 0);
        config.bulletdestroy(transform.localPosition, this.gameObject);
    }
}
