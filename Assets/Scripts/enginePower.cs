using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enginePower : MonoBehaviour
{
    public TheWorld theWorld;
    GameObject theEarth;

    // Interpolate light color between two colors back and forth
    //float duration = 1.0f;
    Color color0 = Color.red;
    Color color1 = Color.white;

    public float speed;
    public float scale = 50;

    public bool isWarp;

    Light lt;

    void Start()
    {
        theEarth = GameObject.FindGameObjectWithTag("world");
        theWorld = theEarth.GetComponent<TheWorld>();
        //speed = theWorld.speedy * scale;
        lt = GetComponent<Light>();
    }

    void Update()
    {

        speed = theWorld.speedy/ scale;
        // set light color
        float t = Mathf.PingPong(Time.time, speed)/speed;
        

        lt.color = Color.Lerp(color1, color0, speed);

        if(isWarp == true)
        {
            lt.intensity = speed * 10;
        }
    }
}
