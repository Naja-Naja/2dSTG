using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove3 : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    /// 更新
    void Update()
    {
        if (player == null)
        {
            Destroy(gameObject);
            return;
        }
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
    }
}
