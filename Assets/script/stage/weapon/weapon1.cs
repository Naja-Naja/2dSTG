using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon1 : MonoBehaviour, Iinput
{
    public GameObject bullet;
    bool fire = false;
    bool reloading = false;
    public float shotrate=0.5f;
    public float M_bulletnumber=10;
    float bulletnumber;
    public float reloadtime=25;
    reloadtime card;
    void Start()
    {
        card = GameObject.Find("card1").GetComponent<reloadtime>();
        bulletnumber = M_bulletnumber;
        //card.bulletnumber(bulletnumber);
        StartCoroutine("shot");
        StartCoroutine("reloadcoroutine");
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
        //無限ループで入力待ち
        while (true)
        {
            while (fire == true)
            {
                //弾のインスタンスを生成
                Instantiate(bullet, this.gameObject.transform.position, transform.localRotation);
                //残弾を減らす
                bulletnumber--;
                //card.bulletnumber(bulletnumber);
                //弾がないならループ離脱
                if (bulletnumber <= 0)
                {
                    reloading = true;
                    fire = false;
                    break;
                }
                //発射間隔の時間だけ待機する
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
                //card.reloadstart(reloadtime);
                yield return new WaitForSeconds(reloadtime);
                bulletnumber = M_bulletnumber;
                //card.bulletnumber(bulletnumber);
                reloading = false;
            }
            yield return null;
        }
    }
}
