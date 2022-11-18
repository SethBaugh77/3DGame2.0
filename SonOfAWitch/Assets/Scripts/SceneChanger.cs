using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        SceneManager.LoadScene(0);
    }

    public void continueGame() {
        // TODO
    }

    public void startHowToPlay() {

    }

    public void startCredits() {
        SceneManager.LoadScene(2);
    }

    public void startMenu() {
        SceneManager.LoadScene(1);
    }

    public void startQuit() {
        Application.Quit(0);
    }
}
