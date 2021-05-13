using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class enemymoveVer2 : MonoBehaviour
{
    Vector2 move;
    float positionx = 0;
    float positiony = 0;
    Sequence tweens;
    void Start()
    {
        positionx = Random.Range(-1.3f, 5f);
        positiony = Random.Range(-2.4f, 4.5f);
        move = new Vector2(positionx, positiony);
        tweens = DOTween.Sequence();
        tweens.Append(transform.DOMove(move, 4f).SetLink(gameObject));
        tweens.Append(transform.DOLocalMove(new Vector2(0, 3), 4f).SetRelative().SetEase(Ease.InOutFlash, 2).SetLoops(10000).SetLink(gameObject));
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.gameObject.SetActive(false);
        }
    }
    public void initialize()
    {
        positionx = Random.Range(-1.3f, 5f);
        positiony = Random.Range(-2.4f, 4.5f);
        Debug.Log(positionx);
        move = new Vector2(positionx, positiony);
        tweens = DOTween.Sequence();
        //transform.position = new Vector2(0, 12);
        tweens.Append(transform.DOMove(new Vector2(12, 0), 0f).SetLink(gameObject));
        tweens.Append(transform.DOMove(move, 4f).SetLink(gameObject));
        //tweens.Restart();
        tweens.Append(transform.DOLocalMove(new Vector2(0, 3), 4f).SetRelative().SetEase(Ease.InOutFlash, 2).SetLoops(10000).SetLink(gameObject));
        
        //tweens.Prepend(transform.DOMove(move, 4f).SetLink(gameObject));
    }

    void loop()
    {
        tweens.Prepend(transform.DOLocalMove(new Vector2(0, 3), 4f).SetRelative().SetEase(Ease.InOutFlash, 2).SetLoops(10000).SetLink(gameObject));
    }
}
