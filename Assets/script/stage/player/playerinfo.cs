using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinfo : MonoBehaviour
{
    public GameObject[] weapons=new GameObject[4];
    //test用の仮設定
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public GameObject weapon4;
    // Start is called before the first frame update
    void Start()
    {
        //test代入
        weapons[0] = weapon1;
        weapons[1] = weapon2;
        weapons[2] = weapon3;
        weapons[3] = weapon4;
        /*
        gamedata gamedata = GameObject.Find("Gamedata").GetComponent<gamedata>();
        if (gamedata == null) { }
        else
        {
            weapons = gamedata.weapons;
        }
        */
        //weaponflame flame = 
        GameObject.Find("weaponflame").GetComponent<weaponflame>().weaponSet(weapons);
        //flame.weaponSet(weapon1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
