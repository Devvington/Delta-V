using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour
{
    public GameObject star;

    public float howManyStars;

    public float bottomSpawn = -1500;
    public float topSpawn = -3000;

    public float lefty = -8000;
    public float righty = 8000;

    // Start is called before the first frame update
    void Start()
    {
        float spawning = Random.Range(bottomSpawn, topSpawn);

        float spawnX = Random.Range(lefty, righty);

        for (int i = 0; i <= howManyStars; i++)
        {
            Instantiate(star,new Vector3(spawnX, spawning, 700f),Quaternion.identity);

            spawning = Random.Range(bottomSpawn, topSpawn);

            spawnX = Random.Range(lefty, righty);
        }
    }
}
