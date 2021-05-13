using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponUI : MonoBehaviour
{
    //情報の受け取り元
    //[SerializeField] weaponflame weaponflame = null;
    weapondata[] weapondatas = new weapondata[4];

    //情報の発信先
    [SerializeField] GameObject card0 = null;
    [SerializeField] GameObject card1 = null;
    [SerializeField] GameObject card2 = null;
    [SerializeField] GameObject card3 = null;
    reloadtime[] weaponUIdata = new reloadtime[4];
    void Start()
    {
        //配列に各武装UIの表記データを持つスクリプトを得る
        //このスクリプトはこの表記を更新する
        weaponUIdata[0] = card0.GetComponent<reloadtime>();
        weaponUIdata[1] = card1.GetComponent<reloadtime>();
        weaponUIdata[2] = card2.GetComponent<reloadtime>();
        weaponUIdata[3] = card3.GetComponent<reloadtime>();
        //weaaponのアイコンを各カードに適用する関数をこの下に書く
        weaponimagesetter();

        //weapondata[4]の配列に情報の参照先を得る
        //weapondatas[0] = weaponflame.weapondata[0].GetComponent<weapondata>();
        /*
        weapondatas[1] = weaponflame.weapondata[1].GetComponent<weapondata>();
        weapondatas[2] = weaponflame.weapondata[2].GetComponent<weapondata>();
        weapondatas[3] = weaponflame.weapondata[3].GetComponent<weapondata>();
        */
    }
    void Update()
    {
        //weaponUIdata[0].card_text.text = "TestingNow";
        UIupdate();
    }

    //UIを管理するオブジェクトに新しいデータを渡す。最適化の余地あり。抜本的にアルゴリズムを見直す？
    void UIupdate()
    {
        //weaponUIdata[0].bulletnumber = weapondatas[0].bulletnumber;
        
        for (int i = 0; i <= 3; i++)
        {
            weaponUIdata[i].bulletnumber = weapondatas[i].bulletnumber;
            weaponUIdata[i].fire = weapondatas[i].fire;
            weaponUIdata[i].reloading = weapondatas[i].reloading;
            weaponUIdata[i].reloadtimer = weapondatas[i].reloadtime;
        }
        
    }
    //武器のインスタンス生成直後に起動。装備している武器の配列を得て、その中のwepondataを配列に格納
    public void weaponGet(GameObject[] weaponarray)
    {
        for (int i = 0; i <= 3; i++)
        {
            weapondatas[i] = weaponarray[i].GetComponent<weapondata>();
        }
    }

    void weaponimagesetter()
    {
        //Debug.Log("imagesetter" + card0.transform.Find("cardicon").gameObject.GetComponent<spritechanger>().sprite_change(weapondatas[0].weaponicon));
        //spritechanger card0sprite = card0.transform.Find("cardicon").gameObject.GetComponent<spritechanger>();
        //card0sprite.sprite_change(weapondatas[0].weaponicon);
        card0.transform.Find("cardicon").gameObject.GetComponent<cardicon>().set = true;
        card1.transform.Find("cardicon").gameObject.GetComponent<cardicon>().set = true;
        card2.transform.Find("cardicon").gameObject.GetComponent<cardicon>().set = true;
        card3.transform.Find("cardicon").gameObject.GetComponent<cardicon>().set = true;
    }
}
