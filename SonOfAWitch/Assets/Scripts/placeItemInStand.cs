using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeItemInStand : MonoBehaviour
{
    public GameObject player;
    public GameObject sceneManager;

    public GameObject placeItemText;

    public GameObject pencilBrewingStand;
    public GameObject grassBrewingStand;
    public GameObject shoeBrewingStand;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1))
        {
            if (level2Manager.holding != null)
            {
                print("chicken");

                placeItemText.gameObject.SetActive(true);

                if (Input.GetMouseButton(0))
                {
                    if(level2Manager.holding == "Grass")
                    {

                        grassBrewingStand.gameObject.SetActive(true);
                        
                    }
                    else if(level2Manager.holding == "Pencil")
                    {
                        pencilBrewingStand.gameObject.SetActive(true);
                    }
                    else if(level2Manager.holding == "Shoe")
                    {
                        shoeBrewingStand.gameObject.SetActive(true);
                    }

                    sceneManager.SendMessage("placeItem");
                    placeItemText.gameObject.SetActive(false);
                }


            }


        }
        else
        {
            placeItemText.gameObject.SetActive(false);
        }


    }
}
