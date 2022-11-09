using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booster : MonoBehaviour
{
    public OrbitScript orbitScript;

    public float bottomSpawn = 140;
    public float topSpawn = 290;

    public float lefty = -0.8f;
    public float righty = 0.8f;

    public bool isStar;

    GameObject anOrbit;

    private void OnTriggerEnter(Collider other)
    {
        float spawning = Random.Range(bottomSpawn, topSpawn);
        orbitScript.transform.rotation = Quaternion.Euler(spawning, 0, 0);

        float spawnX = Random.Range(lefty, righty);

        transform.position = new Vector3(spawnX, transform.position.y, transform.position.z);
    }

    public void Start()
    {
        if(isStar == true)
        {
            anOrbit = GameObject.FindGameObjectWithTag("starOrbit");
            orbitScript = anOrbit.GetComponent<OrbitScript>();
        }
    }
}
