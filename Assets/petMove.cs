using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petMove : MonoBehaviour
{
    Vector3 place;
    public float slow;
    public bool isMoving;
    public GameObject ship;
    public void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Ship");
        place = transform.position;
        isMoving = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(ship.transform, Vector3.up);
        if(isMoving != true)
        {
            StartCoroutine(Wander());
        }
    }

    IEnumerator Wander()
    {
        isMoving = true;
        for (float i = 60; i >= 0; i--)
        {
            float moveMe = -0.01f;
            transform.position = new Vector3(transform.position.x + moveMe, transform.position.y, transform.position.z);
            yield return new WaitForSeconds(0.02f);
        }
        StartCoroutine(WanderBack());
    }

    IEnumerator WanderBack()
    {
        for (float i = 60; i >= 0; i--)
        {
            float moveMe = -0.01f;
            transform.position = new Vector3(transform.position.x - moveMe, transform.position.y, transform.position.z);
            yield return new WaitForSeconds(0.02f);
        }
        isMoving = false;
    }
}
