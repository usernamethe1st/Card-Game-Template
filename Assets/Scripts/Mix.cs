using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mix : MonoBehaviour
{
  
    public Transform Green;
    public Transform fire;
    public Transform Death;
    public Transform Water;
    public Transform Sky;
    public bool mmm = true;

    public Hud hud;
    public float ll = 1 ;
    // Start is called before the first frame update
    void Start()
    {
        Green = GameObject.FindGameObjectWithTag("G").transform;
        fire = GameObject.FindGameObjectWithTag("Hand").transform;
        Death = GameObject.FindGameObjectWithTag("D").transform;
        Water = GameObject.FindGameObjectWithTag("W").transform;
        Sky = GameObject.FindGameObjectWithTag("S").transform;

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


            if (Input.GetKey(KeyCode.UpArrow))
            {
                mmm = false;

                    hud.ters = hud.ters - 1;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                mmm = false;

                hud.ters = hud.ters + 1;
            }
        }

        if (hud.ters == 1)
        {
            transform.position = Green.position;
        }
        if (hud.ters == 2)
        {
            transform.position = fire.position;
        }
        if (hud.ters == 3)
        {
            transform.position = Death.position;
        }
        if (hud.ters == 4)
        {
            transform.position = Water.position;
        }      
        if (hud.ters == 5)
        {
            transform.position = Sky.position;
        }
        if (hud.ters > 5)
        {
            hud.ters = 1;
        }
        if (hud.ters < 1)
        {
            hud.ters = 5;
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            hud.send = true;
            Debug.Log("RightShift key is pressed.");
            if (hud.sendwe)
            {
                hud.atting = true;
            }
        }
        
    }
}
