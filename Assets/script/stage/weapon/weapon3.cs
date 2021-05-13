using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon3 : MonoBehaviour, Iinput
{
    public GameObject bullet;
    bool fire = false;
    bool reloading = false;
    public float shotrate = 0.5f;
    public float M_bulletnumber = 50;
    public float bulletnumber;
    public float reloadtime = 60;
    weapondata weapondata=null;
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
                //弾生成
                GameObject bulletInstance = Instantiate(bullet, this.gameObject.transform.position, transform.localRotation);
                //弾切れか撃つのを止めるまで撃ち続ける
                while (bulletnumber >= 0)
                {
                    yield return new WaitForSeconds(0.1f);
                    bulletnumber=bulletnumber-0.1f;
                    if (reloading==true||fire==false) break;
                }
                if (bulletnumber <= 0)
                {
                    reloading = true;
                    fire = false;
                }
                Destroy(bulletInstance);
                yield return null;
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
