using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class level3Manager : MonoBehaviour
{

    //public GameObject potionText;
    public GameObject potionImage;
    public static bool holding = false;




    public float MAX_HEALTH = 100;
    public float playerCurrHealth;
    public float witchCurrHealth;
    public GameObject gameManager;
    public GameObject playerHealthBar;
    public GameObject witchHealthBar;
    Image playerHealthBarImage;
    Image witchHealthBarImage;


    public GameObject witchWords;
    public GameObject panel;

    private bool beginning;



    // Start is called before the first frame update
    void Start()
    {
        beginning = true;
        witchWords.SetActive(true);
        panel.SetActive(true);
        playerCurrHealth = 5.5499f;
        witchCurrHealth = playerCurrHealth;
        playerHealthBarImage = playerHealthBar.GetComponent<Image>();
        witchHealthBarImage = witchHealthBar.GetComponent<Image>();
        PauseMenu.GameIsPaused = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && beginning)
        {
            PauseMenu.GameIsPaused = false;
            panel.SetActive(false);
            witchWords.SetActive(false);
            //texts[textNum].SetActive(false);
            // pauseMenu.SendMessage("ResumeButNoUI");

        }






        if (playerCurrHealth <= 0)
        {

        }
        else if (witchCurrHealth <= 0)
        {
            gameManager.SendMessage("loadEndScene");
        }

    }

    void pickUpPotion()
    {
        holding = true;
        potionImage.SetActive(true);
    }
    void pickUpPotionMessage()
    {
        //print("ludwig");
       // potionText.SetActive(true);
    }
    void stopPickUpPotionMessage()
    {
        //potionText.SetActive(false);
    }
    void throwPotion()
    {
        holding = false;
        potionImage.SetActive(false);
    }
    void playerHit()
    {
        playerCurrHealth -= 1.4f;
        print("juggle");
        playerHealthBar.transform.localScale =
            new Vector3(playerCurrHealth, 0.50388f, 1f);
        playerHealthBarImage.color = Color.Lerp(Color.green, Color.green, playerCurrHealth / MAX_HEALTH);
    }
    void witchHit()
    {
        witchCurrHealth -= 1.4f;
        witchHealthBar.transform.localScale =
            new Vector3(witchCurrHealth, 0.50388f, 1f);
        witchHealthBarImage.color = Color.Lerp(Color.red, Color.red, witchCurrHealth / MAX_HEALTH);
    }



}
