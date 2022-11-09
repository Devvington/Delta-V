using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TheWorld : MonoBehaviour
{
    public ShipMove theShip;
    float damage;

    public slideMe speedSlider;

    public float speed = 100;

    public Transform Space;

    public GameObject theEnd;
    public GameObject theWin;
    public GameObject closeBars; //UI stuff


    public float boost;
    public float speedy;
    public float boostAmount;

    public float day = 1;

    // Start is called before the first frame update
    void Start()
    {

        speedSlider.SetMaxHealth(100);

    }


    public void FixedUpdate()
    {
        speedSlider.setHealth(speedy); // speed put into speed UI slider
    }
    // Update is called once per frame
    void Update()
    {
        damage = theShip.damage;

        boost = theShip.boost; //grab boost amount from the ship move script, maybe have this change in difficulty?

        speed -= 1 * Time.deltaTime; // speed decreases every sec

        speedy = speed + (boost * boostAmount); // overall speed (speedy) is equal to the speed which decreases by -1 every sec and adds the boost amount

        transform.Rotate(0, 0, -speedy * day * Time.deltaTime); // roatates planet to simulate speed of orbit increase

        Space.position = new Vector3(0f, transform.position.x - (speedy * 0.03f) , 0f); // moves the planet down as player speeds up


        if(speedy <= 0) // if speed less than zero you lose!
        {
            theEnd.SetActive(true);
            closeBars.SetActive(false);
        }

        if (damage <= 0) // if player health less than zero you lose!
        {
            theEnd.SetActive(true);
            closeBars.SetActive(false);
        }

        if (speedy >= 100) // if speed is greater than 100 player wins!
        {
            theWin.SetActive(true);
            closeBars.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.P)) // cheatcode
        {
            speed += 20;
        }


    }
}
