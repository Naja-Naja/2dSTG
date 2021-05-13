using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausebutton : MonoBehaviour//, Iselectbutton
{
    [SerializeField] GameObject marker = null;
    [SerializeField] GameObject pausemenu = null;
    pause pause = null;
    [SerializeField] int buttonnumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        pause=pausemenu.GetComponent<pause>();
    }

    // Update is called once per frame
    void Update()
    {
        //pause中でないなら処理をしない
        if (pause_open.pausenow == false) { return; }

        if (pause.selectcarsor == buttonnumber)
        {
            marker.SetActive(true);
        }
        else
        {
            marker.SetActive(false);
        }
    }
    public void push()
    {
        Debug.Log("ボタン処理");
    }
    /*
    public void select()
    {
        marker.SetActive(true);
    }
    */
}
