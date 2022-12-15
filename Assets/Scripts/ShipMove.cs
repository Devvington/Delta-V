using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    public Collider colliderBoost;

    public float boost;

    public GameObject staticNik;

    public float damage;

    public slideMe slideMe;

    // Start is called before the first frame update
    void Start()
    {
        slideMe.SetMaxHealth(damage);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime,transform.position.y,transform.position.z);
    }

    public void OnTriggerEnter(Collider other)
    {

        GameObject aThing = other.gameObject;


        if (other.CompareTag("cutenik"))
        {
            StartCoroutine(Slow(5));

            staticNik.SetActive(true);

            StartCoroutine(plonkNik(5));

            damage -= 1;

            slideMe.setHealth(damage);
        }

        if (other.CompareTag("booster"))
        {
            StartCoroutine(Boost(2));

            if(damage <= 5)
            {
                damage += 0.2f;
            }

            slideMe.setHealth(damage);
        }
    }

    IEnumerator Slow(float amount)
    {
        for (float i = amount*50; i >= 0; i--)
        {
            boost -= 0.02f;
            yield return new WaitForSeconds(0.02f);
        }
    }
    IEnumerator Boost(float amount)
    {
        for (float i = amount * 50; i >= 0; i--)
        {
            boost += 0.02f;
            yield return new WaitForSeconds(0.02f);
        }
    }
    IEnumerator plonkNik(float amount)
    {
        yield return new WaitForSeconds(amount + 1);
        staticNik.SetActive(false);
    }

}
