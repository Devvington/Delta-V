using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeStars : MonoBehaviour
{
    public float spinny;
    public bool isCutenik;

    public float scale = 5;
    public bool notGameplay;
    // Start is called before the first frame update
    void Start()
    {
        spinny = Random.Range(-0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCutenik == true)
        {
            if(notGameplay == true)
            {
                spinny = 1;
            }
            transform.Rotate(0, spinny * scale, 0);
        }
        else
        {
            transform.Rotate(0, 0, spinny);
        }
        
    }

    


}
