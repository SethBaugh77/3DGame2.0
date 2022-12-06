using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpGrass : MonoBehaviour
{

    public GameObject player;
    public GameObject pickUpGrassText;
    public GameObject sceneManager;
    public GameObject inventoryFullText;
    // Start is called before the first frame update
    void Start()
    {
        pickUpGrassText.gameObject.SetActive(false);
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

                pickUpGrassText.gameObject.SetActive(true);
                //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = true;


                if (Input.GetMouseButton(0))
                {
                    sceneManager.SendMessage("pickUpItem", "Grass");
                    pickUpGrassText.gameObject.SetActive(false);
                    Destroy(this.gameObject);

                    //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



                }
            }
            else
            {
                inventoryFullText.gameObject.SetActive(true);
            }
        }
        else
        {
            pickUpGrassText.gameObject.SetActive(false);
            inventoryFullText.gameObject.SetActive(false);
        }
        //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
    }
}
