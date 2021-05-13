using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapondata : MonoBehaviour
{
    
    public bool fire = false;
    public bool reloading = false;
    public float M_bulletnumber = 10;
    public float bulletnumber;
    public float reloadtime = 25;
    public float option=0;
    public Sprite weaponicon = null;

    public void weapondatanew(bool f, bool r, float Mb, float b, float rt ,float option=0)
    {
        fire = f;
        reloading = r;
        M_bulletnumber = Mb;
        bulletnumber = b;
        reloadtime = rt;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
