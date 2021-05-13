using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbreaker : MonoBehaviour, Idamage
{
    public float maxhp;
    public float nowhp;

    public void AddDamage(float damage)
    {
        nowhp -= damage;
        Debug.Log(this.gameObject + "の残りhp" + nowhp);
        if (nowhp > 0) return;
        Destroy(this.gameObject);
    }
}
