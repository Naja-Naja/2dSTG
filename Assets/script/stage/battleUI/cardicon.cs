using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardicon : MonoBehaviour
{
    public bool set = false;
    bool setted = false;
    Sprite sprite = null;
    [SerializeField]int cardnumber = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (set==true&&setted==false)
        {
            sprite=weaponflame.weapondata[cardnumber].GetComponent<weapondata>().weaponicon;
            GetComponent<spritechanger>().sprite_change(sprite);
            setted = true;
        }
    }
}
