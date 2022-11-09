using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostMaker : MonoBehaviour
{
    public GameObject booster;

    public float howManyBoosters;
    // Start is called before the first frame update
    void Start()
    {
        //uIcontrol = mainMenu.GetComponent<UIcontrol>();
        //difficulty = uIcontrol.difficulty;

        for (int i = 0; i <= howManyBoosters; i++)
        {
            Instantiate(booster, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
