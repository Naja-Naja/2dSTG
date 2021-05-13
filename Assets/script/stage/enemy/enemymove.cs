using UnityEngine;
using DG.Tweening;

public class enemymove : MonoBehaviour
{
    Vector2 move;
    float positionx = 0;
    float positiony = 0;
    Tween loop;
    Tween start;
    void Start()
    {
        //test
        firstinitialize();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("初期化");
            transform.position = new Vector2(0, 0);
            //initialize();
        }
    }

    void UpDown()
    {
        if (positiony>1.05f)
        {
            move = new Vector2(0, -3);
        }
        else
        {
            move = new Vector2(0, 3);
        }
        loop=transform.DOLocalMove(move, 4f).SetRelative().SetEase(Ease.InOutFlash, 2).SetLoops(-1).SetLink(gameObject);
    }
    /*
    public void initialize()
    {
        //transform.localPosition=new Vector2(0,0);
        if (loop != null)
        {
            loop.Pause();
            start.Pause();
            transform.localPosition = new Vector2(12, 0);
            // reset property
            //transform.localRotation = Quaternion.Euler(0, 0, 0);

            //loop.Complete(); Debug.Log("killed");
            //start.Complete();
        }
        Debug.Log("書き換え");
        this.gameObject.transform.position = new Vector3(12, 0,0);

        Vector3 worldPos = this.gameObject.transform.position;
        worldPos.x = 24.0f;    // ワールド座標を基準にした、x座標を1に変更
        worldPos.y = 0.0f;    // ワールド座標を基準にした、y座標を1に変更
        worldPos.z = 0.0f;    // ワールド座標を基準にした、z座標を1に変更
        this.gameObject.transform.position = worldPos;  // ワールド座標での座標を設定

        positionx = Random.Range(-1.3f, 5f);
        positiony = Random.Range(-2.4f, 4.5f);
        move = new Vector2(positionx, positiony);
        //transform.position = move;
        start =transform.DOMove(move, 4f).SetLink(gameObject).OnComplete(() => UpDown());
    }
    */
    /*
    public void initialize()
    {
        positionx = Random.Range(-1.3f, 5f);
        positiony = Random.Range(-2.4f, 4.5f);
        move = new Vector2(positionx, positiony);
        loop.Pause();
        start.Pause();
        loop.Restart();
    }
    */
    void firstinitialize()
    {
        positionx = Random.Range(-1.3f, 5f);
        positiony = Random.Range(-2.4f, 4.5f);
        move = new Vector2(positionx, positiony);
        start = transform.DOMove(move, 4f).SetLink(gameObject).OnComplete(() => UpDown());
    }
    void test()
    {
        Sequence sequence = DOTween.Sequence();
    }
}
