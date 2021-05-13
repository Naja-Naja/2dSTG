using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorselect : MonoBehaviour
{
    public carddata selectweapon = null;
    public Sprite selectweaponimage = null;
    GameObject tmp = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")|| Input.GetKeyDown(KeyCode.Z)|| Input.GetKeyDown("enter"))
        {
            if (tmp.GetComponent<slotcard>() != null) { Debug.Log("return"); return; }
            //selectweapon = tmp.GetComponent<carddata>().cardweapon;
            selectweapon = tmp.GetComponent<carddata>();
            Debug.Log("cursor"+selectweapon.name);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        tmp = collision.gameObject;
    }
}
