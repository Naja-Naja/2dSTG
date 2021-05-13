using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bulletmove4 : MonoBehaviour
{
    [SerializeField]float newAngle = 0;
    [SerializeField] float speed = 3;
    Rigidbody2D rigidbody2 = null;
    private void Start()
    {
        rigidbody2=GetComponent<Rigidbody2D>();
        // 速度を設定する
        SetVelocity(newAngle,speed);
    }
    void Update()
    {
        config.bulletdestroy(transform.localPosition, this.gameObject);
    }

    void SetVelocity(float direction, float speed)
    {
        var vx = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        var vy = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;
        //rigidbody2.velocity = new Vector2(vx, vy);
        GetComponent<Rigidbody2D>().velocity= new Vector2(vx, vy);
    }
    public void SetAngleSpeed(float A,float S)
    {
        newAngle = A;
        speed = S;
        SetVelocity(newAngle, speed);
    }
}