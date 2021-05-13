using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhit : MonoBehaviour, Idamage
{
    public float hp = 3;
    public void AddDamage(float damage)
    {
        hp -= damage;
        Debug.Log(this.gameObject+"の残りhp"+hp);
        if (hp > 0) return;
        Destroy(this.gameObject);

    }
}
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("test");
        // 弾と衝突した場合
        //if (collision.name.Contains("bullet"))
        if (collision.gameObject.tag=="playerbullet")
        {
            //Debug.Log("Destroy!!");
            // 弾を削除する
            //Destroy(collision.gameObject);

            // 敵の HP を減らす
            m_hp--;
            hitting = true;

            // 敵の HP がまだ残っている場合はここで処理を終える
            if (0 < m_hp) return;

            // 敵を削除する
            //this.gameObject.GetComponent<enemymove>().killtween();
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "playerbullet" && hitting)
        {
            Debug.Log("連続hit");
            if (nohit==true) 
            {
                nohit = false;
                StartCoroutine("hit");
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        hitting = false;
        nohit = true;
        Debug.Log("通り抜け終えた");
    }
    IEnumerator hit()
    {
        while (hitting == true)
        {
            m_hp--;
            Debug.Log("damage");
            if (0 >= m_hp)
            {
                Destroy(gameObject);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
    */
