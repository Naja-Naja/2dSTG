using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class pausewindow_move : MonoBehaviour
{
    Vector2 move_down;
    Vector2 move_up;
    private void Start()
    {
        move_down = new Vector2(0, 0);
        move_up = new Vector2(0, 10);
    }
    public void windowmove(bool down)
    {
        if (down)
        {
            print("windowmove");
            transform.DOLocalMove(move_down, 0.2f)/*.SetRelative()*/.SetEase(Ease.OutCubic).SetUpdate(true);
            return;
        }
        transform.DOLocalMove(move_up, 0.2f)/*.SetRelative()*/.SetEase(Ease.OutCubic).SetUpdate(true);
    }
}
