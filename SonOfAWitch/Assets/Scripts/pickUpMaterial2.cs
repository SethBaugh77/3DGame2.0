using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpMaterial2 : MonoBehaviour
{

    public GameObject player;
    public GameObject material2Text;
    public GameObject sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        material2Text.gameObject.SetActive(false);
        //canvas.gameObject.SetActive(true);
        //canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
        //sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1))
        {
            material2Text.gameObject.SetActive(true);
            //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = true;


            if (Input.GetMouseButton(0))
            {
                sceneManager.SendMessage("pickUpItem", "material1");
                material2Text.gameObject.SetActive(false);
                Destroy(this.gameObject);

                //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



            }
        }
        else
            material2Text.gameObject.SetActive(false);
        //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
    }
}
