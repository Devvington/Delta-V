using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TheWorld : MonoBehaviour
{
    public ShipMove theShip;
    float damage;
    UIcontrol uIcontrol;

    public slideMe speedSlider;

    public float speed = 100;

    public Transform Space;
    public GameObject shippy;

    public GameObject theEnd;
    public GameObject theWin;
    public GameObject closeBars; //UI stuff

    public GameObject finScreen;
    public TextMeshProUGUI resultHere;
    public TextMeshProUGUI specificHere;
    public GameObject menuSaver;

    public float boost;
    public float speedy;
    public float boostAmount;

    public float day = 1;
    public float diff;

    public bool gravityOff = false;

    // Start is called before the first frame update
    void Start()
    {
        speedSlider.SetMaxHealth(100);
        menuSaver = GameObject.FindWithTag("diffi");
        uIcontrol = menuSaver.GetComponent<UIcontrol>();
    }

    public void FixedUpdate()
    {
        speedSlider.setHealth(speedy); // speed put into speed UI slider
        diff = uIcontrol.difficulty;
    }
    // Update is called once per frame
    void Update()
    {
        damage = theShip.damage;

        boost = theShip.boost; //grab boost amount from the ship move script, maybe have this change in difficulty?

        if(gravityOff == false)
        {
            speed -= 1 * Time.deltaTime; // speed decreases every sec
        }
            //speed -= 1 * Time.deltaTime; // speed decreases every sec

        speedy = speed + (boost * boostAmount); // overall speed (speedy) is equal to the speed which decreases by -1 every sec and adds the boost amount

        transform.Rotate(0, 0, -speedy * day * Time.deltaTime); // roatates planet to simulate speed of orbit increase

        Space.position = new Vector3(0f, transform.position.x - (speedy * 0.03f) , 0f); // moves the planet down as player speeds up


        if(speedy <= 0) // if speed less than zero you lose!
        {
            // theEnd.SetActive(true);
            //  closeBars.SetActive(false);
            crashed();
        }

        if (damage <= 0) // if player health less than zero you lose!
        {
            //  theEnd.SetActive(true);
            // closeBars.SetActive(false);
            crashed();
        }

        if (speedy >= 100) // if speed is greater than 100 player wins!
        {
            //    theWin.SetActive(true);
            //    closeBars.SetActive(false);
            won();
        }

        if (Input.GetKeyDown(KeyCode.P)) // cheatcode
        {
            speed += 20;
        }

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            escMenu();
        }
    }

    public void openFinScreen(string result, string spec)
    {
        finScreen.SetActive(!finScreen.activeSelf);
        resultHere.text = result;
        specificHere.text = spec;

    }

    public void openFinale(string result, string spec)
    {
        finScreen.SetActive(true);
        resultHere.text = result;
        specificHere.text = spec;

    }

    public void crashed()
    {
        openFinale("You Crashed!", "Difficulty " + diff);
        gravityOff = true;
        shippy.SetActive(false);
    }

    public void won()
    {
        openFinale("You Won!", "Difficulty " + diff);
        gravityOff = true;
        shippy.SetActive(false);
    }

    public void escMenu()
    {
        if(gravityOff == false)
        {
            openFinScreen("Options", "Difficulty " + diff);
        }
    }
}
