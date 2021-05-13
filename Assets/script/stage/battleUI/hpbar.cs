using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpbar : MonoBehaviour
{
    public Image m_hpGauge; // HP ゲージ
    public GameObject player;
    public hit script;
    //public Image m_expGauge; // 経験値ゲージ
    void Start()
    {
        // プレイヤーを取得する
        player = GameObject.FindWithTag("Player");
        script = player.GetComponent<hit>();
    }

    // 毎フレーム呼び出される関数
    private void Update()
    {
        // HP のゲージの表示を更新する
        float hp = script.nowhp;
        float hpMax = script.maxhp;
        m_hpGauge.fillAmount = (float)hp / hpMax;
    }
}
