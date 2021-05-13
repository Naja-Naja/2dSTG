using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage2 : MonoBehaviour
{
    [SerializeField] float damage = 2f;
    [SerializeField] string target = "enemy";
    [SerializeField] string target2 = "bulletbreaker";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != target && collision.gameObject.tag != target2) return;
        Idamage damagetarget = collision.gameObject.GetComponent<Idamage>();
        if (damagetarget == null) return;
        StartCoroutine("attack", damagetarget);
        //collision.gameObject.GetComponent<Idamage>().AddDamage(damage);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        StopCoroutine("attack");
        Debug.Log("通り抜け終えた");
    }

    IEnumerator attack(Idamage damagetarget)
    {
        while (true)
        {
            damagetarget.AddDamage(damage);
            Debug.Log("c_weapon");
            yield return new WaitForSeconds(0.05f);
        }
    }
}
