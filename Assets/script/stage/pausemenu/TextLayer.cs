using UnityEngine;
using System.Collections;

public class TextLayer : MonoBehaviour
{

    public string LayerName;
    public int SortingOrder;

    // Use this for initialization
    void Start()
    {
        //レイヤーの名前
        this.GetComponent<MeshRenderer>().sortingLayerName = LayerName;
        //Order in Layerの数値
        this.GetComponent<MeshRenderer>().sortingOrder = SortingOrder;
    }

    // Update is called once per frame
    void Update()
    {

    }
}