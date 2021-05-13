using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour, Iinput
{
    hit hit = null;
    [SerializeField] string target = "Player";
    bool fire = false;
    bool reloading = false;
    public float shotrate = 0.5f;
    public float M_bulletnumber = 10;
    float bulletnumber;
    public float reloadtime = 25;
    weapondata weapondata;
    void Start()
    {
        hit = GameObject.FindGameObjectWithTag(target).GetComponent<hit>();
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
        //無限ループで入力待ち
        while (true)
        {
            while (fire == true)
            {
                //回復
                hit.nowhp = hit.nowhp + 0.1f;
                if (hit.maxhp < hit.nowhp) { hit.nowhp = hit.maxhp; }
                //残弾を減らす
                bulletnumber--;
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
                yield return new WaitForSeconds(reloadtime);
                bulletnumber = M_bulletnumber;
                reloading = false;
            }
            yield return null;
        }
    }
}
