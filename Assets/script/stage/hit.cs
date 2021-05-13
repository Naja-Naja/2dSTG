using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour, Idamage
{
    public float maxhp;
    public float nowhp;
    [SerializeField]bool enemy = false;
    void OnEnable()
    {
        nowhp = maxhp;
    }
    public void AddDamage(float damage)
    {
        nowhp -= damage;
        Debug.Log(this.gameObject + "の残りhp" + nowhp);
        if (nowhp > 0) return;
        if(enemy==false)Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }
}
