using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class return_menu : MonoBehaviour, Iselectbutton
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void push()
    {
        SceneManager.LoadScene("menu");
    }
}
