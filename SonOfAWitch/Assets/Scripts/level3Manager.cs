using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3Manager : MonoBehaviour
{

    public GameObject potionText;





    public GameObject potionImage;
    public static bool holding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void pickUpPotion()
    {
        holding = true;
        potionImage.SetActive(true);
    }
    void pickUpPotionMessage()
    {
        //print("ludwig");
        potionText.SetActive(true);
    }
    void stopPickUpPotionMessage()
    {
        potionText.SetActive(false);
    }


}
