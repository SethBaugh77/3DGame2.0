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
        
    }

    public void startQuit() {
        Application.Quit(0);
    }
}
