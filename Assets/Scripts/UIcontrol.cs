using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIcontrol : MonoBehaviour
{
    public GameObject playMenu;
    public GameObject mainMenu;

    public int difficulty = 1;
    public TextMeshProUGUI diffText;

    

    // Start is called before the first frame update
    void Start()
    {
        
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


    public void LaunchGame(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        //SceneManager.SetActiveScene();
    }

    public void legIt()
    {
        Application.Quit();
    }
}
