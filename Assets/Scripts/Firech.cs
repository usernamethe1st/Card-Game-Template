using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Firech : MonoBehaviour
{
    public float ll = 1;
    public float kk = 1;
    public float kkk = 1;
    public GameObject Firemana;
    public GameObject Orc;
    public GameObject Bow;
    public GameObject Littlefire;
    public GameObject Potonofextr;
    public Hud hud;
    public Transform target;
    public Transform targets;
    public bool Mmm = true;
    public Transform _Canvas;
    
    // Start is called before the first fssrame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("G").transform;
        targets = GameObject.FindGameObjectWithTag("G1").transform;
        hud = GameObject.FindObjectOfType<Hud>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ll <= 0)
        {
            ll = 1;

            Mmm = true;
        }

        if (Mmm)
        {
            ll = ll - Time.deltaTime;
            
        }
        
       
            
        
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
        if (hud.sendwe  == false)
        {
            
            
            if (hud.ch == 2 )
            {
                
                if (kk == 1)
                {
                    target = GameObject.FindGameObjectWithTag("G").transform;
                }

                if (kk == 2)
                {
                    target = GameObject.FindGameObjectWithTag("Hand").transform;
                }

                if (kk == 3)
                {
                    target = GameObject.FindGameObjectWithTag("D").transform;
                }

                if (kk == 4)
                {
                    target = GameObject.FindGameObjectWithTag("W").transform;
                }

                if (kk == 5)
                {
                    target = GameObject.FindGameObjectWithTag("S").transform;
                    hud.sendwe = true;

                }

                if (kkk == 1)
                {
                    targets = GameObject.FindGameObjectWithTag("G1").transform;
                }

                if (kkk == 2)
                {
                    targets = GameObject.FindGameObjectWithTag("Hand1").transform;
                }

                if (kkk == 3)
                {
                    targets = GameObject.FindGameObjectWithTag("D2").transform;
                }

                if (kkk == 4)
                {
                    targets = GameObject.FindGameObjectWithTag("W1").transform;
                }

                if (kkk == 5)
                {
                    targets = GameObject.FindGameObjectWithTag("S1").transform;

                }

                if (Mmm == true)
                {
                    
                    if (hud.pict <= 50)
                    {
                        Instantiate(Firemana, target.position, target.rotation);
                        Bow.transform.SetParent(_Canvas);
                        Debug.Log("instantiate Firemana 1.");
                        kk = kk + 1;
                        Mmm = false;
                    }

                    if (hud.pict < 70 && hud.pict > 50)
                    {
                        Instantiate(Orc, target.position, target.rotation);
                        Bow.transform.SetParent(_Canvas);
                        kk = kk + 1;
                        Mmm = false;
                        Debug.Log("instantiate Orc 1.");

                    }

                    if (hud.pict <= 85 && hud.pict >= 70)
                    {
                        Instantiate(Bow, target.position, target.rotation);
                        Bow.transform.SetParent(_Canvas);
                        kk = kk + 1;
                        Mmm = false;
                        Debug.Log("instantiate Bow 1.");

                    }

                    if (hud.pict < 105 && hud.pict > 85)
                    {
                        Instantiate(Littlefire, target.position, target.rotation);
                        Littlefire.transform.SetParent(_Canvas);
                        kk = kk + 1;
                        Mmm = false;

                    }

                    if (hud.pict <= 115 && hud.pict >= 105)
                    {
                        Instantiate(Potonofextr, target.position, target.rotation,_Canvas);
                        Potonofextr.transform.SetParent(_Canvas);
                        kk = kk + 1;
                        Mmm = false;

                    }
                }

                if (Mmm == true)
                {
                    if (hud.picts <= 50)
                    {
                        Instantiate(Firemana, targets.position, targets.rotation);
                        Firemana.transform.SetParent(_Canvas);
                        Debug.Log("instantiate fire 1.");
                        kkk = kkk + 1;
                        Mmm = false;

                    }

                    if (hud.picts < 70 && hud.picts > 50)
                    {
                        Instantiate(Orc, target.position, target.rotation);
                        Orc.transform.SetParent(_Canvas);
                        kkk = kkk + 1;
                        Mmm = false;

                    }

                    if (hud.picts <= 85 && hud.picts >= 70)
                    {
                        Instantiate(Bow, targets.position, targets.rotation);
                        Bow.transform.SetParent(_Canvas);
                        kkk = kkk + 1;
                        Mmm = false;

                    }

                    if (hud.picts < 105 && hud.picts > 85)
                    {
                        Instantiate(Littlefire, targets.position, targets.rotation);
                        Bow.transform.SetParent(_Canvas);
                        kkk = kkk + 1;
                        Mmm = false;

                    }

                    if (hud.picts <= 115 && hud.picts >= 105)
                    {
                        Instantiate(Potonofextr, targets.position, targets.rotation);
                        Bow.transform.SetParent(_Canvas);
                        Debug.Log("instantiate fire 1.");
                        kkk = kkk + 1;
                        Mmm = false;

                    }
                }
            }
        }
    }
}
