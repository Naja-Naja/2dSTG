using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove2 : MonoBehaviour
{
    public string LockTag = "enemy";
    GameObject target;//ロックしているオブジェクト
    float newAngle = 0;
    /// 旋回速度
    float _rotSpeed = 0.5f;
    /// 移動速度
    float _speed = 500.0f;
    float Direction
    {
        get { return Mathf.Atan2(GetComponent<Rigidbody2D>().velocity.y, GetComponent<Rigidbody2D>().velocity.x) * Mathf.Rad2Deg; }
    }
    /// 角度と速度から移動速度を設定する
    void SetVelocity(float direction, float speed)
    {
        var vx = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        var vy = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(vx, vy);
    }
    void Start()
    {
        GameObject[] enemy_Objects;
        //敵走査用のゲームオブジェクト配列
        //enemyタグのオブジェクトを配列に得る
        enemy_Objects = GameObject.FindGameObjectsWithTag(LockTag);
        //敵がいないときの例外処理
        if (enemy_Objects.Length == 0) return;
        //敵がいる場合はその敵との距離を計算する
        //初期値を最大に設定
        float min_target_distance = float.MaxValue;
        //ロックオンする敵が複数いた場合のプログラム
        for (int i = 0; i < enemy_Objects.Length; i++)
        {
            float target_distance = Vector2.Distance(transform.localPosition, enemy_Objects[i].transform.position);
            //target_distanceを最短情報に更新し、最短だったgameobjectを記録
            if (target_distance < min_target_distance)
            {
                min_target_distance = target_distance;
                target = enemy_Objects[i];
            }
        }

    }

    void FixedUpdate()
    {
        config.bulletdestroy(transform.localPosition, this.gameObject);
        if (target == null)
        {
            SetVelocity(newAngle, _speed * Time.deltaTime);
            return;
        }
        // 画像の角度を移動方向に向ける
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, Direction));

        // ターゲット座標を取得
        Vector3 next = target.transform.position;
        Vector3 now = transform.position;
        // 目的となる角度を取得する
        Vector3 d = next - now;
        float targetAngle = Mathf.Atan2(d.y, d.x) * Mathf.Rad2Deg;
        // 角度差を求める
        float deltaAngle = Mathf.DeltaAngle(Direction, targetAngle);
        newAngle = Direction;
        if (Mathf.Abs(deltaAngle) < _rotSpeed)
        {
            // 旋回速度を下回る角度差なので何もしない
        }
        else if (deltaAngle > 0)
        {
            // 左回り
            newAngle += _rotSpeed * Time.deltaTime * 60;
        }
        else
        {
            // 右回り
            newAngle -= _rotSpeed * Time.deltaTime * 60;
        }

        // 新しい速度を設定する
        SetVelocity(newAngle, _speed * Time.deltaTime);
    }
}
