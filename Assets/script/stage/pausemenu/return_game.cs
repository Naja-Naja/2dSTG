using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class return_game : MonoBehaviour, Iselectbutton
{
    [SerializeField] GameObject pausemenu = null;
    pause_open pause_Open;
    // Start is called before the first frame update
    void Start()
    {
        pause_Open=pausemenu.GetComponent<pause_open>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void push()
    {
        Debug.Log("ボタン処理2");
        pause_Open.close_menu();
    }
}
