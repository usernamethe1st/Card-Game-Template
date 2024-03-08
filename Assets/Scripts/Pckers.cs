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
   
    public float ter = 1;
    // Start is called before the first frame update
    void Start()
    {

        Green1 = GameObject.FindGameObjectWithTag("G1").transform;
        fire1 = GameObject.FindGameObjectWithTag("hand1").transform;
        Death1 = GameObject.FindGameObjectWithTag("D1").transform;
        Water1 = GameObject.FindGameObjectWithTag("W1").transform;
        Sky1 = GameObject.FindGameObjectWithTag("S1").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ter = ter - 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            ter = ter + 1;
        }
        if (ter == 1)
        {
            transform.position = Green1.position;
        }
        if (ter == 2)
        {
            transform.position = fire1.position;
        }
        if (ter == 3)
        {
            transform.position = Death1.position;
        }
        if (ter == 4)
        {
            transform.position = Water1.position;
        }      
        if (ter == 5)
        {
            transform.position = Sky1.position;
        }
    }
}
