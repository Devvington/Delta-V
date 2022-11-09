using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    public TheWorld theWorld;
    GameObject theEarth;
    public float scale;
    public float speed;
    public float orbit = 120;
    public float maximum = 50;



    public bool closeOrbit;

    void Start()
    {
        theEarth = GameObject.FindGameObjectWithTag("world");
        theWorld = theEarth.GetComponent<TheWorld>();
    }
    // Update is called once per frame
    void Update()
    {

        if(closeOrbit == true)
        {
            float CloseSpeed = Mathf.Clamp((theWorld.speedy * scale), 20, 30);
            //CloseSpeed = theWorld.speedy * scale;
            speed = CloseSpeed;
            //Debug.Log(CloseSpeed);
        }
        //if(theWorld.speedy > 50 && closeOrbit == true)
        //{
        //    speed = 50;
        //}
        else
        {
            speed = theWorld.speedy * scale;
        }

        transform.Rotate(-speed * Time.deltaTime, 0, 0);
    }
}
