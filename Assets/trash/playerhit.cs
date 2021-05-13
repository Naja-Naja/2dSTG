using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhit : MonoBehaviour//, Idamage
{
    public float maxhp = 5;
    public float nowhp;
    // Start is called before the first frame update
    void Start()
    {
        nowhp = maxhp;
    }
    public void AddDamage(float damage)
    {
        nowhp -= damage;
        Debug.Log("残りhp" + nowhp);
        if (nowhp > 0) return;
        Destroy(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("test");
        // 弾と衝突した場合
        //if (collision.name.Contains("bullet"))
        if (collision.gameObject.tag == "enemybullet")
        {
            Debug.Log("Destroy!!");
            // 弾を削除する
            Destroy(collision.gameObject);

            // 敵の HP を減らす
            nowhp--;

            // 敵の HP がまだ残っている場合はここで処理を終える
            if (0 < nowhp) return;

            // 敵を削除する
            //this.gameObject.GetComponent<enemymove>().killtween();
            Destroy(gameObject);
        }
    }
    */
    
    
}
