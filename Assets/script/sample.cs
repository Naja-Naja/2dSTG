using UnityEngine;
using System.Collections;

public class sample: MonoBehaviour
{
    GameObject player;
    [SerializeField]GameObject gamemanager = null;
    weapondata weapondata = null;
    Sprite sprite = null;
    void Start()
    {
        weapondata=gamemanager.GetComponent<playerinfo>().weapon1.GetComponent<weapondata>();
        sprite = weapondata.weaponicon;
        GetComponent<spritechanger>().sprite_change(sprite);
        //GetComponent<SpriteRenderer>().sprite = sprite;
    }
    /// 更新
    void Update()
    {
    }
    public void testcode()
    {
        weapondata = gamemanager.GetComponent<playerinfo>().weapons[0].GetComponent<weapondata>();
        sprite = weapondata.weaponicon;
        GetComponent<spritechanger>().sprite_change(sprite);
    }
}
