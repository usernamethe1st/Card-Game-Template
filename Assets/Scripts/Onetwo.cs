using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onetwo : MonoBehaviour
{ 
    public Hud hud;
    
    public Transform target;
    
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
        if (hud.ters == 1)
        {


            if (hud.atting == true)
            {


                if (this.gameObject.CompareTag("A1"))
                {


                    if (transform.position == target.position)
                    {
                        hud.atting = false;
                        transform.rotation = target.rotation;
                    }
                    else
                    {



                        Vector2 direction = (Vector2)target.position - rd.position;

                        direction.Normalize();
                        float rotateAmount = Vector3.Cross(direction, transform.up).z;
                        rd.angularVelocity = -rotateAmount * rotateSpeed;


                        rd.velocity = transform.up * luck;
                    }
                }
            }
        }
    }
 
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("G"))
        {
            this.gameObject.tag = "A1";
        }
    }
}
