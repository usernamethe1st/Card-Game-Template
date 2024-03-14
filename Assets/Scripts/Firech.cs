using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firech : MonoBehaviour
{
    public float ll = 1;
    public float kk = 1;
    
    public GameObject Firemana;
    public GameObject Orc;
    public GameObject Bow;
    public GameObject Littlefire;
    public GameObject Potonofextr;
    public Hud hud;
    public Transform target;
    public bool mmm = true;
    
    // Start is called before the first fssrame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("G1").transform;
        hud = GameObject.FindObjectOfType<Hud>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ll <= 0)
        {
            ll = 1;
         
        }
        ll = ll - Time.deltaTime;
       
            
        
        if (hud.picts > 115)
        {
            hud.picts = 0;
        }
        if (hud.pict > 100)
        {
            hud.pict = 0;
        }
        hud.pict = hud.pict + 1;
        hud.picts = hud.picts + 1;
        if (hud.ch == 2)
        {
            if (kk == 1)
            {
                target = GameObject.FindGameObjectWithTag("G").transform;
            }
            if (kk == 2)
            {
                target = GameObject.FindGameObjectWithTag("hand").transform;
            }
            if (kk == 3)
            {
                target = GameObject.FindGameObjectWithTag("d").transform;
            }
            if (kk == 4)
            {
                target = GameObject.FindGameObjectWithTag("w").transform;
            }
            if (kk == 5)
            {
                target = GameObject.FindGameObjectWithTag("s").transform;
            }
            if (ll == 1)
            {
                if (hud.pict <= 50)
                {
                    Instantiate(Firemana, target.position, target.rotation);
                    kk = kk + 1;
                }

                if (hud.pict < 70 && hud.pict > 50)
                {
                    Instantiate(Orc);
                    kk = kk + 1;
                }

                if (hud.pict <= 85 && hud.pict >= 70)
                {
                    Instantiate(Bow, target.position, target.rotation);
                    kk = kk + 1;
                }

                if (hud.pict < 105 && hud.pict > 85)
                {
                    Instantiate(Littlefire, target.position, target.rotation);
                    kk = kk + 1;
                }

                if (hud.pict <= 115 && hud.pict >= 105)
                {
                    Instantiate(Potonofextr, target.position, target.rotation);
                    kk = kk + 1;
                }
            }
        }
    }
}
