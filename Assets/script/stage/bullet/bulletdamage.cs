using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage : MonoBehaviour
{
    [SerializeField] float damage = 1;
    [SerializeField] string target="enemy";
    [SerializeField] string target2 = "bulletbreaker";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //タグで対象オブジェクトを判別
        if (collision.gameObject.tag != target&& collision.gameObject.tag != target2) return;
        //コンポーネント取得
        Idamage damagetarget = collision.gameObject.GetComponent<Idamage>();
        Debug.Log(collision.gameObject);
        //消えていなければダメージを与える
        if (damagetarget == null) return;
        damagetarget.AddDamage(damage);
        Destroy(this.gameObject);
    }
}
