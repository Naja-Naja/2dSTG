using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotcard : MonoBehaviour
{
    public carddata selectweapon = null;
    [SerializeField]GameObject tmp = null;
    cardtext_changerable tiletext;
    [SerializeField]slotdata_changerable slotdata_Changerable=null;
    //[SerializeField] GameObject tmp2 = null;
    [SerializeField] carddata carddata = null;
    [SerializeField]slotcarddata slotcarddata = null;
    void Start()
    {
        //tiletext = transform.Find("tiletext").gameObject.GetComponent<cardtext_changerable>();
    }

    // Update is called once per frame
    /*
    void Update()
    {
        //tmp2=tmp.GetComponent<cursorselect>().selectweapon;
        
        if (Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown("enter"))
        {
            //if (tmp.GetComponent<cursorselect>() == null) return;
            selectweapon = tmp;//.GetComponent<cursorselect>().selectweapon;
            tiletext.cardtext_changer(selectweapon);
            //抜本的解決にはなっていないコード。武器選択でバグがでたらオブジェクトの受け渡し関連を疑え
            carddata.cardweapon = selectweapon;
        }
        
    }
    */

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("call");
        if (Input.GetKey("space") || Input.GetKey(KeyCode.Z) || Input.GetKey("enter"))
        {
            //Debug.Log("push");
            tmp = collision.gameObject;
            selectweapon = collision.gameObject.GetComponent<cursorselect>().selectweapon;
            //selectweapon = tmp.GetComponent<cursorselect>().selectweapon;
            //tiletext.cardtext_changer(selectweapon);
            slotdata_Changerable.carddata_changer(selectweapon);
            //抜本的解決にはなっていないコード。武器選択でバグがでたらオブジェクトの受け渡し関連を疑え
            slotcarddata.cardweapon = selectweapon;
        }
           
    }
}
