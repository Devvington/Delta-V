using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inGameUI : MonoBehaviour
{
    public GameObject menuSaver;
    

    // Start is called before the first frame update
    void Start()
    {
        menuSaver = GameObject.FindWithTag("diffi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        Destroy(menuSaver);
        //SceneManager.SetActiveScene();
    }

    public void exception(int sceneID) // for the retry button where we dont need to destroy menusaver
    {
        SceneManager.LoadScene(sceneID);
    }
}
