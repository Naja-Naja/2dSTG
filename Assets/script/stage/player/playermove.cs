using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed; // 移動の速さ
    //private Camera _mainCamera;
    void Start()

    {
        /*
        GameObject obj = GameObject.Find("Main Camera");
        _mainCamera = obj.GetComponent<Camera>();

        // 座標値を出力
        Debug.Log(getScreenTopLeft().x + ", " + getScreenTopLeft().y);
        Debug.Log(getScreenBottomRight().x + ", " + getScreenBottomRight().y);
       // speed = -1*getScreenTopLeft().x * speed;
        */
        
    }

    // 毎フレーム呼び出される関数
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // 矢印キーが押されている方向にプレイヤーを移動する
        float move = speed * Time.deltaTime;
        Vector2 position = transform.position;
        if (h == 1)
        {
            position.x = position.x + move;
        }
        if (h == -1)
        {
            position.x = position.x - move;
        }
        if (v == 1) {
            position.y = position.y + move;
        }
        if (v == -1)
        {
            position.y = position.y - move;
        }


        transform.position = position;
        // プレイヤーが画面外に出ないように位置を制限する
        transform.localPosition = config.ClampPosition(transform.localPosition);
        //Debug.Log(position);
    }
    /*
    private Vector3 getScreenTopLeft()
    {
        // 画面の左上を取得
        Vector3 topLeft = _mainCamera.ScreenToWorldPoint(Vector3.zero);
        // 上下反転させる
        topLeft.Scale(new Vector3(1f, -1f, 1f));
        return topLeft;
    }

    private Vector3 getScreenBottomRight()
    {
        // 画面の右下を取得
        Vector3 bottomRight = _mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
        // 上下反転させる
        bottomRight.Scale(new Vector3(1f, -1f, 1f));
        return bottomRight;
    }
    */
}