using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void goToBeginningScene()
    {
        PlayerPrefs.SetInt("level", 0);
        SceneManager.LoadScene(1);
    }
    void goToLevel1()
    {
        PlayerPrefs.SetInt("level", 1);
        SceneManager.LoadScene(2);
    }

    void goToLevel2()
    {
        PlayerPrefs.SetInt("level", 2);
        SceneManager.LoadScene(3);
    }
   
    void goToLevel3()
    {
        PlayerPrefs.SetInt("level", 3);
        SceneManager.LoadScene(4);
    }

    void checkLevel()
    {
        if (PlayerPrefs.GetInt("level") == 1)
            goToLevel1();
       else if (PlayerPrefs.GetInt("level") == 2)
            goToLevel2();
       else if (PlayerPrefs.GetInt("level") == 3)
            goToLevel3();
       
    }
    void newGame()
    {
        PlayerPrefs.SetInt("level", 0);
        goToBeginningScene();
    }

    void loadEndScene()
    {
        SceneManager.LoadScene(5);
    }

    void goToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
