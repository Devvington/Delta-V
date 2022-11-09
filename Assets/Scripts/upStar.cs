using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upStar : MonoBehaviour
{
    public TheWorld theWorld;
    GameObject theEarth;

    public float speed;
    public float scale;

    // Start is called before the first frame update
    void Start()
    {
        theEarth = GameObject.FindGameObjectWithTag("world");
        theWorld = theEarth.GetComponent<TheWorld>();
        speed = theWorld.speedy * scale;
    }

    // Update is called once per frame
    void Update()
    {
        //speed = theWorld.speedy * scale;
        if(theWorld.speedy <= 100)
        {
            speed = theWorld.speedy * scale;
        }
        if(theWorld.speedy >= 100)
        {
            speed = 100 * scale;
        }
        else
        {
            speed = theWorld.speedy * scale;
        }


        transform.position = new Vector3(transform.position.x , transform.position.y + (speed * Time.deltaTime), transform.position.z);
    }
}
