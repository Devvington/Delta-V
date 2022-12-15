using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class boostMaker : MonoBehaviour
{
    //public GameObject booster;
    public GameObject menuSaver;

    public GameObject one;
    public GameObject two;
    //public GameObject three;

    UIcontrol uIcontrol;

    public float howManyBoosters;
    int difficulty;
    int pilot;

    public GameObject pilotHolder;
    public GameObject holdMyImage;
    public Sprite[] sprites;

    public TextMeshProUGUI textboox;
    public string [] pomPomText;
    public string[] alienText;
    public int populate;

    public bool newText;
    public int ra;

    public GameObject foxyPet;
    public GameObject cutenikPet;
    public bool foxyIsHere = false;
    public bool cutenikIsHere = false;
    // Start is called before the first frame update
    void Start()
    {
        
        menuSaver = GameObject.FindWithTag("diffi");
        uIcontrol = menuSaver.GetComponent<UIcontrol>();
        
        difficulty = uIcontrol.difficulty;
        foxyIsHere = uIcontrol.PetFoxy;
        cutenikIsHere = uIcontrol.PetCutenik;

        pilot = uIcontrol.pilotNumber;
        print(pilot);
        makeThings(one);
        makeThings(two);
        newText = true;

        if(cutenikIsHere == true)
        {
            toggleCutenik();
        }

        if(foxyIsHere == true)
        {
            toggleFoxy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        holdMyImage.GetComponent<Image>().sprite = sprites[pilot];
        
        if(pilot == 1)
        {
            if (newText != false)
            {
                newText = false;
                StartCoroutine(TextUpdatePomPom(6));
                StartCoroutine(timer());
            }    
        }

        if (pilot == 0)
        {
            if (newText != false)
            {
                newText = false;
                StartCoroutine(TextUpdateAlien(6));
                StartCoroutine(timer());
            }
        }
    }

    public void makeThings(GameObject obj)
    {
        if(obj == one)
        {
            populate = 2 + difficulty;
        }

        if (obj == two)
        {
            populate = 15 - difficulty;
        }

        for (int i = 0; i <= populate; i++)
        {
            Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    public void ChangeTextPomPom()
    {
        int rand;
        rand = Random.Range(0, pomPomText.Length);
        textboox.text = pomPomText[rand];
    }

    public void ChangeTextAlien()
    {
        int rand;
        rand = Random.Range(0, alienText.Length);
        textboox.text = alienText[rand];
    }

    IEnumerator TextUpdatePomPom(float amount)
    {
        pilotHolder.SetActive(true);
        ChangeTextPomPom();
        yield return new WaitForSeconds(amount);
        ClearText();
        pilotHolder.SetActive(false);
    }

    IEnumerator timer()
    {
        ra = Random.Range(10, 30);
        yield return new WaitForSeconds(ra);
        newText = true;
    }

    IEnumerator TextUpdateAlien(float amount)
    {
        pilotHolder.SetActive(true);
        ChangeTextAlien();
        yield return new WaitForSeconds(amount);
        ClearText();
        pilotHolder.SetActive(false);
    }
    public void ClearText()
    {
        textboox.text = " ";
    }

    public void toggleCutenik()
    {
        cutenikPet.SetActive(true);
    }

    public void toggleFoxy()
    {
        foxyPet.SetActive(true);
    }
}