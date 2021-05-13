using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class enemymoveVer3 : MonoBehaviour
{
    Vector2 move;
    float positionx = 0;
    float positiony = 0;
    Sequence tweens;

    void OnEnable()
    {
        initialize();
        /*
            positionx = Random.Range(-1.3f, 5f);
            positiony = Random.Range(-2.4f, 4.5f);
            move = new Vector2(positionx, positiony);
            tweens = DOTween.Sequence();
            tweens.Append(transform.DOMove(move, 4f).SetLink(gameObject));
            tweens.Append(transform.DOLocalMove(new Vector2(0, 3), 4f).SetRelative().SetEase(Ease.InOutFlash, 2).SetLoops(10000).SetLink(gameObject));
        */
    }
    
    public void initialize()
    {
        positionx = Random.Range(-1.3f, 5f);
        positiony = Random.Range(-2.4f, 4.5f);
        move = new Vector2(positionx, positiony);
        tweens = DOTween.Sequence();
        tweens.Append(transform.DOMove(new Vector2(12, 0), 0f).SetLink(gameObject));
        tweens.Append(transform.DOMove(move, 4f).SetLink(gameObject));
        tweens.Append(transform.DOLocalMove(UpORDown(), 4f).SetRelative().SetEase(Ease.InOutFlash, 2).SetLoops(10000).SetLink(gameObject));
    }

    private Vector2 UpORDown()
    {
        if (positiony > 1.05f)
        {
            move = new Vector2(0, -3);
        }
        else
        {
            move = new Vector2(0, 3);
        }
        return move;
    }
}
