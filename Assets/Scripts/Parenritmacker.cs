using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parenritmacker : MonoBehaviour
{
    public float ll = 1;

    
    public float xvector = 50;
    public Hud hud;

    public float yvector = 100;
    public Transform Canvas;
    // Start is called before the first frame update
    void Start()
    {
        
        Canvas = GameObject.FindGameObjectWithTag("Canvas").transform;
        
        hud = GameObject.FindObjectOfType<Hud>();
        if (hud.std)
        {
            transform.position = hud.target.position;
            hud.std = false;

            
            if (hud.kk == 2)
            { 
                this.gameObject.tag = "Ga";
            }
            if (hud.kk == 3)
            { 
                this.gameObject.tag = "Fa";
            }
            if (hud.kk == 4)
            { 
                this.gameObject.tag = "Da";
            } if (hud.kk == 5)
            { 
                this.gameObject.tag = "Wa";
            } if (hud.kk == 6)
            { 
                this.gameObject.tag = "Sa";
            }
        }
        //hud.target.position = hud.target.position - new Vector3(xvector, yvector, 0);
    }

    void Update()
    {   
        //if (ll <= 0)
       // {

       //    Mmm = true;
        //}

       // if (Mmm == false)
       //// {
         //   ll = ll - Time.deltaTime;
            
        //}

        //if (Mmm)
        //{
        ///    transform.position = transform.position - new Vector3(xvector, yvector, 0);

       // }


       this.transform.SetParent(Canvas);
       

        
    }
}
