using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour, Iinput
{
    public GameObject bullet;
    bool fire = false;
    bool reloading = false;

    public float M_bulletnumber = 1;
    float bulletnumber;
    public float reloadtime = 25;
    weapondata weapondata;
    GameObject shieldobj = null;
    void Start()
    {
        weapondata = this.gameObject.GetComponent<weapondata>();
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
            if (shieldobj != null) shieldobj.SetActive(true);
            return;
        }
        fire = false;
        if (shieldobj != null) shieldobj.SetActive(false);
    }
    public void reload()
    {
        //reloadingがfalseならtrueにし、あればシールドを破棄
        if (reloading) return;
        reloading = true;
        bulletnumber = 0;
        if (shieldobj != null) Destroy(shieldobj);
    }
    IEnumerator shot()
    {
        while (true)
        {
            while (fire == true)
            {
                if (shieldobj == null && bulletnumber <= 0) { reloading = true; }
                if (shieldobj != null|| reloading==true||bulletnumber <= 0) break;
                shieldobj=Instantiate(bullet, this.gameObject.transform.position, transform.localRotation);
                Debug.Log("d_weapon");
                bulletnumber--;
            }
            yield return null;
        }
    }
    IEnumerator reloadcoroutine()
    {
        while (true)
        {
            //reloadingがtrueなら時間待ったあとreloadingをfalseにする
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
