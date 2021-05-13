using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class reloadtime : MonoBehaviour
{
    public float bulletnumber;
    public bool fire = false;
    public bool reloading = false;
    public float reloadtimer=0;
    float cooltime = 0;
    bool movecor = false;
    public Text card_text = null;
    /*
    float counter=0;
    weapondata[] weapondata = new weapondata[4];
    //[SerializeField] GameObject card=null;
    */
    // Start is called before the first frame update
    void Start()
    {
        /*
        weapondata[0]=weaponflame.weapondata[0].GetComponent<weapondata>();
        // オブジェクトからTextコンポーネントを取得
        card_text = this.gameObject.GetComponent<Text>();
        */
        // テキストの表示を入れ替える
        card_text.text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        if (reloading==false)
        {
            card_text.text = bulletnumber.ToString("f0");
        }
        else if(reloading==true&&movecor==false)
        {
            StartCoroutine("reloadcoroutine");
            movecor = true;
            
        }
    }
    /*
    public void bulletnumber(float bullet)
    {
        card_text.text = bullet.ToString("f0");
    }
    public void reloadstart(float time)
    {
        counter = time;
        card_text.text = time.ToString("f1");
        StartCoroutine("reloadcoroutine");
    }
    */
    IEnumerator reloadcoroutine()
    {
        cooltime = reloadtimer;
        while (reloading)
        {
            card_text.text = cooltime.ToString("f1");
            if (cooltime > 0)
            {
                //処理実行の度に1/fps秒だけずれる。処理の改善が必要
                cooltime = cooltime - 0.1f;
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                yield return null;
            }
        }
        movecor = false;
    }
    
}
