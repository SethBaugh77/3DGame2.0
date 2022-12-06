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
    public float currHealth;
    GameObject gameManager;
    public GameObject playerHealthBar;
    public GameObject witchHealthBar;
    Image playerHealthBarImage;
    Image witchHealthBarImage;







    // Start is called before the first frame update
    void Start()
    {
        currHealth = MAX_HEALTH;
        playerHealthBarImage = playerHealthBar.GetComponent<Image>();
        witchHealthBarImage = witchHealthBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerHealthBar.transform.localScale =
        //    new Vector3((currHealth) / MAX_HEALTH, 1.0f, 1.0f);
        //playerHealthBarImage.color = Color.Lerp(Color.red, Color.green, currHealth / MAX_HEALTH);

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
        print("juggle");
        playerHealthBar.transform.localScale =
            new Vector3((currHealth) / MAX_HEALTH, 1.0f, 1.0f);
        playerHealthBarImage.color = Color.Lerp(Color.green, Color.green, currHealth / MAX_HEALTH);
    }
    void witchHit()
    {
        witchHealthBar.transform.localScale =
            new Vector3((currHealth) / MAX_HEALTH, 1.0f, 1.0f);
        witchHealthBarImage.color = Color.Lerp(Color.red, Color.red, currHealth / MAX_HEALTH);
    }



}
