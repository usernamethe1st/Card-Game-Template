using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pckers : MonoBehaviour
{
   
   
    public Transform Green1;
    public Transform fire1;
    public Transform Death1;
    public Transform Water1;
    public Transform Sky1;
    public bool mmm = true;
  
   
    public float ll = 1 ;

    public Hud hud;
  
    // Start is called before the first frame update
    void Start()
    {

        hud = GameObject.FindObjectOfType<Hud>();
 
    }

    // Update is called once per frame
    void Update()
    {
     
        if (mmm == false)
        {
            ll = ll - Time.deltaTime;
        }

        if (ll <= 0)
        {
            ll = 1;
            mmm = true;
        }
        if (mmm)
        {
            if (Input.GetKey(KeyCode.W))
            {
                mmm = false;
                hud.ter = hud.ter - 1;
            }

            if (Input.GetKey(KeyCode.S))
            {
                mmm = false;

                hud.ter = hud.ter + 1;
            }
        }

        if (hud.ter == 1)
        {
            transform.position = Green1.position;
        }
        if (hud.ter == 2)
        {
            transform.position = fire1.position;
        }
        if (hud.ter == 3)
        {
            transform.position = Death1.position;
        }
        if (hud.ter == 4)
        {
            transform.position = Water1.position;
        }      
        if (hud.ter == 5)
        {
            transform.position = Sky1.position;
        }

        if (hud.ter > 5)
        {
            hud.ter = 1;
        }
        if (hud.ter < 1)
        {
            hud.ter = 5;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            hud.sendt = true;
        }
    }
}