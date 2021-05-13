using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_open : MonoBehaviour
{
    public static bool pausenow = false;
    [SerializeField] pausewindow_move pausewindow_Move = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausenow)
            {
                Time.timeScale = 1f;
                pausenow = false;
                pausewindow_Move.windowmove(pausenow);

            }
            else
            {
                Time.timeScale = 0f;
                pausenow = true;
                pausewindow_Move.windowmove(pausenow);
            }
        }
    }

    public void close_menu()
    {
        Time.timeScale = 1f;
        pausenow = false;
        pausewindow_Move.windowmove(pausenow);
    }
}
