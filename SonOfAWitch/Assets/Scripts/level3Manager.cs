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
    GameObject gameManager;
    public GameObject playerHealthBar;
    public GameObject witchHealthBar;
    Image playerHealthBarImage;
    Image witchHealthBarImage;







    // Start is called before the first frame update
    void Start()
    {
        playerCurrHealth = 5.5499f;
        witchCurrHealth = playerCurrHealth;
        playerHealthBarImage = playerHealthBar.GetComponent<Image>();
        witchHealthBarImage = witchHealthBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCurrHealth <= 0)
        {

        }
        else if (witchCurrHealth <= 0)
        {

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
