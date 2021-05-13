using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public int selectcarsor = 0;
    bool beforeinput = false;
    [SerializeField] GameObject[] buttonobj = new GameObject[3];
    Iselectbutton[] button = new Iselectbutton[3];
    void Start()
    {
        buttonSet();
    }
    void buttonSet()
    {
        for (int i = 0; i <= 2; i++)
        {
            button[i] = buttonobj[i].GetComponent<Iselectbutton>();
        }
    }

    void Update()
    {
        //pause中でないなら処理をしない
        if (pause_open.pausenow == false) { return; }

        //カーソル移動をselectcarsorに得る
        carsorposition();

        //押されたボタンの処理を起動する
        if (Input.GetKeyDown(KeyCode.Z))
        {
            button[Mathf.Abs(selectcarsor)].push();
        }
    }

    //カーソルの位置を一番上から0、-1、-2でループする形で返す
    void carsorposition()
    {
        //カーソルの位置をselectcarcorで管理
        if (Input.GetAxisRaw("Vertical") == 1 && beforeinput == false)
        {
            Debug.Log("up");
            selectcarsor++;
            beforeinput = true;
        }
        else if (Input.GetAxisRaw("Vertical") == -1 && beforeinput == false)
        {
            Debug.Log("down");
            selectcarsor--;
            beforeinput = true;
        }
        else if (Input.GetAxisRaw("Vertical") == 0 && beforeinput == true)
        {
            beforeinput = false;
        }

        //カーソルのオバーフローを修正
        if (selectcarsor == 1) selectcarsor = -2;
        else if (selectcarsor == -3) selectcarsor = 0;
    }
}
