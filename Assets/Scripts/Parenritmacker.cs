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
        hud.target.position = hud.target.position - new Vector3(xvector, yvector, 0);
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
