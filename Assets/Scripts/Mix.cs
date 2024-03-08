using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mix : MonoBehaviour
{
    public float ters = 1;
    
    public Transform Green;
    public Transform fire;
    public Transform Death;
    public Transform Water;
    public Transform Sky;
   

    // Start is called before the first frame update
    void Start()
    {
        Green = GameObject.FindGameObjectWithTag("G").transform;
        fire = GameObject.FindGameObjectWithTag("hand").transform;
        Death = GameObject.FindGameObjectWithTag("D").transform;
        Water = GameObject.FindGameObjectWithTag("W").transform;
        Sky = GameObject.FindGameObjectWithTag("S").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ters = ters - 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            ters = ters + 1;
        }
        if (ters == 1)
        {
            transform.position = Green.position;
        }
        if (ters == 2)
        {
            transform.position = fire.position;
        }
        if (ters == 3)
        {
            transform.position = Death.position;
        }
        if (ters == 4)
        {
            transform.position = Water.position;
        }      
        if (ters == 5)
        {
            transform.position = Sky.position;
        }
    }
}
