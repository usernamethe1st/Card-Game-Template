using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sendsendtdea : MonoBehaviour
{
    public Hud hud;
    
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<Hud>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hud.send)
        {
            hud.ch = hud.ters;

            hud.send = false;
            Destroy(gameObject);
        }
        if (hud.sendt)
        {
            hud.ch = hud.ter;
            hud.sendt = false;
            
            Destroy(gameObject);
        }


    }
}
