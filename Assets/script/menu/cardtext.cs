using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardtext : MonoBehaviour
{
    public TextMesh card_text = null;
    // Start is called before the first frame update
    void Start()
    {
        GameObject parentGameObject = transform.parent.gameObject;
        GameObject text= parentGameObject.GetComponent<carddata>().cardweapon;
        card_text.text = text.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
