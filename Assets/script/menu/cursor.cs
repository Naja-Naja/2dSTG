using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    [SerializeField]float[] basho = { -2, 0 };
    //bool push=false;
    float bh, bv;
    [SerializeField]GameObject startbutton = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (bh != h)
        {
            if (h == 1)
            {
                if (basho[0] == 2) { return; }
                basho[0]++;
            }
            if (h == -1)
            {
                if (basho[0] == -2) { return; }
                basho[0]--;
            }
            bh = h;
        }
        if (bv != v)
        {
            if (v == 1)
            {
                if (basho[1] == 1) { return; }
                basho[1]++;
            }
            if (v == -1)
            {
                if (basho[1] == -1) { return; }
                basho[1]--;
            }
            bv = v;
        }
        if (basho[0] == 2 && basho[1] == 1) { basho[0]--; }



        if (basho[1] == 1)//武器スロットの座標
        {
            transform.position = new Vector2(basho[0] * 2f + 1, 2.5f * basho[1]);
        }
        else if (basho[1] == -1 && basho[0] >= 1)//出撃ボタンの選択時
        {
            transform.position = new Vector2(basho[0] * 8f + 1, 2.5f * basho[1]);
            basho[0] = 1;
            startbutton.SetActive(true);
        }
        else
        {
            transform.position = new Vector2(basho[0] * 2f    , 3.0f * basho[1]);
            startbutton.SetActive(false);
        }
    }
}
