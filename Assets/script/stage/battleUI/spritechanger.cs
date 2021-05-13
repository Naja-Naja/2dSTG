using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechanger : MonoBehaviour
{
    SpriteRenderer spriteRenderer = null;
    [SerializeField]Sprite test = null;
    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        Debug.Log("spritechanger is get this  " + spriteRenderer);
    }

    // Update is called once per frame
    public void sprite_change(Sprite image)
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        Debug.Log("Sprite is " + image);
        spriteRenderer.sprite = image;
        //spriteRenderer.sprite = test;
    }
}
