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
        SceneManager.LoadScene(1);
    }
    void goToLevel1()
    {
        SceneManager.LoadScene(2);
    }

    void goToLevel2()
    {
        SceneManager.LoadScene(3);
    }
   
    void goToLevel3()
    {
        SceneManager.LoadScene(2);
    }







}
