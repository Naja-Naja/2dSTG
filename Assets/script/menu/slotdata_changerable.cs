using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotdata_changerable : MonoBehaviour
{
    public TextMesh card_text = null;
    public Sprite cardslotsprite = null;
    public SpriteRenderer SpriteRenderer = null;
    //このクラスはslotcard.csで呼ばれ、引数で受けたカードデータ内の画像とテキストをslotオブジェクトに適用する

    void Start()
    {
        card_text = transform.Find("tiletext").gameObject.GetComponent<TextMesh>();
        SpriteRenderer =transform.Find("tileimage").gameObject.GetComponent<SpriteRenderer>();
    }
    public void carddata_changer(carddata carddata)
    {
        cardtext_changer(carddata.cardweapon.name);
        print(carddata.cardweapon.name);
        cardimage_changer(carddata.cardimage);
    }
    void cardtext_changer(string text)
    {
        card_text.text = text;
    }
    void cardimage_changer(Sprite weapoonimage)
    {
        SpriteRenderer.sprite = weapoonimage;
    }
}
