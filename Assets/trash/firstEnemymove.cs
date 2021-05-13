using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class firstEnemymove : MonoBehaviour
{
    Vector2 move2;
    float positionx = 0;
    float positiony = 0;
    Vector2 move;

    Tween currentPlayTween;
    void Start()
    {
        positionx=Random.Range(-1.3f, 5f);
        positiony = Random.Range(-2.4f, 4.5f);
        move = new Vector2(positionx, positiony);
        //transform.position = move;
        transform.DOMove(/*new Vector2(12,0)*/move, 4f).SetLink(gameObject).OnComplete(() => transform.position = move);


        /*
        currentPlayTween = transform.DOMove(move, 4f)
                .SetEase(Ease.OutQuad);
        // 相対に切り替え
        currentPlayTween.SetRelative();



        // 再生
        currentPlayTween.Play();
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
