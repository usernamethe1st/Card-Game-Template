using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firech : MonoBehaviour
{
    public GameObject Firemana;
    public Hud hud;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<Hud>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hud.pict > 10)
        {
            hud.pict = 0;
        }
        hud.pict = hud.pict + 1;
        hud.picts = hud.picts + 1;
        if (hud.ch == 4)
        {
            if (hud.pict >= 5)
            {
                Instantiate(Firemana);
            }
        }
    }
}
