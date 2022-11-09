using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class falling : MonoBehaviour
{
    public TheWorld theWorld;
    GameObject theEarth;

    public float speed;
    public float scale;
    public float rott;

    public float normRotation;

    public GameObject warning100;
    public GameObject warning50;

    // Start is called before the first frame update
    void Start()
    {
        theEarth = GameObject.FindGameObjectWithTag("world");
        theWorld = theEarth.GetComponent<TheWorld>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = theWorld.speedy;
        if (speed <= 15)
        {
            StartCoroutine(fall(speed));
            //rott = 15 - speed;
            transform.rotation = Quaternion.Euler(normRotation + rott*2.5f,0,0);
            warning50.SetActive(true);
        }
        else
        {
            transform.rotation = Quaternion.Euler(normRotation, 0, 0);
            warning50.SetActive(false);
        }
    }

    IEnumerator fall(float amount)
    {
        for (float i = amount * 10; i >= 0; i--)
        {
            rott = 15 - speed;
            yield return new WaitForSeconds(0.02f);
        }
    }
    IEnumerator flick()
    {
        for (float i = 1; i >= 0; i--)
        {
            rott = 15 - speed;
            yield return new WaitForSeconds(0.02f);
        }
    }
}
