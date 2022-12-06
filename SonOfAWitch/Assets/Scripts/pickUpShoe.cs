using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pickUpShoe : MonoBehaviour
{

    public GameObject player;
    public GameObject pickUpShoeText;
    public GameObject sceneManager;
    public GameObject inventoryFullText;
    //public TextMeshProUGUI buyprompt;
    // Start is called before the first frame update
    void Start()
    {
        pickUpShoeText.gameObject.SetActive(false);
        //canvas.gameObject.SetActive(true);
        //canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
        //sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1))
        {

            if (level2Manager.holding == null)
            {

                pickUpShoeText.gameObject.SetActive(true);
                //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = true;


                if (Input.GetMouseButton(0))
                {
                    sceneManager.SendMessage("pickUpItem", "Shoe");
                    pickUpShoeText.gameObject.SetActive(false);
                    Destroy(this.gameObject);

                    //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



                }
            }
            else
            {
                print("garrett");
                inventoryFullText.gameObject.SetActive(true);
                //inventoryFullText.gameObject.GetComponent<TextMeshProUGUI>().enabled = true;
                print("garrett2");
                print("garrett3" + level2Manager.holding);
            }
        }
        else
        {
            pickUpShoeText.gameObject.SetActive(false);
            inventoryFullText.gameObject.SetActive(false);
        }
        //if ((player.transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1))
        //{


        //    if (level2Manager.holding == null)
        //    {
        //        pickUpShoeText.gameObject.SetActive(true);
        //        //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = true;


        //        if (Input.GetMouseButton(0))
        //        {
        //            sceneManager.SendMessage("pickUpItem", "Shoe");
        //            pickUpShoeText.gameObject.SetActive(false);
        //            Destroy(this.gameObject);

        //            //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



        //        }
        //    }
        //    else
        //    {
        //        inventoryFullText.gameObject.SetActive(true);
        //    }


        //}
        //else
        //{
        //    pickUpShoeText.gameObject.SetActive(false);
        //    inventoryFullText.gameObject.SetActive(false);
        //}
        //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
    }
}
