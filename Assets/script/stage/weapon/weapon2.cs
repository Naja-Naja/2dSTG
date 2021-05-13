using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon2 : MonoBehaviour, Iinput
{
    public GameObject bullet;
    bool fire = false;
    bool reloading = false;
    public float shotrate = 0.5f;
    public float M_bulletnumber = 10;
    float bulletnumber;
    public float reloadtime = 25;
    weapondata weapondata=null;
    void Start()
    {
        bulletnumber = M_bulletnumber;
        StartCoroutine("shot");
        StartCoroutine("reloadcoroutine");
    }
    void Update()
    {
        weapondata.weapondatanew(fire, reloading, M_bulletnumber, bulletnumber, reloadtime);
    }
    public void input()
    {
        if (fire == false && reloading == false)
        {
            fire = true;
            return;
        }
        fire = false;
    }
    public void reload()
    {
        if (reloading) return;
        reloading = true;
        bulletnumber = 0;
    }
    IEnumerator shot()
    {
        while (true)
        {
            while (fire == true)
            {
                Instantiate(bullet, this.gameObject.transform.position, transform.localRotation);
                bulletnumber--;
                if (bulletnumber <= 0)
                {
                    reloading = true;
                    fire = false;
                    break;
                }
                yield return new WaitForSeconds(shotrate);
            }
            yield return null;
        }
    }
    IEnumerator reloadcoroutine()
    {
        while (true)
        {
            while (reloading)
            {
                yield return new WaitForSeconds(reloadtime);
                bulletnumber = M_bulletnumber;
                reloading = false;
            }
            yield return null;
        }
    }
}
