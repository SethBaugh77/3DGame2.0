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
        spawnPotionsForPlayer.spot0Occupied = false;
        spawnPotionsForPlayer.spot1Occupied = false;
        spawnPotionsForPlayer.spot2Occupied = false;
        spawnPotionsForPlayer.spot3Occupied = false;
        SceneManager.LoadScene(0);
    }

    void quitGame()
    {
            Application.Quit(0);
        
    }
    void goToHowToPlay()
    {
        SceneManager.LoadScene(7);

    }
    void goToCredits()
    {
        SceneManager.LoadScene(8);

    }
    void goToLoseScene()
    {
        //     public static bool spot0Occupied = false;
        //public static bool spot1Occupied = false;
        //public static bool spot2Occupied = false;
        //public static bool spot3Occupied = false;
        spawnPotionsForPlayer.spot0Occupied = false;
        spawnPotionsForPlayer.spot1Occupied = false;
        spawnPotionsForPlayer.spot2Occupied = false;
        spawnPotionsForPlayer.spot3Occupied = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(6);
    }

}
