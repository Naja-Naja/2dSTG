using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponflame : MonoBehaviour
{
    static public GameObject[] weapondata = new GameObject[4];
    Iinput[] weapons = new Iinput[4];

    //仮
    [SerializeField]GameObject weaponUI = null;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) == false)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                weapons[0].input();
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                weapons[1].input();
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                weapons[2].input();
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                weapons[3].input();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                weapons[0].reload();
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                weapons[1].reload();
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                weapons[2].reload();
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                weapons[3].reload();
            }
        }
    }
    public void weaponSet(GameObject[] weapon)
    {
        for (int i = 0; i <= 3; i++)
        {
            weapondata[i] = Instantiate(weapon[i], this.gameObject.transform);
            weapons[i] =weapondata[i].GetComponent<Iinput>();
        }
        weaponUI.GetComponent<weaponUI>().weaponGet(weapondata);
    }
}
