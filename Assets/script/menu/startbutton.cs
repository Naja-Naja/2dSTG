using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbutton : MonoBehaviour
{
    [SerializeField]menumanager menumanager = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") || Input.GetKey(KeyCode.Z) || Input.GetKey("enter"))
        {
            menumanager.stageload();
        }
    }
}
