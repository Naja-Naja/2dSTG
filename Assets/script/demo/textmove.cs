using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textmove : MonoBehaviour
{
    [SerializeField]GameObject player=null;
    void Start()
    {
       
    }
    /// 更新
    void Update()
    {
        if (player == null)
        {
            Destroy(gameObject);
            return;
        }
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y+0.5f, 0);
    }
}