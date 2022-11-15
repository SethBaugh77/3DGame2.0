using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
   public GameObject BeetleImage;
    public GameObject keyImage;
   public string holding = null;
    // Start is called before the first frame update
    void Start()
    {
        BeetleImage.SetActive(false);
        keyImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pickUpItem(string item)
    {
        
        if(item == "beetle")
        {
            holding = "beetle";
            BeetleImage.SetActive(true);
        }
        else if(item == "key")
        {
            holding = "key";
            keyImage.SetActive(true);
            BeetleImage.SetActive(false);
        }
    }
   



}
