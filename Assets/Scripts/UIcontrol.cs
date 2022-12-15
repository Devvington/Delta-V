using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIcontrol : MonoBehaviour
{
    public GameObject playMenu;
    public GameObject mainMenu;
    public GameObject funMenu;

    public int difficulty = 1;
    public TextMeshProUGUI diffText;

    public int pilotNumber;

    public bool PetCutenik = false;
    public bool PetFoxy = false;

    public GameObject FoxyBorder;
    public GameObject CutenikBorder;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        diffText.text = difficulty.ToString();
    }

    public void increaseDiff()
    {
        difficulty += 1;

        if(difficulty > 10)
        {
            difficulty = 1;
        }
    }

    public void toMainMenu()
    {
        playMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void toPlayMenu()
    {
        mainMenu.SetActive(false);
        playMenu.SetActive(true);
    }

    public void showFunMenu()
    {
        funMenu.SetActive(!funMenu.activeSelf);
    }
    public void LaunchGame(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        playMenu.SetActive(false);
        //SceneManager.SetActiveScene();
    }

    public void legIt()
    {
        Application.Quit();
    }

    public void SetPilot(int numb)
    {
        pilotNumber = numb; // 1= pompom pilot
    }

    public void SetCutenik()
    {
        PetCutenik = !PetCutenik;
    }

    public void SetFoxy()
    {
        PetFoxy = !PetFoxy;
    }
    
    public void CutenikSelect()
    {
        CutenikBorder.SetActive(!CutenikBorder.activeSelf);
    }

    public void FoxySelect()
    {
        FoxyBorder.SetActive(!FoxyBorder.activeSelf);
    }

}
