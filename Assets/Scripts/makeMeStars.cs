using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeMeStars : MonoBehaviour
{
    public TheWorld theWorld;
    GameObject theEarth;

    public float bottomSpawn = -1500;
    public float topSpawn = -3000;

    public float lefty = -8000;
    public float righty = 8000;

    public float speed;



    public void Start()
    {
        theEarth = GameObject.FindGameObjectWithTag("world");
        theWorld = theEarth.GetComponent<TheWorld>();
    }

    private void OnTriggerEnter(Collider other)
    {
        float spawning = Random.Range(bottomSpawn, topSpawn);

        float spawnX = Random.Range(lefty, righty);

        transform.position = new Vector3(spawnX, spawning, 700);
    }

    public void Update()
    {
        speed = theWorld.speedy;

        //transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
    }
}
