using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class testmove : MonoBehaviour
{
    Tween loop;
    bool tmp = false;
    Vector2 move = new Vector2(0, 2);
    public GameObject a;
    //enemymoveVer2 b;
    void Start()
    {
        //transform.DOMove(new Vector2(2,0), 2f).SetLink(gameObject).OnComplete(() => UpDown());
        //b = a.GetComponent<enemymoveVer2>();
        //loop = transform.DOLocalMove(move, 4f).SetRelative().SetEase(Ease.InOutFlash, 2).SetLoops(-1).SetLink(gameObject);
        //transform.localPosition = new Vector2(0, 0);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            a.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            a.SetActive(true);
        }
        /*
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("初期化");
            transform.position = new Vector2(0, 0);
            Settween();
        }
        /*
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.gameObject.SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("初期化");
            a.SetActive(true);
            b.initialize();
        }
        */
    }
}
