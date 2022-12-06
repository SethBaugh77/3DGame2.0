using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickUpPotion : MonoBehaviour
{
    //public GameObject potionText;
    public GameObject player;
    public GameObject sceneManager;
     string potionSpot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("x:" + transform.position.x);
        print("y:" + transform.position.y);
        print("z:" + transform.position.z);
        if ((player.transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1))
        {
            //potionText.gameObject.SetActive(true);
            print("InHere");
            //sceneManager.SendMessage("pickUpPotionMessage");
            //print("janey");
            //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = true;


            if (Input.GetMouseButton(0))
            {
                print("Messi");
                sceneManager.SendMessage("pickUpPotion");
                //sceneManager.SendMessage("stopPickUpPotionMessage");
                Destroy(this.gameObject);
                if (potionSpot == "0")
                    spawnPotionsForPlayer.spot0Occupied = false;
               else if (potionSpot == "1")
                    spawnPotionsForPlayer.spot1Occupied = false;
               else if (potionSpot == "2")
                    spawnPotionsForPlayer.spot2Occupied = false;
               else if (potionSpot == "3")
                    spawnPotionsForPlayer.spot3Occupied = false;


                //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



            }
        }
        print("OutHere");
        //sceneManager.SendMessage("stopPickUpPotionMessage");
        //potionText.gameObject.SetActive(false);
    }
    void chooseSpot(string spot)
    {
        potionSpot = spot;
    }


}
