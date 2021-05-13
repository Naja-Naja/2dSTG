using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamedata : MonoBehaviour
{
    public GameObject[] weapons = new GameObject[4];
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        
    }
}
