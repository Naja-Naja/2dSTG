using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carddata : MonoBehaviour
{
    public GameObject cardweapon = null;
    public Sprite cardimage = null;
    // Start is called before the first frame update
    void Start()
    {
        //cardimage = GetComponent<SpriteRenderer>().sprite;
        cardimage = transform.Find("tileimage").gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
