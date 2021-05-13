using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    GameObject[] weapons = new GameObject[4];
    //test用の仮設定
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public GameObject weapon4;
    [SerializeField]gamedata gamedata=null;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("stageload", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void stageload()
    {
        weapons[0] = weapon1.GetComponent<slotcarddata>().cardweapon.cardweapon;
        weapons[1] = weapon2.GetComponent<slotcarddata>().cardweapon.cardweapon;
        weapons[2] = weapon3.GetComponent<slotcarddata>().cardweapon.cardweapon;
        weapons[3] = weapon4.GetComponent<slotcarddata>().cardweapon.cardweapon;
        gamedata.weapons = weapons;
        ChangeScene();

    }
    void ChangeScene()
    {
        SceneManager.LoadScene("stage");
    }
}
