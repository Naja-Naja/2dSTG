using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class config : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Screen.SetResolution(480, 350, false, 60);
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// ////////////////////////////////////////////////////////////////
    // 移動可能な範囲
    public static Vector2 m_moveLimit = new Vector2(6f, 4.6f);
    public static Vector2 underLimit = new Vector2(0f, -2.4f);

    // 指定された位置を移動可能な範囲に収めた値を返す
    public static Vector3 ClampPosition(Vector3 position)
    {
        return new Vector3
        (
            Mathf.Clamp(position.x, -m_moveLimit.x, m_moveLimit.x),
            Mathf.Clamp(position.y, underLimit.y, m_moveLimit.y),
            0
        );
    }
    /////////////////////////////////////////////////////////////
    //弾の描画範囲

    public static Vector2 bulletrange = new Vector2(7f, 5f);

    //範囲外なら消去
    public static void bulletdestroy(Vector3 position,GameObject bullet)
    {
        if (position.x > bulletrange.x || position.x < -bulletrange.x || position.y > bulletrange.y || position.y < -bulletrange.y)
        {
            //Destroy(bullet);
            bullet.SetActive(false);
        }
    }
}
