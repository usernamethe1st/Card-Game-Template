using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onetwo : MonoBehaviour
{ 
    public Hud hud;
    
    public Transform target;

    
    public Transform Gatag;
    public Transform Fatag;
    public Transform Datag;
    public Transform Watag;
    public Transform Satag;
    
    
    public Rigidbody2D rd;
    
    public GameObject Firemana;
    public GameObject Orc;
    public GameObject Bow;
    public GameObject Littlefire;
    public GameObject Potonofextr;
    
    public float rotateSpeed = 200f;
    public float luck = 10f;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<Hud>();
        rd = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Centering").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // (hud.ters == 1)


  
        Gatag = GameObject.FindGameObjectWithTag("Ga").transform;
        Datag = GameObject.FindGameObjectWithTag("Da").transform;
        Satag = GameObject.FindGameObjectWithTag("Sa").transform;
        Watag = GameObject.FindGameObjectWithTag("Wa").transform;
        Fatag = GameObject.FindGameObjectWithTag("Fa").transform;
        

        if (hud.atting == true)
        {
            if (hud.ters == 1)
            {
                Gatag.tag = "A1";
                Gatag.position = target.position;
                hud.atting = false;
                Debug.Log("instantiate fire 1.");
            }
            if (hud.ters == 2)
            {
                Fatag.tag = "A1";
            }
            if (hud.ters == 3)
            {
               Datag.tag = "A1";
            }
            if (hud.ters == 4)
            {
                Watag.tag = "A1";
            }
            if (hud.ters == 5)
            {
                Satag.tag = "A1";
            }
            
        }


           
    }
 

}
