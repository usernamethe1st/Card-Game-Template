using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onetwo : MonoBehaviour
{ 
    public Hud hud;
    public GameObject Firemana;
    public GameObject Orc;
    public GameObject Bow;
    public GameObject Littlefire;
    public GameObject Potonofextr;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<Hud>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            
        }
    }
}
